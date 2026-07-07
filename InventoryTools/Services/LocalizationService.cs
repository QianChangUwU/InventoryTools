using System.Collections.Generic;

namespace InventoryTools.Services;

/// <summary>
/// 简易中文本地化服务。
/// 通过字典将英文 UI 字符串映射为中文翻译。
/// 使用 Tr() 扩展方法在显示点调用。
/// </summary>
public static class LocalizationService
{
    private static readonly Dictionary<string, string> Translations = BuildTranslations();

    private static Dictionary<string, string> BuildTranslations()
    {
        var d = new Dictionary<string, string>();
        // 使用索引器添加，遇到重复键时自动覆盖而非抛异常

        // ===== ItemLocalizer - 背包位置 =====
        d["Bag 1"] = "背包 1";
        d["Bag 2"] = "背包 2";
        d["Bag 3"] = "背包 3";
        d["Bag 4"] = "背包 4";
        d["Bag 5"] = "背包 5";
        d["Saddlebag Left"] = "陆行鸟包(左)";
        d["Saddlebag Right"] = "陆行鸟包(右)";
        d["Premium Saddlebag Left"] = "特级陆行鸟包(左)";
        d["Premium Saddlebag Right"] = "特级陆行鸟包(右)";
        d["Armory - Body"] = "兵装库 - 身体";
        d["Armory - Ear"] = "兵装库 - 耳饰";
        d["Armory - Feet"] = "兵装库 - 脚部";
        d["Armory - Hand"] = "兵装库 - 手臂";
        d["Armory - Head"] = "兵装库 - 头部";
        d["Armory - Legs"] = "兵装库 - 腿部";
        d["Armory - Main"] = "兵装库 - 主手";
        d["Armory - Neck"] = "兵装库 - 颈部";
        d["Armory - Offhand"] = "兵装库 - 副手";
        d["Armory - Ring"] = "兵装库 - 戒指";
        d["Armory - Waist"] = "兵装库 - 腰带";
        d["Armory - Wrist"] = "兵装库 - 腕部";
        d["Armory - Soul Crystal"] = "兵装库 - 灵魂水晶";
        d["Equipped Gear"] = "已装备";
        d["Free Company Chest - 1"] = "部队箱 - 1";
        d["Free Company Chest - 2"] = "部队箱 - 2";
        d["Free Company Chest - 3"] = "部队箱 - 3";
        d["Free Company Chest - 4"] = "部队箱 - 4";
        d["Free Company Chest - 5"] = "部队箱 - 5";
        d["Free Company Chest - 6"] = "部队箱 - 6";
        d["Free Company Chest - 7"] = "部队箱 - 7";
        d["Free Company Chest - 8"] = "部队箱 - 8";
        d["Free Company Chest - 9"] = "部队箱 - 9";
        d["Free Company Chest - 10"] = "部队箱 - 10";
        d["Free Company Chest - 11"] = "部队箱 - 11";
        d["Market"] = "市场";
        d["Glamour Chest"] = "幻化柜";
        d["Currency"] = "货币";
        d["Free Company - Gil"] = "部队 - 金币";
        d["Free Company - Crystals"] = "部队 - 水晶";
        d["Free Company - Currency"] = "部队 - 货币";
        d["Crystals"] = "水晶";
        d["Housing Exterior Appearance"] = "房屋外观";
        d["Housing Interior Appearance"] = "房屋内饰";
        d["Housing Exterior Storeroom"] = "房屋外观储物室";
        d["Housing Interior Storeroom"] = "房屋内饰储物室";
        d["Housing Interior Placed Items"] = "房屋内饰已放置物品";
        d["Housing Exterior Placed Items"] = "房屋外观已放置物品";
        d["Unknown Cabinet"] = "未知柜子";

        // ===== SettingCategory - 设置分类 =====
        d["General"] = "常规";
        d["Visuals"] = "外观";
        d["Marketboard"] = "市场板";
        d["Craft Overlay"] = "制作悬浮窗";
        d["Craft Tracker (Legacy)"] = "制作追踪 (旧版)";
        d["Tooltips"] = "鼠标提示";
        d["Hotkeys"] = "快捷键";
        d["History"] = "历史记录";
        d["Windows"] = "窗口";
        d["Lists"] = "清单";
        d["Context Menu"] = "右键菜单";
        d["Mob Spawn Tracker"] = "怪物刷新追踪";
        d["Title Menu Button"] = "标题菜单按钮";
        d["Auto Save"] = "自动保存";
        d["Items"] = "物品";
        d["Highlighting"] = "高亮";
        d["Equipment Recommendations"] = "装备推荐";

        // ===== FilterCategory - 过滤器分类 =====
        d["Basic"] = "基本";
        d["Acquisition"] = "获取途径";
        d["Crafting"] = "制作";
        d["Gathering"] = "采集";
        d["Searching"] = "搜索";
        d["Display"] = "显示";
        d["Inventories"] = "库存";
        d["Columns"] = "列";
        d["Advanced"] = "高级";
        d["Craft Columns"] = "制作列";
        d["Ingredient Sourcing"] = "材料来源";
        d["Zone Preference"] = "区域偏好";
        d["World Price Preference"] = "世界价格偏好";
        d["Sources"] = "来源";
        d["Uses"] = "用途";
        d["Source (Categories)"] = "来源 (分类)";
        d["Use (Categories)"] = "用途 (分类)";
        d["Settings"] = "设置";
        d["Stats"] = "属性";
        d["Completion Tracking"] = "完成追踪";
        d["Notifications"] = "通知";

        // ===== ColumnCategory - 列分类 =====
        d["Unsorted"] = "未分类";
        d["Tools"] = "工具";
        d["Debug"] = "调试";
        d["Buttons"] = "按钮";
        d["Inventory"] = "库存";

        // ===== 常用按钮和选项 =====
        d["Yes"] = "是";
        d["No"] = "否";
        d["N/A"] = "无";
        d["Reset"] = "重置";
        d["Add All"] = "全部添加";
        d["No items selected"] = "未选择项目";
        d["Start typing to search.."] = "输入以搜索..";

        // ===== 窗口名称 =====
        d["Submarines"] = "潜水艇";
        d["Retainer Ventures"] = "雇员探险";
        d["Help"] = "帮助";
        d["Generate Support Dump"] = "生成支持转储";
        d["Invalid Submarine Exploration"] = "无效的潜水艇探索";
        d["Invalid Retainer Task"] = "无效的雇员任务";
        d["Invalid Item"] = "无效物品";
        d["Invalid NPC"] = "无效NPC";
        d["Invalid List"] = "无效清单";

        // ===== 列名称 =====
        d["Name"] = "名称";
        d["Name & Icon"] = "名称和图标";
        d["Type"] = "类型";
        d["Source"] = "来源";
        d["Source World"] = "来源世界";
        d["Quantity"] = "数量";
        d["Quantity/Total Quantity Available"] = "数量/可用总量";
        d["Total Quantity Available"] = "可用总量";
        d["Stack Size"] = "堆叠上限";
        d["Spiritbond"] = "精炼度";
        d["Dye"] = "染料";
        d["Dye Count"] = "染色槽";
        d["Rarity"] = "稀有度";
        d["iLevel"] = "品级";
        d["Required Level"] = "需求等级";
        d["Delay"] = "延迟";
        d["Magical Damage"] = "魔法伤害";
        d["Physical Damage"] = "物理伤害";
        d["Materia Count"] = "魔晶石槽数";
        d["Attribute"] = "属性";
        d["Patch Added"] = "版本";
        d["Item ID"] = "物品ID";
        d["Inventory Location"] = "库存位置";
        d["Category (Basic)"] = "分类 (基本)";
        d["Category (Marketboard)"] = "分类 (市场板)";
        d["Venture Type"] = "探险类型";
        d["Is From Timed Node?"] = "来自限时采集点?";
        d["Is sold in Square Store?"] = "商城出售?";
        d["Next Gather Uptime"] = "下次采集时间";
        d["Shortcuts"] = "快捷方式";
        d["Sell to Vendor Price"] = "出售NPC价格";
        d["Sell to Vendor Price (Total)"] = "出售NPC价格 (总计)";
        d["Retainer Selling Unit Price"] = "雇员出售单价";
        d["Is Recipe Unlocked?"] = "配方已解锁?";
        d["Recipe Total Count"] = "配方总数";
        d["Is Unobtainable?"] = "无法获取?";
        d["Is Stackable?"] = "可堆叠?";
        d["Are Recipes Completed?"] = "配方已完成?";
        d["Is Dropped by Mobs?"] = "怪物掉落?";
        d["Is Leve(Craft) Item?"] = "理符(制作)物品?";
        d["Outdated Gear?"] = "装备过期?";
        d["Last Seen Date/Time"] = "最后看到时间";
        d["Market Board Average Price NQ"] = "市场板均价 NQ";
        d["Market Board Average Price HQ"] = "市场板均价 HQ";
        d["Market Board Average Price NQ/HQ"] = "市场板均价 NQ/HQ";
        d["Market Board Minimum Price NQ"] = "市场板最低价 NQ";
        d["Market Board Minimum Price HQ"] = "市场板最低价 HQ";
        d["Market Board Minimum Price NQ/HQ"] = "市场板最低价 NQ/HQ";
        d["Market Board Average Total Price(Qty * Price) NQ/HQ"] = "市场板均总价(数量*价格) NQ/HQ";
        d["Market Board Minimum Total Price(Qty * Price) NQ/HQ"] = "市场板最低总价(数量*价格) NQ/HQ";

        // ===== 设置名称 =====
        d["Switch craft lists automatically?"] = "自动切换制作清单?";
        d["Switch lists automatically?"] = "自动切换清单?";
        d["Add Item Locations"] = "添加物品位置";
        d["Add Item Locations (Affix with Character Name)"] = "添加物品位置 (附带角色名)";
        d["Add Item Locations (Order)"] = "添加物品位置 (排序)";
        d["Add Item Locations (Max Results)"] = "添加物品位置 (最大结果数)";
        d["Add Item Locations (Display Mode)"] = "添加物品位置 (显示模式)";
        d["Add Item Locations (Search Locations)"] = "添加物品位置 (搜索范围)";
        d["Tooltip Category Blacklist"] = "提示分类黑名单";
        d["Tooltip Category Whitelist"] = "提示分类白名单";
        d["Text Colour"] = "文字颜色";
        d["Limit to items on the current character?"] = "仅限当前角色物品?";
        d["Coffer Loot Info"] = "宝箱战利品信息";
        d["Coffer Loot (Search Locations)"] = "宝箱战利品 (搜索范围)";
        d["Outfit Glamour Info"] = "幻化套装信息";
        d["Outfit Glamour (Search Locations)"] = "幻化套装 (搜索范围)";
        d["Add Amount to Retrieve"] = "添加取回数量";
        d["Add Item Unlock Status"] = "添加物品解锁状态";
        d["Add Item Unlock Status (Characters)"] = "添加物品解锁状态 (角色)";
        d["Add Plugin Name"] = "添加插件名";
        d["Footer New Lines"] = "底部空行";
        d["Header New Lines"] = "顶部空行";
        d["Source Information Configuration"] = "来源信息配置";
        d["Use Information Configuration"] = "用途信息配置";
        d["Display Mode"] = "显示模式";
        d["Add Market Minimum NQ/HQ Price?"] = "添加市场最低价 NQ/HQ?";
        d["Add Market Average NQ/HQ Price"] = "添加市场均价 NQ/HQ";
        d["Track Mob Spawns"] = "追踪怪物刷新";
        d["Window List Highlighting"] = "窗口清单高亮";
        d["Use Acquisition Icon Grouping"] = "使用获取图标分组";
        d["Source Acquisition Icon Grouping"] = "来源获取图标分组";
        d["Show 'All Lists' Tab?"] = "显示「所有清单」标签?";
        d["Show item number in retainer list?"] = "在雇员列表显示物品数量?";
        d["Keep Background List Highlighting?"] = "保持后台清单高亮?";
        d["Retainer List Colour"] = "雇员列表颜色";
        d["Tab Highlight Colour"] = "标签高亮颜色";
        d["Highlight Colour"] = "高亮颜色";
        d["Highlight Destination Colour"] = "目标高亮颜色";
        d["Highlight Empty Destination?"] = "高亮空目标?";
        d["Invert Highlighting?"] = "反转高亮?";
        d["Invert Destination Highlighting?"] = "反转目标高亮?";
        d["Invert Tab Highlighting?"] = "反转标签高亮?";
        d["Enable History Tracking?"] = "启用历史追踪?";
        d["History Track Events"] = "历史追踪事件";
        d["Enable Tooltip Tweaks?"] = "启用提示修改?";
        d["Keep market prices for X hours"] = "市场价格保留小时数";
        d["Price Home World?"] = "以本地世界定价?";
        d["Price Active World?"] = "以当前世界定价?";
        d["Marketboard Sale History Days"] = "市场板销售历史天数";
        d["Price Worlds"] = "定价世界";
        d["Toggle Airships Window"] = "切换飞艇窗口";
        d["Toggle Submarines Window"] = "切换潜水艇窗口";
        d["Toggle Retainer Ventures Window"] = "切换雇员探险窗口";
        d["Toggle Configuration Window"] = "切换配置窗口";
        d["Toggle Lists Window"] = "切换清单窗口";
        d["Toggle Craft Window"] = "切换制作窗口";
        d["Toggle Duties Window"] = "切换副本窗口";
        d["Toggle Mob Window"] = "切换怪物窗口";
        d["Toggle More Info"] = "切换更多信息";
        d["Open Item Log Hotkey"] = "打开物品日志快捷键";
        d["Open Gathering Log Hotkey"] = "打开采集日志快捷键";
        d["Open Fishing Log Hotkey"] = "打开钓鱼日志快捷键";
        d["Open Crafting Log Hotkey"] = "打开制作日志快捷键";
        d["Items Window Layout"] = "物品窗口布局";
        d["Destination Highlight Colour"] = "目标高亮颜色";
        d["Colour Retainer List"] = "雇员列表着色";
        d["Automatically Download Prices"] = "自动下载价格";
        d["Allow Cross Character"] = "允许跨角色";
        d["Add Title Menu Button"] = "添加标题菜单按钮";
        d["Context Menu - Search"] = "右键菜单 - 搜索";
        d["Context Menu - Open Crafting Log"] = "右键菜单 - 打开制作日志";
        d["Context Menu - Add to Active Craft List"] = "右键菜单 - 添加到活动制作清单";
        d["Context Menu - Add to Craft List"] = "右键菜单 - 添加到制作清单";
        d["Context Menu - Add to Curated List"] = "右键菜单 - 添加到精选清单";
        d["Context Menu - Add to Favourites"] = "右键菜单 - 添加到收藏";
        d["Context Menu - Copy Name"] = "右键菜单 - 复制名称";
        d["Context Menu - More Information"] = "右键菜单 - 更多信息";
        d["Context Menu - Open Fishing Log"] = "右键菜单 - 打开钓鱼日志";
        d["Context Menu - Open Gathering Log"] = "右键菜单 - 打开采集日志";
        d["Persist Data"] = "持久化数据";
        d["Shop Highlighting"] = "商店高亮";
        d["Active Craft List"] = "活动制作清单";
        d["Background Filter"] = "后台过滤器";
        d["Auto Save Time"] = "自动保存时间";
        d["Acquisition Tracker Login Delay"] = "获取追踪登录延迟";
        d["Acquisition Tracker Persist State"] = "获取追踪持久化状态";
        d["Compendium Row Height"] = "图鉴行高";
        d["Compendium Wotsit"] = "图鉴 Wotsit";
        d["Craft Overlay Hide"] = "制作悬浮窗隐藏";
        d["Craft Overlay Max Expanded Items"] = "制作悬浮窗最大展开项";
        d["Craft Overlay Remember State"] = "制作悬浮窗记住状态";
        d["Craft Overlay Window State"] = "制作悬浮窗窗口状态";
        d["Craft Window Layout"] = "制作窗口布局";
        d["Craft Window View"] = "制作窗口视图";
        d["Enable Tetris"] = "启用俄罗斯方块";
        d["Filters Window Layout"] = "过滤器窗口布局";
        d["Glamour Ready Set Display Mode"] = "幻化套装显示模式";
        d["Save Background Filter"] = "保存后台过滤器";
        d["Shop Highlighting Disable Items"] = "商店高亮禁用物品";
        d["Shop Highlighting Npc Color"] = "商店高亮NPC颜色";
        d["Shop Highlighting Npc Nameplate Icon"] = "商店高亮NPC名牌图标";
        d["Shop Highlighting Npc"] = "商店高亮NPC";
        d["ImGui Tooltip Mode"] = "ImGui提示模式";

        // ===== 过滤器名称 =====
        d["Default Zone Order"] = "默认区域排序";
        d["Table Row Height"] = "表格行高";
        d["Freeze Columns"] = "冻结列";
        d["Tab Highlight Color"] = "标签高亮颜色";
        d["Spirit Bond"] = "精炼度";
        d["Sell to Shop Price"] = "出售商店价格";
        d["Market Board Categories"] = "市场板分类";
        d["Retainer Retrieve Order"] = "雇员取回顺序";
        d["Retainer List Color"] = "雇员列表颜色";
        d["Patch"] = "版本";
        d["Purchased with Currency"] = "货币购买";
        d["Highlight NPCs?"] = "高亮NPC?";
        d["Name (Selector)"] = "名称 (选择器)";
        d["Categories"] = "分类";
        d["Is HQ?"] = "高品质?";
        d["Is Part of Gearset?"] = "属于套装?";
        d["Is Collectible?"] = "收藏品?";
        d["Ignore HQ Filter?"] = "忽略高品质过滤?";
        d["Ingredient Search Filter"] = "材料搜索过滤器";
        d["Highlight When?"] = "何时高亮?";
        d["Highlight Destination Duplicates?"] = "高亮目标重复?";
        d["Highlight Destination Color"] = "高亮目标颜色";
        d["Highlight Color"] = "高亮颜色";
        d["Has been gathered before?"] = "已采集过?";
        d["Gear Sets"] = "套装";
        d["Gathered By?"] = "采集方式?";
        d["Source - Inventories"] = "来源 - 库存";
        d["Market Board Avg. Total Price"] = "市场板均总价";
        d["Marketboard Avg. Price"] = "市场板均价";
        d["Marketboard Sale Counter"] = "市场板销售计数";
        d["Market Board Total Minimum Price"] = "市场板最低总价";
        d["Marketboard Minimum Price"] = "市场板最低价";
        d["Marketboard Sale History Days"] = "市场板销售历史天数";

        // ===== Tooltip 显示文本 =====
        d["Available From: "] = "获取来源: ";
        d["Used In: "] = "用于: ";
        d["Owned"] = "拥有";
        d["Locations:"] = "位置:";
        d["Locations"] = "位置";
        d["Ctrl: Link"] = "Ctrl: 链接物品";
        d["Shift: Try on"] = "Shift: 试穿";
        d["When HQ:"] = "高品质时:";
        d["Can be HQ"] = "可为高品质";
        d["Unique"] = "稀有";
        d["Untradable"] = "不可交易";
        d["Item Level"] = "物品等级";
        d["Equip Level"] = "装备等级";
        d["other locations."] = "个其他位置。";
        d["Market Board Data"] = "市场板数据";
        d["Average Price"] = "均价";
        d["Average Price (HQ)"] = "均价 (HQ)";
        d["Minimum Price"] = "最低价";
        d["Minimum Price (HQ)"] = "最低价 (HQ)";
        d["Missing: "] = "缺少: ";
        d["Buy: "] = "购买: ";
        d["should be retrieved"] = "应取回";
        d["Loot"] = "战利品";
        d["items owned"] = "已拥有";
        d["Available in:"] = "可从以下获取:";
        d["Already acquired"] = "已获得";
        d["Outfit Glamour"] = "幻化套装";
        d["Part of"] = "属于";
        d["Already in"] = "已在";
        d["Sources"] = "来源";
        d["Uses"] = "用途";
        d["more)"] = "更多)";
        d["Only equippable by "] = "仅可装备于 ";
        d["Can be HQ"] = "可为高品质";

        // ===== Tooltip 设置选项 =====
        d["Item Tooltip Mode"] = "物品提示模式";
        d["Never"] = "从不";
        d["Icons"] = "仅图标";
        d["Everywhere"] = "始终";
        d["Always"] = "始终";
        d["Control"] = "Ctrl";
        d["Shift"] = "Shift";
        d["Source Information Enabled"] = "启用来源信息";
        d["Source Information Modifier Key"] = "来源信息修饰键";
        d["Should source information be shown in the tooltip? For example that an item can be sourced via crafting, shops, monsters etc"] = "是否在提示中显示来源信息？例如物品可通过制作、商店、怪物等获取";
        d["Should the tooltip only be shown if a modifier key is pressed?"] = "是否仅在按下修饰键时显示提示?";
        d["Use Information Enabled"] = "启用用途信息";
        d["Use Information Modifier Key"] = "用途信息修饰键";
        d["Should use information be shown in the tooltip? For example, the item is used in a recipe or as currency at a shop, etc"] = "是否在提示中显示用途信息？例如物品用于配方或商店货币等";
        d["Item Tooltip Mode"] = "物品提示模式";
        d["Should a tooltip for items be shown, never, when hovering an item's icon or when hovering any row within an item table?"] = "是否显示物品提示：从不、仅悬停图标时、或悬停表格任意行时?";
        d["Disable/enable the entire tooltip modification system for the plugin. If this is off, no changes will be made to your item's tooltips."] = "禁用/启用插件的提示修改系统。关闭后不会对物品提示做任何修改。";
        d["Should [Allagan Tools] be displayed in the tooltip above any tooltip modifications?"] = "是否在提示修改上方显示 [Allagan Tools] ?";
        d["How the locations of items should be presented in the tooltip. This requires 'Add Item Locations?' to be on."] = "物品位置在提示中的显示方式。需要开启「添加物品位置」。";
        d["Character/Retainer - Quantity - Quality"] = "角色/雇员 - 数量 - 品质";
        d["Character/Retainer - Bag - Slot - Quality"] = "角色/雇员 - 背包 - 槽位 - 品质";
        d["Character/Retainer - Bag - Slot - Quantity"] = "角色/雇员 - 背包 - 槽位 - 数量";
        d["Character/Retainer - Category - Quantity - Quality"] = "角色/雇员 - 分类 - 数量 - 品质";
        d["Character/Retainer - World - Category - Quantity - Quality"] = "角色/雇员 - 世界 - 分类 - 数量 - 品质";
        d["Character Per Line"] = "每角色一行";
        d["Grouped By Unlock Status"] = "按解锁状态分组";
        d["Add Item Unlock Status (Display Mode)"] = "添加物品解锁状态 (显示模式)";
        d["How should the item unlock status tooltip be displayed?"] = "物品解锁状态提示应如何显示?";
        d["Addon Text Not Found"] = "未找到插件文本";

        // ===== Tooltip 设置帮助文本 =====
        d["When hovering an item, should the tooltip show the locations of any copies of the item you currently own?"] = "悬停物品时，是否在提示中显示您拥有的该物品的位置?";
        d["How should the items displayed in the tooltip that you own be ordered? None is included if you find the sorting to be non-performant."] = "提示中显示的已拥有物品应如何排序？如排序影响性能可选无。";
        d["Alphabetical Order(Character/Retainer/etc)"] = "字母顺序(角色/雇员等)";
        d["Alphabetical Order(Category)"] = "字母顺序(分类)";
        d["Item Quantity"] = "物品数量";
        d["No Order"] = "不排序";
        d["When hovering an item, should the tooltip contain the minimum market price for both NQ and HQ. Please make sure 'Automatically download prices' is enabled."] = "悬停物品时，是否在提示中显示NQ和HQ的最低市场价格？请确保已启用「自动下载价格」。";
        d["If an item can be unlocked/acquired, shows if your characters have unlocked/acquired said item. Can be configured to show specific characters inside the configuration window."] = "如果物品可解锁/获取，显示您的角色是否已解锁/获取该物品。可在配置窗口中设置显示特定角色。";
        d["Acquired Item Colour"] = "已获取物品颜色";
        d["Not Acquired Item Colour"] = "未获取物品颜色";
        d["In detailed mode, what colour should acquired items be shown in?"] = "详细模式下，已获取物品显示什么颜色?";
        d["In detailed mode, what colour should not-yet-acquired items be shown in?"] = "详细模式下，未获取物品显示什么颜色?";
        d["When enabled, what colour should the text be for the 'Add Item Locations' tooltip text be?"] = "启用后，「添加物品位置」提示文字的颜色?";
        d["When enabled, what colour should the text be for the 'Market Pricing' tooltip text be?"] = "启用后，「市场价格」提示文字的颜色?";
        d["When enabled, what colour should the text be for the 'Amount to Retrieve' tooltip text be?"] = "启用后，「取回数量」提示文字的颜色?";
        d["When enabled, what colour should the text be for the 'Item Unlock Status' tooltip text be?"] = "启用后，「物品解锁状态」提示文字的颜色?";
        d["When enabled, what colour should the text be for the 'Source Information' tooltip text be?"] = "启用后，「来源信息」提示文字的颜色?";
        d["When enabled, what colour should the text be for the 'Use Information' tooltip text be?"] = "启用后，「用途信息」提示文字的颜色?";
        d["When enabled, what colour should the text be for the 'Ingredient Patch' tooltip text be?"] = "启用后，「材料版本」提示文字的颜色?";
        d["When enabled, what colour should the text be for the 'Outfit Glamour' tooltip text be?"] = "启用后，「幻化套装」提示文字的颜色?";
        d["When enabled, what colour should the text be for the 'Coffer Loot' tooltip text be?"] = "启用后，「宝箱战利品」提示文字的颜色?";
        d["Market Price"] = "市场价格";
        d["Display Mode"] = "显示模式";

        // ===== InventoryCategory.FormattedName =====
        d["Bags"] = "背包";
        d["Saddle Bags"] = "陆行鸟鞍囊1";
        d["Premium Saddle Bags"] = "陆行鸟鞍囊2";
        d["Free Company Bags"] = "部队箱";
        d["Armoury Chest"] = "兵装库";
        d["Equipped"] = "已装备";
        d["Armoire"] = "装备柜";
        d["Housing Exterior Items"] = "房屋外观物品";
        d["Housing Interior Items"] = "房屋内饰物品";

        // ===== InventoryCategory.FormattedDetailedName =====
        d["Character Bags"] = "角色背包";
        d["Character Equipped"] = "角色已装备";
        d["Retainer Bags"] = "雇员背包";
        d["Retainer Market"] = "雇员市场";
        d["Retainer Equipped"] = "雇员已装备";

        // ===== 按钮和通用 UI =====
        d["Reset"] = "重置";
        d["Cancel"] = "取消";
        d["Close"] = "关闭";
        d["Copy"] = "复制";
        d["Import"] = "导入";
        d["Proceed"] = "继续";
        d["Open"] = "打开";
        d["Checking"] = "检查中";
        d["Unknown"] = "未知";
        d["Acquired"] = "已获得";
        d["Not Acquired"] = "未获得";
        d["Teleport"] = "传送";
        d["Map Link"] = "地图链接";
        d["Open Wiki"] = "打开 Wiki";
        d["Paste text here"] = "在此粘贴文本";
        d["Import to Craft List: "] = "导入到制作清单: ";

        // ===== 过滤器/列名称 =====
        d["100 gil or less"] = "100金以下";
        d["Amount can Craft"] = "可制作数量";
        d["Amount in Character Inventory"] = "角色库存数量";
        d["Amount Missing"] = "缺少数量";
        d["Amount Required"] = "需求数量";
        d["Amount to Retrieve"] = "取回数量";
        d["Are Recipes Completed?"] = "配方已完成?";
        d["Attribute"] = "属性";
        d["Button Types"] = "按钮类型";
        d["Buy Button"] = "购买按钮";
        d["Buy From Vendor Price"] = "NPC购买价格";
        d["Can be Equipped?"] = "可装备?";
        d["Can be High Quality?"] = "可为高品质?";
        d["Can be Placed on Market?"] = "可上架市场?";
        d["Can be Traded?"] = "可交易?";
        d["Category"] = "分类";
        d["Character"] = "角色";
        d["Character Owner"] = "所属角色";
        d["Character Search Scope"] = "角色搜索范围";
        d["Coffer Loot (Search Locations)"] = "宝箱战利品 (搜索范围)";
        d["Coffer Loot Info"] = "宝箱战利品信息";
        d["Color name in retainer list?"] = "雇员列表着色?";
        d["Columns"] = "列";
        d["Completion Sound"] = "完成提示音";
        d["Context Menu - More Information (Items)"] = "右键菜单 - 更多信息 (物品)";
        d["Context Menu - Search Scope"] = "右键菜单 - 搜索范围";
        d["Copy Item Name Button"] = "复制物品名按钮";
        d["Craft Button"] = "制作按钮";
        d["Craft Calculator"] = "制作计算器";
        d["Craft Completion Mode"] = "制作完成模式";
        d["Craft Display Mode"] = "制作显示模式";
        d["Craft List Mode"] = "制作清单模式";
        d["Custom Button"] = "自定义按钮";
        d["Custom Link Button"] = "自定义链接按钮";
        d["Debug - Craft"] = "调试 - 制作";
        d["Debug - General Information"] = "调试 - 常规信息";
        d["Default Ingredient Sourcing"] = "默认材料来源";
        d["Default Sort Column Order"] = "默认排序列顺序";
        d["Default Sort Column"] = "默认排序列";
        d["Destination Highlight Colour"] = "目标高亮颜色";
        d["Destination Inventories"] = "目标库存";
        d["Destination"] = "目标";
        d["Destinations"] = "目标";
        d["Desynth Class"] = "分解职业";
        d["Desynthesis Class"] = "分解职业";
        d["Desynthesis Skill Delta"] = "分解技能差值";
        d["Duplicate Items"] = "重复物品";
        d["Duplicates Only?"] = "仅重复?";
        d["Dye"] = "染料";
        d["Enable Tetris?"] = "启用俄罗斯方块?";
        d["Ephemeral?"] = "限时采集点?";
        d["Equippable By Gender"] = "可装备性别";
        d["Equippable By Race"] = "可装备种族";
        d["Equippable By"] = "可装备于";
        d["Equipped By (Class/Job)"] = "装备者 (职业)";
        d["Equipped By (Gender)"] = "装备者 (性别)";
        d["Equipped By (Race)"] = "装备者 (种族)";
        d["Exclude Sources"] = "排除来源";
        d["Expert Delivery Reward Seal Count"] = "专家交付奖励印章数";
        d["Favourite?"] = "收藏?";
        d["Filter Items when in Retainer?"] = "在雇员界面过滤物品?";
        d["Filter Stats"] = "过滤属性";
        d["Gather/Purchase/Buy"] = "采集/购买/购入";
        d["Gathering Log Button"] = "采集日志按钮";
        d["Gearset Number"] = "套装编号";
        d["Group Crystals By"] = "水晶分组方式";
        d["Group Currency By"] = "货币分组方式";
        d["Group Everything Else By"] = "其他物品分组方式";
        d["Group House Vendors By"] = "房屋商店分组方式";
        d["Group Precrafts By"] = "预制作分组方式";
        d["Group Retrieval Items By"] = "取回物品分组方式";
        d["Has Been Acquired?"] = "已获得?";
        d["Header Text Colour"] = "标题文字颜色";
        d["Highlight Color"] = "高亮颜色";
        d["Highlight Destination Color"] = "目标高亮颜色";
        d["Highlight Destination?"] = "高亮目标?";
        d["History Event Amount"] = "历史事件数量";
        d["History Event Date/Time"] = "历史事件日期/时间";
        d["History Event Reason"] = "历史事件原因";
        d["HQ Required"] = "需要高品质";
        d["Icon"] = "图标";
        d["In Gearset?"] = "在套装中?";
        d["Include Sources"] = "包含来源";
        d["Ingredient Patch Search"] = "材料版本搜索";
        d["Inventories to Retrieve From"] = "取回来源库存";
        d["Inventories to Retrieve To"] = "取回目标库存";
        d["Inventory Search Scope"] = "库存搜索范围";
        d["Is Acquired?"] = "已获得?";
        d["Is Aquarium Item?"] = "水族箱物品?";
        d["Is Armoire Item?"] = "装备柜物品?";
        d["Is Craft Component?"] = "制作材料?";
        d["Is Craftable?"] = "可制作?";
        d["Is custom delivery item?"] = "自定义交付物品?";
        d["Is Desynthable?"] = "可分解?";
        d["Is Dyeable?"] = "可染色?";
        d["Is Favourite?"] = "收藏?";
        d["Is from Calamity Salvager?"] = "灾厄商人出售?";
        d["Is From Ephemeral Node?"] = "来自限时采集点?";
        d["Is From Fate?"] = "来自命运理符?";
        d["Is From Hidden Node?"] = "来自隐藏采集点?";
        d["Is From Timed Node?"] = "来自定时采集点?";
        d["Is Gatherable?"] = "可采集?";
        d["Is GC Turn-in item?"] = "军团交付物品?";
        d["Is Housing Item?"] = "房屋物品?";
        d["Is Ishgardian Craft?"] = "伊修加德复兴制作?";
        d["Is Outfit Glamour Item?"] = "幻化套装物品?";
        d["Is Outfit Glamour Set?"] = "幻化套装?";
        d["Is Purchasable?"] = "可购买?";
        d["Is Recipe Unlocked?"] = "配方已解锁?";
        d["Is Tradable?"] = "可交易?";
        d["Is Unobtainable?"] = "无法获取?";
        d["Job"] = "职业";
        d["Level"] = "等级";
        d["Logged in Gathering Log?"] = "已登录采集日志?";
        d["Market Pricing"] = "市场价格";
        d["Material clean-up"] = "材料清理";
        d["More Information Hotkey"] = "更多信息快捷键";
        d["Next Step in Craft"] = "下一步制作";
        d["Notification Prefix"] = "通知前缀";
        d["Off-hand"] = "副手";
        d["Outfit Glamour (Search Locations)"] = "幻化套装 (搜索范围)";
        d["Outfit Glamour Info"] = "幻化套装信息";
        d["Output Ordering"] = "输出排序";
        d["Per-Item Ingredient Source Overrides"] = "单独材料来源覆盖";
        d["Qualities"] = "品质";
        d["Relative Item Level"] = "相对品级";
        d["Remove"] = "移除";
        d["Retainer Retrieval (Output)"] = "雇员取回 (输出)";
        d["Retainer Retrieval"] = "雇员取回";
        d["Reverse Craft List Order?"] = "反转制作清单顺序?";
        d["Sell to Shop Price"] = "出售商店价格";
        d["Settings"] = "设置";
        d["Show Cross-Character Inventories in Lists?"] = "在清单中显示跨角色库存?";
        d["Source Acquisition Icon Grouping"] = "来源获取图标分组";
        d["Source - Inventories"] = "来源 - 库存";
        d["Source World"] = "来源世界";
        d["Staging Area"] = "中转区";
        d["Track Combat Drops?"] = "追踪战斗掉落?";
        d["Track Crafts?"] = "追踪制作?";
        d["Track Gathering?"] = "追踪采集?";
        d["Track Market Board?"] = "追踪市场板?";
        d["Track Mob Spawns"] = "追踪怪物刷新";
        d["Track Other?"] = "追踪其他?";
        d["Track Shopping?"] = "追踪购物?";
        d["Types"] = "类型";
        d["Use Active World?"] = "使用当前世界?";
        d["Use Default Worlds?"] = "使用默认世界?";
        d["Use Home World?"] = "使用本地世界?";
        d["Use OR when filtering items."] = "过滤物品时使用 OR 逻辑";
        d["World"] = "世界";
        d["Zone"] = "区域";
        d["Auto save every"] = "自动保存间隔";
        d["Auto save inventories/configuration?"] = "自动保存库存/配置?";
        d["Automatically download prices?"] = "自动下载价格?";
        d["Background List Highlighting"] = "后台清单高亮";
        d["Add Title Menu Button?"] = "添加标题菜单按钮?";
        d["Active Craft List"] = "活动制作清单";

        // ===== 过滤器帮助文本 =====
        d["A button that opens the crafting log for the item"] = "打开该物品制作日志的按钮";
        d["A button/list to show you where you can buy an item"] = "显示物品购买位置的按钮/列表";
        d["A list of extra worlds we should automatically price"] = "需要自动定价的额外世界列表";
        d["Add a new column. Leave the column name blank if you want to use the default."] = "添加新列。留空列名则使用默认值。";
        d["Adds a button for quickly removing items from your list"] = "添加快速移除清单物品的按钮";
        d["An bonus attributes of the item(Strength, HP, Perception, etc)"] = "物品的附加属性(力量、HP、感知等)";
        d["Can the item be dyed?"] = "物品可染色?";
        d["Can the item be equipped?"] = "物品可装备?";
        d["Can the item be gathered?"] = "物品可采集?";
        d["Can the item be high quality?"] = "物品可为高品质?";
        d["Can the item be placed on the marketboard?"] = "物品可上架市场板?";
        d["Can the item be purchased with gil?"] = "物品可用金币购买?";
        d["Can the item be traded?"] = "物品可交易?";
        d["Can the item by desynthed?"] = "物品可分解?";
        d["Can this item be crafted?"] = "该物品可制作?";
        d["Can this item be equipped?"] = "该物品可装备?";
        d["Can this item be placed on the market?"] = "该物品可上架市场?";
        d["Can this item be put in a aquarium?"] = "该物品可放入水族箱?";
        d["Can this item be traded?"] = "该物品可交易?";
        d["Can this item be used to craft another item?"] = "该物品可用于制作其他物品?";
        d["Choose the display mode of the dye column"] = "选择染料列的显示模式";
        d["Copies the item name to the clipboard."] = "复制物品名到剪贴板";
        d["Displays the last time an item was seen."] = "显示物品最后出现的时间";
        d["Filter by the categories available on the market board."] = "按市场板分类过滤";
        d["Filter by the categories the game gives items when you scroll over them."] = "按游戏内物品分类过滤";
        d["Filter by the gear sets that a item is in."] = "按物品所在的套装过滤";
        d["Filter items by whether all crafting requirements (job level, mastery book, specialization) are met by the current character. Items with no crafting source are excluded when a value is set."] = "按当前角色是否满足所有制作条件(职业等级、秘籍、专家)过滤。设置值时排除无制作来源的物品。";
        d["Finds all gatherable items in your characters inventory and attempts to show you where to put them in your retainers."] = "查找角色库存中所有可采集物品，并尝试显示应放入雇员的位置。";
        d["Finds any items where there are 2 seperate stacks in retainers & characters and attempts to sort them into a single stack. This is great for making sure your retainers are as compacted as possible."] = "查找雇员和角色中存在两个独立堆叠的物品，并尝试合并为一组。适合确保雇员库存尽可能紧凑。";
        d["Has the item been made unobtainable?"] = "物品是否已无法获取?";
        d["Has this gathering item been gathered at least once by the currently logged in character? This only supports mining and botany at present."] = "当前角色是否至少采集过一次该采集品？目前仅支持采矿和园艺。";
        d["Has this item be acquired by your active character?"] = "当前角色是否已获得该物品?";
        d["Have the recipes that make this item been completed?"] = "制作该物品的配方是否已完成?";
        d["How is this item gathered?"] = "该物品如何采集?";
        d["How long should we store the market prices for before refreshing from universalis?"] = "市场价格应保留多久后从 Universalis 刷新?";
        d["How many dyes does this item have or can it support?"] = "该物品有多少个染色槽?";
        d["How many materia does this item have or can it have?"] = "该物品有多少个魔晶石槽?";
        d["How many minutes should there be between each auto save?"] = "每次自动保存间隔多少分钟?";
        d["How many pixels high should each item row try to display at?"] = "每行物品显示多少像素高?";
        d["How much the item can be purchased from a vendor(gil)"] = "从NPC购买该物品的价格(金币)";
        d["Is the item a part of a gearset?"] = "物品是否在套装中?";
        d["Is the item collectable?"] = "物品是收藏品?";
        d["Is the item Collectible?"] = "物品是收藏品?";
        d["Is the item High Quality?"] = "物品是高品质?";
        d["Is the item stackable (can hold more than 1 in a stack)?"] = "物品可堆叠(一组可放多个)?";
        d["Is this item a favourite?"] = "该物品是收藏?";
        d["Is this item a housing item? This might be slightly inaccurate for the time being."] = "该物品是房屋物品？可能略有误差。";
        d["Is this item a Ishgardian Restoration craft item?"] = "该物品是伊修加德复兴制作物品?";
        d["Is this item available at a calmity salvager?"] = "该物品在灾厄商人处有售?";
        d["Is this item available at a ephemeral node?"] = "该物品来自限时采集点?";
        d["Is this item available at a hidden node?"] = "该物品来自隐藏采集点?";
        d["Is this item available at a timed node?"] = "该物品来自定时采集点?";
        d["Is this item dropped by mobs?"] = "该物品由怪物掉落?";
        d["Is this item dropped/acquired in a fate?"] = "该物品来自命运理符?";
        d["Is this item in your list of favourites?"] = "该物品在收藏列表中?";
        d["Is this item part of a gearset?"] = "该物品属于套装?";
        d["Is this item part of a glamour ready item?"] = "该物品属于幻化套装?";
        d["Is this item sold in the square store?"] = "该物品在商城出售?";
        d["Is this item the combined form of a outfit glamour set?"] = "该物品是幻化套装的合成形式?";
        d["Is this item used for custom deliveries?"] = "该物品用于自定义交付?";
        d["Is this item used for grand company supply missions?"] = "该物品用于军团补给任务?";
        d["Is this item used in a craft leve?"] = "该物品用于制作理符?";
        d["Makes the Tooltip Category Whitelist into a Blacklist if checked."] = "勾选后将提示分类白名单变为黑名单。";
        d["Override the ingredient source for specific items. Overrides set here take precedence over the list's default ingredient sourcing order."] = "覆盖特定物品的材料来源。此处的覆盖优先于清单的默认材料来源顺序。";
        d["Provides the gearsets that an item is part of."] = "显示物品所在的套装。";
        d["Searches by the name of the item."] = "按物品名称搜索。";
        d["Select craftable items and the filter will determine the ingredients used in the craft and will only list those ingredients. The add all from filter button will add all the items from the selected filter to the list."] = "选择可制作物品，过滤器将确定制作所需的材料并仅列出这些材料。「从过滤器全部添加」按钮会将所选过滤器的所有物品添加到清单。";
        d["Select the characters you want to search inside."] = "选择要搜索的角色。";
        d["Select the inventories you want to search inside."] = "选择要搜索的库存。";
        d["Set the layout of the craft window"] = "设置制作窗口布局";
        d["Set the layout of the items window"] = "设置物品窗口布局";
        d["Should all the items not matching the filter be highlighted instead? If set to N/A will use the 'Invert Highlighting' setting inside the general configuration."] = "是否高亮不匹配过滤器的物品？设为「无」则使用常规配置中的「反转高亮」设置。";
        d["Should each item in the list require a HQ version of the item(if applicable)?"] = "清单中每个物品是否需要高品质版本(如适用)?";
        d["Should items required by this list highlight NPCs that sell them?"] = "是否高亮出售清单所需物品的NPC?";
        d["Should price data be automatically downloaded when it's viewed in a list?"] = "在清单中查看时是否自动下载价格数据?";
        d["Should the currently active world be automatically priced?"] = "是否自动为当前世界定价?";
        d["Should the name of the retainer in the summoning bell list be coloured if a relevant item is to be sorted or is available in their inventory?"] = "在雇员召唤铃列表中，如有相关物品需整理或存在于雇员库存中，是否为雇员名称着色?";
        d["Should your character's home world be automatically priced?"] = "是否自动为角色本地世界定价?";
        d["Should your currently logged in character's active world be used as a pricing source?"] = "是否使用当前角色的世界作为定价来源?";
        d["Should your currently logged in character's home world be used as a pricing source?"] = "是否使用当前角色的本地世界作为定价来源?";
        d["Shows a button that links to gatherbuddy's /gather function."] = "显示链接到 GatherBuddy 的 /gather 功能的按钮。";
        d["Shows a button that opens the item's gathering/fishing log entry if applicable."] = "显示打开物品采集/钓鱼日志的按钮(如适用)。";
        d["Shows basic debug information"] = "显示基本调试信息";
        d["Shows craft debug information"] = "显示制作调试信息";
        d["Shows how long an item will be available to gather if it's already spawned, and when the next time an item will be available to gather"] = "显示物品可采集时长(如已刷新)及下次可采集时间";
        d["Shows if an item can be equipped by a specific gender."] = "显示物品是否可由特定性别装备。";
        d["Shows if an item can be equipped by a specific race."] = "显示物品是否可由特定种族装备。";
        d["Shows if the item belongs in the armoire."] = "显示物品是否属于装备柜。";
        d["Shows the character/retainer an item is located in."] = "显示物品所在的角色/雇员。";
        d["Shows the icon of the item, pressing it will open the more information window for the item."] = "显示物品图标，点击打开物品详情窗口。";
        d["Shows the item's internal ID."] = "显示物品的内部ID。";
        d["Shows the location of the item in your inventory."] = "显示物品在库存中的位置。";
        d["Shows the number of sales that have been made within X days."] = "显示X天内的销售数量。";
        d["Shows the patch in which the item was added."] = "显示物品添加的版本。";
        d["Shows the spiritbond % of the item."] = "显示物品的精炼度百分比。";
        d["Shows what class/job an item can be equipped by"] = "显示物品可由哪个职业装备";
        d["Shows where the item should be moved to or where the item was moved to in the case of a history filter."] = "显示物品应移至何处，或在历史过滤器中显示物品已移至何处。";
        d["Shows whether all requirements to craft this item (job level, mastery book, specialization) are met by the current character."] = "显示当前角色是否满足制作该物品的所有要求(职业等级、秘籍、专家)。";
        d["Shows you any items that sell for under 100 gil at shops."] = "显示商店售价低于100金的物品。";
        d["The amount required with inventory and external sources factored in/The amount required without inventory and external sources factored in."] = "计入库存和外部来源后的需求量/未计入库存和外部来源的需求量。";
        d["The amount that changed(if applicable)"] = "变化数量(如适用)";
        d["The amount this item can be sold to a vendor for(gil)."] = "该物品出售给NPC的价格(金币)。";
        d["The attribute to show"] = "要显示的属性";
        d["The buttons to display"] = "要显示的按钮";
        d["The category of the item."] = "物品的分类。";
        d["The category to use when in tool mode"] = "工具模式下使用的分类";
        d["The character to use"] = "要使用的角色";
        d["The color to set any items in the destination that match your source filter(assuming highlight destination duplicates is on)."] = "目标中匹配源过滤器的物品的着色(需开启高亮目标重复)。";
        d["The color to set the highlighted items to."] = "高亮物品的着色。";
        d["The color to set the highlighted tabs(that contain filtered items) to."] = "高亮标签(包含过滤物品)的着色。";
        d["The colour of the header text in the craft list."] = "制作清单标题文字的颜色。";
        d["The column to use to sort by default"] = "默认排序列";
        d["The current dye of the item"] = "物品当前染料";
        d["The current market pricing for the given item. "] = "给定物品的当前市场价格。";
        d["The direction to sort the list in by default."] = "清单默认排序方向。";
        d["The hotkey to toggle the configuration window."] = "切换配置窗口的快捷键。";
        d["The iLevel of the item."] = "物品的品级。";
        d["The item you've selected from the list of recommendations"] = "从推荐列表中选择的物品";
        d["The item's rarity."] = "物品的稀有度。";
        d["The job to recommend items for"] = "推荐物品的目标职业";
        d["The magical damage of the item"] = "物品的魔法伤害";
        d["The market board minimum price of the item. For this to work you need to have automatic pricing enabled and also note that any background price updates will not be evaluated until an event that refreshes the inventory occurs(this happens fairly often)."] = "物品的市场板最低价。需启用自动定价，后台价格更新需等待库存刷新事件才会生效。";
        d["The market board price of the item. For this to work you need to have automatic pricing enabled and also note that any background price updates will not be evaluated until an event that refreshes the inventory occurs(this happens fairly often)."] = "物品的市场板价格。需启用自动定价，后台价格更新需等待库存刷新事件才会生效。";
        d["The maximum amount of locations to list on the tooltip. This requires 'Display Amount Owned?' to be enabled."] = "提示中列出的最大位置数。需启用「显示拥有数量」。";
        d["The maximum stack size of the item."] = "物品的最大堆叠数。";
        d["The name of the item with the icon next to it."] = "物品名称(带图标)。";
        d["The name of the item."] = "物品名称。";
        d["The number of dyes the item has or supports."] = "物品的染色槽数。";
        d["The number of recipes the item is a component of."] = "该物品作为材料的配方数量。";
        d["The number of seals that are rewarded when handing this item in as an expert delivery."] = "作为专家交付物品时奖励的军票数。";
        d["The patch in which the item was added."] = "物品添加的版本。";
        d["The physical damage of the item"] = "物品的物理伤害";
        d["The price when bought from shops."] = "从商店购买的价格。";
        d["The quantity of the item."] = "物品的数量。";
        d["The reason the change occurred"] = "变化原因";
        d["The required level to equip the item."] = "装备该物品的需求等级。";
        d["The slot to fill"] = "要填充的槽位";
        d["The spirit bond of the item."] = "物品的精炼度。";
        d["The start level of items"] = "物品起始等级";
        d["The time it takes between each automatic attack while engaged with and in range of an enemy in seconds."] = "与敌人交战时每次自动攻击的间隔(秒)。";
        d["The total amount this item can be sold to a vendor for in gil(price * quantity)."] = "该物品出售给NPC的总价(单价*数量)。";
        d["The total market board price of the item(minimum price * quantity). For this to work you need to have automatic pricing enabled and also note that any background price updates will not be evaluated until an event that refreshes the inventory occurs(this happens fairly often)."] = "物品的市场板总价(最低价*数量)。需启用自动定价。";
        d["The total market board price of the item(price * quantity). For this to work you need to have automatic pricing enabled and also note that any background price updates will not be evaluated until an event that refreshes the inventory occurs(this happens fairly often)."] = "物品的市场板总价(价格*数量)。需启用自动定价。";
        d["The type of the item."] = "物品的类型。";
        d["The type of the venture"] = "探险类型";
        d["The type of ventures that the item can be acquired from"] = "可获取该物品的探险类型";
        d["The world for this column to display?"] = "该列显示的世界?";
        d["This is the colour of any text added to the item tooltip. You can give each tooltip module it's own colour by going into the tooltip's settings."] = "物品提示中添加文字的颜色。可在提示设置中为每个模块单独设置颜色。";
        d["What class is related to de-synthesising this item?"] = "哪个职业可分解该物品?";
        d["When adding information to tooltips, should we limit the items affected to these categories? If 'Tooltip Category Blacklist` is checked, this functionality will be reversed."] = "在提示中添加信息时，是否限制受影响的物品分类？如勾选「提示分类黑名单」则功能反转。";
        d["When did the historical inventory event happen?"] = "历史库存事件发生时间?";
        d["When displaying the items for a craft, if there are items to be retrieved should we display this before or after the shortfall is made up. If first is selected, it will make you retrieve items first, if last is selected, any missing items you'll need will have to be collected/purchased before the remainder will be shown for retrieval."] = "显示制作物品时，如有需取回的物品，是先显示取回还是先显示短缺。选择「先」则先取回物品，选择「后」则需先收集/购买短缺物品才会显示剩余取回。";
        d["When highlighting is turned on for a list, should it always be active or should it only be active when a column is being searched in"] = "清单启用高亮时，是始终激活还是仅在搜索列时激活";
        d["When recommending an item, what sources should be excluded?"] = "推荐物品时排除哪些来源?";
        d["When recommending an item, what sources should be used?"] = "推荐物品时使用哪些来源?";
        d["When searching for an item across the inventories AT knows about, which inventories should be searched?"] = "在 AT 已知的库存中搜索物品时，应搜索哪些库存?";
        d["When should the highlighting apply?"] = "何时应用高亮?";
        d["When showing the locations of the items you own in the tooltip, which inventories should be included in the search?"] = "在提示中显示拥有的物品位置时，应包含哪些库存?";
        d["When showing the unlock status on items, these characters will be displayed. Leave empty to display all characters."] = "在物品上显示解锁状态时显示这些角色。留空则显示所有角色。";
        d["When source acquisition icons are displayed, how should they be grouped?"] = "来源获取图标显示时如何分组?";
        d["When use acquisition icons are displayed, how should they be grouped?"] = "用途获取图标显示时如何分组?";
        d["Which classes can this equipment be equipped by?"] = "该装备可由哪些职业装备?";
        d["Which events should be tracked by the history module?"] = "历史模块应追踪哪些事件?";
        d["Which genders can this equipment be equipped by?"] = "该装备可由哪些性别装备?";
        d["Which inventories should be searched when determining how many coffer loot items you already own?"] = "确定已拥有多少宝箱战利品时应搜索哪些库存?";
        d["Which inventories should be searched when determining which outfit glamour set items you already own?"] = "确定已拥有哪些幻化套装物品时应搜索哪些库存?";
        d["Which quality of items should be counted?"] = "应计算哪种品质的物品?";
        d["Which races can this equipment be equipped by?"] = "该装备可由哪些种族装备?";
        d["Which source categories should this display?"] = "应显示哪些来源分类?";
        d["Which source types should this display?"] = "应显示哪些来源类型?";
        d["Which use types should this display?"] = "应显示哪些用途类型?";
        d["Will show any gear considered to be outdated. This will compare the item level of each item with the level of your classes. It will use the lowest level you have applicable to the weapon to determine if it's outdated. Any classes you do not have are not taken into consideration."] = "显示被认为过时的装备。将比较物品品级与你的职业等级，使用适用的最低等级判断是否过时。未拥有的职业不计入。";
        d["Modify each items craft settings in this column"] = "在此列中修改每个物品的制作设置";

        // ===== 帮助窗口文本 =====
        d["1. General"] = "1. 常规";
        d["2. Filter Basics"] = "2. 过滤器基础";
        d["3. Filtering"] = "3. 过滤";
        d["4. About"] = "4. 关于";
        d["Inventory Tracking:"] = "库存追踪:";
        d["Craft Planning:"] = "制作规划:";
        d["Item Information:"] = "物品信息:";
        d["Highlighting:"] = "高亮:";
        d["This is a very basic guide, for more information please see the wiki."] = "这是一个基本指南，更多信息请查看 Wiki。";
        d["Lists are the core way the plugin provides a way for you to view the items you are looking for or are attempting to sort."] = "清单是插件为您提供查看所需物品或整理物品的核心方式。";
        d["There are currently 3 types of list that can be created."] = "目前可创建3种类型的清单。";
        d["Search List"] = "搜索清单";
        d["This type of list allows you search for specific items across all your inventories. If you just need to find an item, but don't want help sorting it, this is the list type you want."] = "此类型清单允许您在所有库存中搜索特定物品。如果只需查找物品而不需整理，请使用此类型。";
        d["Example Usages:"] = "使用示例:";
        d["Sort Filter"] = "整理过滤器";
        d["This type of list builds on top of the 'Search List' but also lets you pick where you want the items to be sorted. It'll attempt to show you the most optimized plan for storing the items in the destinations you pick."] = "此类型在「搜索清单」基础上增加物品整理功能，会尝试显示最优的物品存放方案。";
        d["Game Item Filter"] = "游戏物品过滤器";
        d["This filter allows you search across all the items that exist within the game's catalogue of items."] = "此过滤器允许您搜索游戏中所有存在的物品。";
        d["Advanced Search/Filter Syntax:"] = "高级搜索/过滤语法:";
        d["About:"] = "关于:";
        d["Plugin Wiki: "] = "插件 Wiki: ";
        d["Found a bug?"] = "发现 Bug?";
        d["Track your inventories"] = "追踪您的库存";
        d["Plan your crafts"] = "规划您的制作";
        d["Provide information about items, monsters, duties and much more"] = "提供物品、怪物、副本等信息";
        d["Close & Open Main Window"] = "关闭并打开主窗口";

        // ===== 物品窗口文本 =====
        d["Item with the ID "] = "找不到ID为 ";
        d[" could not be found."] = " 的物品。";
        d["Desynth with "] = "分解职业: ";
        d["Acquired:"] = "已获得:";
        d["Sell to Vendor: "] = "出售NPC: ";
        d["Buy from Vendor: "] = "NPC购买: ";
        d["Buy from Calamity Salvager: "] = "灾厄商人购买: ";
        d["Add item to craft list - "] = "添加到制作清单 - ";
        d["Item ID: "] = "物品ID: ";
        d["No locations known."] = "无已知位置。";
        d["This item has been combined into a single outfit glamour item."] = "该物品已合并为单个幻化套装物品。";
        d["Shops: "] = "商店: ";
        d["Market Pricing"] = "市场价格";
        d["Ishgard Restoration"] = "伊修加德复兴";
        d["Mob Drops ("] = "怪物掉落 (";
        d["Shared Models ("] = "共享模型 (";
        d["Recipes - Item is a requirement ("] = "配方 - 物品是需求 (";
        d["Gathering ("] = "采集 (";
        d["Ventures ("] = "探险 (";
        d["Shops ("] = "商店 (";
        d["Owned ("] = "拥有 (";
        d["Sources ("] = "来源 (";
        d["Uses ("] = "用途 (";
        d["Rewards ("] = "奖励 (";
        d["Debug"] = "调试";

        // ===== 其他窗口文本 =====
        d["Submarine Exploration Point with the ID "] = "找不到ID为 ";
        d["Unlocked Via: "] = "解锁途径: ";
        d["Rank Required: "] = "需求等级: ";
        d["Level: "] = "等级: ";
        d["Duration: "] = "持续时间: ";
        d["Experience: "] = "经验值: ";
        d["Venture Cost: "] = "探险消耗: ";
        d["Average iLvl: "] = "平均品级: ";
        d["Duty ID: "] = "任务ID: ";
        d["List: "] = "清单: ";
        d["Refreshing: "] = "刷新中: ";
        d["Needs Refresh: "] = "需要刷新: ";
        d["Highlight?"] = "高亮?";
        d["Add Company Craft to List"] = "添加部队合建到清单";
        d["Total Cost NQ: "] = "NQ总成本: ";
        d["Total Cost HQ: "] = "HQ总成本: ";

        // ===== 杂项 =====
        d["When searching the following operators can be used to compare: "] = "搜索时可使用以下运算符: ";
        d[">, >=, <, <=, =, for numerical comparisons"] = ">, >=, <, <=, =, 用于数值比较";
        d["=, for exact comparisons"] = "=, 用于精确比较";
        d["!, for inequality comparisons"] = "!, 用于不等比较";
        d["||, search multiple expressions using OR"] = "||, 使用OR搜索多个表达式";
        d["&&, search multiple expressions using AND"] = "&&, 使用AND搜索多个表达式";

        // ===== 菜单项 =====
        d["Configuration"] = "配置";
        d["Changelog"] = "更新日志";
        d["Help"] = "帮助";
        d["Enable Verbose Logging"] = "启用详细日志";
        d["Generate Support Dump"] = "生成支持转储";
        d["Report a Issue"] = "报告问题";
        d["Ko-Fi"] = "Ko-Fi";
        d["Clear Search"] = "清除搜索";
        d["Teamcraft Format"] = "Teamcraft 格式";
        d["JSON Format"] = "JSON 格式";
        d["Paste List Contents"] = "粘贴清单内容";
        d["Clear List"] = "清空清单";
        d["New Craft List"] = "新建制作清单";
        d["New Craft List (Ephemeral)"] = "新建制作清单 (临时)";
        d["New Curated List"] = "新建精选清单";
        d["Tabs"] = "标签页";
        d["Sidebar"] = "侧边栏";
        d["Single"] = "单窗口";
        d["Export"] = "导出";
        d["Refresh All Prices"] = "刷新所有价格";
        d["Search List"] = "搜索清单";
        d["Sort List"] = "整理清单";
        d["Game Item List"] = "游戏物品清单";
        d["Curated List"] = "精选清单";
        d["History List"] = "历史清单";
        d["Export Current List (Share Code)"] = "导出当前清单 (分享码)";
        d["Import List (Share Code)"] = "导入清单 (分享码)";
        d["Add to new Craft List"] = "添加到新制作清单";
        d["Add to new Craft List (ephemeral)"] = "添加到新制作清单 (临时)";
        d["Craft List (All)"] = "制作清单 (全部)";
        d["Craft List (Outputs)"] = "制作清单 (成品)";
        d["Craft List (Precrafts)"] = "制作清单 (预制作)";
        d["Craft List (Gatherables)"] = "制作清单 (可采集)";
        d["Craft List (Missing Gatherables)"] = "制作清单 (缺少采集)";
        d["Retainer/Bag List"] = "雇员/背包清单";

        // ===== 窗口名称 =====
        d["Allagan Tools"] = "Allagan Tools";
        d["Allagan Tools - Configuration"] = "Allagan Tools - 配置";
        d["Allagan Tools - Crafts"] = "Allagan Tools - 制作";
        d["Allagan Tools - Help"] = "Allagan Tools - 帮助";
        d["Allagan Tools - Changelog"] = "Allagan Tools - 更新日志";
        d["Allagan Tools - Lists"] = "Allagan Tools - 清单";
        d["Allagan Tools - Filter"] = "Allagan Tools - 过滤器";
        d["Allagan Tools - Item"] = "Allagan Tools - 物品";
        d["Allagan Tools - Intro"] = "Allagan Tools - 介绍";
        d["Allagan Tools - Support Dump"] = "Allagan Tools - 支持转储";
        d["Allagan Tools - Teamcraft Import"] = "Allagan Tools - Teamcraft 导入";

        // ===== 配置窗口标签页 =====
        d["General"] = "常规";
        d["Lists"] = "清单";
        d["Tooltips"] = "提示";
        d["Context Menu"] = "右键菜单";
        d["Hotkeys"] = "快捷键";
        d["Windows"] = "窗口";
        d["Colors"] = "颜色";
        d["Advanced"] = "高级";
        d["Filters"] = "过滤器";
        d["Columns"] = "列";
        d["Craft Filters"] = "制作过滤器";
        d["Craft Columns"] = "制作列";
        d["Interfaces"] = "接口";

        // ===== 过滤器分类 =====
        d["Search Filters"] = "搜索过滤器";
        d["Display"] = "显示";
        d["Sorting"] = "整理";
        d["Source Filters"] = "来源过滤器";
        d["Highlighting"] = "高亮";
        d["Craft Lists"] = "制作清单";
        d["History"] = "历史";
        d["Game Item Filters"] = "游戏物品过滤器";
        d["Curated Lists"] = "精选清单";

        // ===== 其他通用字符串 =====
        d["Yes"] = "是";
        d["No"] = "否";
        d["N/A"] = "无";
        d["None"] = "无";
        d["All"] = "全部";
        d["Search..."] = "搜索...";
        d["Search"] = "搜索";
        d["Add"] = "添加";
        d["Remove"] = "移除";
        d["Edit"] = "编辑";
        d["Delete"] = "删除";
        d["Save"] = "保存";
        d["Load"] = "加载";
        d["Refresh"] = "刷新";
        d["Apply"] = "应用";
        d["OK"] = "确定";
        d["Enabled"] = "已启用";
        d["Disabled"] = "已禁用";
        d["Default"] = "默认";
        d["Custom"] = "自定义";
        d["Name"] = "名称";
        d["Type"] = "类型";
        d["Source"] = "来源";
        d["Sources"] = "来源";
        d["Uses"] = "用途";
        d["Quantity"] = "数量";
        d["Patch"] = "版本";
        d["Patch Added"] = "添加版本";
        d["Rarity"] = "稀有度";
        d["Stack Size"] = "堆叠数";
        d["Item Level"] = "品级";
        d["iLevel"] = "品级";
        d["Spirit Bond"] = "精炼度";
        d["Spiritbond"] = "精炼度";
        d["Dye Count"] = "染料数";
        d["Materia Count"] = "魔晶石数";
        d["Physical Damage"] = "物理伤害";
        d["Magical Damage"] = "魔法伤害";
        d["Delay"] = "延迟";
        d["Required Level"] = "需求等级";
        d["Recipe Total Count"] = "配方总数";
        d["Venture Type"] = "探险类型";
        d["Table Row Height"] = "表格行高";
        d["Freeze Columns"] = "冻结列";
        d["Highlight Colour"] = "高亮颜色";
        d["Highlight When?"] = "高亮时机";
        d["Highlight Destination Duplicates?"] = "高亮目标重复?";
        d["Highlight Empty Destination?"] = "高亮空目标?";
        d["Highlight NPCs?"] = "高亮NPC?";
        d["Invert Destination Highlighting?"] = "反转目标高亮?";
        d["Invert Highlighting?"] = "反转高亮?";
        d["Invert Tab Highlighting?"] = "反转标签高亮?";
        d["Tab Highlight Color"] = "标签高亮颜色";
        d["Tab Highlight Colour"] = "标签高亮颜色";
        d["Retainer List Color"] = "雇员列表颜色";
        d["Retainer List Colour"] = "雇员列表颜色";
        d["Window List Highlighting"] = "窗口清单高亮";
        d["Keep Background List Highlighting?"] = "保持后台清单高亮?";
        d["Retainer Retrieve Order"] = "雇员取回顺序";
        d["Retainer Selling Unit Price"] = "雇员出售单价";
        d["Sell to Vendor Price"] = "出售NPC价格";
        d["Sell to Vendor Price (Total)"] = "出售NPC总价";
        d["Market Board Average Price HQ"] = "市场板HQ均价";
        d["Market Board Average Price NQ"] = "市场板NQ均价";
        d["Market Board Average Price NQ/HQ"] = "市场板NQ/HQ均价";
        d["Market Board Minimum Price HQ"] = "市场板HQ最低价";
        d["Market Board Minimum Price NQ"] = "市场板NQ最低价";
        d["Market Board Minimum Price NQ/HQ"] = "市场板NQ/HQ最低价";
        d["Market Board Avg. Total Price"] = "市场板均价总价";
        d["Market Board Total Minimum Price"] = "市场板最低总价";
        d["Market Board Average Total Price(Qty * Price) NQ/HQ"] = "市场板NQ/HQ均价总价(数量*价格)";
        d["Market Board Minimum Total Price(Qty * Price) NQ/HQ"] = "市场板NQ/HQ最低总价(数量*价格)";
        d["Marketboard Avg. Price"] = "市场板均价";
        d["Marketboard Minimum Price"] = "市场板最低价";
        d["Marketboard Sale Counter"] = "市场板销售计数";
        d["Marketboard Sale History Days"] = "市场板销售历史天数";
        d["Keep market prices for X hours"] = "市场价格保留小时数";
        d["Price Active World?"] = "为当前世界定价?";
        d["Price Home World?"] = "为本地世界定价?";
        d["Price Worlds"] = "定价世界";
        d["World Price Preference"] = "世界价格偏好";
        d["Switch craft lists automatically?"] = "自动切换制作清单?";
        d["Switch lists automatically?"] = "自动切换清单?";
        d["Show 'All Lists' Tab?"] = "显示'所有清单'标签?";
        d["Show item number in retainer list?"] = "在雇员列表显示物品编号?";
        d["Limit to items on the current character?"] = "仅限当前角色物品?";
        d["Enable History Tracking?"] = "启用历史追踪?";
        d["Enable Tooltip Tweaks?"] = "启用提示修改?";
        d["Ignore HQ Filter?"] = "忽略HQ过滤?";
        d["Footer New Lines"] = "页脚换行";
        d["Header New Lines"] = "标题换行";
        d["Text Colour"] = "文字颜色";
        d["Notification Prefix"] = "通知前缀";
        d["Tooltip Category Whitelist"] = "提示分类白名单";
        d["Tooltip Category Blacklist"] = "提示分类黑名单";
        d["Context Menu - Add to Active Craft List"] = "右键菜单 - 添加到活动制作清单";
        d["Context Menu - Add to Craft List"] = "右键菜单 - 添加到制作清单";
        d["Context Menu - Open Crafting Log"] = "右键菜单 - 打开制作日志";
        d["Context Menu - Open Fishing Log"] = "右键菜单 - 打开钓鱼日志";
        d["Context Menu - Open Gathering Log"] = "右键菜单 - 打开采集日志";
        d["Context Menu - Search"] = "右键菜单 - 搜索";
        d["Open Crafting Log Hotkey"] = "打开制作日志快捷键";
        d["Open Fishing Log Hotkey"] = "打开钓鱼日志快捷键";
        d["Open Gathering Log Hotkey"] = "打开采集日志快捷键";
        d["Open Item Log Hotkey"] = "打开物品日志快捷键";
        d["Toggle Airships Window"] = "切换飞空艇窗口";
        d["Toggle Configuration Window"] = "切换配置窗口";
        d["Toggle Craft Window"] = "切换制作窗口";
        d["Toggle Duties Window"] = "切换任务窗口";
        d["Toggle Lists Window"] = "切换清单窗口";
        d["Toggle Mob Window"] = "切换怪物窗口";
        d["Toggle Retainer Ventures Window"] = "切换雇员探险窗口";
        d["Toggle Submarines Window"] = "切换潜水艇窗口";
        d["Craft Columns"] = "制作列";
        d["Craft Window Layout"] = "制作窗口布局";
        d["Items Window Layout"] = "物品窗口布局";
        d["Add Plugin Name"] = "添加插件名";
        d["Add Item Locations"] = "添加物品位置";
        d["Add Item Locations (Affix with Character Name)"] = "添加物品位置 (附角色名)";
        d["Add Item Locations (Display Mode)"] = "添加物品位置 (显示模式)";
        d["Add Item Locations (Max Results)"] = "添加物品位置 (最大结果数)";
        d["Add Item Locations (Order)"] = "添加物品位置 (排序)";
        d["Add Item Locations (Search Locations)"] = "添加物品位置 (搜索范围)";
        d["Add Item Unlock Status"] = "添加物品解锁状态";
        d["Add Item Unlock Status (Characters)"] = "添加物品解锁状态 (角色)";
        d["Add Market Average NQ/HQ Price"] = "添加市场NQ/HQ均价";
        d["Add Market Minimum NQ/HQ Price?"] = "添加市场NQ/HQ最低价?";
        d["Acquisition"] = "获取";
        d["Use Acquisition Icon Grouping"] = "用途获取图标分组";
        d["Use Information Configuration"] = "用途信息配置";
        d["Source Information Configuration"] = "来源信息配置";
        d["Character Scope Picker"] = "角色范围选择器";
        d["Inventory Scope"] = "库存范围";
        d["Inventory Location"] = "库存位置";
        d["Last Seen Date/Time"] = "最后见到日期/时间";
        d["Next Gather Uptime"] = "下次采集刷新";
        d["Name & Icon"] = "名称和图标";
        d["Name (Selector)"] = "名称 (选择器)";
        d["Total Quantity Available"] = "可用总数量";
        d["Quantity/Total Quantity Available"] = "数量/可用总数量";
        d["Add Amount to Retrieve"] = "添加取回数量";
        d["Gathered By?"] = "采集方式?";
        d["Is HQ?"] = "是高品质?";
        d["Is Collectable?"] = "是收藏品?";
        d["Is Collectible?"] = "是收藏品?";
        d["Is Dropped by Mobs?"] = "怪物掉落?";
        d["Is Stackable?"] = "可堆叠?";
        d["Is Part of Gearset?"] = "属于套装?";
        d["Equipped By (Class/Job)"] = "装备者 (职业)";
        d["Gear Sets"] = "套装";
        d["Desynth Class"] = "分解职业";
        d["Purchased with Currency"] = "购买货币";
        d["Is Leve(Craft) Item?"] = "制作理符物品?";
        d["Categories"] = "分类";
        d["Category (Basic)"] = "分类 (基本)";
        d["Category (Marketboard)"] = "分类 (市场板)";
        d["Market Board Categories"] = "市场板分类";
        d["Outdated Gear?"] = "过时装备?";
        d["Shortcuts"] = "快捷方式";
        d["Craft Columns"] = "制作列";
        d["Default Zone Order"] = "默认区域顺序";
        d["Zone"] = "区域";

        // ===== BulletText 帮助文本 =====
        d["Finding materials for a craft."] = "查找制作所需的材料。";
        d["Finding a housing item you put somewhere."] = "查找你放在某处的房屋物品。";
        d["Seeing how much an item you just picked up is worth."] = "查看刚拾取的物品价值。";
        d["Seeing if a specific item is already in your glamour chest or armoire."] = "检查特定物品是否已在幻象柜或装备柜中。";
        d["Checking your retainers equipment without actually going to a retainer bell."] = "无需前往雇员铃即可查看雇员装备。";
        d["Checking if any items you have can go into the armoire."] = "检查你拥有的物品是否可以放入装备柜。";
        d["Putting away materials after a craft and not having them double up."] = "制作后整理材料，避免重复堆叠。";
        d["Store items above a certain item level within your chocobo saddlebag for later."] = "将高于一定品级的物品存入陆行鸟鞍包备用。";
        d["Find items that are unique to your free company chest and put them there."] = "查找仅限部队箱的物品并放入其中。";
        d["Searching for glamours"] = "搜索幻化";
        d["Seeing what mounts/minions you haven't obtained"] = "查看尚未获得的坐骑/宠物";
        d["Tracking the prices of all the items within the game"] = "追踪游戏中所有物品的价格";
        d["You can now copy configurations between your craft lists."] = "现在可以在制作清单之间复制配置。";
        d["Two new columns have been added to your craft lists: 'Next Step' and 'Settings'."] = "制作清单中新增了两列: '下一步' 和 '设置'。";
        d["The 'Next Step' column provides guidance on what you should do next."] = "'下一步' 列提供下一步操作的指引。";
        d["The 'Settings' column allows you to configure item sourcing, retainer settings, and recipes."] = "'设置' 列允许配置物品来源、雇员设置和配方。";
        d["The update includes the following changes:"] = "本次更新包含以下变更:";
        d["You can now change groupings for crafts based on class or required crafting order."] = "现在可以按职业或制作顺序更改制作分组。";
        d["Retrievable items can be prioritized in their own group."] = "可取回的物品可以优先放在单独的组中。";
        d["Gatherable and purchasable items can be grouped by zone."] = "可采集和可购买的物品可以按区域分组。";
        d["Improved handling of items that can be purchased with seals, poetics, and scrip currencies."] = "改进了可用军票、诗学、票据购买的物品的处理。";
        d["You can customize these options further by clicking the pencil icon in the top right corner of a list."] = "点击清单右上角的铅笔图标可进一步自定义这些选项。";

        // ===== InputText 占位符 =====
        d["Start typing to search.."] = "输入以搜索..";
        d["Item"] = "物品";
        d["Addon Name"] = "插件名称";
        d["Component ID"] = "组件ID";
        d["Max Scan Size"] = "最大扫描大小";

        // ===== 配置向导 =====
        d["Open Help"] = "打开帮助";
        d["Continue"] = "继续";
        d["Close (and show next time the plugin loads)"] = "关闭 (下次加载插件时再显示)";
        d["Continue (and show on new features)"] = "继续 (有新功能时显示)";
        d["Continue (and never show the wizard again)"] = "继续 (不再显示向导)";
        d["Close (and never show the wizard again)"] = "关闭 (不再显示向导)";
        d["Previous"] = "上一步";
        d["Next"] = "下一步";
        d["Finish"] = "完成";

        // ===== 其他窗口 =====
        d["Save"] = "保存";
        d["Export Configuration to Clipboard"] = "导出配置到剪贴板";
        d["Drops"] = "掉落";
        d["Highlight?"] = "高亮?";
        d["Add Company Craft to List"] = "添加部队合建到清单";

        // ===== 源渲染器名称 =====
        d["Airship Drop"] = "飞空艇掉落";
        d["Aquarium"] = "水族箱";
        d["Armoire"] = "装备柜";
        d["Battle Leve"] = "战斗理符";
        d["Buddy"] = "宠物";
        d["Company Leve"] = "部队理符";
        d["Craft Leve"] = "制作理符";
        d["Craft Result"] = "制作结果";
        d["Craft Soul Crystal"] = "制作灵魂水晶";
        d["Custom Delivery"] = "自定义交付";
        d["Dungeon Boss Chest"] = "副本首领宝箱";
        d["Dungeon Boss Drop"] = "副本首领掉落";
        d["Dungeon Chest"] = "副本宝箱";
        d["Dungeon Drop"] = "副本掉落";
        d["Fate Shop"] = "命运商店";
        d["FCC Shop"] = "部队商店";
        d["Field Operation Coffer"] = "作战区域宝箱";
        d["Fishing"] = "钓鱼";
        d["Folklore Tome"] = "采集传说";
        d["Gardening Crossbreed"] = "园艺杂交";
        d["Gathering Leve"] = "采集理符";
        d["Gathering"] = "采集";
        d["GC Expert Delivery"] = "军团专家交付";
        d["GC Shop"] = "军团商店";
        d["GC Supply Duty"] = "军团补给任务";
        d["Gearset"] = "套装";
        d["Gil Shop"] = "金币商店";
        d["Glamour Ready Set"] = "幻化套装";
        d["Glamour Ready"] = "幻化就绪";
        d["House Vendor"] = "房屋商店";
        d["Job Soul Crystal"] = "职业灵魂水晶";
        d["Monster Drop"] = "怪物掉落";
        d["PvP Series"] = "PvP赛季";
        d["Quest"] = "任务";
        d["Relic Weapon"] = "专属武器";
        d["Secret Recipe Book"] = "秘籍";
        d["Skybuilder Hand In"] = "伊修加德复兴上交";
        d["Spearfishing"] = "鱼叉";
        d["Special Shop"] = "特殊商店";
        d["Stain"] = "染色";
        d["Supplement"] = "补充";
        d["Tool/Weapon"] = "工具/武器";
        d["Triple Triad"] = "九宫幻卡";

        // ===== 其他 =====
        d["Craft"] = "制作";
        d["Gather"] = "采集";
        d["Buy"] = "购买";
        d["Remove"] = "移除";
        d["Copy Item Name"] = "复制物品名";

        // ===== PluginCommands 命令帮助和错误消息 =====
        d["Shows the allagan tools items list window."] = "显示Allagan Tools的物品列表窗口.";
        d["Shows the allagan tools duties window."] = "显示Allagan Tools的任务/副本窗口.";
        d["Shows the allagan tools mobs window."] = "显示Allagan Tools的怪物窗口.";
        d["Shows the allagan tools npcs window."] = "显示Allagan Tools的NPC窗口.";
        d["Shows the allagan tools compendium window."] = "显示Allagan Tools的图鉴窗口.";
        d["Toggle a specific compendium list window."] = "切换显示特定的图鉴列表窗口.";
        d["Please enter the name of a compendium type, the following are available:\n"] = "请输入图鉴类型的名称，可用的类型如下：\n";
        d[" is not a valid compendium type."] = " 不是有效的图鉴类型.";
        d["Toggles the specified list's highlight on/off, turning off any other highlighting in the process."] = "开关指定列表的高亮显示，启用时会一并关闭其他所有高亮.";
        d["You must enter the name of an list."] = "您必须输入一个列表的名称.";
        d["Open/closes a window displaying the contents of a single list."] = "打开/关闭显示单个列表内容的窗口.";
        d["You must enter the name of a list."] = "您必须输入一个列表的名称.";
        d["Could not find a list with that name."] = "找不到该名称对应的列表";
        d["Opens the allagan tools crafts window"] = "打开Allagan Tools的制作窗口";
        d["Opens the allagan tools airships window"] = "打开Allagan Tools的飞空艇窗口";
        d["Opens the allagan tools submarines window"] = "打开Allagan Tools的潜水艇窗口";
        d["Opens the allagan tools retainer ventures window"] = "打开Allagan Tools的雇员探险窗口";
        d["Opens the allagan tools configuration window"] = "打开Allagan Tools的配置窗口";
        d["Opens the allagan tools help window"] = "打开Allagan Tools的帮助窗口";
        d["Opens the allagan tools debug window"] = "打开Allagan Tools的调试窗口";
        d["Clears the currently active highlighting. Pass in background or ui to turn off highlighting for the background and ui highlighting respectively."] = "清除当前所有激活的高亮显示。传入参数 background 可关闭背景高亮，传入 ui 可关闭界面元素的高亮.";
        d["Closes all list windows."] = "关闭所有列表窗口.";
        d["Closes all list windows and clears all active highlighting. Pass in background or ui to close just the background or ui highlighting respectively."] = "关闭所有列表窗口，同时清除当前所有激活的高亮显示。传入参数 background 可仅关闭背景高亮，传入 ui 可仅关闭界面元素的高亮.";
        d["Toggles the crafting overlay window."] = "切换制作覆盖窗口的显示状态.";
        d["Toggles the equipment recommendation window."] = "切换装备推荐窗口的显示状态.";
        d["Toggles the chocobo colour calculator window."] = "切换陆行鸟颜色计算器窗口的显示状态";
        d["Opens the more information window for a specific item. Provide the name of the item or the ID of the item."] = "打开特定物品的详细信息窗口。请提供物品名称或物品ID.";
        d["The item "] = "物品";
        d[" could not be found."] = " 不存在";

        // ===== FiltersWindow 菜单栏 =====
        d["File"] = "文件";
        d["Compendium"] = "指南";
        d["Copy List Contents"] = "复制清单内容";
        d["Add to Craft List"] = "添加到制作清单";
        d["Add to Curated List"] = "添加到精选清单";
        d["Add (Preconfigured)"] = "添加 (预设)";
        d["Import/Export"] = "导入/导出";
        d["Export Current List (Share Code)"] = "导出当前清单 (分享码)";
        d["Import List (Share Code)"] = "导入清单 (分享码)";
        d["Save to csv"] = "保存为 CSV";
        d["Are you sure you want to clear this curated list?"] = "确定要清空此精选清单吗？";
        d["The list's contents were copied to your clipboard."] = "清单内容已复制到剪贴板。";
        d["The contents of your clipboard could not be parsed."] = "无法解析剪贴板内容。";
        d["The contents of your clipboard were imported."] = "剪贴板内容已导入。";
        d["[CTRL] to open in a new window."] = "[Ctrl] 在新窗口中打开。";
        d["Compendium Viewer"] = "指南浏览器";
        d["Compendium is a WIP feature, expect more here soon!"] = "指南是开发中的功能，敬请期待！";

        // ===== PopupMenu - 设置菜单 =====
        d["Mob Window"] = "怪物窗口";
        d["Npcs Window"] = "NPC 窗口";
        d["Duties Window"] = "任务窗口";
        d["Airships Window"] = "飞艇窗口";
        d["Submarines Window"] = "潜水艇窗口";
        d["Retainer Ventures Window"] = "雇员探险窗口";
        d["Open the mobs window."] = "打开怪物窗口。";
        d["Open the npcs window."] = "打开 NPC 窗口。";
        d["Open the duties window."] = "打开任务窗口。";
        d["Open the airships window."] = "打开飞艇窗口。";
        d["Open the submarines window."] = "打开潜水艇窗口。";
        d["Open the retainer ventures window."] = "打开雇员探险窗口。";
        d["Open the help window."] = "打开帮助窗口。";

        // ===== PopupMenu - 添加列表菜单 =====
        d["This will create a new list that let's you search for specific items within your characters and retainers inventories."] = "创建一个新清单，用于在角色和雇员的背包中搜索特定物品。";
        d["This will create a new list that let's you search for specific items within your characters and retainers inventories then determine where they should be moved to."] = "创建一个新清单，用于在角色和雇员的背包中搜索特定物品，并决定它们应移动到哪里。";
        d["This will create a list that lets you search for all items in the game."] = "创建一个清单，用于搜索游戏中的所有物品。";
        d["This will create a list that lets you view historical data of how your inventory has changed."] = "创建一个清单，用于查看背包变化的历史数据。";
        d["This will create a list that lets you add individual items to it manually."] = "创建一个清单，用于手动添加单个物品。";

        // ===== PopupMenu - 筛选器右键菜单 =====
        d["Edit the filter."] = "编辑筛选器。";
        d["Duplicate the filter."] = "复制筛选器。";
        d["Move Left"] = "左移";
        d["Move Right"] = "右移";
        d["Move Up"] = "上移";
        d["Move Down"] = "下移";
        d["Move the filter left."] = "将筛选器左移。";
        d["Move the filter right."] = "将筛选器右移。";
        d["Move the filter up."] = "将筛选器上移。";
        d["Move the filter down."] = "将筛选器下移。";
        d["Duplicate"] = "复制";
        d["Are you sure you want to remove this filter?"] = "确定要移除此筛选器吗？";

        // ===== 其他聊天消息 =====
        d["Please enter the name of a compendium type, the following are available:\\n"] = "请输入指南类型的名称，可用的类型如下：\\n";
        d[" is not a valid compendium type."] = " 不是有效的指南类型。";
        d["You must enter the name of an list."] = "请输入列表名称。";
        d["You must enter the name of a list."] = "请输入列表名称。";
        d["Could not find a list with that name."] = "找不到该名称的列表。";
        d["Filter Configuration"] = "筛选器配置";
        d["New Search List"] = "新搜索清单";
        d["New Sort List"] = "新排序清单";
        d["New Game Item List"] = "新游戏物品清单";
        d["New History List"] = "新历史清单";
        d["New Curated List"] = "新精选清单";
        d["New Craft List"] = "新制作清单";

        // ===== 导入/导出消息 =====
        d["[Export] "] = "[导出] ";
        d["[Import] "] = "[导入] ";
        d["You must paste a list generated via the export function or that was shared with you before pressing ok."] = "请先粘贴通过导出功能生成或分享给你的清单，再点击确定。";
        d["The list was imported successfully."] = "清单导入成功。";
        d["Invalid data detected in import string. Please make sure this string is valid."] = "导入字符串中检测到无效数据，请确认字符串是否有效。";
        d["Please enter a valid share code for a list below and then hit ok to import it."] = "请在下方输入有效的清单分享码，然后点击确定导入。";

        // ===== FiltersWindow - 其他未翻译字符串 =====
        d["Filters Window"] = "物品窗口";
        d["Items"] = "物品";
        d["Filters"] = "物品";
        d["The contents of your clipboard could not be parsed."] = "无法解析剪贴板内容。";
        d["The curated list's contents were copied to your clipboard."] = "精选清单内容已复制到剪贴板。";
        d["Get started by adding a craft list by hitting the + button on the bottom left."] = "点击左下角的 + 按钮添加制作清单开始使用。";
        d["Clear the current search."] = "清除当前搜索。";
        d["Add a new list."] = "添加新清单。";
        d["Add a new list"] = "添加新清单";
        d["All Lists"] = "所有清单";
        d["General"] = "常规";
        d["Name: "] = "名称：";
        d["List Type: "] = "清单类型：";
        d["Search..."] = "搜索...";
        d["No results found"] = "未找到结果";
        d["You are currently editing the list's configuration. Press the tick on the right hand side to save configuration."] = "您正在编辑清单配置。点击右侧的对勾按钮保存配置。";
        d["Return to the filter."] = "返回筛选器。";
        d["When checked, any items matching the filter will be highlighted once you search in any of the columns."] = "勾选后，在任意列中搜索时，匹配筛选器的物品将被高亮显示。";
        d["When checked, any items matching the filter will be highlighted."] = "勾选后，匹配筛选器的物品将被高亮显示。";
        d["Toggles the add item side bar."] = "切换添加物品侧栏。";
        d["Edit the list's configuration."] = "编辑清单配置。";
        d["Refresh Market Prices"] = "刷新市场价格";
        d["Pending Market Requests: "] = "待处理的市场请求：";
        d["Open the configuration window."] = "打开配置窗口。";
        d["Open the craft window."] = "打开制作窗口。";
        d["Are you sure you want to clear all your stored history?"] = "确定要清除所有存储的历史记录吗？";
        d["Clear your history."] = "清除历史记录。";
        d[" items"] = " 个物品";
        d[" historical records"] = " 条历史记录";
        d["History tracking is currently disabled"] = "历史记录跟踪当前已禁用";
        d["No List"] = "无清单";
        d["New Craft List (Ephemeral)"] = "新制作清单 (临时)";
        d["Export Configuration to Clipboard"] = "导出配置到剪贴板";

        // ===== 窗口名称 =====
        d["Allagan Tools"] = "Allagan Tools";
        d["Generate Support Dump"] = "生成支持转储";
        d["Invalid Submarine Exploration"] = "无效的潜水艇探索";
        d["Submarines"] = "潜水艇";
        d["Allagan Tools - Invalid Retainer Task"] = "Allagan Tools - 无效雇员任务";
        d["Retainer Ventures"] = "雇员探险";
        d["Invalid Item"] = "无效物品";
        d["Invalid List"] = "无效清单";
        d["Invalid NPC"] = "无效 NPC";
        d["Items"] = "物品";
        d["Duties"] = "任务";
        d["Configuration Wizard"] = "配置向导";
        d["Configuration"] = "配置";
        d["Crafts"] = "制作";
        d["Help"] = "帮助";
        d["NPCs"] = "NPC";
        d["Mobs"] = "怪物";
        d["Airship"] = "飞艇";
        d["Duty"] = "任务";
        d["Sources"] = "来源";
        d["Chocobo Colour Calculator"] = "陆行鸟颜色计算器";
        d["Configuration Wizard"] = "配置向导";

        // ===== GenericName =====
        d["Filters"] = "物品";
        d["Mob"] = "怪物";

        // ===== HoverTooltip (ItemWindow) =====
        d["Open in Garland Tools"] = "在 Garland Tools 中打开";
        d["Open in Teamcraft"] = "在 Teamcraft 中打开";
        d["Open in Universalis"] = "在 Universalis 中打开";
        d["Open in Gamer Escape"] = "在 Gamer Escape 中打开";
        d["Open in Console Games Wiki"] = "在 Console Games Wiki 中打开";
        d["Craftable - Open in Craft Log"] = "可制作 - 打开制作日志";
        d["Craftable - Add to Craft List"] = "可制作 - 添加到制作清单";
        d["Gatherable - Open in Gathering Log"] = "可采集 - 打开采集日志";
        d["Gatherable - Gather with Gatherbuddy"] = "可采集 - 使用 GatherBuddy 采集";
        d["Gatherable - Open in Fishing Log"] = "可采集 - 打开钓鱼日志";
        d["Refresh the current prices."] = "刷新当前价格。";

        // ===== HoverTooltip (FilterWindow) =====
        d["Export to CSV"] = "导出为 CSV";
        d["Open the items window."] = "打开物品窗口。";

        // ===== HoverTooltip (CraftsWindow) =====
        d["Add a new craft list."] = "添加新制作清单。";
        d["Add a new ephemeral craft list that will be deleted once all the items in it are completed."] = "添加一个临时制作清单，所有物品完成后将自动删除。";
        d["Add a new craft list"] = "添加新制作清单";
        d["When checked, any items you need to retrieve from external sources will be highlighted."] = "勾选后，需要从外部来源获取的物品将被高亮显示。";
        d["Hide any precrafts/gather/buy items once completed?"] = "完成后隐藏前置制作/采集/购买物品？";
        d["Shows missing requirements for the current craft list."] = "显示当前制作清单的缺失需求。";
        d["Edit the craft list's configuration."] = "编辑制作清单配置。";
        d["Toggle the current craft list."] = "切换当前制作清单。";
        d["Open the craft list's tree view."] = "打开制作清单树视图。";
        d["This is the craft list that finished crafts will count towards."] = "完成的制作将计入此制作清单。";
        d["This is the ephemeral craft list, once all items in it are completed, the list will delete itself."] = "这是临时制作清单，所有物品完成后将自动删除。";
        d["Return to the craft list."] = "返回制作清单。";
        d["Reset craft list to default configuration (keeps items)."] = "将制作清单重置为默认配置（保留物品）。";
        d["Reset to the default settings."] = "重置为默认设置。";
        d["Copy existing filter's settings"] = "复制现有筛选器设置";

        // ===== HoverTooltip (ConfigurationWindow) =====
        d["Add a sample filter"] = "添加示例筛选器";
        d["Start configuration wizard."] = "启动配置向导。";

        // ===== CraftsWindow 菜单 =====
        d["Copy List Contents (JSON)"] = "复制清单内容 (JSON)";
        d["New Craft List (Ephemeral)"] = "新制作清单 (临时)";
        d["Add From Game"] = "从游戏中添加";
        d["Craftable only"] = "仅可制作";
        d["Default Configuration"] = "默认配置";
        d["Are you sure you want to reset your configuration to the default?"] = "确定要将配置重置为默认值吗？";
        d["OK"] = "确定";
        d["The retainer/bag were copied to your clipboard."] = "雇员/背包内容已复制到剪贴板。";
        d["The contents of your clipboard were imported."] = "剪贴板内容已导入。";

        // ===== ItemWindow =====
        d["Housing Vendor"] = "房屋商人";
        d["Base"] = "基础";
        d["Mid"] = "中级";
        d["High"] = "高级";
        d["Could not open the crafting log, you are currently crafting."] = "无法打开制作日志，您正在制作中。";

        // ===== HelpWindow =====
        d["The plugin will do it's best to keep track of your inventories. Some inventories are only cached when they are first accessed. If you aren't seeing your retainer/free company/glamour chest/etc then please be sure to view them first otherwise the plugin will not be able to cache them."] = "插件会尽最大努力跟踪您的库存。某些库存仅在首次访问时才会被缓存。如果您没有看到雇员/部队箱/幻化柜等，请先在游戏中查看它们，否则插件无法缓存。";
        d["Once the plugin knows about the items, you can create lists to narrow down searches for specific items, help you sort the items and a myriad of other things."] = "一旦插件了解了您的物品，您可以创建清单来缩小特定物品的搜索范围，帮助排序物品以及各种其他功能。";
        d["The plugin has a dedicated crafts window that lets you create lists of items you want to craft. It'll create a plan that breaks each item down into it's individual parts and will tell you what you're missing. It'll tell you where everything you need is and if you are missing anything, it'll direct you to the place to find/buy the missing items."] = "插件有专门的制作窗口，可以创建要制作的物品清单。它会创建一个计划，将每个物品分解为各个组件，并告诉您缺少什么。它会告诉您所需物品的位置，如果缺少任何东西，它会引导您找到/购买缺少的物品。";
        d["If you've ever used Teamcraft, you should be right at home."] = "如果您用过 Teamcraft，会觉得非常熟悉。";
        d["The plugin has a fairly comprehensive database of information about each item. If you've used garland tools, the information provided is very similar. Clicking on an item's icon within the plugin will always open the item's information window."] = "插件有相当全面的物品信息数据库。如果您用过 Garland Tools，提供的信息非常相似。点击插件内物品的图标总是会在物品信息窗口中打开。";
        d["When using either an item list or a craft list, you can toggle highlighting. This will highlight the items in game so that you can see exactly where the items are. When the plugins windows are active, you can hit the 'Highlight' checkbox to activate highlighting for that list. If you want to trigger this with a macro, please have a look at the commands section of help, you can toggle 'background' highlighting."] = "使用物品清单或制作清单时，您可以切换高亮显示。这将在游戏中高亮显示物品，让您可以准确看到物品的位置。当插件窗口处于活动状态时，您可以点击「高亮」复选框来激活该清单的高亮。如果您想通过宏来触发，请查看帮助中的命令部分，您可以切换「后台」高亮。";

        // ===== IntroWindow =====
        d["Welcome to Allagan Tools."] = "欢迎使用 Allagan Tools。";

        // ===== ConfigurationWizard =====
        d["Welcome back to the Allagan Tools configuration wizard."] = "欢迎回到 Allagan Tools 配置向导。";
        d["Welcome to the Allagan Tools configuration wizard."] = "欢迎使用 Allagan Tools 配置向导。";
        d["If this is your first time using Allagan Tools, I'd recommend opening the help window and reading the General section. It gives you a run down of what the plugin can do."] = "如果您是首次使用 Allagan Tools，建议打开帮助窗口并阅读「常规」部分。它会介绍插件的功能。";
        d["If you are a returning user feel free to close this window."] = "如果您是老用户，可以直接关闭此窗口。";

        // ===== ConfigurationWindow =====
        d["There are no new settings available to configure."] = "没有可配置的新设置。";
        d["Wizard"] = "向导";

        // ===== SupportDumpWindow =====
        d["Failed to generate the support dump. Please check your Dalamud log for details."] = "生成支持转储失败。请查看 Dalamud 日志了解详情。";

        // ===== ChocoboColourWindow =====
        d["Han Lemon"] = "瀚宇柠檬";

        // ===== CraftOverlayWindow 表头 =====
        d["Step"] = "步骤";
        d["Bell"] = "铃";
        d["Action"] = "操作";
        d["Icon"] = "图标";

        // ===== RetainerTaskWindow =====
        d[" - Venture"] = " - 探险";

        // ===== CraftsWindow - PopupMenu 右键菜单 =====
        d["Edit the craft list."] = "编辑制作清单。";
        d["Duplicate the craft list."] = "复制制作清单。";
        d["Move the craft list left."] = "将制作清单左移。";
        d["Move the craft list right."] = "将制作清单右移。";
        d["Move the craft list up."] = "将制作清单上移。";
        d["Move the craft list down."] = "将制作清单下移。";
        d["Are you sure you want to remove this craft list?"] = "确定要移除此制作清单吗？";
        d["Remove the craft list."] = "移除制作清单。";
        d["Are you sure you want to clear your craft list?"] = "确定要清空此制作清单吗？";
        d["Are you sure you want to reset the default craft list?.\nThis operation cannot be undone!\n\n"] = "确定要重置默认制作清单吗？\n此操作无法撤销！\n\n";

        // ===== 窗口名称补充 =====
        d["Unknown Mob"] = "未知怪物";
        d["Unknown Airship Point"] = "未知飞艇坐标";
        d["Invalid Duty"] = "无效任务";
        d["Airships"] = "飞艇";

        // ===== 其他未翻译字符串 =====
        d["Shared Models"] = "共享模型";
        d["Unknown Content Type"] = "未知内容类型";
        d["Unknown Boss"] = "未知首领";
        d["Unknown Retainer"] = "未知雇员";
        d["Unknown Craft Type"] = "未知制作类型";
        d[" - Fight "] = " - 战斗 ";

        // ===== DutyWindow =====
        d["Dungeon with the ID "] = "副本ID：";
        d[" could not be found."] = " 不存在。";
        d["Level Required: "] = "等级要求：";
        d["Item Level Required: "] = "品级要求：";
        d["Coffer "] = "宝箱 ";
        d["Other Chests ("] = "其他宝箱 (";
        d["Rewards ("] = "奖励 (";
        d["Debug"] = "调试";
        d["Duty ID: "] = "任务ID：";
        d["Name"] = "名称";

        // ===== CraftsWindow - 聊天消息 =====
        d["The craft list's contents were copied to your clipboard."] = "制作清单内容已复制到剪贴板。";
        d["The craft list's outputs were copied to your clipboard."] = "制作清单产出已复制到剪贴板。";
        d["The craft list's gatherables were copied to your clipboard."] = "制作清单可采集物已复制到剪贴板。";
        d["This will paste the contents of items copied via the 'Copy List Contents' menu above, it also will attempt to parse Teamcraft lists if one is in your clipboard. If you have a garland tools URL in your clipboard that points to a group, it will also attempt to parse that add it to your craft list."] = "这将粘贴通过上方「复制清单内容」菜单复制的物品内容，也会尝试解析剪贴板中的 Teamcraft 清单。如果剪贴板中有指向群组的 Garland Tools URL，也会尝试解析并添加到制作清单中。";
        d["This is the default configuration for new craft lists. Any new craft list will inherit this lists settings."] = "这是新制作清单的默认配置。任何新制作清单都将继承此清单的设置。";
        d["You are currently editing default craft list configuration."] = "您正在编辑默认制作清单配置。";
        d["You are currently editing the craft list's configuration. Press the tick on the right hand side to save configuration."] = "您正在编辑制作清单配置。点击右侧的对勾按钮保存配置。";
        d["To Craft"] = "待制作";
        d["Items in Retainers/Bags"] = "雇员/背包中的物品";
        d["New: Missing Requirements"] = "新功能：缺失需求";
        d["This button turns red when your craft list contains items that require unlocks you don't have (recipe books, folklore tomes, job levels). Click it to see exactly what you're missing."] = "当制作清单中包含需要您尚未解锁的内容（配方书、采集传说、职业等级）时，此按钮会变红。点击查看具体缺少什么。";

        // ===== TeamCraftImportWindow =====
        d["Import to Craft List: "] = "导入到制作清单：";
        d["Guide to importing lists.\r\n\r\n"] = "导入清单指南。\r\n\r\n";
        d["Step 1. Open a list on Teamcraft with the items you wish to craft.\r\n\r\n"] = "步骤 1. 在 Teamcraft 中打开包含您想制作的物品的清单。\r\n\r\n";
        d["Step 2. Find the 'Items' \"Copy as Text\" button. You only want to copy the output items.\r\n\r\n"] = "步骤 2. 找到「物品」下的「复制为文本」按钮。只需复制产出物品。\r\n\r\n";
        d["Step 3. Paste into the text box below in this window.\r\n\r\n"] = "步骤 3. 粘贴到此窗口下方的文本框中。\r\n\r\n";
        d["Step 4. Click import."] = "步骤 4. 点击导入。";

        // ===== SupportDumpWindow =====
        d["Only press this if you have been instructed to, it will generate a zip file containing your inventory, the allagan tools configuration, and your logs. If you are attempting to provide this information to help fix a bug, turn on Verbose Logging in File, replicate the bug and then generate this dump. Proceed?"] = "仅在收到指示时才点击此按钮，它将生成一个包含您的库存、Allagan Tools 配置和日志的 zip 文件。如果您想提供此信息来帮助修复错误，请先在「文件」菜单中开启详细日志，复现错误然后生成此转储。继续吗？";
        d["Save support dump"] = "保存支持转储";

        // ===== RetainerTasksWindow =====
        d["Average iLvl"] = "平均品级";

        // ===== IntroWindow =====
        d["You can open various new windows using command shortcuts(the main filter  or from the main window."] = "您可以使用命令快捷方式（主筛选器）或从主窗口打开各种新窗口。";
        d["If you're unsure, right-click on an item or a table row for more options!"] = "如果不确定，右键点击物品或表格行获取更多选项！";
        d["To learn about the different features, I recommend going to the settings section and reading the information provided by the ? icons."] = "要了解不同功能，建议前往设置部分并阅读 ? 图标提供的信息。";

        // ===== ItemWindow =====
        d["This is a vendor that can be placed inside your house/apartment."] = "这是一个可以放置在房屋/公寓内的商人。";

        // ===== CraftsWindow - Universalis 错误提示 =====
        d["There was an error when contacting Universalis at "] = "联系 Universalis 时出错，时间：";
        d[". This likely means Universalis is having issues. Allagan Tools will back off requests for 30 seconds whenever this happens."] = "。这很可能意味着 Universalis 遇到了问题。发生这种情况时，Allagan Tools 将暂停请求 30 秒。";
        d["It appears you are sending too many requests to Universalis, if you have multiple plugins requesting marketboard data, this is the most likely cause."] = "您似乎向 Universalis 发送了过多请求，如果您有多个插件请求市场数据，这很可能是原因。";

        // ===== List Type 补充 =====
        d["List Type: "] = "清单类型：";
        d["Save to csv"] = "保存为 CSV";

        // ===== HelpWindow =====
        d["Allagan Tools is a mult-purpose plugin providing 3 primary features, tracking/displaying your inventory data, helping you plan crafts and providing information about items. There are other features, and they are covered in 'Features'"] = "Allagan Tools 是一个多功能插件，提供三大主要功能：跟踪/显示您的库存数据、帮助您规划制作以及提供物品信息。还有其他功能，在「功能」部分有介绍。";
        d["If you've used Teamcraft or Garland Tools, it takes some inspiration from both."] = "如果您用过 Teamcraft 或 Garland Tools，它从两者中汲取了灵感。";
        d["When creating a list or when searching through the results of a list it is possible to use a series of operators to make your search more specific. The available operators are dependant on what you searching against but at present support for !, <, >, >=, <=, = is present."] = "创建清单或搜索清单结果时，可以使用一系列运算符使搜索更精确。可用运算符取决于您搜索的内容，但目前支持 !, <, >, >=, <=, =。";
        d["! - Show any results that do not contain what is entered - available for text and numbers."] = "! - 显示不包含输入内容的任何结果 - 适用于文本和数字。";
        d["< - Show any results that have a value less than what is entered - available for numbers."] = "< - 显示值小于输入内容的任何结果 - 适用于数字。";
        d["> - Show any results that have a value greater than what is entered - available for numbers."] = "> - 显示值大于输入内容的任何结果 - 适用于数字。";
        d[">= - Show any results that have a value greater than or equal to what is entered - available for numbers."] = ">= - 显示值大于或等于输入内容的任何结果 - 适用于数字。";
        d["<= - Show any results that have a value less than or equal to what is entered - available for numbers."] = "<= - 显示值小于或等于输入内容的任何结果 - 适用于数字。";
        d["= - Show any results that have a value equal to what is entered - available for text and numbers."] = "= - 显示值等于输入内容的任何结果 - 适用于文本和数字。";
        d["This plugin is written in some of the free time that I have, it's a labour of love and I will hopefully be actively releasing updates for a while."] = "这个插件是在我的业余时间编写的，这是一项出于热爱的项目，希望能持续发布更新。";
        d["If you run into any issues please submit feedback via the plugin installer feedback button."] = "如果遇到任何问题，请通过插件安装器的反馈按钮提交反馈。";

        // ===== ConfigurationWindow - PopupMenu =====
        d["New Sort Filter"] = "新排序筛选器";

        // ===== ConfigurationWizard =====
        d["There are new features available to configure and you elected to show this window when that occurs."] = "有新功能可以配置，您选择了在出现新功能时显示此窗口。";
        d["This will guide you through the setup of the most commonly used features. This wizard, with your permission will show itself again when a new feature gets released as features are normally left for the user to configure and activate."] = "这将引导您完成最常用功能的设置。在您的许可下，当新功能发布时，此向导会再次显示，因为功能通常留给用户自行配置和激活。";

        // ===== CraftOverlayWindow =====
        d["Open the Allagan Tools crafts window."] = "打开 Allagan Tools 制作窗口。";
        d["Open the Allagan Tools configuration window."] = "打开 Allagan Tools 配置窗口。";
        d["Toggle highlighting."] = "切换高亮显示。";
        d["Select active craft list"] = "选择活动制作清单";

        // ===== SupportDumpWindow - 插值消息 =====
        d["Support dump saved to "] = "支持转储已保存到 ";
        d["The following files could not be included in the support dump: "] = "以下文件无法包含在支持转储中：";

        return d;
    }

    /// <summary>
    /// 将英文字符串翻译为中文。如果字典中不存在，返回原字符串。
    /// </summary>
    public static string Tr(this string? text)
    {
        if (string.IsNullOrEmpty(text)) return text ?? string.Empty;
        return Translations.TryGetValue(text, out var translated) ? translated : text;
    }
}
