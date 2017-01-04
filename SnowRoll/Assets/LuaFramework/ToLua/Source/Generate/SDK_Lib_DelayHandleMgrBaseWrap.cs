﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class SDK_Lib_DelayHandleMgrBaseWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(SDK.Lib.DelayHandleMgrBase), typeof(SDK.Lib.GObject));
		L.RegFunction("incDepth", incDepth);
		L.RegFunction("decDepth", decDepth);
		L.RegFunction("bInDepth", bInDepth);
		L.RegFunction("New", _CreateSDK_Lib_DelayHandleMgrBase);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateSDK_Lib_DelayHandleMgrBase(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				SDK.Lib.DelayHandleMgrBase obj = new SDK.Lib.DelayHandleMgrBase();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: SDK.Lib.DelayHandleMgrBase.New");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int incDepth(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			SDK.Lib.DelayHandleMgrBase obj = (SDK.Lib.DelayHandleMgrBase)ToLua.CheckObject(L, 1, typeof(SDK.Lib.DelayHandleMgrBase));
			obj.incDepth();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int decDepth(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			SDK.Lib.DelayHandleMgrBase obj = (SDK.Lib.DelayHandleMgrBase)ToLua.CheckObject(L, 1, typeof(SDK.Lib.DelayHandleMgrBase));
			obj.decDepth();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int bInDepth(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			SDK.Lib.DelayHandleMgrBase obj = (SDK.Lib.DelayHandleMgrBase)ToLua.CheckObject(L, 1, typeof(SDK.Lib.DelayHandleMgrBase));
			bool o = obj.bInDepth();
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}
