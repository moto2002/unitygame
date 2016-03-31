using SDK.Lib;
using System;
using System.IO;
using System.Text;
using UnityEditor;
using UnityEngine;

enum SaveFormat
{
    Triangles,
    Quads,
}

enum SaveResolution
{
    Full,
    Half,
    Quarter,
    Eighth,
    Sixteenth,
}

class ExportTerrain : EditorWindow
{
    SaveFormat saveFormat = SaveFormat.Triangles;
    SaveResolution saveResolution = SaveResolution.Half;
    static TerrainData terrainData;
    static Vector3 terrainPos;

    int tCount;
    int counter;
    int totalCount;

    [MenuItem("My/Terrain/Export To Obj...")]
    static public void Init()
    {
        terrainData = null;
        Terrain terrainObject = Selection.activeObject as Terrain;
        if (!terrainObject)
        {
            terrainObject = Terrain.activeTerrain;
        }
        if (terrainObject)
        {
            terrainData = terrainObject.terrainData;
            terrainPos = terrainObject.transform.position;
        }
        EditorWindow.GetWindow(typeof(ExportTerrain)).Show();
    }

    public void OnGUI()
    {
        if (!terrainData)
        {
            GUILayout.Label("No terrain found");
            if (GUILayout.Button("Cancel"))
            {
                EditorWindow.GetWindow(typeof(ExportTerrain)).Close();
            }
            return;
        }
        saveFormat = (SaveFormat)EditorGUILayout.EnumPopup("Export Format", (Enum)saveFormat);
        saveResolution = (SaveResolution)EditorGUILayout.EnumPopup("Resolution", (Enum)saveResolution);

        if (GUILayout.Button("Export"))
        {
            Export();
        }
        if (GUILayout.Button("ExportTexture"))
        {
            //exportAlphaTexture();
            exportSplatTexture();
        }
        if (GUILayout.Button("ExportHeightMap"))
        {
            exportHeightMap();
        }
        if (GUILayout.Button("ExportAlphaMap"))
        {
            exportAlphaMap();
        }
    }

