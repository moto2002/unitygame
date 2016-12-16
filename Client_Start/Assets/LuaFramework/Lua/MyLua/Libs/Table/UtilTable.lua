MLoader("MyLua.Libs.Core.GlobalNS");
MLoader("MyLua.Libs.Core.Class");
MLoader("MyLua.Libs.Core.GObject");

local M = GlobalNS.StaticClass();
local this = M;
M.clsName = "UtilTable";
GlobalNS[M.clsName] = M;

function M.ctor()
    this.mPrePos = 0;        -- 记录之前的位置
    this.mSCnt = 0;
end

function M.readString(bytes, tmpStr)
    _, this.mSCnt = bytes:readUnsignedInt16(this.mSCnt);
    _, tmpStr = bytes:readMultiByte(tmpStr, this.mSCnt, GlobalNS.CSSystem.GkEncode.eUTF8);
	return tmpStr;
end

M.ctor();        -- 构造

return M;