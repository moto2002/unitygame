﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class SDK_Lib_SnowBallCfgWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(SDK.Lib.SnowBallCfg), typeof(System.Object));
		L.RegFunction("init", init);
		L.RegFunction("dispose", dispose);
		L.RegFunction("isLessMaxNum", isLessMaxNum);
		L.RegFunction("isGreatEqualMaxNum", isGreatEqualMaxNum);
		L.RegFunction("New", _CreateSDK_Lib_SnowBallCfg);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("mXmlSnowBallCfg", get_mXmlSnowBallCfg, set_mXmlSnowBallCfg);
		L.RegVar("mCanAttackRate", get_mCanAttackRate, set_mCanAttackRate);
		L.RegVar("mInitSnowRadius", get_mInitSnowRadius, set_mInitSnowRadius);
		L.RegVar("mMassFactor", get_mMassFactor, set_mMassFactor);
		L.RegVar("mK", get_mK, set_mK);
		L.RegVar("mN", get_mN, set_mN);
		L.RegVar("mCanSplitFactor", get_mCanSplitFactor, set_mCanSplitFactor);
		L.RegVar("mMaxSnowNum", get_mMaxSnowNum, set_mMaxSnowNum);
		L.RegVar("mSplitRelStartPos", get_mSplitRelStartPos, set_mSplitRelStartPos);
		L.RegVar("mSplitRelDist", get_mSplitRelDist, set_mSplitRelDist);
		L.RegVar("mMergeContactTime", get_mMergeContactTime, set_mMergeContactTime);
		L.RegVar("mMergeCoolTime", get_mMergeCoolTime, set_mMergeCoolTime);
		L.RegVar("mEmitSnowMass", get_mEmitSnowMass, set_mEmitSnowMass);
		L.RegVar("mEmitSnowRadius", get_mEmitSnowRadius, set_mEmitSnowRadius);
		L.RegVar("mEmitRelStartPos", get_mEmitRelStartPos, set_mEmitRelStartPos);
		L.RegVar("mEmitRelDist", get_mEmitRelDist, set_mEmitRelDist);
		L.RegVar("mMoveSpeed_k", get_mMoveSpeed_k, set_mMoveSpeed_k);
		L.RegVar("mMoveSpeed_b", get_mMoveSpeed_b, set_mMoveSpeed_b);
		L.RegVar("mA", get_mA, set_mA);
		L.RegVar("mCameraDistance_Z", get_mCameraDistance_Z, set_mCameraDistance_Z);
		L.RegVar("mCameraChangeFactor_Z", get_mCameraChangeFactor_Z, set_mCameraChangeFactor_Z);
		L.RegVar("mLimitRadius", get_mLimitRadius, set_mLimitRadius);
		L.RegVar("mCameraDistance_Y", get_mCameraDistance_Y, set_mCameraDistance_Y);
		L.RegVar("mCameraChangeFactor_Y", get_mCameraChangeFactor_Y, set_mCameraChangeFactor_Y);
		L.RegConstant("msSeparateFactor", 8);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateSDK_Lib_SnowBallCfg(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				SDK.Lib.SnowBallCfg obj = new SDK.Lib.SnowBallCfg();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: SDK.Lib.SnowBallCfg.New");
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
			SDK.Lib.SnowBallCfg obj = (SDK.Lib.SnowBallCfg)ToLua.CheckObject(L, 1, typeof(SDK.Lib.SnowBallCfg));
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
			SDK.Lib.SnowBallCfg obj = (SDK.Lib.SnowBallCfg)ToLua.CheckObject(L, 1, typeof(SDK.Lib.SnowBallCfg));
			obj.dispose();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int isLessMaxNum(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			SDK.Lib.SnowBallCfg obj = (SDK.Lib.SnowBallCfg)ToLua.CheckObject(L, 1, typeof(SDK.Lib.SnowBallCfg));
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			bool o = obj.isLessMaxNum(arg0);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int isGreatEqualMaxNum(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			SDK.Lib.SnowBallCfg obj = (SDK.Lib.SnowBallCfg)ToLua.CheckObject(L, 1, typeof(SDK.Lib.SnowBallCfg));
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			bool o = obj.isGreatEqualMaxNum(arg0);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_mXmlSnowBallCfg(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SDK.Lib.SnowBallCfg obj = (SDK.Lib.SnowBallCfg)o;
			SDK.Lib.XmlSnowBallCfg ret = obj.mXmlSnowBallCfg;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index mXmlSnowBallCfg on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_mCanAttackRate(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SDK.Lib.SnowBallCfg obj = (SDK.Lib.SnowBallCfg)o;
			float ret = obj.mCanAttackRate;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index mCanAttackRate on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_mInitSnowRadius(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SDK.Lib.SnowBallCfg obj = (SDK.Lib.SnowBallCfg)o;
			float ret = obj.mInitSnowRadius;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index mInitSnowRadius on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_mMassFactor(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SDK.Lib.SnowBallCfg obj = (SDK.Lib.SnowBallCfg)o;
			float ret = obj.mMassFactor;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index mMassFactor on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_mK(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SDK.Lib.SnowBallCfg obj = (SDK.Lib.SnowBallCfg)o;
			float ret = obj.mK;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index mK on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_mN(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SDK.Lib.SnowBallCfg obj = (SDK.Lib.SnowBallCfg)o;
			float ret = obj.mN;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index mN on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_mCanSplitFactor(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SDK.Lib.SnowBallCfg obj = (SDK.Lib.SnowBallCfg)o;
			float ret = obj.mCanSplitFactor;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index mCanSplitFactor on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_mMaxSnowNum(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SDK.Lib.SnowBallCfg obj = (SDK.Lib.SnowBallCfg)o;
			int ret = obj.mMaxSnowNum;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index mMaxSnowNum on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_mSplitRelStartPos(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SDK.Lib.SnowBallCfg obj = (SDK.Lib.SnowBallCfg)o;
			float ret = obj.mSplitRelStartPos;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index mSplitRelStartPos on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_mSplitRelDist(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SDK.Lib.SnowBallCfg obj = (SDK.Lib.SnowBallCfg)o;
			float ret = obj.mSplitRelDist;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index mSplitRelDist on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_mMergeContactTime(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SDK.Lib.SnowBallCfg obj = (SDK.Lib.SnowBallCfg)o;
			float ret = obj.mMergeContactTime;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index mMergeContactTime on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_mMergeCoolTime(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SDK.Lib.SnowBallCfg obj = (SDK.Lib.SnowBallCfg)o;
			float ret = obj.mMergeCoolTime;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index mMergeCoolTime on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_mEmitSnowMass(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SDK.Lib.SnowBallCfg obj = (SDK.Lib.SnowBallCfg)o;
			float ret = obj.mEmitSnowMass;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index mEmitSnowMass on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_mEmitSnowRadius(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SDK.Lib.SnowBallCfg obj = (SDK.Lib.SnowBallCfg)o;
			float ret = obj.mEmitSnowRadius;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index mEmitSnowRadius on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_mEmitRelStartPos(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SDK.Lib.SnowBallCfg obj = (SDK.Lib.SnowBallCfg)o;
			float ret = obj.mEmitRelStartPos;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index mEmitRelStartPos on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_mEmitRelDist(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SDK.Lib.SnowBallCfg obj = (SDK.Lib.SnowBallCfg)o;
			float ret = obj.mEmitRelDist;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index mEmitRelDist on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_mMoveSpeed_k(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SDK.Lib.SnowBallCfg obj = (SDK.Lib.SnowBallCfg)o;
			float ret = obj.mMoveSpeed_k;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index mMoveSpeed_k on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_mMoveSpeed_b(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SDK.Lib.SnowBallCfg obj = (SDK.Lib.SnowBallCfg)o;
			float ret = obj.mMoveSpeed_b;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index mMoveSpeed_b on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_mA(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SDK.Lib.SnowBallCfg obj = (SDK.Lib.SnowBallCfg)o;
			float ret = obj.mA;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index mA on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_mCameraDistance_Z(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SDK.Lib.SnowBallCfg obj = (SDK.Lib.SnowBallCfg)o;
			float ret = obj.mCameraDistance_Z;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index mCameraDistance_Z on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_mCameraChangeFactor_Z(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SDK.Lib.SnowBallCfg obj = (SDK.Lib.SnowBallCfg)o;
			float ret = obj.mCameraChangeFactor_Z;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index mCameraChangeFactor_Z on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_mLimitRadius(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SDK.Lib.SnowBallCfg obj = (SDK.Lib.SnowBallCfg)o;
			float ret = obj.mLimitRadius;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index mLimitRadius on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_mCameraDistance_Y(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SDK.Lib.SnowBallCfg obj = (SDK.Lib.SnowBallCfg)o;
			float ret = obj.mCameraDistance_Y;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index mCameraDistance_Y on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_mCameraChangeFactor_Y(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SDK.Lib.SnowBallCfg obj = (SDK.Lib.SnowBallCfg)o;
			float ret = obj.mCameraChangeFactor_Y;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index mCameraChangeFactor_Y on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_mXmlSnowBallCfg(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SDK.Lib.SnowBallCfg obj = (SDK.Lib.SnowBallCfg)o;
			SDK.Lib.XmlSnowBallCfg arg0 = (SDK.Lib.XmlSnowBallCfg)ToLua.CheckObject(L, 2, typeof(SDK.Lib.XmlSnowBallCfg));
			obj.mXmlSnowBallCfg = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index mXmlSnowBallCfg on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_mCanAttackRate(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SDK.Lib.SnowBallCfg obj = (SDK.Lib.SnowBallCfg)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.mCanAttackRate = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index mCanAttackRate on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_mInitSnowRadius(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SDK.Lib.SnowBallCfg obj = (SDK.Lib.SnowBallCfg)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.mInitSnowRadius = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index mInitSnowRadius on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_mMassFactor(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SDK.Lib.SnowBallCfg obj = (SDK.Lib.SnowBallCfg)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.mMassFactor = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index mMassFactor on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_mK(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SDK.Lib.SnowBallCfg obj = (SDK.Lib.SnowBallCfg)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.mK = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index mK on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_mN(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SDK.Lib.SnowBallCfg obj = (SDK.Lib.SnowBallCfg)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.mN = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index mN on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_mCanSplitFactor(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SDK.Lib.SnowBallCfg obj = (SDK.Lib.SnowBallCfg)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.mCanSplitFactor = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index mCanSplitFactor on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_mMaxSnowNum(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SDK.Lib.SnowBallCfg obj = (SDK.Lib.SnowBallCfg)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.mMaxSnowNum = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index mMaxSnowNum on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_mSplitRelStartPos(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SDK.Lib.SnowBallCfg obj = (SDK.Lib.SnowBallCfg)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.mSplitRelStartPos = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index mSplitRelStartPos on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_mSplitRelDist(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SDK.Lib.SnowBallCfg obj = (SDK.Lib.SnowBallCfg)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.mSplitRelDist = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index mSplitRelDist on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_mMergeContactTime(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SDK.Lib.SnowBallCfg obj = (SDK.Lib.SnowBallCfg)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.mMergeContactTime = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index mMergeContactTime on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_mMergeCoolTime(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SDK.Lib.SnowBallCfg obj = (SDK.Lib.SnowBallCfg)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.mMergeCoolTime = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index mMergeCoolTime on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_mEmitSnowMass(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SDK.Lib.SnowBallCfg obj = (SDK.Lib.SnowBallCfg)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.mEmitSnowMass = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index mEmitSnowMass on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_mEmitSnowRadius(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SDK.Lib.SnowBallCfg obj = (SDK.Lib.SnowBallCfg)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.mEmitSnowRadius = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index mEmitSnowRadius on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_mEmitRelStartPos(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SDK.Lib.SnowBallCfg obj = (SDK.Lib.SnowBallCfg)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.mEmitRelStartPos = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index mEmitRelStartPos on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_mEmitRelDist(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SDK.Lib.SnowBallCfg obj = (SDK.Lib.SnowBallCfg)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.mEmitRelDist = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index mEmitRelDist on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_mMoveSpeed_k(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SDK.Lib.SnowBallCfg obj = (SDK.Lib.SnowBallCfg)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.mMoveSpeed_k = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index mMoveSpeed_k on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_mMoveSpeed_b(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SDK.Lib.SnowBallCfg obj = (SDK.Lib.SnowBallCfg)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.mMoveSpeed_b = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index mMoveSpeed_b on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_mA(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SDK.Lib.SnowBallCfg obj = (SDK.Lib.SnowBallCfg)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.mA = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index mA on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_mCameraDistance_Z(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SDK.Lib.SnowBallCfg obj = (SDK.Lib.SnowBallCfg)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.mCameraDistance_Z = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index mCameraDistance_Z on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_mCameraChangeFactor_Z(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SDK.Lib.SnowBallCfg obj = (SDK.Lib.SnowBallCfg)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.mCameraChangeFactor_Z = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index mCameraChangeFactor_Z on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_mLimitRadius(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SDK.Lib.SnowBallCfg obj = (SDK.Lib.SnowBallCfg)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.mLimitRadius = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index mLimitRadius on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_mCameraDistance_Y(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SDK.Lib.SnowBallCfg obj = (SDK.Lib.SnowBallCfg)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.mCameraDistance_Y = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index mCameraDistance_Y on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_mCameraChangeFactor_Y(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SDK.Lib.SnowBallCfg obj = (SDK.Lib.SnowBallCfg)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.mCameraChangeFactor_Y = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index mCameraChangeFactor_Y on a nil value" : e.Message);
		}
	}
}
