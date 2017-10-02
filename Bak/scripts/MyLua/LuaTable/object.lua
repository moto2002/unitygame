LuaExcelManager = LuaExcelManager or {}

LuaExcelManager.object_object = {
	[1]={id = 1,name = [[饼干]],activeskinid = 0,type = 4,subtype = 3,image = [[1]],usage = [[幽浮星球的厨师特质的饼干，蕴含幽浮星的神秘力量。可解锁幽浮皮肤的不同颜色]],acquire = [[比赛结算获得]],},
	[2]={id = 2,name = [[糖果]],activeskinid = 0,type = 4,subtype = 3,image = [[2]],usage = [[地球自然界中存在的甜蜜糖果，是幽浮星人最喜爱的食物，可在蛋蛋屋中兑换幽浮皮肤以及子弹]],acquire = [[分享并邀请新玩家获得]],},
	[3]={id = 3,name = [[弹珠]],activeskinid = 0,type = 4,subtype = 3,image = [[3]],usage = [[来自东方神秘力量的弹珠，它的一切目前都是未知的]],acquire = [[暂无]],},
	[11]={id = 11,name = [[皮肤碎片1]],activeskinid = 0,type = 6,subtype = 1,image = [[11]],},
	[12]={id = 12,name = [[皮肤碎片2]],activeskinid = 0,type = 6,subtype = 1,image = [[12]],},
	[5001]={id = 5001,name = [[扭蛋]],activeskinid = 0,type = 5,subtype = 1,image = [[5001]],},
	[5002]={id = 5002,name = [[签到礼包]],activeskinid = 0,type = 5,subtype = 1,image = [[5002]],},
	[10001]={id = 10001,name = [[小飞机]],activeskinid = 1,type = 1,subtype = 1,image = [[1]],storeacquiremode = 1,ticket = 20,},
	[10002]={id = 10002,name = [[飞碟]],activeskinid = 2,type = 1,subtype = 1,image = [[12]],storeacquiremode = 1,ticket = 20,},
	[10003]={id = 10003,name = [[鱿鱼]],activeskinid = 3,type = 1,subtype = 1,image = [[23]],storeacquiremode = 1,ticket = 30,},
	[10004]={id = 10004,name = [[机器人]],activeskinid = 4,type = 1,subtype = 1,image = [[34]],storeacquiremode = 1,ticket = 50,},
	[10005]={id = 10005,name = [[战斗机]],activeskinid = 5,type = 1,subtype = 1,image = [[45]],storeacquiremode = 1,ticket = 100,},
	[10006]={id = 10006,name = [[时空战斗机]],activeskinid = 6,type = 1,subtype = 1,image = [[56]],storeacquiremode = 2,acquirewaydesc = [[赛季结算奖励中获得]],acquiredetaildesc = [[在赛季结算前，达到皇冠段位的玩家，便可获得该奖励]],ticket = 500,},
	[10007]={id = 10007,name = [[猫头鹰]],activeskinid = 7,type = 1,subtype = 1,image = [[67]],storeacquiremode = 1,ticket = 300,},
	[10008]={id = 10008,name = [[萌机器人]],activeskinid = 8,type = 1,subtype = 1,image = [[78]],storeacquiremode = 1,ticket = 350,},
	[10009]={id = 10009,name = [[机械战甲]],activeskinid = 9,type = 1,subtype = 1,image = [[89]],storeacquiremode = 1,ticket = 650,},
	[10010]={id = 10010,name = [[幽灵战浮]],activeskinid = 10,type = 1,subtype = 1,image = [[100]],storeacquiremode = 1,ticket = 400,},
	[10011]={id = 10011,name = [[纸飞机]],activeskinid = 11,type = 1,subtype = 1,image = [[101]],storeacquiremode = 1,ticket = 500,},
	[10012]={id = 10012,name = [[铁甲战机]],activeskinid = 12,type = 1,subtype = 1,image = [[112]],storeacquiremode = 1,ticket = 120,},
	[10013]={id = 10013,name = [[萌小鸡]],activeskinid = 13,type = 1,subtype = 1,image = [[123]],storeacquiremode = 1,ticket = 350,},
	[10014]={id = 10014,name = [[章鱼哥]],activeskinid = 14,type = 1,subtype = 1,image = [[134]],storeacquiremode = 1,ticket = 150,},
	[10015]={id = 10015,name = [[小龙虾]],activeskinid = 15,type = 1,subtype = 1,image = [[145]],storeacquiremode = 1,ticket = 400,},
	[10016]={id = 10016,name = [[大白]],activeskinid = 16,type = 1,subtype = 1,image = [[156]],storeacquiremode = 1,ticket = 400,},
	[20001]={id = 20001,name = [[子弹]],activeskinid = 0,type = 2,subtype = 2,image = [[1]],storeacquiremode = 1,ticket = 10,},
	[20002]={id = 20002,name = [[薄荷绿]],activeskinid = 0,type = 2,subtype = 2,image = [[2]],storeacquiremode = 1,ticket = 30,},
	[20003]={id = 20003,name = [[闪光白]],activeskinid = 0,type = 2,subtype = 2,image = [[3]],storeacquiremode = 1,ticket = 20,},
	[20004]={id = 20004,name = [[尊贵紫]],activeskinid = 0,type = 2,subtype = 2,image = [[4]],storeacquiremode = 1,ticket = 20,},
	[20005]={id = 20005,name = [[荧光红]],activeskinid = 0,type = 2,subtype = 2,image = [[5]],storeacquiremode = 1,ticket = 20,},
	[20006]={id = 20006,name = [[宝蓝]],activeskinid = 0,type = 2,subtype = 2,image = [[6]],storeacquiremode = 1,ticket = 20,},
	[20007]={id = 20007,name = [[闪明雷]],activeskinid = 0,type = 2,subtype = 2,image = [[7]],storeacquiremode = 1,ticket = 80,},
	[20008]={id = 20008,name = [[丘比特之箭]],activeskinid = 0,type = 2,subtype = 2,image = [[8]],storeacquiremode = 1,ticket = 100,},
	[20009]={id = 20009,name = [[棒棒糖]],activeskinid = 0,type = 2,subtype = 2,image = [[9]],storeacquiremode = 1,ticket = 150,},
	[20010]={id = 20010,name = [[闪电]],activeskinid = 0,type = 2,subtype = 2,image = [[10]],storeacquiremode = 1,ticket = 120,},
	[20011]={id = 20011,name = [[小火箭]],activeskinid = 0,type = 2,subtype = 2,image = [[11]],storeacquiremode = 1,ticket = 100,},
	[20012]={id = 20012,name = [[火焰球]],activeskinid = 0,type = 2,subtype = 2,image = [[12]],storeacquiremode = 1,ticket = 50,},
	[20013]={id = 20013,name = [[暗鬼波]],activeskinid = 0,type = 2,subtype = 2,image = [[13]],storeacquiremode = 1,ticket = 50,},
	[20014]={id = 20014,name = [[光波]],activeskinid = 0,type = 2,subtype = 2,image = [[14]],storeacquiremode = 1,ticket = 50,},
	[20015]={id = 20015,name = [[篮球火]],activeskinid = 0,type = 2,subtype = 2,image = [[15]],storeacquiremode = 1,ticket = 80,},
	[20016]={id = 20016,name = [[机械枪]],activeskinid = 0,type = 2,subtype = 2,image = [[16]],storeacquiremode = 1,ticket = 60,},
	[20017]={id = 20017,name = [[月牙光波]],activeskinid = 0,type = 2,subtype = 2,image = [[17]],storeacquiremode = 1,ticket = 50,},
	[20018]={id = 20018,name = [[放大镜]],activeskinid = 0,type = 2,subtype = 2,image = [[18]],storeacquiremode = 1,ticket = 50,},
	[20019]={id = 20019,name = [[五月的原谅帽]],activeskinid = 0,type = 2,subtype = 2,image = [[19]],storeacquiremode = 2,acquirewaydesc = [[赛季结算奖励中获得]],acquiredetaildesc = [[在赛季结算前，达到金杯段位的玩家，便可获得该奖励]],ticket = 500,},
	[30001]={id = 30001,name = [[白色轨迹]],activeskinid = 0,type = 3,subtype = 1,image = [[30001]],},
	[30011]={id = 30011,name = [[蓝色轨迹]],activeskinid = 0,type = 3,subtype = 1,image = [[30011]],},
}