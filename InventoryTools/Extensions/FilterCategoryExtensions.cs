using System;
using InventoryTools.Logic.Filters;
using InventoryTools.Services;

namespace InventoryTools.Extensions;

public static class FilterCategoryExtensions
{
    public static string FormattedName(this FilterCategory filterCategory)
    {
        return filterCategory switch
        {
            FilterCategory.SourceCategories => "Source (Categories)".Tr(),
            FilterCategory.UseCategories => "Use (Categories)".Tr(),
            _ => filterCategory.ToString().ToSentence().Tr()
        };
    }
}