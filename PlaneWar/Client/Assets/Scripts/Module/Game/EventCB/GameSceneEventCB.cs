﻿using SDK.Lib;
using UnityEngine;

#if UNIT_TEST
using UnitTest;
#endif

namespace Game.Game
{
    public class GameSceneEventCB : ISceneEventCB
    {
        // 场景加载完成处理事件
        public void onLevelLoaded()
        {
            Ctx.mInstance.sendSelRole();

            Ctx.mInstance.mLuaSystem.onSceneLoaded();

            // 关联相机
            GameObject cam = UtilApi.GoFindChildByName("MainCamera").gameObject;
            Ctx.mInstance.mCamSys.setMainCamera(cam.GetComponent<Camera>());

            Ctx.mInstance.mClipRect.setCam(cam.GetComponent<Camera>());
            Ctx.mInstance.mTileMgr.setWorldWidthHeight(
                (int)Ctx.mInstance.mSnowBallCfg.mXmlSnowBallCfg.mXmlItemMap.mWidth,
                (int)Ctx.mInstance.mSnowBallCfg.mXmlSnowBallCfg.mXmlItemMap.mWidth);

            // 创建主角
            //Ctx.mInstance.mPlayerMgr.createPlayerMain();
            // 创建机器人
            //Ctx.mInstance.mRobotMgr.CreateSnowFood();
            // 创建 SnowBall
            //Ctx.mInstance.mSnowBlockMgr.CreateASnowBlock();
            // 创建所有的雪球
            //Ctx.mInstance.mSnowBlockMgr.createAllSnowFood();
            // 创建所有的 Robot
            //Ctx.mInstance.mRobotMgr.createAllRobot();
            //Ctx.mInstance.mUiMgr.loadAndShow(UIFormId.eUIPack);

            // 场景加载完成，关闭登陆界面
            Ctx.mInstance.mLuaSystem.exitForm((int)SDK.Lib.UIFormId.eUIStartGame_Lua);
            runTest();
        }

        protected void runTest()
        {
            // 运行单元测试
#if UNIT_TEST
            TestMain pTestMain = new TestMain();
            pTestMain.run();
#endif
            //Ctx.mInstance.mNetMgr.openSocket("106.14.32.169", 20013);
        }

        protected void init()
        {

        }
    }
}