﻿namespace SDK.Lib
{
    /**
     * @brief 全局委托，只要初始化后，就可以注册和使用这些委托，不用等到哪一个资源创建完成
     */
    public class GlobalDelegate
    {
        // PlayerMainChild 的质量发生改变
        public AddOnceEventDispatch mMainChildMassChangedDispatch;
        // Camera 相机方向或者位置发生改变
        public AddOnceEventDispatch mCameraOrientChangedDispatch;

        public AddOnceEventDispatch mMainOrientChangedDispatch;     // PlayerMain 方向改变分发器
        public AddOnceEventDispatch mMainPosChangedDispatch;        // PlayerMain 位置改变分发器
        public AddOnceEventDispatch mMainOrientStopChangedDispatch; // PlayerMain 方向改变停止分发器
        public AddOnceEventDispatch mMainPosStopChangedDispatch;    // PlayerMain 位置改变停止分发器

        public GlobalDelegate()
        {
            this.mMainChildMassChangedDispatch = new AddOnceEventDispatch();
            this.mCameraOrientChangedDispatch = new AddOnceEventDispatch();
            this.mMainOrientChangedDispatch = new AddOnceEventDispatch();
            this.mMainPosChangedDispatch = new AddOnceEventDispatch();
            this.mMainOrientStopChangedDispatch = new AddOnceEventDispatch();
            this.mMainPosStopChangedDispatch = new AddOnceEventDispatch();
        }

        public void init()
        {

        }

        public void dispose()
        {

        }
    }
}