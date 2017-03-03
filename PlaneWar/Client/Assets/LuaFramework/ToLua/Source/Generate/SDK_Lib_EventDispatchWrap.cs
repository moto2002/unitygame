﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class SDK_Lib_EventDispatchWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(SDK.Lib.EventDispatch), typeof(SDK.Lib.DelayHandleMgrBase));
		L.RegFunction("init", init);
		L.RegFunction("dispose", dispose);
		L.RegFunction("addDispatch", addDispatch);
		L.RegFunction("removeDispatch", removeDispatch);
		L.RegFunction("addEventHandle", addEventHandle);
		L.RegFunction("removeEventHandle", removeEventHandle);
		L.RegFunction("dispatchEvent", dispatchEvent);
		L.RegFunction("clearEventHandle", clearEventHandle);
		L.RegFunction("isExistEventHandle", isExistEventHandle);
		L.RegFunction("copyFrom", copyFrom);
		L.RegFunction("hasEventHandle", hasEventHandle);
		L.RegFunction("getEventHandle", getEventHandle);
		L.RegFunction("New", _CreateSDK_Lib_EventDispatch);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("uniqueId", get_uniqueId, set_uniqueId);
		L.RegVar("luaCSBridgeDispatch", get_luaCSBridgeDispatch, set_luaCSBridgeDispatch);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateSDK_Lib_EventDispatch(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				int arg0 = (int)LuaDLL.luaL_checknumber(L, 1);
				SDK.Lib.EventDispatch obj = new SDK.Lib.EventDispatch(arg0);
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: SDK.Lib.EventDispatch.New");
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
			SDK.Lib.EventDispatch obj = (SDK.Lib.EventDispatch)ToLua.CheckObject(L, 1, typeof(SDK.Lib.EventDispatch));
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
			SDK.Lib.EventDispatch obj = (SDK.Lib.EventDispatch)ToLua.CheckObject(L, 1, typeof(SDK.Lib.EventDispatch));
			obj.dispose();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int addDispatch(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			SDK.Lib.EventDispatch obj = (SDK.Lib.EventDispatch)ToLua.CheckObject(L, 1, typeof(SDK.Lib.EventDispatch));
			SDK.Lib.EventDispatchFunctionObject arg0 = (SDK.Lib.EventDispatchFunctionObject)ToLua.CheckObject(L, 2, typeof(SDK.Lib.EventDispatchFunctionObject));
			obj.addDispatch(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int removeDispatch(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			SDK.Lib.EventDispatch obj = (SDK.Lib.EventDispatch)ToLua.CheckObject(L, 1, typeof(SDK.Lib.EventDispatch));
			SDK.Lib.EventDispatchFunctionObject arg0 = (SDK.Lib.EventDispatchFunctionObject)ToLua.CheckObject(L, 2, typeof(SDK.Lib.EventDispatchFunctionObject));
			obj.removeDispatch(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int addEventHandle(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 7);
			SDK.Lib.EventDispatch obj = (SDK.Lib.EventDispatch)ToLua.CheckObject(L, 1, typeof(SDK.Lib.EventDispatch));
			SDK.Lib.ICalleeObject arg0 = (SDK.Lib.ICalleeObject)ToLua.CheckObject(L, 2, typeof(SDK.Lib.ICalleeObject));
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

			uint arg2 = (uint)LuaDLL.luaL_checknumber(L, 4);
			LuaTable arg3 = ToLua.CheckLuaTable(L, 5);
			LuaFunction arg4 = ToLua.CheckLuaFunction(L, 6);
			uint arg5 = (uint)LuaDLL.luaL_checknumber(L, 7);
			obj.addEventHandle(arg0, arg1, arg2, arg3, arg4, arg5);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int removeEventHandle(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 7);
			SDK.Lib.EventDispatch obj = (SDK.Lib.EventDispatch)ToLua.CheckObject(L, 1, typeof(SDK.Lib.EventDispatch));
			SDK.Lib.ICalleeObject arg0 = (SDK.Lib.ICalleeObject)ToLua.CheckObject(L, 2, typeof(SDK.Lib.ICalleeObject));
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

			uint arg2 = (uint)LuaDLL.luaL_checknumber(L, 4);
			LuaTable arg3 = ToLua.CheckLuaTable(L, 5);
			LuaFunction arg4 = ToLua.CheckLuaFunction(L, 6);
			uint arg5 = (uint)LuaDLL.luaL_checknumber(L, 7);
			obj.removeEventHandle(arg0, arg1, arg2, arg3, arg4, arg5);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int dispatchEvent(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			SDK.Lib.EventDispatch obj = (SDK.Lib.EventDispatch)ToLua.CheckObject(L, 1, typeof(SDK.Lib.EventDispatch));
			SDK.Lib.IDispatchObject arg0 = (SDK.Lib.IDispatchObject)ToLua.CheckObject(L, 2, typeof(SDK.Lib.IDispatchObject));
			obj.dispatchEvent(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int clearEventHandle(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			SDK.Lib.EventDispatch obj = (SDK.Lib.EventDispatch)ToLua.CheckObject(L, 1, typeof(SDK.Lib.EventDispatch));
			obj.clearEventHandle();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int isExistEventHandle(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 7);
			SDK.Lib.EventDispatch obj = (SDK.Lib.EventDispatch)ToLua.CheckObject(L, 1, typeof(SDK.Lib.EventDispatch));
			SDK.Lib.ICalleeObject arg0 = (SDK.Lib.ICalleeObject)ToLua.CheckObject(L, 2, typeof(SDK.Lib.ICalleeObject));
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

			uint arg2 = (uint)LuaDLL.luaL_checknumber(L, 4);
			LuaTable arg3 = ToLua.CheckLuaTable(L, 5);
			LuaFunction arg4 = ToLua.CheckLuaFunction(L, 6);
			uint arg5 = (uint)LuaDLL.luaL_checknumber(L, 7);
			bool o = obj.isExistEventHandle(arg0, arg1, arg2, arg3, arg4, arg5);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int copyFrom(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			SDK.Lib.EventDispatch obj = (SDK.Lib.EventDispatch)ToLua.CheckObject(L, 1, typeof(SDK.Lib.EventDispatch));
			SDK.Lib.EventDispatch arg0 = (SDK.Lib.EventDispatch)ToLua.CheckObject(L, 2, typeof(SDK.Lib.EventDispatch));
			obj.copyFrom(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int hasEventHandle(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			SDK.Lib.EventDispatch obj = (SDK.Lib.EventDispatch)ToLua.CheckObject(L, 1, typeof(SDK.Lib.EventDispatch));
			bool o = obj.hasEventHandle();
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int getEventHandle(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			SDK.Lib.EventDispatch obj = (SDK.Lib.EventDispatch)ToLua.CheckObject(L, 1, typeof(SDK.Lib.EventDispatch));
			int o = obj.getEventHandle();
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_uniqueId(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SDK.Lib.EventDispatch obj = (SDK.Lib.EventDispatch)o;
			int ret = obj.uniqueId;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index uniqueId on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_luaCSBridgeDispatch(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SDK.Lib.EventDispatch obj = (SDK.Lib.EventDispatch)o;
			SDK.Lib.LuaCSBridgeDispatch ret = obj.luaCSBridgeDispatch;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index luaCSBridgeDispatch on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_uniqueId(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SDK.Lib.EventDispatch obj = (SDK.Lib.EventDispatch)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.uniqueId = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index uniqueId on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_luaCSBridgeDispatch(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SDK.Lib.EventDispatch obj = (SDK.Lib.EventDispatch)o;
			SDK.Lib.LuaCSBridgeDispatch arg0 = (SDK.Lib.LuaCSBridgeDispatch)ToLua.CheckObject(L, 2, typeof(SDK.Lib.LuaCSBridgeDispatch));
			obj.luaCSBridgeDispatch = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index luaCSBridgeDispatch on a nil value" : e.Message);
		}
	}
}

