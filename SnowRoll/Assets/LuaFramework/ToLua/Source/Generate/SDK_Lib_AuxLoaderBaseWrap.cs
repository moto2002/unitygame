﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class SDK_Lib_AuxLoaderBaseWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(SDK.Lib.AuxLoaderBase), typeof(SDK.Lib.GObject));
		L.RegFunction("dispose", dispose);
		L.RegFunction("hasSuccessLoaded", hasSuccessLoaded);
		L.RegFunction("hasFailed", hasFailed);
		L.RegFunction("hasLoadEnd", hasLoadEnd);
		L.RegFunction("needUnload", needUnload);
		L.RegFunction("setPath", setPath);
		L.RegFunction("updatePath", updatePath);
		L.RegFunction("isInvalid", isInvalid);
		L.RegFunction("getLogicPath", getLogicPath);
		L.RegFunction("syncLoad", syncLoad);
		L.RegFunction("asyncLoad", asyncLoad);
		L.RegFunction("download", download);
		L.RegFunction("unload", unload);
		L.RegFunction("onProgressEventHandle", onProgressEventHandle);
		L.RegFunction("New", _CreateSDK_Lib_AuxLoaderBase);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateSDK_Lib_AuxLoaderBase(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				string arg0 = ToLua.CheckString(L, 1);
				SDK.Lib.AuxLoaderBase obj = new SDK.Lib.AuxLoaderBase(arg0);
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: SDK.Lib.AuxLoaderBase.New");
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
			SDK.Lib.AuxLoaderBase obj = (SDK.Lib.AuxLoaderBase)ToLua.CheckObject(L, 1, typeof(SDK.Lib.AuxLoaderBase));
			obj.dispose();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int hasSuccessLoaded(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			SDK.Lib.AuxLoaderBase obj = (SDK.Lib.AuxLoaderBase)ToLua.CheckObject(L, 1, typeof(SDK.Lib.AuxLoaderBase));
			bool o = obj.hasSuccessLoaded();
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int hasFailed(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			SDK.Lib.AuxLoaderBase obj = (SDK.Lib.AuxLoaderBase)ToLua.CheckObject(L, 1, typeof(SDK.Lib.AuxLoaderBase));
			bool o = obj.hasFailed();
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int hasLoadEnd(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			SDK.Lib.AuxLoaderBase obj = (SDK.Lib.AuxLoaderBase)ToLua.CheckObject(L, 1, typeof(SDK.Lib.AuxLoaderBase));
			bool o = obj.hasLoadEnd();
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int needUnload(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			SDK.Lib.AuxLoaderBase obj = (SDK.Lib.AuxLoaderBase)ToLua.CheckObject(L, 1, typeof(SDK.Lib.AuxLoaderBase));
			string arg0 = ToLua.CheckString(L, 2);
			bool o = obj.needUnload(arg0);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int setPath(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			SDK.Lib.AuxLoaderBase obj = (SDK.Lib.AuxLoaderBase)ToLua.CheckObject(L, 1, typeof(SDK.Lib.AuxLoaderBase));
			string arg0 = ToLua.CheckString(L, 2);
			obj.setPath(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int updatePath(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			SDK.Lib.AuxLoaderBase obj = (SDK.Lib.AuxLoaderBase)ToLua.CheckObject(L, 1, typeof(SDK.Lib.AuxLoaderBase));
			string arg0 = ToLua.CheckString(L, 2);
			obj.updatePath(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int isInvalid(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			SDK.Lib.AuxLoaderBase obj = (SDK.Lib.AuxLoaderBase)ToLua.CheckObject(L, 1, typeof(SDK.Lib.AuxLoaderBase));
			bool o = obj.isInvalid();
			LuaDLL.lua_pushboolean(L, o);
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
			SDK.Lib.AuxLoaderBase obj = (SDK.Lib.AuxLoaderBase)ToLua.CheckObject(L, 1, typeof(SDK.Lib.AuxLoaderBase));
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

			if (count == 4 && TypeChecker.CheckTypes(L, 1, typeof(SDK.Lib.AuxLoaderBase), typeof(string), typeof(SDK.Lib.MAction<SDK.Lib.IDispatchObject>), typeof(SDK.Lib.MAction<SDK.Lib.IDispatchObject>)))
			{
				SDK.Lib.AuxLoaderBase obj = (SDK.Lib.AuxLoaderBase)ToLua.ToObject(L, 1);
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
			else if (count == 5 && TypeChecker.CheckTypes(L, 1, typeof(SDK.Lib.AuxLoaderBase), typeof(string), typeof(LuaInterface.LuaTable), typeof(LuaInterface.LuaFunction), typeof(LuaInterface.LuaFunction)))
			{
				SDK.Lib.AuxLoaderBase obj = (SDK.Lib.AuxLoaderBase)ToLua.ToObject(L, 1);
				string arg0 = ToLua.ToString(L, 2);
				LuaTable arg1 = ToLua.ToLuaTable(L, 3);
				LuaFunction arg2 = ToLua.ToLuaFunction(L, 4);
				LuaFunction arg3 = ToLua.ToLuaFunction(L, 5);
				obj.syncLoad(arg0, arg1, arg2, arg3);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: SDK.Lib.AuxLoaderBase.syncLoad");
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

			if (count == 4 && TypeChecker.CheckTypes(L, 1, typeof(SDK.Lib.AuxLoaderBase), typeof(string), typeof(SDK.Lib.MAction<SDK.Lib.IDispatchObject>), typeof(SDK.Lib.MAction<SDK.Lib.IDispatchObject>)))
			{
				SDK.Lib.AuxLoaderBase obj = (SDK.Lib.AuxLoaderBase)ToLua.ToObject(L, 1);
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
			else if (count == 5 && TypeChecker.CheckTypes(L, 1, typeof(SDK.Lib.AuxLoaderBase), typeof(string), typeof(LuaInterface.LuaTable), typeof(LuaInterface.LuaFunction), typeof(LuaInterface.LuaFunction)))
			{
				SDK.Lib.AuxLoaderBase obj = (SDK.Lib.AuxLoaderBase)ToLua.ToObject(L, 1);
				string arg0 = ToLua.ToString(L, 2);
				LuaTable arg1 = ToLua.ToLuaTable(L, 3);
				LuaFunction arg2 = ToLua.ToLuaFunction(L, 4);
				LuaFunction arg3 = ToLua.ToLuaFunction(L, 5);
				obj.asyncLoad(arg0, arg1, arg2, arg3);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: SDK.Lib.AuxLoaderBase.asyncLoad");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int download(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 6);
			SDK.Lib.AuxLoaderBase obj = (SDK.Lib.AuxLoaderBase)ToLua.CheckObject(L, 1, typeof(SDK.Lib.AuxLoaderBase));
			string arg0 = ToLua.CheckString(L, 2);
			SDK.Lib.MAction<SDK.Lib.IDispatchObject> arg1 = null;
			LuaTypes funcType3 = LuaDLL.lua_type(L, 3);

			if (funcType3 != LuaTypes.LUA_TFUNCTION)
			{
				 arg1 = (SDK.Lib.MAction<SDK.Lib.IDispatchObject>)ToLua.CheckObject(L, 3, typeof(SDK.Lib.MAction<SDK.Lib.IDispatchObject>));
			}
			else
			{
				LuaFunction func = ToLua.ToLuaFunction(L, 3);
				arg1 = DelegateFactory.CreateDelegate(typeof(SDK.Lib.MAction<SDK.Lib.IDispatchObject>), func) as SDK.Lib.MAction<SDK.Lib.IDispatchObject>;
			}

			long arg2 = LuaDLL.tolua_checkint64(L, 4);
			bool arg3 = LuaDLL.luaL_checkboolean(L, 5);
			int arg4 = (int)LuaDLL.luaL_checknumber(L, 6);
			obj.download(arg0, arg1, arg2, arg3, arg4);
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
			SDK.Lib.AuxLoaderBase obj = (SDK.Lib.AuxLoaderBase)ToLua.CheckObject(L, 1, typeof(SDK.Lib.AuxLoaderBase));
			obj.unload();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int onProgressEventHandle(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			SDK.Lib.AuxLoaderBase obj = (SDK.Lib.AuxLoaderBase)ToLua.CheckObject(L, 1, typeof(SDK.Lib.AuxLoaderBase));
			SDK.Lib.IDispatchObject arg0 = (SDK.Lib.IDispatchObject)ToLua.CheckObject(L, 2, typeof(SDK.Lib.IDispatchObject));
			obj.onProgressEventHandle(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}
