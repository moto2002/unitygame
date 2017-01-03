﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class SDK_Lib_LuaSystemWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(SDK.Lib.LuaSystem), typeof(System.Object));
		L.RegFunction("init", init);
		L.RegFunction("getLuaScriptMgr", getLuaScriptMgr);
		L.RegFunction("getLuaClassLoader", getLuaClassLoader);
		L.RegFunction("setNeedUpdate", setNeedUpdate);
		L.RegFunction("callLuaFunction", callLuaFunction);
		L.RegFunction("getLuaTable", getLuaTable);
		L.RegFunction("getLuaMember", getLuaMember);
		L.RegFunction("doFile", doFile);
		L.RegFunction("doString", doString);
		L.RegFunction("requireFile", requireFile);
		L.RegFunction("sendFromLua", sendFromLua);
		L.RegFunction("sendFromLuaRpc", sendFromLuaRpc);
		L.RegFunction("receiveToLua", receiveToLua);
		L.RegFunction("receiveToLuaRpc", receiveToLuaRpc);
		L.RegFunction("onSceneLoaded", onSceneLoaded);
		L.RegFunction("onPlayerMainLoaded", onPlayerMainLoaded);
		L.RegFunction("onSocketConnected", onSocketConnected);
		L.RegFunction("loadModule", loadModule);
		L.RegFunction("malloc", malloc);
		L.RegFunction("advance", advance);
		L.RegFunction("openForm", openForm);
		L.RegFunction("exitForm", exitForm);
		L.RegFunction("addClick", addClick);
		L.RegFunction("getTable2StrArray", getTable2StrArray);
		L.RegFunction("getTable2IntArray", getTable2IntArray);
		L.RegFunction("isSystemAttr", isSystemAttr);
		L.RegFunction("push", push);
		L.RegFunction("readFile", readFile);
		L.RegFunction("receiveToLua_KBE", receiveToLua_KBE);
		L.RegFunction("New", _CreateSDK_Lib_LuaSystem);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("lua", get_lua, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateSDK_Lib_LuaSystem(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				SDK.Lib.LuaSystem obj = new SDK.Lib.LuaSystem();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: SDK.Lib.LuaSystem.New");
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
			SDK.Lib.LuaSystem obj = (SDK.Lib.LuaSystem)ToLua.CheckObject(L, 1, typeof(SDK.Lib.LuaSystem));
			obj.init();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int getLuaScriptMgr(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			SDK.Lib.LuaSystem obj = (SDK.Lib.LuaSystem)ToLua.CheckObject(L, 1, typeof(SDK.Lib.LuaSystem));
			SDK.Lib.LuaScriptMgr o = obj.getLuaScriptMgr();
			ToLua.PushObject(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int getLuaClassLoader(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			SDK.Lib.LuaSystem obj = (SDK.Lib.LuaSystem)ToLua.CheckObject(L, 1, typeof(SDK.Lib.LuaSystem));
			SDK.Lib.LuaCSBridgeClassLoader o = obj.getLuaClassLoader();
			ToLua.PushObject(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int setNeedUpdate(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			SDK.Lib.LuaSystem obj = (SDK.Lib.LuaSystem)ToLua.CheckObject(L, 1, typeof(SDK.Lib.LuaSystem));
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.setNeedUpdate(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int callLuaFunction(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			SDK.Lib.LuaSystem obj = (SDK.Lib.LuaSystem)ToLua.CheckObject(L, 1, typeof(SDK.Lib.LuaSystem));
			string arg0 = ToLua.CheckString(L, 2);
			object[] arg1 = ToLua.ToParamsObject(L, 3, count - 2);
			object[] o = obj.callLuaFunction(arg0, arg1);
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int getLuaTable(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			SDK.Lib.LuaSystem obj = (SDK.Lib.LuaSystem)ToLua.CheckObject(L, 1, typeof(SDK.Lib.LuaSystem));
			string arg0 = ToLua.CheckString(L, 2);
			LuaInterface.LuaTable o = obj.getLuaTable(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int getLuaMember(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			SDK.Lib.LuaSystem obj = (SDK.Lib.LuaSystem)ToLua.CheckObject(L, 1, typeof(SDK.Lib.LuaSystem));
			string arg0 = ToLua.CheckString(L, 2);
			object o = obj.getLuaMember(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int doFile(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			SDK.Lib.LuaSystem obj = (SDK.Lib.LuaSystem)ToLua.CheckObject(L, 1, typeof(SDK.Lib.LuaSystem));
			string arg0 = ToLua.CheckString(L, 2);
			object[] o = obj.doFile(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int doString(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			SDK.Lib.LuaSystem obj = (SDK.Lib.LuaSystem)ToLua.CheckObject(L, 1, typeof(SDK.Lib.LuaSystem));
			string arg0 = ToLua.CheckString(L, 2);
			object[] o = obj.doString(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int requireFile(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			SDK.Lib.LuaSystem obj = (SDK.Lib.LuaSystem)ToLua.CheckObject(L, 1, typeof(SDK.Lib.LuaSystem));
			string arg0 = ToLua.CheckString(L, 2);
			object[] o = obj.requireFile(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int sendFromLua(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			SDK.Lib.LuaSystem obj = (SDK.Lib.LuaSystem)ToLua.CheckObject(L, 1, typeof(SDK.Lib.LuaSystem));
			ushort arg0 = (ushort)LuaDLL.luaL_checknumber(L, 2);
			LuaByteBuffer arg1 = new LuaByteBuffer(ToLua.CheckByteBuffer(L, 3));
			obj.sendFromLua(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int sendFromLuaRpc(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			SDK.Lib.LuaSystem obj = (SDK.Lib.LuaSystem)ToLua.CheckObject(L, 1, typeof(SDK.Lib.LuaSystem));
			LuaByteBuffer arg0 = new LuaByteBuffer(ToLua.CheckByteBuffer(L, 2));
			obj.sendFromLuaRpc(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int receiveToLua(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(SDK.Lib.LuaSystem), typeof(byte[])))
			{
				SDK.Lib.LuaSystem obj = (SDK.Lib.LuaSystem)ToLua.ToObject(L, 1);
				byte[] arg0 = ToLua.CheckByteBuffer(L, 2);
				obj.receiveToLua(arg0);
				return 0;
			}
			else if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(SDK.Lib.LuaSystem), typeof(SDK.Lib.ByteBuffer)))
			{
				SDK.Lib.LuaSystem obj = (SDK.Lib.LuaSystem)ToLua.ToObject(L, 1);
				SDK.Lib.ByteBuffer arg0 = (SDK.Lib.ByteBuffer)ToLua.ToObject(L, 2);
				obj.receiveToLua(arg0);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: SDK.Lib.LuaSystem.receiveToLua");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int receiveToLuaRpc(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			SDK.Lib.LuaSystem obj = (SDK.Lib.LuaSystem)ToLua.CheckObject(L, 1, typeof(SDK.Lib.LuaSystem));
			SDK.Lib.ByteBuffer arg0 = (SDK.Lib.ByteBuffer)ToLua.CheckObject(L, 2, typeof(SDK.Lib.ByteBuffer));
			obj.receiveToLuaRpc(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int onSceneLoaded(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			SDK.Lib.LuaSystem obj = (SDK.Lib.LuaSystem)ToLua.CheckObject(L, 1, typeof(SDK.Lib.LuaSystem));
			obj.onSceneLoaded();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int onPlayerMainLoaded(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			SDK.Lib.LuaSystem obj = (SDK.Lib.LuaSystem)ToLua.CheckObject(L, 1, typeof(SDK.Lib.LuaSystem));
			obj.onPlayerMainLoaded();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int onSocketConnected(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			SDK.Lib.LuaSystem obj = (SDK.Lib.LuaSystem)ToLua.CheckObject(L, 1, typeof(SDK.Lib.LuaSystem));
			obj.onSocketConnected();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int loadModule(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			SDK.Lib.LuaSystem obj = (SDK.Lib.LuaSystem)ToLua.CheckObject(L, 1, typeof(SDK.Lib.LuaSystem));
			string arg0 = ToLua.CheckString(L, 2);
			LuaInterface.LuaTable o = obj.loadModule(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int malloc(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			SDK.Lib.LuaSystem obj = (SDK.Lib.LuaSystem)ToLua.CheckObject(L, 1, typeof(SDK.Lib.LuaSystem));
			LuaTable arg0 = ToLua.CheckLuaTable(L, 2);
			LuaInterface.LuaTable o = obj.malloc(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int advance(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			SDK.Lib.LuaSystem obj = (SDK.Lib.LuaSystem)ToLua.CheckObject(L, 1, typeof(SDK.Lib.LuaSystem));
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.advance(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int openForm(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			SDK.Lib.LuaSystem obj = (SDK.Lib.LuaSystem)ToLua.CheckObject(L, 1, typeof(SDK.Lib.LuaSystem));
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.openForm(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int exitForm(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			SDK.Lib.LuaSystem obj = (SDK.Lib.LuaSystem)ToLua.CheckObject(L, 1, typeof(SDK.Lib.LuaSystem));
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.exitForm(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int addClick(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			SDK.Lib.LuaSystem obj = (SDK.Lib.LuaSystem)ToLua.CheckObject(L, 1, typeof(SDK.Lib.LuaSystem));
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckUnityObject(L, 2, typeof(UnityEngine.GameObject));
			LuaFunction arg1 = ToLua.CheckLuaFunction(L, 3);
			obj.addClick(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int getTable2StrArray(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			SDK.Lib.LuaSystem obj = (SDK.Lib.LuaSystem)ToLua.CheckObject(L, 1, typeof(SDK.Lib.LuaSystem));
			string arg0 = ToLua.CheckString(L, 2);
			string arg1 = ToLua.CheckString(L, 3);
			string[] o = obj.getTable2StrArray(arg0, arg1);
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int getTable2IntArray(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			SDK.Lib.LuaSystem obj = (SDK.Lib.LuaSystem)ToLua.CheckObject(L, 1, typeof(SDK.Lib.LuaSystem));
			string arg0 = ToLua.CheckString(L, 2);
			string arg1 = ToLua.CheckString(L, 3);
			int[] o = obj.getTable2IntArray(arg0, arg1);
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int isSystemAttr(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			SDK.Lib.LuaSystem obj = (SDK.Lib.LuaSystem)ToLua.CheckObject(L, 1, typeof(SDK.Lib.LuaSystem));
			string arg0 = ToLua.CheckString(L, 2);
			bool o = obj.isSystemAttr(arg0);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int push(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			System.IntPtr arg0 = (System.IntPtr)LuaDLL.lua_touserdata(L, 1);
			SDK.Lib.MLuaStringBuffer arg1 = (SDK.Lib.MLuaStringBuffer)ToLua.CheckObject(L, 2, typeof(SDK.Lib.MLuaStringBuffer));
			SDK.Lib.LuaSystem.push(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int readFile(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			SDK.Lib.LuaSystem obj = (SDK.Lib.LuaSystem)ToLua.CheckObject(L, 1, typeof(SDK.Lib.LuaSystem));
			string arg0 = ToLua.CheckString(L, 2);
			byte[] o = obj.readFile(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int receiveToLua_KBE(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			SDK.Lib.LuaSystem obj = (SDK.Lib.LuaSystem)ToLua.CheckObject(L, 1, typeof(SDK.Lib.LuaSystem));
			string arg0 = ToLua.CheckString(L, 2);
			object[] arg1 = ToLua.CheckObjectArray(L, 3);
			obj.receiveToLua_KBE(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_lua(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SDK.Lib.LuaSystem obj = (SDK.Lib.LuaSystem)o;
			LuaInterface.LuaState ret = obj.lua;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index lua on a nil value" : e.Message);
		}
	}
}

