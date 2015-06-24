﻿namespace FightCore
{
    public class DragDropData
    {
        protected SceneCardBase m_curDragItem;             // 当前正在拖放的 item
        protected bool m_bDownInCard;

        public DragDropData()
        {
            m_bDownInCard = false;
        }

        public SceneCardBase getCurDragItem()
        {
            return m_curDragItem;
        }

        public void setCurDragItem(SceneCardBase curDragItem_)
        {
            m_curDragItem = curDragItem_;
        }

        // 是否在拖动卡牌
        public bool bInDargCarding()
        {
            return m_curDragItem != null;
        }

        // 是否在手牌卡牌中按下
        public void setDownInCard(bool bDownInCard_)
        {
            m_bDownInCard = bDownInCard_;
        }

        public bool getDownInCard()
        {
            return m_bDownInCard;
        }
    }
}