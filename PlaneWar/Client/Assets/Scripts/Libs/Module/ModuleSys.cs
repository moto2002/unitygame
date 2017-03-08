﻿using Game.Game;
using Game.Login;
using System.Collections.Generic;

namespace SDK.Lib
{
    /**
     * @brief 主要是各个模块的管理
     */
    public class ModuleSys : IModuleSys
    {
        protected MDictionary<ModuleId, ModuleHandleItem> mType2ItemDic;

        public ModuleSys()
        {
            this.mType2ItemDic = new MDictionary<ModuleId, ModuleHandleItem>();
            this.registerHandler();
        }

        protected void registerHandler()
        {
            ModuleHandleItem item;

            item = new ModuleHandleItem();
            item.mLoadEventHandle = onLoginLoadEventHandle;
            item.mModuleID = ModuleId.LOGINMN;
            item.mModuleLayerPath = ModulePath.LOGINMN;
            item.mPath = string.Format("{0}{1}{2}", Ctx.mInstance.mCfg.mPathLst[(int)ResPathType.ePathModule], ModuleName.LOGINMN, ".prefab");
            this.mType2ItemDic[item.mModuleID] = item;

            item = new ModuleHandleItem();
            item.mLoadEventHandle = onGameLoadEventHandle;
            item.mModuleID = ModuleId.GAMEMN;
            item.mModuleLayerPath = ModulePath.GAMEMN;
            item.mPath = string.Format("{0}{1}{2}", Ctx.mInstance.mCfg.mPathLst[(int)ResPathType.ePathModule], ModuleName.GAMEMN, ".prefab");
            this.mType2ItemDic[item.mModuleID] = item;

            item = new ModuleHandleItem();
            item.mLoadEventHandle = onAutoUpdateLoadEventHandle;
            item.mModuleID = ModuleId.AUTOUPDATEMN;
            item.mModuleLayerPath = ModulePath.AUTOUPDATEMN;
            item.mPath = string.Format("{0}{1}{2}", Ctx.mInstance.mCfg.mPathLst[(int)ResPathType.ePathModule], ModuleName.AUTOUPDATEMN, ".prefab");
            this.mType2ItemDic[item.mModuleID] = item;
        }

        // 加载游戏模块
        public void loadModule(ModuleId moduleID)
        {
            if (!this.mType2ItemDic[moduleID].mIsLoaded)
            {
                this.mType2ItemDic[moduleID].mIsLoaded = true;

                if (ModuleId.LOGINMN == moduleID)
                {
                    Ctx.mInstance.mLoginSys = new LoginSys();
                    ((Ctx.mInstance.mLoginSys) as LoginSys).mLoginFlowHandle = new LoginFlowHandle();
                    ((Ctx.mInstance.mLoginSys) as LoginSys).Start();
                }
                else if(ModuleId.GAMEMN == moduleID)
                {
                    Ctx.mInstance.mGameSys = new GameSys();
                    Ctx.mInstance.mGameSys.Start();
                }
            }
            else
            {
            }
        }

        public void unloadModule(ModuleId moduleID)
        {
            if (ModuleId.LOGINMN == moduleID)
            {
                if (Ctx.mInstance.mLoginSys != null)
                {
                    Ctx.mInstance.mLoginSys.unload();
                }
            }
            else if (ModuleId.AUTOUPDATEMN == moduleID)
            {
                if (Ctx.mInstance.mAutoUpdate!= null)
                {
                    Ctx.mInstance.mAutoUpdate.unload();
                }
            }
            if (Ctx.mInstance.mLayerMgr.mPath2Go.ContainsKey(mType2ItemDic[moduleID].mModuleLayerPath))
            {
                UtilApi.Destroy(Ctx.mInstance.mLayerMgr.mPath2Go[mType2ItemDic[moduleID].mModuleLayerPath]);
            }
            else
            {
            }
            Ctx.mInstance.mLayerMgr.mPath2Go.Remove(mType2ItemDic[moduleID].mModuleLayerPath);
            // 太卡，暂时屏蔽掉
            //UtilApi.UnloadUnusedAssets();
        }

