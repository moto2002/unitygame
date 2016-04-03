using System;

namespace SDK.Lib
{
    public class BytesResMgr : ResMgrBase
    {
        public BytesResMgr()
        {

        }

        public BytesRes getAndSyncLoadRes(string path)
        {
            path = MFileSys.convResourcesPath2AssetBundlesPath(path);
            path = path + UtilApi.PREFAB_DOT_EXT;
            return getAndSyncLoad<BytesRes>(path);
        }

        public BytesRes getAndAsyncLoadRes(string path, Action<IDispatchObject> handle)
        {
            path = MFileSys.convResourcesPath2AssetBundlesPath(path);
            path = path + UtilApi.PREFAB_DOT_EXT;
            return getAndAsyncLoad<BytesRes>(path, handle);
        }
    }
}