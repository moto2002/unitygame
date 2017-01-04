﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class Game_Login_LoginNetHandleCB_KBEWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(Game.Login.LoginNetHandleCB_KBE), typeof(System.Object));
		L.RegFunction("setAccountAndPasswd", setAccountAndPasswd);
		L.RegFunction("init", init);
		L.RegFunction("dispose", dispose);
		L.RegFunction("err", err);
		L.RegFunction("info", info);
		L.RegFunction("login", login);
		L.RegFunction("relogin", relogin);
		L.RegFunction("createAccount", createAccount);
		L.RegFunction("onCreateAccountResult", onCreateAccountResult);
		L.RegFunction("onConnectStatus", onConnectStatus);
		L.RegFunction("onLoginFailed", onLoginFailed);
		L.RegFunction("onVersionNotMatch", onVersionNotMatch);
		L.RegFunction("onScriptVersionNotMatch", onScriptVersionNotMatch);
		L.RegFunction("onLoginBaseappFailed", onLoginBaseappFailed);
		L.RegFunction("onLoginBaseapp", onLoginBaseapp);
		L.RegFunction("onLoginSuccessfully", onLoginSuccessfully);
		L.RegFunction("onKicked", onKicked);
		L.RegFunction("Loginapp_importClientMessages", Loginapp_importClientMessages);
		L.RegFunction("Baseapp_importClientMessages", Baseapp_importClientMessages);
		L.RegFunction("Baseapp_importClientEntityDef", Baseapp_importClientEntityDef);
		L.RegFunction("onReqAvatarList", onReqAvatarList);
		L.RegFunction("onCreateAvatarResult", onCreateAvatarResult);
		L.RegFunction("onRemoveAvatar", onRemoveAvatar);
		L.RegFunction("onDisableConnect", onDisableConnect);
		L.RegFunction("New", _CreateGame_Login_LoginNetHandleCB_KBE);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("ui_state", get_ui_state, set_ui_state);
		L.RegVar("showReliveGUI", get_showReliveGUI, set_showReliveGUI);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateGame_Login_LoginNetHandleCB_KBE(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				Game.Login.LoginNetHandleCB_KBE obj = new Game.Login.LoginNetHandleCB_KBE();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: Game.Login.LoginNetHandleCB_KBE.New");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int setAccountAndPasswd(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			Game.Login.LoginNetHandleCB_KBE obj = (Game.Login.LoginNetHandleCB_KBE)ToLua.CheckObject(L, 1, typeof(Game.Login.LoginNetHandleCB_KBE));
			string arg0 = ToLua.CheckString(L, 2);
			string arg1 = ToLua.CheckString(L, 3);
			obj.setAccountAndPasswd(arg0, arg1);
			return 0;
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
			Game.Login.LoginNetHandleCB_KBE obj = (Game.Login.LoginNetHandleCB_KBE)ToLua.CheckObject(L, 1, typeof(Game.Login.LoginNetHandleCB_KBE));
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
			Game.Login.LoginNetHandleCB_KBE obj = (Game.Login.LoginNetHandleCB_KBE)ToLua.CheckObject(L, 1, typeof(Game.Login.LoginNetHandleCB_KBE));
			obj.dispose();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int err(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Game.Login.LoginNetHandleCB_KBE obj = (Game.Login.LoginNetHandleCB_KBE)ToLua.CheckObject(L, 1, typeof(Game.Login.LoginNetHandleCB_KBE));
			string arg0 = ToLua.CheckString(L, 2);
			obj.err(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int info(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Game.Login.LoginNetHandleCB_KBE obj = (Game.Login.LoginNetHandleCB_KBE)ToLua.CheckObject(L, 1, typeof(Game.Login.LoginNetHandleCB_KBE));
			string arg0 = ToLua.CheckString(L, 2);
			obj.info(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int login(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			Game.Login.LoginNetHandleCB_KBE obj = (Game.Login.LoginNetHandleCB_KBE)ToLua.CheckObject(L, 1, typeof(Game.Login.LoginNetHandleCB_KBE));
			obj.login();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int relogin(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			Game.Login.LoginNetHandleCB_KBE obj = (Game.Login.LoginNetHandleCB_KBE)ToLua.CheckObject(L, 1, typeof(Game.Login.LoginNetHandleCB_KBE));
			obj.relogin();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int createAccount(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			Game.Login.LoginNetHandleCB_KBE obj = (Game.Login.LoginNetHandleCB_KBE)ToLua.CheckObject(L, 1, typeof(Game.Login.LoginNetHandleCB_KBE));
			obj.createAccount();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int onCreateAccountResult(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			Game.Login.LoginNetHandleCB_KBE obj = (Game.Login.LoginNetHandleCB_KBE)ToLua.CheckObject(L, 1, typeof(Game.Login.LoginNetHandleCB_KBE));
			ushort arg0 = (ushort)LuaDLL.luaL_checknumber(L, 2);
			byte[] arg1 = ToLua.CheckByteBuffer(L, 3);
			obj.onCreateAccountResult(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int onConnectStatus(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Game.Login.LoginNetHandleCB_KBE obj = (Game.Login.LoginNetHandleCB_KBE)ToLua.CheckObject(L, 1, typeof(Game.Login.LoginNetHandleCB_KBE));
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.onConnectStatus(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int onLoginFailed(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Game.Login.LoginNetHandleCB_KBE obj = (Game.Login.LoginNetHandleCB_KBE)ToLua.CheckObject(L, 1, typeof(Game.Login.LoginNetHandleCB_KBE));
			ushort arg0 = (ushort)LuaDLL.luaL_checknumber(L, 2);
			obj.onLoginFailed(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int onVersionNotMatch(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			Game.Login.LoginNetHandleCB_KBE obj = (Game.Login.LoginNetHandleCB_KBE)ToLua.CheckObject(L, 1, typeof(Game.Login.LoginNetHandleCB_KBE));
			string arg0 = ToLua.CheckString(L, 2);
			string arg1 = ToLua.CheckString(L, 3);
			obj.onVersionNotMatch(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int onScriptVersionNotMatch(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			Game.Login.LoginNetHandleCB_KBE obj = (Game.Login.LoginNetHandleCB_KBE)ToLua.CheckObject(L, 1, typeof(Game.Login.LoginNetHandleCB_KBE));
			string arg0 = ToLua.CheckString(L, 2);
			string arg1 = ToLua.CheckString(L, 3);
			obj.onScriptVersionNotMatch(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int onLoginBaseappFailed(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Game.Login.LoginNetHandleCB_KBE obj = (Game.Login.LoginNetHandleCB_KBE)ToLua.CheckObject(L, 1, typeof(Game.Login.LoginNetHandleCB_KBE));
			ushort arg0 = (ushort)LuaDLL.luaL_checknumber(L, 2);
			obj.onLoginBaseappFailed(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int onLoginBaseapp(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			Game.Login.LoginNetHandleCB_KBE obj = (Game.Login.LoginNetHandleCB_KBE)ToLua.CheckObject(L, 1, typeof(Game.Login.LoginNetHandleCB_KBE));
			obj.onLoginBaseapp();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int onLoginSuccessfully(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 4);
			Game.Login.LoginNetHandleCB_KBE obj = (Game.Login.LoginNetHandleCB_KBE)ToLua.CheckObject(L, 1, typeof(Game.Login.LoginNetHandleCB_KBE));
			ulong arg0 = LuaDLL.tolua_checkuint64(L, 2);
			int arg1 = (int)LuaDLL.luaL_checknumber(L, 3);
			KBEngine.Account arg2 = (KBEngine.Account)ToLua.CheckObject(L, 4, typeof(KBEngine.Account));
			obj.onLoginSuccessfully(arg0, arg1, arg2);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int onKicked(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Game.Login.LoginNetHandleCB_KBE obj = (Game.Login.LoginNetHandleCB_KBE)ToLua.CheckObject(L, 1, typeof(Game.Login.LoginNetHandleCB_KBE));
			ushort arg0 = (ushort)LuaDLL.luaL_checknumber(L, 2);
			obj.onKicked(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Loginapp_importClientMessages(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			Game.Login.LoginNetHandleCB_KBE obj = (Game.Login.LoginNetHandleCB_KBE)ToLua.CheckObject(L, 1, typeof(Game.Login.LoginNetHandleCB_KBE));
			obj.Loginapp_importClientMessages();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Baseapp_importClientMessages(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			Game.Login.LoginNetHandleCB_KBE obj = (Game.Login.LoginNetHandleCB_KBE)ToLua.CheckObject(L, 1, typeof(Game.Login.LoginNetHandleCB_KBE));
			obj.Baseapp_importClientMessages();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Baseapp_importClientEntityDef(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			Game.Login.LoginNetHandleCB_KBE obj = (Game.Login.LoginNetHandleCB_KBE)ToLua.CheckObject(L, 1, typeof(Game.Login.LoginNetHandleCB_KBE));
			obj.Baseapp_importClientEntityDef();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int onReqAvatarList(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Game.Login.LoginNetHandleCB_KBE obj = (Game.Login.LoginNetHandleCB_KBE)ToLua.CheckObject(L, 1, typeof(Game.Login.LoginNetHandleCB_KBE));
			System.Collections.Generic.Dictionary<ulong,System.Collections.Generic.Dictionary<string,object>> arg0 = (System.Collections.Generic.Dictionary<ulong,System.Collections.Generic.Dictionary<string,object>>)ToLua.CheckObject(L, 2, typeof(System.Collections.Generic.Dictionary<ulong,System.Collections.Generic.Dictionary<string,object>>));
			obj.onReqAvatarList(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int onCreateAvatarResult(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 4);
			Game.Login.LoginNetHandleCB_KBE obj = (Game.Login.LoginNetHandleCB_KBE)ToLua.CheckObject(L, 1, typeof(Game.Login.LoginNetHandleCB_KBE));
			byte arg0 = (byte)LuaDLL.luaL_checknumber(L, 2);
			object arg1 = ToLua.ToVarObject(L, 3);
			System.Collections.Generic.Dictionary<ulong,System.Collections.Generic.Dictionary<string,object>> arg2 = (System.Collections.Generic.Dictionary<ulong,System.Collections.Generic.Dictionary<string,object>>)ToLua.CheckObject(L, 4, typeof(System.Collections.Generic.Dictionary<ulong,System.Collections.Generic.Dictionary<string,object>>));
			obj.onCreateAvatarResult(arg0, arg1, arg2);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int onRemoveAvatar(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			Game.Login.LoginNetHandleCB_KBE obj = (Game.Login.LoginNetHandleCB_KBE)ToLua.CheckObject(L, 1, typeof(Game.Login.LoginNetHandleCB_KBE));
			ulong arg0 = LuaDLL.tolua_checkuint64(L, 2);
			System.Collections.Generic.Dictionary<ulong,System.Collections.Generic.Dictionary<string,object>> arg1 = (System.Collections.Generic.Dictionary<ulong,System.Collections.Generic.Dictionary<string,object>>)ToLua.CheckObject(L, 3, typeof(System.Collections.Generic.Dictionary<ulong,System.Collections.Generic.Dictionary<string,object>>));
			obj.onRemoveAvatar(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int onDisableConnect(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			Game.Login.LoginNetHandleCB_KBE obj = (Game.Login.LoginNetHandleCB_KBE)ToLua.CheckObject(L, 1, typeof(Game.Login.LoginNetHandleCB_KBE));
			obj.onDisableConnect();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_ui_state(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Game.Login.LoginNetHandleCB_KBE obj = (Game.Login.LoginNetHandleCB_KBE)o;
			int ret = obj.ui_state;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index ui_state on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_showReliveGUI(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Game.Login.LoginNetHandleCB_KBE obj = (Game.Login.LoginNetHandleCB_KBE)o;
			bool ret = obj.showReliveGUI;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index showReliveGUI on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_ui_state(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Game.Login.LoginNetHandleCB_KBE obj = (Game.Login.LoginNetHandleCB_KBE)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.ui_state = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index ui_state on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_showReliveGUI(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Game.Login.LoginNetHandleCB_KBE obj = (Game.Login.LoginNetHandleCB_KBE)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.showReliveGUI = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index showReliveGUI on a nil value" : e.Message);
		}
	}
}
