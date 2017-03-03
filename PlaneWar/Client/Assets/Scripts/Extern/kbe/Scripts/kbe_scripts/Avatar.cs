namespace KBEngine
{
    using UnityEngine;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using SDK.Lib;

    public class Avatar : KBEngine.GameObject
    {
        public Combat combat = null;

        //public static SkillBox skillbox = new SkillBox();

        public Avatar()
        {
        }

        public override void __init__()
        {
            combat = new Combat(this);

            if (isPlayer())
            {
                Event.registerIn("relive", this, "relive");
                //Event.registerIn("useTargetSkill", this, "useTargetSkill");
                Event.registerIn("jump", this, "jump");
                Event.registerIn("updatePlayer", this, "updatePlayer");
            }

            if (isPlayer())
            {
                mEntity_SDK = new SDK.Lib.PlayerMain();

                if (MacroDef.ENABLE_LOG)
                {
                    Ctx.mInstance.mLogSys.log(string.Format("MainPlayer Created, eid = {0}", this.id), LogTypeId.eLogSceneInterActive);
                }
            }
            else
            {
                mEntity_SDK = new SDK.Lib.PlayerOther();

                if (MacroDef.ENABLE_LOG)
                {
                    Ctx.mInstance.mLogSys.log(string.Format("PlayerOther Created, eid = {0}", this.id), LogTypeId.eLogSceneInterActive);
                }
            }

            mEntity_SDK.setEntity_KBE(this);
            (this.mEntity_SDK as BeingEntity).setThisId((uint)this.id);

            mEntity_SDK.init();
            (this.mEntity_SDK as BeingEntity).setDestPos_FromKBE(this.position, true);
        }

        public override void onDestroy()
        {
            if (isPlayer())
            {
                KBEngine.Event.deregisterIn(this);
            }

            if (null != this.mEntity_SDK)
            {
                this.mEntity_SDK.dispose();
            }
        }

        public void relive(Byte type)
        {
            cellCall("relive", type);
        }

        //public bool useTargetSkill(Int32 skillID, Int32 targetID)
        //{
        //    Skill skill = SkillBox.inst.get(skillID);
        //    if (skill == null)
        //        return false;

        //    SCEntityObject scobject = new SCEntityObject(targetID);
        //    if (skill.validCast(this, scobject))
        //    {
        //        skill.use(this, scobject);
        //        return true;
        //    }

        //    return false;
        //}

        public void jump()
        {
            cellCall("jump");
        }

        public virtual void onJump()
        {
            Dbg.DEBUG_MSG(className + "::onJump: " + id);
            Event.fireOut("otherAvatarOnJump", new object[] { this });
        }

        public virtual void updatePlayer(float x, float y, float z, float yaw)
        {
            position.x = x;
            position.y = y;
            position.z = z;

            direction.z = yaw;
        }

        //public virtual void onAddSkill(Int32 skillID)
        //{
        //    Event.fireOut("onAddSkill", new object[] { this });

        //    Skill skill = new Skill();
        //    skill.id = skillID;
        //    skill.name = skillID + " ";
        //    switch (skillID)
        //    {
        //        case 1:
        //            break;
        //        case 1000101:
        //            skill.canUseDistMax = 20f;
        //            break;
        //        case 2000101:
        //            skill.canUseDistMax = 20f;
        //            break;
        //        case 3000101:
        //            skill.canUseDistMax = 20f;
        //            break;
        //        case 4000101:
        //            skill.canUseDistMax = 20f;
        //            break;
        //        case 5000101:
        //            skill.canUseDistMax = 20f;
        //            break;
        //        case 6000101:
        //            skill.canUseDistMax = 20f;
        //            break;
        //        default:
        //            break;
        //    };

        //    SkillBox.inst.add(skill);
        //}

        //public virtual void onRemoveSkill(Int32 skillID)
        //{
        //    Dbg.DEBUG_MSG(className + "::onRemoveSkill(" + skillID + ")");
        //    Event.fireOut("onRemoveSkill", new object[] { this });
        //    SkillBox.inst.remove(skillID);
        //}

        public override void onEnterWorld()
        {
            base.onEnterWorld();

            if (isPlayer())
            {
                Event.fireOut("onAvatarEnterWorld", new object[] { KBEngineApp.app.entity_uuid, id, this });
                //SkillBox.inst.pull();
            }
        }

        public override void onLeaveWorld()
        {
            base.onLeaveWorld();

            if (isPlayer())
            {

            }
            else
            {
                if (null != this.mEntity_SDK)
                {
                    this.mEntity_SDK.dispose();
                }
            }
        }

        //Top10排名
        public void updateRankList(byte myRank, Dictionary<string, object> infos)
        {
            List<object> listinfos = (List<object>)infos["values"];
            int count = listinfos.Count;
            RankInfo[] result = new RankInfo[count];
            for (int i = 0; i < count; i++)
            {
                Dictionary<string, object> info = (Dictionary<string, object>)listinfos[i];
                result[i].rank = i + 1;
                result[i].eid = Convert.ToUInt32(info["eid"]);
                result[i].name = (string)info["name"];
            }

            SDK.Lib.Ctx.mInstance.mLuaSystem.receiveToLua_KBE("notifyTop10RankInfoList", new object[] { result, myRank, count });
        }

        //结算排名
        public void notifyResultData(byte myRank, Dictionary<string, object> infos)
        {
            List<object> listinfos = (List<object>)infos["values"];
            int count = listinfos.Count;
            RankInfo[] result = new RankInfo[count];
            for (int i = 0; i < count; i++)
            {
                Dictionary<string, object> info = (Dictionary<string, object>)listinfos[i];
                result[i].rank = i + 1;
                result[i].eid = Convert.ToUInt32(info["eid"]);
                result[i].name = (string)info["name"];
                result[i].radius = (float)Convert.ToDouble(info["finalRadius"]);
                result[i].swallownum = Convert.ToUInt32(info["eatCount"]);
                result[i].avatarindex = Convert.ToByte(info["imageid"]);
            }
            Ctx.mInstance.mUiMgr.exitForm(UIFormId.eUIJoyStick);
            Ctx.mInstance.mUiMgr.exitForm(UIFormId.eUIForwardForce);
            if (Ctx.mInstance.mSystemSetting.hasKey("MusicModel"))
            {
                if (Ctx.mInstance.mSystemSetting.getInt("MusicModel") == 1)
                {
                    Ctx.mInstance.mSoundMgr.stop("Sound/Music/StudioEIM-myseabed.mp3");
                }
            }
            else
            {
                Ctx.mInstance.mSoundMgr.stop("Sound/Music/StudioEIM-myseabed.mp3");
            }
            
            SDK.Lib.Ctx.mInstance.mLuaSystem.receiveToLua_KBE("notifyResultRankInfoList", new object[] { result, myRank, count });
        }

        //游戏数据
        public void notifyPersonalData(uint zhenzhu, uint haixing, uint huihe, uint swallownum, float maxmass)
        {
            Ctx.mInstance.mSystemSetting.setInt("ZhenZhu", (int)zhenzhu);
            Ctx.mInstance.mSystemSetting.setInt("HaiXing", (int)haixing);
            Ctx.mInstance.mSystemSetting.setInt("HuiHe", (int)huihe);
            Ctx.mInstance.mSystemSetting.setInt("SwallowNum", (int)swallownum);
            Ctx.mInstance.mSystemSetting.setFloat("MaxMass", maxmass);
        }

        //bug报告成功
        public void onAdviceSuccessfully()
        {
            Ctx.mInstance.mSystemSetting.setString("MyReport", "");
        }

        //服务器提示
        public void screenMsg(string msg)
        {
            Ctx.mInstance.mLuaSystem.receiveToLua_KBE("notifySomeMessage", new object[] { msg });
        }

        public void notifySplitSuccess(byte type)
        {
            if (MacroDef.ENABLE_LOG)
            {
                Ctx.mInstance.mLogSys.log("Avatar::notifySplitSuccess", LogTypeId.eLogScene);
            }

            //分裂吞吐无论成功与否，只需获取服务器通知即可
            if (type == 1) //分裂
            {
                Ctx.mInstance.mCommonData.setSplitSuccess(true);
            }
            else if (type == 2)//吞吐
            {
                Ctx.mInstance.mCommonData.setEmitSuccess(true);
            }
        }

        public void notifySplitFail(byte type, List<object> idList, List<object> uniqueidList)
        {
            if (MacroDef.ENABLE_LOG)
            {
                Ctx.mInstance.mLogSys.log("Avatar::notifySplitFail", LogTypeId.eLogScene);
            }

            //分裂吞吐无论成功与否，只需获取服务器通知即可
            if (type == 1) //分裂
            {
                Ctx.mInstance.mCommonData.setSplitSuccess(true);
            }
            else if (type == 2)//吞吐
            {
                Ctx.mInstance.mCommonData.setEmitSuccess(true);

                int idx = 0;
                int len = idList.Count;
                uint aId = 0;
                uint bId = 0;
                PlayerSnowBlock playerSnow = null;

                while (idx < len)
                {
                    UtilMath.getSingleId((System.UInt64)uniqueidList[idx], ref aId, ref bId);
                    playerSnow = Ctx.mInstance.mPlayerSnowBlockMgr.getEntityByUniqueId(Ctx.mInstance.mPlayerSnowBlockMgr.genStrIdById(bId)) as PlayerSnowBlock;

                    if (null != playerSnow)
                    {
                        playerSnow.dispose();
                    }

                    ++idx;
                }
            }
        }

        public void notifyMergeFail(List<object> idList)
        {
            int idx = 0;
            int len = idList.Count;

            System.Int32 eid;

            if (null != this.mEntity_SDK)
            {
                while (idx < len)
                {
                    eid = (System.Int32)idList[idx];
                    SDK.Lib.PlayerMainChild playerChild = (this.mEntity_SDK as PlayerMain).mPlayerSplitMerge.mPlayerChildMgr.getEntityByThisId((uint)eid) as SDK.Lib.PlayerMainChild;

                    if (MacroDef.ENABLE_LOG)
                    {
                        Ctx.mInstance.mLogSys.log(string.Format("Avatar::notifySplit, thisId = {0}", eid), LogTypeId.eLogScene);
                    }

                    if (null != playerChild)
                    {
                        //playerChild.setClientDispose(false);
                        //playerChild.setFreezeXZ(false);
                        //playerChild.setIsMerge(false);
                        playerChild.setBeingSubState(BeingSubState.eBSSNone);

                        if (MacroDef.ENABLE_LOG)
                        {
                            Ctx.mInstance.mLogSys.log("Avatar::notifySplit, can find being", LogTypeId.eLogScene);
                        }
                    }

                    ++idx;
                }
            }
        }

        // 通知吃失败 aThisid:攻击方 bThisid:被吃方
        // type:  类型1代表吃电脑玩家失败,类型2代表吃玩家失败,目前吃雪块和屎是不会失败的
        public void notifyEatFail(byte type, System.Int32 aThisid, System.Int32 bThisid)
        {
            if(1 == type)
            {
                SDK.Lib.ComputerBall bBeingEntity = Ctx.mInstance.mComputerBallMgr.getEntityByThisId((uint)bThisid) as SDK.Lib.ComputerBall;
                bBeingEntity.setIsEatedByOther(false);
            }
            else if(2 == type)
            {
                PlayerChild bBeingEntity = Ctx.mInstance.mPlayerMgr.getEntityByThisId((uint)bThisid) as PlayerChild;
                bBeingEntity.setIsEatedByOther(false);
            }
        }

        // 通知融合结果
        public void notifyMergeSuccess(System.Int32 aThisid, System.Int32 bThisid, System.Int32 cThisId, float mass)
        {
            if (MacroDef.ENABLE_LOG)
            {
                Ctx.mInstance.mLogSys.log(string.Format("Avatar::notifyMerge, aThisid = {0}, bThisid = {1}, cThisid = {2}, mass = {3}", aThisid, bThisid, cThisId, mass), LogTypeId.eLogScene);
            }

            PlayerMainChild aChild = Ctx.mInstance.mPlayerMgr.getHero().mPlayerSplitMerge.mPlayerChildMgr.getEntityByThisId((uint)aThisid) as PlayerMainChild;
            PlayerMainChild bChild = Ctx.mInstance.mPlayerMgr.getHero().mPlayerSplitMerge.mPlayerChildMgr.getEntityByThisId((uint)bThisid) as PlayerMainChild;

            PlayerMainChild firChild;
            PlayerMainChild sndChild;

            if (null != aChild && null != bChild)
            {
                if (aThisid == cThisId)
                {
                    firChild = aChild;
                    sndChild = bChild;
                }
                else
                {
                    firChild = bChild;
                    sndChild = aChild;
                }

                Ctx.mInstance.mPlayerMgr.getHero().mPlayerSplitMerge.removeMerge(firChild, sndChild);

                // 必须在 firChild.setMass 之前设置， firChild.setMass 里面要计算质量
                sndChild.setBeingSubState(BeingSubState.eBSSMerge);
                (sndChild.mMovement as PlayerMainChildMovement).removeParentOrientChangedhandle();

                //firChild.setIsMerge(false);
                firChild.setBeingSubState(BeingSubState.eBSSNone);
                firChild.setLastMergedTime();
                firChild.setMass(mass);

                sndChild.setMergeEntity(firChild);
                float moveSpeed = aChild.getMoveSpeed(true) * Ctx.mInstance.mSnowBallCfg.mMergeSpeedFactor;
                if(moveSpeed < Ctx.mInstance.mSnowBallCfg.mMergeMinSpeed)
                {
                    moveSpeed = Ctx.mInstance.mSnowBallCfg.mMergeMinSpeed;
                }

                sndChild.setMoveSpeed(moveSpeed);
                UtilApi.enableCollider<UnityEngine.SphereCollider>(sndChild.getGameObject(), false);
                sndChild.setDestPosForMerge(firChild.getPos(), false);
            }
        }

        // 更新指定eid所有子飞机的速度
        public void changeMovespeed(int eid, float movespeed)
        {
            Player player = Ctx.mInstance.mPlayerMgr.getEntityByThisId((uint)eid) as Player;
            player.mPlayerSplitMerge.setAllChildsMoveSpeed(movespeed);
        }

        //public override void SetPosition(object old)
        //{
        //    base.SetPosition(old);

        //    if (null != this.mEntity_SDK)
        //    {
        //        (this.mEntity_SDK as BeingEntity).setDestPos(this.position);
        //        (this.mEntity_SDK as BeingEntity).setOriginal(this.position);
        //    }
        //}

        //public override void SetDirection(object old)
        //{
        //    base.SetDirection(old);
        //    if (null != this.mEntity_SDK)
        //    {
        //        (this.mEntity_SDK as BeingEntity).setDestRotate(new Vector3(this.direction.y, this.direction.z, this.direction.x));
        //    }
        //}
    }
}