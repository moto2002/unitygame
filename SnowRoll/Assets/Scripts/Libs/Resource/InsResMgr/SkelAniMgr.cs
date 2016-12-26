using LuaInterface;

namespace SDK.Lib
{
    public class SkelAniMgr : InsResMgrBase
    {
        public SkelAniMgr()
        {

        }

        public SkelAnimRes getAndSyncLoadRes(string path, MAction<IDispatchObject> handle)
        {
            return getAndSyncLoad<SkelAnimRes>(path, handle);
        }

        public SkelAnimRes getAndAsyncLoadRes(string path, MAction<IDispatchObject> handle)
        {
            return getAndAsyncLoad<SkelAnimRes>(path, handle);
        }

        public SkelAnimRes getAndAsyncLoadRes(string path, LuaTable luaTable = null, LuaFunction luaFunction = null)
        {
            return getAndAsyncLoad<SkelAnimRes>(path, luaTable, luaFunction, true);
        }
    }
}