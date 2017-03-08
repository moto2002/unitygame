using KBEngine;
using UnityEngine;
using System;
using SDK.Lib;

public class MWorld_KBE
{
    public MWorld_KBE()
    {

    }

    public void init()
    {
        installEvents();
    }

    void installEvents()
    {
        // in world
        KBEngine.Event.registerOut("addSpaceGeometryMapping", this, "addSpaceGeometryMapping");
        KBEngine.Event.registerOut("onAvatarEnterWorld", this, "onAvatarEnterWorld");
        KBEngine.Event.registerOut("onEnterWorld", this, "onEnterWorld");
        KBEngine.Event.registerOut("onLeaveWorld", this, "onLeaveWorld");
        KBEngine.Event.registerOut("SetPosition", this, "SetPosition");
        KBEngine.Event.registerOut("SetDirection", this, "SetDirection");
        KBEngine.Event.registerOut("updatePosition", this, "updatePosition");
        KBEngine.Event.registerOut("onControlled", this, "onControlled");
        KBEngine.Event.registerOut("set_HP", this, "set_HP");
        KBEngine.Event.registerOut("set_MP", this, "set_MP");
        KBEngine.Event.registerOut("set_HP_Max", this, "set_HP_Max");
        KBEngine.Event.registerOut("set_MP_Max", this, "set_MP_Max");
        KBEngine.Event.registerOut("set_level", this, "set_level");
        KBEngine.Event.registerOut("set_name", this, "set_entityName");
        KBEngine.Event.registerOut("set_state", this, "set_state");
        KBEngine.Event.registerOut("set_moveSpeed", this, "set_moveSpeed");
        KBEngine.Event.registerOut("set_modelScale", this, "set_modelScale");
        KBEngine.Event.registerOut("set_modelID", this, "set_modelID");
        KBEngine.Event.registerOut("recvDamage", this, "recvDamage");
        KBEngine.Event.registerOut("otherAvatarOnJump", this, "otherAvatarOnJump");
        KBEngine.Event.registerOut("onAddSkill", this, "onAddSkill");
    }

    public void dispose()
    {
        KBEngine.Event.deregisterOut(this);
    }

    public void addSpaceGeometryMapping(string respath)
    {
        //if (terrain == null)
        //    terrain = UtilApi.Instantiate(terrainPerfab) as UnityEngine.GameObject;

        //if (player)
        //    player.GetComponent<GameEntity>().entityEnable();

        if (Ctx.mInstance.mSceneSys.isSceneLoaded())
        {
            PlayerMain playerMain = Ctx.mInstance.mPlayerMgr.getHero();
            if (null != playerMain)
            {
                //playerMain.entityEnable();
            }
        }
    }

    public void onAvatarEnterWorld(UInt64 rndUUID, Int32 eid, KBEngine.Avatar avatar)
    {
        if (!avatar.isPlayer())
        {
            return;
        }        
    }

    // �������ǣ�ֻҪɾ����ʾ���������´���
    //public void createPlayer()
    //{
    //    //if (player != null)
    //    //{
    //    //    if (terrain != null)
    //    //        player.GetComponent<GameEntity>().entityEnable();
    //    //    return;
    //    //}

    //    PlayerMain player = Ctx.mInstance.mPlayerMgr.getHero();
    //    if (player != null)
    //    {
    //        if (Ctx.mInstance.mSceneSys.isSceneLoaded())
    //        {
    //            //player.entityEnable();
    //        }
    //        return;
    //    }

    //    if (KBEngineApp.app.entity_type != "Avatar")
    //    {
    //        return;
    //    }

    //    KBEngine.Avatar avatar = (KBEngine.Avatar)KBEngineApp.app.player();
    //    if (avatar == null)
    //    {
    //        Debug.Log("wait create(palyer)!");
    //        return;
    //    }

    //    float y = avatar.position.y;
    //    if (avatar.isOnGround)
    //        y = 1.3f;

    //    //player = UtilApi.Instantiate(avatarPerfab, new Vector3(avatar.position.x, y, avatar.position.z),
    //    //                     Quaternion.Euler(new Vector3(avatar.direction.y, avatar.direction.z, avatar.direction.x))) as UnityEngine.GameObject;

