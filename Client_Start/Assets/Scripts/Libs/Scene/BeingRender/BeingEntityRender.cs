﻿namespace SDK.Lib
{
    public class BeingEntityRender : EntityRenderBase
    {
        protected string mResPath;  // 资源目录
        protected AuxPrefabLoader mAuxPrefabLoader;

        /**
         * @brief 资源加载之类的基本操作写在这里
         */
        public BeingEntityRender(SceneEntityBase entity_)
            : base(entity_)
        {

        }

        public void setResPath(string path)
        {
            this.mResPath = path;
        }

        override public void onDestroy()
        {
            if(null != this.mAuxPrefabLoader)
            {
                mAuxPrefabLoader.dispose();
            }

            base.onDestroy();
        }

        // 资源加载
        override public void load()
        {
            if(null == this.mAuxPrefabLoader)
            {
                this.mAuxPrefabLoader = new AuxPrefabLoader("", true, false);
                this.mAuxPrefabLoader.setDestroySelf(false); // 自己释放 GmmeObject
            }

            this.mAuxPrefabLoader.syncLoad(mResPath);
            this.selfGo = this.mAuxPrefabLoader.getGameObject();
        }
    }
}