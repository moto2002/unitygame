﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class SDK_Lib_ModuleIdWrap
{
	public static void Register(LuaState L)
	{
		L.BeginEnum(typeof(SDK.Lib.ModuleId));
		L.RegVar("LOGINMN", get_LOGINMN, null);
		L.RegVar("GAMEMN", get_GAMEMN, null);
		L.RegVar("AUTOUPDATEMN", get_AUTOUPDATEMN, null);
		L.RegFunction("IntToEnum", IntToEnum);
		L.EndEnum();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_LOGINMN(IntPtr L)
	{
		ToLua.Push(L, SDK.Lib.ModuleId.LOGINMN);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_GAMEMN(IntPtr L)
	{
		ToLua.Push(L, SDK.Lib.ModuleId.GAMEMN);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_AUTOUPDATEMN(IntPtr L)
	{
		ToLua.Push(L, SDK.Lib.ModuleId.AUTOUPDATEMN);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		SDK.Lib.ModuleId o = (SDK.Lib.ModuleId)arg0;
		ToLua.Push(L, o);
		return 1;
	}
}
