﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class SDK_Lib_AuxBytesLoaderWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(SDK.Lib.AuxBytesLoader), typeof(SDK.Lib.AuxLoaderBase));
		L.RegFunction("dispose", dispose);
		L.RegFunction("getBytes", getBytes);
		L.RegFunction("getLogicPath", getLogicPath);
		L.RegFunction("syncLoad", syncLoad);
		L.RegFunction("asyncLoad", asyncLoad);
		L.RegFunction("onBytesLoaded", onBytesLoaded);
		L.RegFunction("unload", unload);
		L.RegFunction("New", _CreateSDK_Lib_AuxBytesLoader);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateSDK_Lib_AuxBytesLoader(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				string arg0 = ToLua.CheckString(L, 1);
				SDK.Lib.AuxBytesLoader obj = new SDK.Lib.AuxBytesLoader(arg0);
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: SDK.Lib.AuxBytesLoader.New");
			}
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
			SDK.Lib.AuxBytesLoader obj = (SDK.Lib.AuxBytesLoader)ToLua.CheckObject(L, 1, typeof(SDK.Lib.AuxBytesLoader));
			obj.dispose();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int getBytes(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			SDK.Lib.AuxBytesLoader obj = (SDK.Lib.AuxBytesLoader)ToLua.CheckObject(L, 1, typeof(SDK.Lib.AuxBytesLoader));
			byte[] o = obj.getBytes();
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int getLogicPath(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			SDK.Lib.AuxBytesLoader obj = (SDK.Lib.AuxBytesLoader)ToLua.CheckObject(L, 1, typeof(SDK.Lib.AuxBytesLoader));
			string o = obj.getLogicPath();
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int syncLoad(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 4 && TypeChecker.CheckTypes(L, 1, typeof(SDK.Lib.AuxBytesLoader), typeof(string), typeof(SDK.Lib.MAction<SDK.Lib.IDispatchObject>), typeof(SDK.Lib.MAction<SDK.Lib.IDispatchObject>)))
			{
				SDK.Lib.AuxBytesLoader obj = (SDK.Lib.AuxBytesLoader)ToLua.ToObject(L, 1);
				string arg0 = ToLua.ToString(L, 2);
				SDK.Lib.MAction<SDK.Lib.IDispatchObject> arg1 = null;
				LuaTypes funcType3 = LuaDLL.lua_type(L, 3);

				if (funcType3 != LuaTypes.LUA_TFUNCTION)
				{
					 arg1 = (SDK.Lib.MAction<SDK.Lib.IDispatchObject>)ToLua.ToObject(L, 3);
				}
				else
				{
					LuaFunction func = ToLua.ToLuaFunction(L, 3);
					arg1 = DelegateFactory.CreateDelegate(typeof(SDK.Lib.MAction<SDK.Lib.IDispatchObject>), func) as SDK.Lib.MAction<SDK.Lib.IDispatchObject>;
				}

				SDK.Lib.MAction<SDK.Lib.IDispatchObject> arg2 = null;
				LuaTypes funcType4 = LuaDLL.lua_type(L, 4);

				if (funcType4 != LuaTypes.LUA_TFUNCTION)
				{
					 arg2 = (SDK.Lib.MAction<SDK.Lib.IDispatchObject>)ToLua.ToObject(L, 4);
				}
				else
				{
					LuaFunction func = ToLua.ToLuaFunction(L, 4);
					arg2 = DelegateFactory.CreateDelegate(typeof(SDK.Lib.MAction<SDK.Lib.IDispatchObject>), func) as SDK.Lib.MAction<SDK.Lib.IDispatchObject>;
				}

				obj.syncLoad(arg0, arg1, arg2);
				return 0;
			}
			else if (count == 5 && TypeChecker.CheckTypes(L, 1, typeof(SDK.Lib.AuxBytesLoader), typeof(string), typeof(LuaInterface.LuaTable), typeof(LuaInterface.LuaFunction), typeof(LuaInterface.LuaFunction)))
			{
				SDK.Lib.AuxBytesLoader obj = (SDK.Lib.AuxBytesLoader)ToLua.ToObject(L, 1);
				string arg0 = ToLua.ToString(L, 2);
				LuaTable arg1 = ToLua.ToLuaTable(L, 3);
				LuaFunction arg2 = ToLua.ToLuaFunction(L, 4);
				LuaFunction arg3 = ToLua.ToLuaFunction(L, 5);
				obj.syncLoad(arg0, arg1, arg2, arg3);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: SDK.Lib.AuxBytesLoader.syncLoad");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int asyncLoad(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 4 && TypeChecker.CheckTypes(L, 1, typeof(SDK.Lib.AuxBytesLoader), typeof(string), typeof(SDK.Lib.MAction<SDK.Lib.IDispatchObject>), typeof(SDK.Lib.MAction<SDK.Lib.IDispatchObject>)))
			{
				SDK.Lib.AuxBytesLoader obj = (SDK.Lib.AuxBytesLoader)ToLua.ToObject(L, 1);
				string arg0 = ToLua.ToString(L, 2);
				SDK.Lib.MAction<SDK.Lib.IDispatchObject> arg1 = null;
				LuaTypes funcType3 = LuaDLL.lua_type(L, 3);

				if (funcType3 != LuaTypes.LUA_TFUNCTION)
				{
					 arg1 = (SDK.Lib.MAction<SDK.Lib.IDispatchObject>)ToLua.ToObject(L, 3);
				}
				else
				{
					LuaFunction func = ToLua.ToLuaFunction(L, 3);
					arg1 = DelegateFactory.CreateDelegate(typeof(SDK.Lib.MAction<SDK.Lib.IDispatchObject>), func) as SDK.Lib.MAction<SDK.Lib.IDispatchObject>;
				}

				SDK.Lib.MAction<SDK.Lib.IDispatchObject> arg2 = null;
				LuaTypes funcType4 = LuaDLL.lua_type(L, 4);

				if (funcType4 != LuaTypes.LUA_TFUNCTION)
				{
					 arg2 = (SDK.Lib.MAction<SDK.Lib.IDispatchObject>)ToLua.ToObject(L, 4);
				}
				else
				{
					LuaFunction func = ToLua.ToLuaFunction(L, 4);
					arg2 = DelegateFactory.CreateDelegate(typeof(SDK.Lib.MAction<SDK.Lib.IDispatchObject>), func) as SDK.Lib.MAction<SDK.Lib.IDispatchObject>;
				}

				obj.asyncLoad(arg0, arg1, arg2);
				return 0;
			}
			else if (count == 5 && TypeChecker.CheckTypes(L, 1, typeof(SDK.Lib.AuxBytesLoader), typeof(string), typeof(LuaInterface.LuaTable), typeof(LuaInterface.LuaFunction), typeof(LuaInterface.LuaFunction)))
			{
				SDK.Lib.AuxBytesLoader obj = (SDK.Lib.AuxBytesLoader)ToLua.ToObject(L, 1);
				string arg0 = ToLua.ToString(L, 2);
				LuaTable arg1 = ToLua.ToLuaTable(L, 3);
				LuaFunction arg2 = ToLua.ToLuaFunction(L, 4);
				LuaFunction arg3 = ToLua.ToLuaFunction(L, 5);
				obj.asyncLoad(arg0, arg1, arg2, arg3);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: SDK.Lib.AuxBytesLoader.asyncLoad");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int onBytesLoaded(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			SDK.Lib.AuxBytesLoader obj = (SDK.Lib.AuxBytesLoader)ToLua.CheckObject(L, 1, typeof(SDK.Lib.AuxBytesLoader));
			SDK.Lib.IDispatchObject arg0 = (SDK.Lib.IDispatchObject)ToLua.CheckObject(L, 2, typeof(SDK.Lib.IDispatchObject));
			obj.onBytesLoaded(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int unload(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			SDK.Lib.AuxBytesLoader obj = (SDK.Lib.AuxBytesLoader)ToLua.CheckObject(L, 1, typeof(SDK.Lib.AuxBytesLoader));
			obj.unload();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}