    //    //player.GetComponent<GameEntity>().entityDisable();

    //    player.setPos(new Vector3(avatar.position.x, y, avatar.position.z));
    //    player.setRotation(Quaternion.Euler(new Vector3(avatar.direction.y, avatar.direction.z, avatar.direction.x)));

    //    //avatar.renderObj = player;
    //    avatar.renderObj = player.gameObject();
    //    //((UnityEngine.GameObject)avatar.renderObj).GetComponent<GameEntity>().isPlayer = true;

    //    // �б�Ҫ����һ�£����ڸýӿ���Update�첽���ã��п���set_position�ȳ�ʼ����Ϣ�Ѿ��ȴ�����
    //    // ��ô���������renderObj��λ�úͷ���Ϊ0��������������
    //    SetPosition(avatar);
    //    SetDirection(avatar);
    //}

    public void onAddSkill(KBEngine.Entity entity)
    {
    }

    // �����������
    public void onEnterWorld(KBEngine.Entity entity)
    {
        if (entity.isPlayer())
            return;

        float y = entity.position.y;
        if (entity.isOnGround)
            y = 1.3f;

        //entity.renderObj = UtilApi.Instantiate(entityPerfab, new Vector3(entity.position.x, y, entity.position.z),
        //    Quaternion.Euler(new Vector3(entity.direction.y, entity.direction.z, entity.direction.x))) as UnityEngine.GameObject;

        //((UnityEngine.GameObject)entity.renderObj).name = entity.className + "_" + entity.id;

        // �������
    }

    public void onLeaveWorld(KBEngine.Entity entity)
    {
        if (entity.renderObj == null)
            return;

        UnityEngine.GameObject.Destroy((UnityEngine.GameObject)entity.renderObj);
        entity.renderObj = null;
    }

    public void SetPosition(KBEngine.Entity entity)
    {
        //if (entity.renderObj == null)
        //    return;

        //((UnityEngine.GameObject)entity.renderObj).GetComponent<GameEntity>().destPosition = entity.position;
        //((UnityEngine.GameObject)entity.renderObj).GetComponent<GameEntity>().position = entity.position;

        Player player = entity.getEntity_SDK() as Player;
        SDK.Lib.ComputerBall AIBall = null;
        if (player == null)
        {
            AIBall = entity.getEntity_SDK() as SDK.Lib.ComputerBall;
        }
        if (player == null && AIBall == null) return;

        if(player != null)
        {
            if (EntityType.ePlayerMain != player.getEntityType())
            {
                player.setDestPos_FromKBE(entity.position, true);
            }
        }        

        if(AIBall != null)
        {
            AIBall.setDestPos_FromKBE(entity.position, true);
        }

        if (entity.isPlayer())
        {
            // ������Ҫ����һ���¼����������
            Ctx.mInstance.mGlobalDelegate.mMainChildChangedDispatch.dispatchEvent(null);
        }
    }

    public void updatePosition(KBEngine.Entity entity)
    {
        //if (entity.renderObj == null)
        //    return;

        //GameEntity gameEntity = ((UnityEngine.GameObject)entity.renderObj).GetComponent<GameEntity>();
        //gameEntity.destPosition = entity.position;
        //gameEntity.isOnGround = entity.isOnGround;

        BeingEntity beingentity = entity.getEntity_SDK() as BeingEntity;

        if (entity != null)
        {
            if (EntityType.ePlayerMainChild == beingentity.getEntityType())
            {
                beingentity.setDestPos_FromKBE(entity.position, true);
            }
            else if (EntityType.eComputerBall == beingentity.getEntityType() ||
                     EntityType.eFlyBullet == beingentity.getEntityType() ||
                     EntityType.ePlayerOtherChild == beingentity.getEntityType()
                     )
            {
                beingentity.setDestPos_FromKBE(entity.position, false);
            }
        }

        //player.isOnGround = entity.isOnGround;

        if (null != beingentity && EntityType.ePlayerMainChild == beingentity.getEntityType())
        {
            if (MacroDef.ENABLE_LOG)
            {
                Ctx.mInstance.mLogSys.log(
                        string.Format("Update Move PosX = {0}, PosY = {1}, PosZ = {2}", entity.position.x, entity.position.y, entity.position.z),
                        LogTypeId.eLogBeingMove);
            }
        }
    }