    public void Export()
    {
        string fileName = EditorUtility.SaveFilePanel("Export .obj file", "", "Terrain", "obj");
        int w = terrainData.heightmapWidth;
        int h = terrainData.heightmapHeight;
        Vector3 meshScale = terrainData.size;
        var tRes = Mathf.Pow(2, (int)(saveResolution));
        meshScale = new Vector3(meshScale.x / (w - 1) * tRes, meshScale.y, meshScale.z / (h - 1) * tRes);
        Vector2 uvScale = new Vector2(1.0f / (w - 1), 1.0f / (h - 1));
        float[,] tData = terrainData.GetHeights(0, 0, w, h);

        w = (int)((w - 1) / tRes + 1);
        h = (int)((h - 1) / tRes + 1);
        var tVertices = new Vector3[w * h];
        var tUV = new Vector2[w * h];
        int[] tPolys = null;
        if (saveFormat == SaveFormat.Triangles)
        {
            tPolys = new int[(w - 1) * (h - 1) * 6];
        }
        else
        {
            tPolys = new int[(w - 1) * (h - 1) * 4];
        }

        // Build vertices and UVs
        for (int y = 0; y < h; y++)
        {
            for (int x = 0; x < w; x++)
            {
                tVertices[y * w + x] = Vector3.Scale(meshScale, new Vector3(x, (int)(tData[(int)(x * tRes), (int)(y * tRes)]), y)) + terrainPos;
                tUV[y * w + x] = Vector2.Scale(new Vector2(x * tRes, y * tRes), uvScale);
            }
        }

        var index = 0;
        if (saveFormat == SaveFormat.Triangles)
        {
            // Build triangle indices: 3 indices into vertex array for each triangle
            for (int y = 0; y < h - 1; y++)
            {
                for (int x = 0; x < w - 1; x++)
                {
                    // For each grid cell output two triangles
                    tPolys[index++] = (y * w) + x;
                    tPolys[index++] = ((y + 1) * w) + x;
                    tPolys[index++] = (y * w) + x + 1;

                    tPolys[index++] = ((y + 1) * w) + x;
                    tPolys[index++] = ((y + 1) * w) + x + 1;
                    tPolys[index++] = (y * w) + x + 1;
                }
            }
        }
        else
        {
            // Build quad indices: 4 indices into vertex array for each quad
            for (int y = 0; y < h - 1; y++)
            {
                for (int x = 0; x < w - 1; x++)
                {
                    // For each grid cell output one quad
                    tPolys[index++] = (y * w) + x;
                    tPolys[index++] = ((y + 1) * w) + x;
                    tPolys[index++] = ((y + 1) * w) + x + 1;
                    tPolys[index++] = (y * w) + x + 1;
                }
            }
        }

        // Export to .obj
        StreamWriter sw = null;
        try
        {
            sw = new StreamWriter(fileName);
            sw.WriteLine("# Unity terrain OBJ File");

            // Write vertices
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            counter = tCount = 0;
            totalCount = (tVertices.Length * 2 + (saveFormat == SaveFormat.Triangles ? tPolys.Length / 3 : tPolys.Length / 4)) / 1000;
            StringBuilder sb = null;
            for (int i = 0; i < tVertices.Length; i++)
            {
                UpdateProgress();
                sb = new StringBuilder("v ", 20);
                // StringBuilder stuff is done this way because it's faster than using the "{0} {1} {2}"etc. format
                // Which is important when you're exporting huge terrains.
                sb.Append(tVertices[i].x.ToString()).Append(" ").
                   Append(tVertices[i].y.ToString()).Append(" ").
                   Append(tVertices[i].z.ToString());
                sw.WriteLine(sb);
            }
            // Write UVs
            for (int i = 0; i < tUV.Length; i++)
            {
                UpdateProgress();
                sb = new StringBuilder("vt ", 22);
                sb.Append(tUV[i].x.ToString()).Append(" ").
                   Append(tUV[i].y.ToString());
                sw.WriteLine(sb);
            }
            if (saveFormat == SaveFormat.Triangles)
            {
                // Write triangles
                for (int i = 0; i < tPolys.Length; i += 3)
                {
                    UpdateProgress();
                    sb = new StringBuilder("f ", 43);
                    sb.Append(tPolys[i] + 1).Append("/").Append(tPolys[i] + 1).Append(" ").
                       Append(tPolys[i + 1] + 1).Append("/").Append(tPolys[i + 1] + 1).Append(" ").
                       Append(tPolys[i + 2] + 1).Append("/").Append(tPolys[i + 2] + 1);
                    sw.WriteLine(sb);
                }
            }
            else
            {
                // Write quads
                for (int i = 0; i < tPolys.Length; i += 4)
                {
                    UpdateProgress();
                    sb = new StringBuilder("f ", 57);
                    sb.Append(tPolys[i] + 1).Append("/").Append(tPolys[i] + 1).Append(" ").
                       Append(tPolys[i + 1] + 1).Append("/").Append(tPolys[i + 1] + 1).Append(" ").
                       Append(tPolys[i + 2] + 1).Append("/").Append(tPolys[i + 2] + 1).Append(" ").
                       Append(tPolys[i + 3] + 1).Append("/").Append(tPolys[i + 3] + 1);
                    sw.WriteLine(sb);
                }
            }
        }
        catch (Exception err)
        {
            Debug.Log("Error saving file: " + err.Message);
        }
        sw.Close();

        terrainData = null;
        EditorUtility.ClearProgressBar();
        EditorWindow.GetWindow(typeof(ExportTerrain)).Close();
    }

    public void UpdateProgress()
    {
        if (counter++ == 1000)
        {
            counter = 0;
            EditorUtility.DisplayProgressBar("Saving...", "", Mathf.InverseLerp(0, totalCount, ++tCount));
        }
    }

    public void exportAlphaTexture()
    {
        string path = Application.streamingAssetsPath;
        UtilApi.saveTex2Disc(terrainData.alphamapTextures[0], path + "/alphamapTextures_0.png");
    }

