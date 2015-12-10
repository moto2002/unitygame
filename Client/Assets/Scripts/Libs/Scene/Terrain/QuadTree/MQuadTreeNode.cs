﻿using UnityEngine;

namespace SDK.Lib
{
    /**
     * @brief 四叉树结点
     */
    public class MQuadTreeNode : MNodeBase
    {
        protected TerrainPage m_terrain;    // 地形

        protected float m_centerX;  // 世界空间中的中心点
        protected float m_centerZ;  // 世界空间中的中心点
        protected float m_depth;    // 当前节点的树的深度
        protected bool m_leaf;      // 当前节点是否是 Leaf 节点
        protected float m_height;   // 当前节点的高度，不是深度，是高度

        /**
         * @brief 四个 Child 节点的排列
         * 2 - 3
         * |   |
         * 0 - 1
         */
        protected MQuadTreeNode m_leftBottom;   // Child 节点
        protected MQuadTreeNode m_rightBottom;  // Child 节点
        protected MQuadTreeNode m_leftTop;      // Child 节点
        protected MQuadTreeNode m_rightTop;     // Child 节点

        protected float m_halfExtentXZ;     // 世界空间中节点大小的一班，主要用来裁剪
        protected float m_halfExtentY;

        protected MNodeProxy m_nodeProxy;   // 保存的一些与显示有关的数据
        /**
         * @brief Tile 的偏移原点在左上角，不是在四叉树的中间
         * |---------> x
         * |  LT  |  RT  |
         * -----------
         * |  LB  |  RB  |
         * -----------
         * V
         * z
         */
        protected int m_xTileOffset;        // 当前节点相对于父节点的 X Tile 偏移数量
        protected int m_zTileOffset;        // 当前节点相对于父节点的 Z Tile 偏移数量

        /**
         * @brief 四叉树的节点，深度根据 leaf 的大小确定
         */
        public MQuadTreeNode(TerrainPage terrain, int maxDepth = 5, int size = 10000, int height = 1000000, float centerX = 0, float centerZ = 0, int depth = 0, int xTileOffset = 0, int zTileOffset = 0)
        {
            m_terrain = terrain;
            m_nodeProxy = new MQuadTreeNodeProxy();

            int halfSize = (int)(size * 0.5f);

            m_centerX = centerX;
            m_centerZ = centerZ;
            m_height = height;
            m_depth = depth;
            m_halfExtentXZ = size * 0.5f;
            m_halfExtentY = height * 0.5f;

            m_leaf = depth == maxDepth;
            m_xTileOffset = xTileOffset;
            m_zTileOffset = zTileOffset;

            int curDepthTileCount = terrain.getTerrainPageCfg().getXTileCount() / UtilApi.powerTwo(depth);    // 当前节点的 Tile 数量
            int halfCurDepthTileCount = curDepthTileCount / 2;  // 当前节点的 Tile 数量的一半

            if (!m_leaf)
            {
                float halfHalfSize = halfSize * 0.5f;

                // 左底
                m_leftBottom = new MQuadTreeNode(terrain, maxDepth, halfSize, height, centerX - halfHalfSize, centerZ - halfHalfSize, depth + 1, 0, halfCurDepthTileCount);
                addNode(m_leftBottom);

                // 右底
                m_rightBottom = new MQuadTreeNode(terrain, maxDepth, halfSize, height, centerX + halfHalfSize, centerZ - halfHalfSize, depth + 1, halfCurDepthTileCount, halfCurDepthTileCount);
                addNode(m_rightBottom);

                // 左顶
                m_leftTop = new MQuadTreeNode(terrain, maxDepth, halfSize, height, centerX - halfHalfSize, centerZ + halfHalfSize, depth + 1, 0, 0);
                addNode(m_leftTop);

                // 右顶
                m_rightTop = new MQuadTreeNode(terrain, maxDepth, halfSize, height, centerX + halfHalfSize, centerZ + halfHalfSize, depth + 1, halfCurDepthTileCount, 0);
                addNode(m_rightTop);
            }
        }

