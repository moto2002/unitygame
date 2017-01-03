﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class SDK_Lib_GlobalDelegateWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(SDK.Lib.GlobalDelegate), typeof(System.Object));
		L.RegFunction("init", init);
		L.RegFunction("dispose", dispose);
		L.RegFunction("New", _CreateSDK_Lib_GlobalDelegate);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("mMainChildMassChangedDispatch", get_mMainChildMassChangedDispatch, set_mMainChildMassChangedDispatch);
		L.RegVar("mCameraOrientChangedDispatch", get_mCameraOrientChangedDispatch, set_mCameraOrientChangedDispatch);
		L.RegVar("mMainOrientChangedDispatch", get_mMainOrientChangedDispatch, set_mMainOrientChangedDispatch);
		L.RegVar("mMainPosChangedDispatch", get_mMainPosChangedDispatch, set_mMainPosChangedDispatch);
		L.RegVar("mMainOrientStopChangedDispatch", get_mMainOrientStopChangedDispatch, set_mMainOrientStopChangedDispatch);
		L.RegVar("mMainPosStopChangedDispatch", get_mMainPosStopChangedDispatch, set_mMainPosStopChangedDispatch);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateSDK_Lib_GlobalDelegate(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				SDK.Lib.GlobalDelegate obj = new SDK.Lib.GlobalDelegate();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: SDK.Lib.GlobalDelegate.New");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int init(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			SDK.Lib.GlobalDelegate obj = (SDK.Lib.GlobalDelegate)ToLua.CheckObject(L, 1, typeof(SDK.Lib.GlobalDelegate));
			obj.init();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int dispose(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			SDK.Lib.GlobalDelegate obj = (SDK.Lib.GlobalDelegate)ToLua.CheckObject(L, 1, typeof(SDK.Lib.GlobalDelegate));
			obj.dispose();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_mMainChildMassChangedDispatch(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SDK.Lib.GlobalDelegate obj = (SDK.Lib.GlobalDelegate)o;
			SDK.Lib.AddOnceEventDispatch ret = obj.mMainChildMassChangedDispatch;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index mMainChildMassChangedDispatch on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_mCameraOrientChangedDispatch(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SDK.Lib.GlobalDelegate obj = (SDK.Lib.GlobalDelegate)o;
			SDK.Lib.AddOnceEventDispatch ret = obj.mCameraOrientChangedDispatch;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index mCameraOrientChangedDispatch on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_mMainOrientChangedDispatch(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SDK.Lib.GlobalDelegate obj = (SDK.Lib.GlobalDelegate)o;
			SDK.Lib.AddOnceEventDispatch ret = obj.mMainOrientChangedDispatch;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index mMainOrientChangedDispatch on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_mMainPosChangedDispatch(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SDK.Lib.GlobalDelegate obj = (SDK.Lib.GlobalDelegate)o;
			SDK.Lib.AddOnceEventDispatch ret = obj.mMainPosChangedDispatch;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index mMainPosChangedDispatch on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_mMainOrientStopChangedDispatch(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SDK.Lib.GlobalDelegate obj = (SDK.Lib.GlobalDelegate)o;
			SDK.Lib.AddOnceEventDispatch ret = obj.mMainOrientStopChangedDispatch;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index mMainOrientStopChangedDispatch on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_mMainPosStopChangedDispatch(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SDK.Lib.GlobalDelegate obj = (SDK.Lib.GlobalDelegate)o;
			SDK.Lib.AddOnceEventDispatch ret = obj.mMainPosStopChangedDispatch;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index mMainPosStopChangedDispatch on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_mMainChildMassChangedDispatch(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SDK.Lib.GlobalDelegate obj = (SDK.Lib.GlobalDelegate)o;
			SDK.Lib.AddOnceEventDispatch arg0 = (SDK.Lib.AddOnceEventDispatch)ToLua.CheckObject(L, 2, typeof(SDK.Lib.AddOnceEventDispatch));
			obj.mMainChildMassChangedDispatch = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index mMainChildMassChangedDispatch on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_mCameraOrientChangedDispatch(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SDK.Lib.GlobalDelegate obj = (SDK.Lib.GlobalDelegate)o;
			SDK.Lib.AddOnceEventDispatch arg0 = (SDK.Lib.AddOnceEventDispatch)ToLua.CheckObject(L, 2, typeof(SDK.Lib.AddOnceEventDispatch));
			obj.mCameraOrientChangedDispatch = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index mCameraOrientChangedDispatch on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_mMainOrientChangedDispatch(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SDK.Lib.GlobalDelegate obj = (SDK.Lib.GlobalDelegate)o;
			SDK.Lib.AddOnceEventDispatch arg0 = (SDK.Lib.AddOnceEventDispatch)ToLua.CheckObject(L, 2, typeof(SDK.Lib.AddOnceEventDispatch));
			obj.mMainOrientChangedDispatch = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index mMainOrientChangedDispatch on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_mMainPosChangedDispatch(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SDK.Lib.GlobalDelegate obj = (SDK.Lib.GlobalDelegate)o;
			SDK.Lib.AddOnceEventDispatch arg0 = (SDK.Lib.AddOnceEventDispatch)ToLua.CheckObject(L, 2, typeof(SDK.Lib.AddOnceEventDispatch));
			obj.mMainPosChangedDispatch = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index mMainPosChangedDispatch on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_mMainOrientStopChangedDispatch(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SDK.Lib.GlobalDelegate obj = (SDK.Lib.GlobalDelegate)o;
			SDK.Lib.AddOnceEventDispatch arg0 = (SDK.Lib.AddOnceEventDispatch)ToLua.CheckObject(L, 2, typeof(SDK.Lib.AddOnceEventDispatch));
			obj.mMainOrientStopChangedDispatch = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index mMainOrientStopChangedDispatch on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_mMainPosStopChangedDispatch(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SDK.Lib.GlobalDelegate obj = (SDK.Lib.GlobalDelegate)o;
			SDK.Lib.AddOnceEventDispatch arg0 = (SDK.Lib.AddOnceEventDispatch)ToLua.CheckObject(L, 2, typeof(SDK.Lib.AddOnceEventDispatch));
			obj.mMainPosStopChangedDispatch = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index mMainPosStopChangedDispatch on a nil value" : e.Message);
		}
	}
}