        public void onLoginLoadEventHandle(IDispatchObject dispObj)
        {
            ResItem res = dispObj as ResItem;
            if (res.refCountResLoadResultNotify.resLoadState.hasSuccessLoaded())
            {
                Ctx.mInstance.mLayerMgr.mPath2Go[ModulePath.LOGINMN] = res.InstantiateObject(mType2ItemDic[ModuleId.LOGINMN].mPath);
                Ctx.mInstance.mLayerMgr.mPath2Go[ModulePath.LOGINMN].name = ModuleName.LOGINMN;
                Ctx.mInstance.mLayerMgr.mPath2Go[ModulePath.LOGINMN].transform.parent = Ctx.mInstance.mLayerMgr.mPath2Go[NotDestroyPath.ND_CV_Root].transform;

                // 立马卸载这个资源
                Ctx.mInstance.mResLoadMgr.unload(mType2ItemDic[ModuleId.LOGINMN].mPath, onLoginLoadEventHandle);
            }
            else if (res.refCountResLoadResultNotify.resLoadState.hasFailed())
            {
                onModuleFailed(dispObj);
            }
        }

        public void onGameLoadEventHandle(IDispatchObject dispObj)
        {
            ResItem res = dispObj as ResItem;
            if (res.refCountResLoadResultNotify.resLoadState.hasSuccessLoaded())
            {
                Ctx.mInstance.mLayerMgr.mPath2Go[ModulePath.GAMEMN] = res.InstantiateObject(mType2ItemDic[ModuleId.GAMEMN].mPath);
                Ctx.mInstance.mLayerMgr.mPath2Go[ModulePath.GAMEMN].name = ModuleName.GAMEMN;
                Ctx.mInstance.mLayerMgr.mPath2Go[NotDestroyPath.ND_CV_Game].transform.parent = Ctx.mInstance.mLayerMgr.mPath2Go[NotDestroyPath.ND_CV_Root].transform;

                // 游戏模块也不释放
                UtilApi.DontDestroyOnLoad(Ctx.mInstance.mLayerMgr.mPath2Go[NotDestroyPath.ND_CV_Game]);

                // 立马卸载这个资源
                Ctx.mInstance.mResLoadMgr.unload(mType2ItemDic[ModuleId.GAMEMN].mPath, onGameLoadEventHandle);
            }
            else if (res.refCountResLoadResultNotify.resLoadState.hasFailed())
            {
                onModuleFailed(dispObj);
            }
        }

        public void onAutoUpdateLoadEventHandle(IDispatchObject dispObj)
        {
            ResItem res = dispObj as ResItem;
            if (res.refCountResLoadResultNotify.resLoadState.hasSuccessLoaded())
            {
                Ctx.mInstance.mLogSys.debugLog_1(LangItemID.eItem0, res.getLoadPath());

                Ctx.mInstance.mLayerMgr.mPath2Go[ModulePath.AUTOUPDATEMN] = res.InstantiateObject(mType2ItemDic[ModuleId.AUTOUPDATEMN].mPath);
                Ctx.mInstance.mLayerMgr.mPath2Go[ModulePath.AUTOUPDATEMN].name = ModuleName.AUTOUPDATEMN;
                Ctx.mInstance.mLayerMgr.mPath2Go[ModulePath.AUTOUPDATEMN].transform.parent = Ctx.mInstance.mLayerMgr.mPath2Go[NotDestroyPath.ND_CV_Root].transform;

                // 立马卸载这个资源
                Ctx.mInstance.mResLoadMgr.unload(mType2ItemDic[ModuleId.AUTOUPDATEMN].mPath, onAutoUpdateLoadEventHandle);
            }
            else if (res.refCountResLoadResultNotify.resLoadState.hasFailed())
            {
                onModuleFailed(dispObj);
            }
        }

        public void onModuleFailed(IDispatchObject dispObj)
        {
            ResItem res = dispObj as ResItem;
            Ctx.mInstance.mLogSys.debugLog_1(LangItemID.eItem1, res.getLoadPath());

            Ctx.mInstance.mResLoadMgr.unload(res.getResUniqueId(), onLoginLoadEventHandle);
        }
    }
}