        override public bool isInFrustum(MList<MPlane3D> planes, int numPlanes)
		{
			for (int i = 0; i < numPlanes; ++i) 
            {
                MPlane3D plane = planes[i];
				float flippedExtentX = plane.m_a< 0? - m_halfExtentXZ : m_halfExtentXZ;
                float flippedExtentY = plane.m_b < 0? - m_halfExtentY : m_halfExtentY;
                float flippedExtentZ = plane.m_c < 0? - m_halfExtentXZ : m_halfExtentXZ;
                float projDist = plane.m_a * (m_centerX + flippedExtentX) + plane.m_b * flippedExtentY + plane.m_c * (m_centerZ + flippedExtentZ) - plane.m_d;
                if (projDist < 0)
                {
                    return false;
                }
			}
			
			return true;
		}

        override public MNodeBase findPartitionForEntity()
        {
            MBoundingVolumeBase bounds = null;
            Vector3 min = bounds.getMin();
            Vector3 max = bounds.getMax();
            return findPartitionForBounds(min.x, min.z, max.x, max.z);
        }

        private MQuadTreeNode findPartitionForBounds(float minX, float minZ, float maxX, float maxZ)
		{
			bool left, right;
            bool far, near;

            if (m_leaf)
            {
                return this;
            }
			
			right = maxX > m_centerX;
            left = minX < m_centerX;
            far = maxZ > m_centerZ;
            near = minZ < m_centerZ;

            if (left && right)
            {
                return this;
            }
			
			if (near)
            {
                if (far)
                {
                    return this;
                }

                if (left)
                {
                    return m_leftBottom.findPartitionForBounds(minX, minZ, maxX, maxZ);
                }
                else
                {
                    return m_rightBottom.findPartitionForBounds(minX, minZ, maxX, maxZ);
                }
            }
            else
            {
                if (left)
                {
                    return m_leftTop.findPartitionForBounds(minX, minZ, maxX, maxZ);
                }
                else
                {
                    return m_rightTop.findPartitionForBounds(minX, minZ, maxX, maxZ);
                }
            }
        }

        /**
         * @brief 更新 Frustum 裁剪剔除
         */
        override public void updateClip(MList<MPlane3D> planes)
        {
            if(this.isInFrustum(planes, planes.length()))   // 如果在 Frustum 内
            {
                if (m_leaf)      // 如果是 Leaf 节点
                {
                    m_nodeProxy.show();
                    // 继续更新 Lod
                }
                else    // 继续裁剪 Child
                {
                    m_rightTop.updateClip(planes);
                    m_leftTop.updateClip(planes);
                    m_rightBottom.updateClip(planes);
                    m_leftBottom.updateClip(planes);
                }
            }
            else            // 如果不可见，就直接隐藏掉
            {
                if (m_leaf)
                {
                    m_nodeProxy.hide();
                }
            }
        }

        /**
         * @brief 获取当前节点对应的 Tile 在 Tile 坐标系中的 X 位置
         */
        protected int getXTileIndex()
        {
            if (this.m_parent == null)
            {
                return m_xTileOffset;
            }
            else
            {
                return m_xTileOffset + (this.m_parent as MQuadTreeNode).getXTileIndex();
            }
        }

        /**
         * @brief 获取当前节点对应的 Tile 在 Tile 坐标系中的 X 位置
         */
        protected int getZTileIndex()
        {
            if (this.m_parent == null)
            {
                return m_zTileOffset;
            }
            else
            {
                return m_zTileOffset + (this.m_parent as MQuadTreeNode).getZTileIndex();
            }
        }

        // 获取当前节点对应的 Tile 在保存的 Tile 的数组中的索引
        protected int getTileIndex()
        {
            int xTile = m_xTileOffset;
            int zTile = m_zTileOffset;

            if(this.m_parent != null)
            {
                xTile += (this.m_parent as MQuadTreeNode).getXTileIndex();
                zTile += (this.m_parent as MQuadTreeNode).getZTileIndex();
            }

            return m_terrain.getTerrainPageCfg().getTileIndex(xTile, zTile);
        }

        /**
         * @brief 四叉树构造完成更新一些数据
         */
        override public void postInit()
        {
            if(m_leaf)
            {
                updateProxy();
            }
            else
            {
                m_leftBottom.postInit();
                m_rightBottom.postInit();
                m_leftTop.postInit();
                m_rightTop.postInit();
            }
        }

        /**
         * @brief 获取 Proxy 数据
         */
        protected void updateProxy()
        {
            if (m_leaf)
            {
                int tileIndex = getTileIndex();
                m_nodeProxy.updateMesh(m_terrain, tileIndex);
            }
        }
    }
}