    public void exportSplatTexture_NotRun()
    {
        string path = Application.streamingAssetsPath;
        int idx = 0;
        SplatPrototype splatLayer = null;
        Texture2D writeTex = null;
        Color color;
        for (idx = 0; idx < terrainData.splatPrototypes.Length; ++idx)
        {
            splatLayer = terrainData.splatPrototypes[idx];
            writeTex = new Texture2D(splatLayer.texture.width, splatLayer.texture.height, TextureFormat.RGB24, false);
            
            for(int imageY = 0; imageY < splatLayer.texture.height; ++imageY)
            {
                for(int imageX = 0; imageX < splatLayer.texture.width; ++imageX)
                {
                    // ��������ǲ��ܶ�д�ģ���Ҫʹ�� AssetDatabase.GetAssetPath ��ȡ����Ŀ¼
                    color = splatLayer.texture.GetPixel(imageX, imageY);
                    writeTex.SetPixel(imageX, imageY, color);
                }
            }
            UtilApi.saveTex2Disc(splatLayer.texture, path + "/SplatTextures" + idx + ".png");
        }
    }

    public void exportSplatTexture()
    {
        string path = Application.streamingAssetsPath;
        int idx = 0;
        SplatPrototype splatLayer = null;
        string resPath = "";
        for (idx = 0; idx < terrainData.splatPrototypes.Length; ++idx)
        {
            splatLayer = terrainData.splatPrototypes[idx];
            resPath = AssetDatabase.GetAssetPath(splatLayer.texture);
            // ����Ŀ¼
        }
    }

    public void exportHeightMap()
    {
        string fileName = string.Format("{0}/{1}.png", Application.dataPath, "heightmap");
        int w = terrainData.heightmapWidth;
        int h = terrainData.heightmapHeight;
        Vector3 meshScale = terrainData.size;
        float[,] tData = terrainData.GetHeights(0, 0, w, h);

        Color color = new Color(0, 0, 0, 0);
        float height = 0;
        Texture2D heightMap = new Texture2D(w, h, TextureFormat.BGRA32, true);
        for(int idy = 0; idy < h; ++idy)
        {
            for(int idx = 0; idx < w; ++idx)
            {
                height = tData[idx, idy];
                color = new Color(height, height, height, height);
                heightMap.SetPixel(idx, idy, color);
            }
        }

        UtilApi.saveTex2Disc(heightMap, fileName);
    }

    // ���� AlphaMap
    public void exportAlphaMap_a()
    {
        string fileName = "";
        Texture2D[] alphamapTextures = terrainData.alphamapTextures;
        for(int idx = 0; idx < alphamapTextures.Length; ++idx)
        {
            fileName = string.Format("{0}/{1}_{2}.png", Application.dataPath, "AlphaMap", idx);
            UtilApi.saveTex2Disc(alphamapTextures[idx], fileName);
        }
    }

    public void exportAlphaMap()
    {
        float[,,] splatmapData = terrainData.GetAlphamaps(0, 0, terrainData.alphamapWidth, terrainData.alphamapHeight);

        int alphamapWidth = terrainData.alphamapWidth;
        int alphamapHeight = terrainData.alphamapHeight;
        int alphamapLayers = terrainData.alphamapLayers;

        int channel = 4;
        int channelIdx = 0;

        float r = 0;
        float g = 0;
        float b = 0;
        float a = 0;

        string fileName = "";
        Color color = new Color(0, 0, 0, 0);
        Texture2D alphaMap = new Texture2D(alphamapWidth, alphamapHeight, TextureFormat.BGRA32, true);

        int imageIdx = 0;

        while (channelIdx < alphamapLayers)
        {
            r = 0;
            g = 0;
            b = 0;
            a = 0;

            for (int idy = 0; idy < alphamapHeight; ++idy)
            {
                for(int idx = 0; idx < alphamapWidth; ++idx)
                {
                    r = splatmapData[idx, idy, channelIdx];
                    if(channelIdx + 1 < alphamapLayers)
                    {
                        g = splatmapData[idx, idy, channelIdx + 1];
                    }
                    if (channelIdx + 2 < alphamapLayers)
                    {
                        b = splatmapData[idx, idy, channelIdx + 2];
                    }
                    if (channelIdx + 3 < alphamapLayers)
                    {
                        a = splatmapData[idx, idy, channelIdx + 3];
                    }

                    color = new Color(r, g, b, a);
                    alphaMap.SetPixel(idx, idy, color);
                }
            }

            fileName = string.Format("{0}/{1}_{2}.png", Application.dataPath, "AlphaMap", imageIdx);
            UtilApi.saveTex2Disc(alphaMap, fileName);

            imageIdx += 1;
            channelIdx += channel;
        }
    }
}