    public void onControlled(KBEngine.Entity entity, bool isControlled)
    {
        //if (entity.renderObj == null)
        //    return;

        //GameEntity gameEntity = ((UnityEngine.GameObject)entity.renderObj).GetComponent<GameEntity>();
        //gameEntity.isControlled = isControlled;

        Player player = entity.getEntity_SDK() as Player;
        if (player == null)
            return;

        //player.isControlled = isControlled;
    }

    public void SetDirection(KBEngine.Entity entity)
    {
        //if (entity.renderObj == null)
        //    return;

        //((UnityEngine.GameObject)entity.renderObj).GetComponent<GameEntity>().destDirection =
        //    new Vector3(entity.direction.y, entity.direction.z, entity.direction.x);

        BeingEntity player = entity.getEntity_SDK() as BeingEntity;

        if (player != null)
        {
            if (EntityType.ePlayerMainChild == player.getEntityType() ||
                EntityType.eFlyBullet == player.getEntityType())
            {
                UnityEngine.Vector3 euler = UtilApi.invConvRotByMode(UtilMath.getRotateByOrient(UtilApi.convRotByMode(entity.direction)).eulerAngles);
                player.setDestRotate_FromKBE(euler, true);
            }
        }
    }

    public void set_HP(KBEngine.Entity entity, object v)
    {
        if (entity.renderObj != null)
        {
            ((UnityEngine.GameObject)entity.renderObj).GetComponent<GameEntity>().hp = "" + (Int32)v + "/" + (Int32)entity.getDefinedProperty("HP_Max");
        }
    }

    public void set_MP(KBEngine.Entity entity, object v)
    {
    }

    public void set_HP_Max(KBEngine.Entity entity, object v)
    {
        if (entity.renderObj != null)
        {
            ((UnityEngine.GameObject)entity.renderObj).GetComponent<GameEntity>().hp = (Int32)entity.getDefinedProperty("HP") + "/" + (Int32)v;
        }
    }

    public void set_MP_Max(KBEngine.Entity entity, object v)
    {
    }

    public void set_level(KBEngine.Entity entity, object v)
    {
    }

    public void set_entityName(KBEngine.Entity entity, object v)
    {
        if (entity.renderObj != null)
        {
            ((UnityEngine.GameObject)entity.renderObj).GetComponent<GameEntity>().entity_name = (string)v;
        }
    }

    public void set_state(KBEngine.Entity entity, object v)
    {
        if (entity.renderObj != null)
        {
            ((UnityEngine.GameObject)entity.renderObj).GetComponent<GameEntity>().set_state((SByte)v);
        }

        if (entity.isPlayer())
        {
            Debug.Log("player->set_state: " + v);

            //if (((SByte)v) == 1)
            //    UI.inst.showReliveGUI = true;
            //else
            //    UI.inst.showReliveGUI = false;

            return;
        }
    }

    public void set_moveSpeed(KBEngine.Entity entity, object v)
    {
        return; //ȡ���ٶ�ͬ��
        //float fspeed = ((float)(Byte)v) / 10f;

        ////if (entity.renderObj != null)
        ////{
        ////    ((UnityEngine.GameObject)entity.renderObj).GetComponent<GameEntity>().speed = fspeed;
        ////}

        //Player player = entity.getEntity_SDK() as Player;
        //if (player == null)
        //    return;

        //player.setMoveSpeed(fspeed);
    }

    public void set_modelScale(KBEngine.Entity entity, object v)
    {
    }

    public void set_modelID(KBEngine.Entity entity, object v)
    {
    }

    public void recvDamage(KBEngine.Entity entity, KBEngine.Entity attacker, Int32 skillID, Int32 damageType, Int32 damage)
    {
    }

    public void otherAvatarOnJump(KBEngine.Entity entity)
    {
        Debug.Log("otherAvatarOnJump: " + entity.id);
        if (entity.renderObj != null)
        {
            ((UnityEngine.GameObject)entity.renderObj).GetComponent<GameEntity>().OnJump();
        }
    }
}