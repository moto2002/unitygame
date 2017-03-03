﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class SDK_Lib_PlayerWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(SDK.Lib.Player), typeof(SDK.Lib.BeingEntity));
		L.RegFunction("setCanMove", setCanMove);
		L.RegFunction("getCanMove", getCanMove);
		L.RegFunction("dispose", dispose);
		L.RegFunction("onDestroy", onDestroy);
		L.RegFunction("autoHandle", autoHandle);
		L.RegFunction("initRender", initRender);
		L.RegFunction("setPos", setPos);
		L.RegFunction("setDestPos", setDestPos);
		L.RegFunction("getDeltaPos", getDeltaPos);
		L.RegFunction("canEatOther", canEatOther);
		L.RegFunction("getAllChildMovement", getAllChildMovement);
		L.RegFunction("getChildList", getChildList);
		L.RegFunction("isExistThisId", isExistThisId);
		L.RegFunction("getIsDead", getIsDead);
		L.RegFunction("New", _CreateSDK_Lib_Player);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("mPlayerSplitMerge", get_mPlayerSplitMerge, set_mPlayerSplitMerge);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateSDK_Lib_Player(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				SDK.Lib.Player obj = new SDK.Lib.Player();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: SDK.Lib.Player.New");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int setCanMove(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			SDK.Lib.Player obj = (SDK.Lib.Player)ToLua.CheckObject(L, 1, typeof(SDK.Lib.Player));
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.setCanMove(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int getCanMove(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			SDK.Lib.Player obj = (SDK.Lib.Player)ToLua.CheckObject(L, 1, typeof(SDK.Lib.Player));
			bool o = obj.getCanMove();
			LuaDLL.lua_pushboolean(L, o);
			return 1;
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
			SDK.Lib.Player obj = (SDK.Lib.Player)ToLua.CheckObject(L, 1, typeof(SDK.Lib.Player));
			obj.dispose();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int onDestroy(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			SDK.Lib.Player obj = (SDK.Lib.Player)ToLua.CheckObject(L, 1, typeof(SDK.Lib.Player));
			obj.onDestroy();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int autoHandle(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			SDK.Lib.Player obj = (SDK.Lib.Player)ToLua.CheckObject(L, 1, typeof(SDK.Lib.Player));
			obj.autoHandle();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int initRender(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			SDK.Lib.Player obj = (SDK.Lib.Player)ToLua.CheckObject(L, 1, typeof(SDK.Lib.Player));
			obj.initRender();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int setPos(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			SDK.Lib.Player obj = (SDK.Lib.Player)ToLua.CheckObject(L, 1, typeof(SDK.Lib.Player));
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
			obj.setPos(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int setDestPos(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			SDK.Lib.Player obj = (SDK.Lib.Player)ToLua.CheckObject(L, 1, typeof(SDK.Lib.Player));
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
			bool arg1 = LuaDLL.luaL_checkboolean(L, 3);
			obj.setDestPos(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int getDeltaPos(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			SDK.Lib.Player obj = (SDK.Lib.Player)ToLua.CheckObject(L, 1, typeof(SDK.Lib.Player));
			UnityEngine.Vector3 o = obj.getDeltaPos();
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int canEatOther(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			SDK.Lib.Player obj = (SDK.Lib.Player)ToLua.CheckObject(L, 1, typeof(SDK.Lib.Player));
			SDK.Lib.BeingEntity arg0 = (SDK.Lib.BeingEntity)ToLua.CheckObject(L, 2, typeof(SDK.Lib.BeingEntity));
			bool o = obj.canEatOther(arg0);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int getAllChildMovement(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			SDK.Lib.Player obj = (SDK.Lib.Player)ToLua.CheckObject(L, 1, typeof(SDK.Lib.Player));
			SDK.Lib.PlayerMovement[] o = obj.getAllChildMovement();
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int getChildList(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			SDK.Lib.Player obj = (SDK.Lib.Player)ToLua.CheckObject(L, 1, typeof(SDK.Lib.Player));
			SDK.Lib.MList<SDK.Lib.SceneEntityBase> o = obj.getChildList();
			ToLua.PushObject(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int isExistThisId(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			SDK.Lib.Player obj = (SDK.Lib.Player)ToLua.CheckObject(L, 1, typeof(SDK.Lib.Player));
			uint arg0 = (uint)LuaDLL.luaL_checknumber(L, 2);
			bool o = obj.isExistThisId(arg0);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int getIsDead(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			SDK.Lib.Player obj = (SDK.Lib.Player)ToLua.CheckObject(L, 1, typeof(SDK.Lib.Player));
			bool o = obj.getIsDead();
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_mPlayerSplitMerge(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SDK.Lib.Player obj = (SDK.Lib.Player)o;
			SDK.Lib.PlayerSplitMerge ret = obj.mPlayerSplitMerge;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index mPlayerSplitMerge on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_mPlayerSplitMerge(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SDK.Lib.Player obj = (SDK.Lib.Player)o;
			SDK.Lib.PlayerSplitMerge arg0 = (SDK.Lib.PlayerSplitMerge)ToLua.CheckObject(L, 2, typeof(SDK.Lib.PlayerSplitMerge));
			obj.mPlayerSplitMerge = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index mPlayerSplitMerge on a nil value" : e.Message);
		}
	}
}

