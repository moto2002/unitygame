﻿namespace SDK.Common
{
    /**
     * @brief 处理消息工具
     */
    public class UtilMsg
    {
        // 发送消息
        public static void sendMsg(stNullUserCmd msg)
        {
            msg.serialize(Ctx.m_instance.m_netMgr.getSendBA());
            // 打印日志
            Ctx.m_instance.m_shareMgr.m_tmpStr = string.Format("发送消息: byCmd = {0}, byParam = {1}", msg.byCmd, msg.byParam);
            Ctx.m_instance.m_log.log(Ctx.m_instance.m_shareMgr.m_tmpStr);
            Ctx.m_instance.m_netMgr.send();
        }
    }
}