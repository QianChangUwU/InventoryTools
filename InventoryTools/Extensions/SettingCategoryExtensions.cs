using InventoryTools.Logic.Settings.Abstract;
using InventoryTools.Services;

namespace InventoryTools.Extensions
{
    public static class SettingCategoryExtensions
    {
        public static string FormattedName(this SettingCategory settingCategory)
        {
            switch (settingCategory)
            {
                case SettingCategory.General:
                    return "General".Tr();
                case SettingCategory.Visuals:
                    return "Visuals".Tr();
                case SettingCategory.MarketBoard:
                    return "Marketboard".Tr();
                case SettingCategory.CraftOverlay:
                    return "Craft Overlay".Tr();
                case SettingCategory.CraftTracker:
                    return "Craft Tracker (Legacy)".Tr();
                case SettingCategory.ToolTips:
                    return "Tooltips".Tr();
                case SettingCategory.Hotkeys:
                    return "Hotkeys".Tr();
                case SettingCategory.History:
                    return "History".Tr();
                case SettingCategory.Windows:
                    return "Windows".Tr();
                case SettingCategory.Lists:
                    return "Lists".Tr();
                case SettingCategory.ContextMenu:
                    return "Context Menu".Tr();
                case SettingCategory.MobSpawnTracker:
                    return "Mob Spawn Tracker".Tr();
                case SettingCategory.TitleMenuButtons:
                    return "Title Menu Button".Tr();
                case SettingCategory.AutoSave:
                    return "Auto Save".Tr();
                case SettingCategory.Items:
                    return "Items".Tr();
                case SettingCategory.Highlighting:
                    return "Highlighting".Tr();
                case SettingCategory.EquipmentRecommendation:
                    return "Equipment Recommendations".Tr();
            }
            return settingCategory.ToString();
        }
    }
}