﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class SDK_Lib_MFileSysWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(SDK.Lib.MFileSys), typeof(System.Object));
		L.RegFunction("init", init);
		L.RegFunction("getLocalDataDir", getLocalDataDir);
		L.RegFunction("getLocalReadDir", getLocalReadDir);
		L.RegFunction("getLocalWriteDir", getLocalWriteDir);
		L.RegFunction("getWWWPersistentDataPath", getWWWPersistentDataPath);
		L.RegFunction("getAssetBundlesPersistentDataPath", getAssetBundlesPersistentDataPath);
		L.RegFunction("getDataStreamStreamingAssetsPath", getDataStreamStreamingAssetsPath);
		L.RegFunction("getDataStreamPersistentDataPath", getDataStreamPersistentDataPath);
		L.RegFunction("getWorkPath", getWorkPath);
		L.RegFunction("getDebugWorkPath", getDebugWorkPath);
		L.RegFunction("getAbsPathByRelPath", getAbsPathByRelPath);
		L.RegFunction("readFileAllBytes", readFileAllBytes);
		L.RegFunction("readLuaBufferToFile", readLuaBufferToFile);
		L.RegFunction("New", _CreateSDK_Lib_MFileSys);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("msStreamingAssetsPath", get_msStreamingAssetsPath, set_msStreamingAssetsPath);
		L.RegVar("msPersistentDataPath", get_msPersistentDataPath, set_msPersistentDataPath);
		L.RegVar("msWWWStreamingAssetsPath", get_msWWWStreamingAssetsPath, set_msWWWStreamingAssetsPath);
		L.RegVar("msAssetBundlesStreamingAssetsPath", get_msAssetBundlesStreamingAssetsPath, set_msAssetBundlesStreamingAssetsPath);
		L.RegVar("msWWWPersistentDataPath", get_msWWWPersistentDataPath, set_msWWWPersistentDataPath);
		L.RegVar("msAssetBundlesPersistentDataPath", get_msAssetBundlesPersistentDataPath, set_msAssetBundlesPersistentDataPath);
		L.RegVar("msDataStreamResourcesPath", get_msDataStreamResourcesPath, set_msDataStreamResourcesPath);
		L.RegVar("msDataStreamStreamingAssetsPath", get_msDataStreamStreamingAssetsPath, set_msDataStreamStreamingAssetsPath);
		L.RegVar("msDataStreamPersistentDataPath", get_msDataStreamPersistentDataPath, set_msDataStreamPersistentDataPath);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateSDK_Lib_MFileSys(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				SDK.Lib.MFileSys obj = new SDK.Lib.MFileSys();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: SDK.Lib.MFileSys.New");
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
			ToLua.CheckArgsCount(L, 0);
			SDK.Lib.MFileSys.init();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int getLocalDataDir(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			string o = SDK.Lib.MFileSys.getLocalDataDir();
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int getLocalReadDir(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			string o = SDK.Lib.MFileSys.getLocalReadDir();
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int getLocalWriteDir(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			string o = SDK.Lib.MFileSys.getLocalWriteDir();
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int getWWWPersistentDataPath(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			string o = SDK.Lib.MFileSys.getWWWPersistentDataPath();
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int getAssetBundlesPersistentDataPath(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			string o = SDK.Lib.MFileSys.getAssetBundlesPersistentDataPath();
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int getDataStreamStreamingAssetsPath(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			string o = SDK.Lib.MFileSys.getDataStreamStreamingAssetsPath();
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int getDataStreamPersistentDataPath(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			string o = SDK.Lib.MFileSys.getDataStreamPersistentDataPath();
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int getWorkPath(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			string o = SDK.Lib.MFileSys.getWorkPath();
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int getDebugWorkPath(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			string o = SDK.Lib.MFileSys.getDebugWorkPath();
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int getAbsPathByRelPath(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			string arg0 = ToLua.CheckString(L, 1);
			SDK.Lib.ResLoadType arg1 = (SDK.Lib.ResLoadType)ToLua.CheckObject(L, 2, typeof(SDK.Lib.ResLoadType));
			string o = SDK.Lib.MFileSys.getAbsPathByRelPath(ref arg0, ref arg1);
			LuaDLL.lua_pushstring(L, o);
			LuaDLL.lua_pushstring(L, arg0);
			ToLua.Push(L, arg1);
			return 3;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int readFileAllBytes(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			byte[] o = SDK.Lib.MFileSys.readFileAllBytes(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int readLuaBufferToFile(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			LuaInterface.LuaByteBuffer o = SDK.Lib.MFileSys.readLuaBufferToFile(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_msStreamingAssetsPath(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, SDK.Lib.MFileSys.msStreamingAssetsPath);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_msPersistentDataPath(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, SDK.Lib.MFileSys.msPersistentDataPath);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_msWWWStreamingAssetsPath(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, SDK.Lib.MFileSys.msWWWStreamingAssetsPath);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_msAssetBundlesStreamingAssetsPath(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, SDK.Lib.MFileSys.msAssetBundlesStreamingAssetsPath);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_msWWWPersistentDataPath(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, SDK.Lib.MFileSys.msWWWPersistentDataPath);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_msAssetBundlesPersistentDataPath(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, SDK.Lib.MFileSys.msAssetBundlesPersistentDataPath);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_msDataStreamResourcesPath(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, SDK.Lib.MFileSys.msDataStreamResourcesPath);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_msDataStreamStreamingAssetsPath(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, SDK.Lib.MFileSys.msDataStreamStreamingAssetsPath);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_msDataStreamPersistentDataPath(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, SDK.Lib.MFileSys.msDataStreamPersistentDataPath);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_msStreamingAssetsPath(IntPtr L)
	{
		try
		{
			string arg0 = ToLua.CheckString(L, 2);
			SDK.Lib.MFileSys.msStreamingAssetsPath = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_msPersistentDataPath(IntPtr L)
	{
		try
		{
			string arg0 = ToLua.CheckString(L, 2);
			SDK.Lib.MFileSys.msPersistentDataPath = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_msWWWStreamingAssetsPath(IntPtr L)
	{
		try
		{
			string arg0 = ToLua.CheckString(L, 2);
			SDK.Lib.MFileSys.msWWWStreamingAssetsPath = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_msAssetBundlesStreamingAssetsPath(IntPtr L)
	{
		try
		{
			string arg0 = ToLua.CheckString(L, 2);
			SDK.Lib.MFileSys.msAssetBundlesStreamingAssetsPath = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_msWWWPersistentDataPath(IntPtr L)
	{
		try
		{
			string arg0 = ToLua.CheckString(L, 2);
			SDK.Lib.MFileSys.msWWWPersistentDataPath = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_msAssetBundlesPersistentDataPath(IntPtr L)
	{
		try
		{
			string arg0 = ToLua.CheckString(L, 2);
			SDK.Lib.MFileSys.msAssetBundlesPersistentDataPath = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_msDataStreamResourcesPath(IntPtr L)
	{
		try
		{
			string arg0 = ToLua.CheckString(L, 2);
			SDK.Lib.MFileSys.msDataStreamResourcesPath = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_msDataStreamStreamingAssetsPath(IntPtr L)
	{
		try
		{
			string arg0 = ToLua.CheckString(L, 2);
			SDK.Lib.MFileSys.msDataStreamStreamingAssetsPath = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_msDataStreamPersistentDataPath(IntPtr L)
	{
		try
		{
			string arg0 = ToLua.CheckString(L, 2);
			SDK.Lib.MFileSys.msDataStreamPersistentDataPath = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}
