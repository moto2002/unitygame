local M = GlobalNS.StaticClass();
local this = M;
M.clsName = "UtilPath";
GlobalNS[M.clsName] = M;

function M.CombineTwo(aPath, bPath)
	local retPath = string.format("%s/%s", aPath, bPath);
	return retPath;
end

return M;