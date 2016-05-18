local M = GlobalNS.Class(GlobalNS.GObject);
M.clsName = "LogSys";
GlobalNS[M.clsName] = M;

function M:ctor()

end

function M:dtor()

end

function M:isInFilter(logTypeId)
    if(logTypeId == GlobalNS.LogTypeId.eLogCommon or
       logTypeId == GlobalNS.LogTypeId.eLogTest) then
        return false;
    end
    
    return true;
end

function M:log(message, logTypeId)
    -- 输出日志信息
    if(self:isInFilter(logTypeId)) then
        GlobalNS.CSSystem.log(message, logTypeId);    
    end
end

function M:warn(message, logTypeId)
    -- 输出日志信息
    if(self:isInFilter(logTypeId)) then
        GlobalNS.CSSystem.warn(message, logTypeId);    
    end
end

function M:error(message, logTypeId)
    -- 输出日志信息
    if(self:isInFilter(logTypeId)) then
        GlobalNS.CSSystem.error(message, logTypeId);    
    end
end

return M;