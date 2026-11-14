using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading;
using System.Threading.Tasks;
using AllaganLib.Shared.Extensions;
using Autofac.Features.OwnedInstances;
using DalaMock.Host.Mediator;
using Dalamud.Bindings.ImGui;
using Dalamud.Interface.Utility.Raii;
using Dalamud.Plugin.Services;
using InventoryTools.Compendium.Interfaces;
using InventoryTools.Compendium.Models;
using InventoryTools.Compendium.Services;
using InventoryTools.Logic;
using InventoryTools.Mediator;
using InventoryTools.Services;
using InventoryTools.Ui;
using Microsoft.Extensions.Logging;
using Serilog.Events;

namespace InventoryTools.Compendium.Windows;

public class CompendiumListWindow : CompendiumWindow
{
    private readonly WindowState _windowState;
    private readonly CompendiumSectionStateService _sectionStateService;
    private SectionState? _sectionState;
    private Task<SectionState>? _sectionStateTask;
    private readonly ICompendiumType _compendiumType;
    private readonly IPluginLog _pluginLog;
    private readonly IEnumerable<IMenuWindow> _menuWindows;
    private readonly IEnumerable<ICompendiumType> _compendiumTypes;
    private readonly Lazy<ICompendiumTable<WindowState, MessageBase>> _table;
    private ICompendiumGrouping? _compendiumGrouping = null;
    private List<KeyValuePair<object, string>>? _compendiumTabs = null;
    private object? _currentTab = null;
    private bool _defaultGroupSet = false;

    private object? _pendingTab = null;

    private object? _lastFollowedGroup = null;

    public delegate Owned<CompendiumListWindow> Factory(ICompendiumType compendiumType);

    public CompendiumListWindow(ILogger<CompendiumListWindow> logger, WindowState windowState, CompendiumSectionStateService sectionStateService, MediatorService mediator, ImGuiService imGuiService, InventoryToolsConfiguration configuration, ICompendiumType compendiumType, IPluginLog pluginLog, IEnumerable<IMenuWindow> menuWindows, IEnumerable<ICompendiumType> compendiumTypes) : base(logger, mediator, imGuiService, configuration, compendiumType.Plural + " Window")
    {
        _windowState = windowState;
        _sectionStateService = sectionStateService;
        _compendiumType = compendiumType;
        _pluginLog = pluginLog;
        _menuWindows = menuWindows;
        _compendiumTypes = compendiumTypes.Where(c => c.ShowInListing).OrderBy(c => c.Plural);
        _table = new Lazy<ICompendiumTable<WindowState, MessageBase>>(
            compendiumType.BuildTable,
            LazyThreadSafetyMode.PublicationOnly);
        Flags = ImGuiWindowFlags.MenuBar;
    }

    private List<KeyValuePair<object, string>>? GetTabs(ICompendiumGrouping compendiumGrouping)
    {
        return _compendiumType.GetGroups(compendiumGrouping)?.OrderBy(k => k.Value).ToList();
    }

    private string? GetSavedGrouping()
    {
        return ((AllaganLib.Interface.FormFields.IConfigurable<string?>)_sectionState!).Get("grouping");
    }

    private void SetSavedGrouping(string? newGrouping)
    {
        _sectionState?.Set("grouping", newGrouping);
    }

    private string GetFollowKey(ICompendiumGrouping grouping)
    {
        return "follow_current_group_" + grouping.Key;
    }

    private bool IsFollowingCurrentGroup(ICompendiumGrouping grouping)
    {
        return ((AllaganLib.Interface.FormFields.IConfigurable<string?>)_sectionState!).Get(GetFollowKey(grouping)) == "true";
    }

    private void SetFollowingCurrentGroup(ICompendiumGrouping grouping, bool follow)
    {
        _sectionState?.Set(GetFollowKey(grouping), follow ? "true" : null);
    }

    private bool HasTab(object groupKey)
    {
        return _compendiumTabs?.Any(c => Equals(c.Key, groupKey)) ?? false;
    }

    private void UpdateFollowedGroup()
    {
        if (_compendiumGrouping?.CurrentGroupFunc == null || !IsFollowingCurrentGroup(_compendiumGrouping))
        {
            return;
        }

        var currentGroup = _compendiumGrouping.CurrentGroupFunc();
        if (currentGroup != null && !Equals(currentGroup, _lastFollowedGroup))
        {
            _lastFollowedGroup = currentGroup;
            _pendingTab = currentGroup;
        }
    }

    public override void DrawWindow()
    {
        if (_sectionState == null)
        {
            if (_sectionStateTask == null)
            {
                _sectionStateTask = _sectionStateService.GetState(_compendiumType, CompendiumSectionType.List);
            }

            if (_sectionStateTask.IsCompleted)
            {
                _sectionState = _sectionStateTask.Result;
                _sectionStateTask = null;
            }

            if (_sectionState == null)
            {
                return;
            }
        }

        DrawMenuBar();

        if (!_defaultGroupSet)
        {
            _defaultGroupSet = true;
            var savedGrouping = GetSavedGrouping();
            var groupings = _compendiumType.GetGroupings();
            if (groupings != null)
            {
                if (savedGrouping != null)
                {
                    _compendiumGrouping = groupings.FirstOrDefault(c => c.Key == savedGrouping);
                }

                var defaultGrouping = _compendiumType.GetDefaultGrouping();
                if (_compendiumGrouping == null && defaultGrouping != string.Empty)
                {
                    _compendiumGrouping = groupings.FirstOrDefault(c => c.Key == defaultGrouping);
                }
            }
        }

        if (_compendiumGrouping == null)
        {
            MediatorService.Publish(_table.Value.Draw(_windowState, new Vector2(0, 0)));
        }
        else
        {
            UpdateFollowedGroup();
            using (var tabBar = ImRaii.TabBar(_compendiumGrouping.Key, ImGuiTabBarFlags.FittingPolicyScroll | ImGuiTabBarFlags.ListPopupButton))
            {
                if (tabBar)
                {
                    _compendiumTabs ??= GetTabs(_compendiumGrouping);
                    var pendingTab = _pendingTab;
                    _pendingTab = null;
                    if (_compendiumTabs == null)
                    {
                        MediatorService.Publish(_table.Value.Draw(_windowState, new Vector2(0, 0)));
                    }
                    else
                    {
                        foreach (var tab in _compendiumTabs)
                        {
                            var tabFlags = ImGuiTabItemFlags.NoReorder;
                            if (pendingTab != null && Equals(tab.Key, pendingTab))
                            {
                                tabFlags |= ImGuiTabItemFlags.SetSelected;
                            }

                            using (var tabItem = ImRaii.TabItem(tab.Value, tabFlags))
                            {
                                if (tabItem)
                                {
                                    if (_currentTab == null || _currentTab != tab.Key)
                                    {
                                        _currentTab = tab.Key;
                                        _table.Value.SetGrouping(_compendiumGrouping, tab.Key);
                                    }
                                    MediatorService.Publish(_table.Value.Draw(_windowState, new Vector2(0, 0)));

                                }
                            }
                        }
                    }

                }
            }
        }
    }

    private void DrawMenuBar()
        {
            using (var menuBar = ImRaii.MenuBar())
            {
                if (menuBar)
                {
                    using (var menu = ImRaii.Menu("File"))
                    {
                        if (menu)
                        {
                            if (ImGui.MenuItem("Configuration".Tr()))
                            {
                                this.MediatorService.Publish(new OpenGenericWindowMessage(typeof(ConfigurationWindow)));
                            }

                            if (ImGui.MenuItem("Changelog".Tr()))
                            {
                                this.MediatorService.Publish(new OpenGenericWindowMessage(typeof(ChangelogWindow)));
                            }

                            if (ImGui.MenuItem("Help".Tr()))
                            {
                                this.MediatorService.Publish(new OpenGenericWindowMessage(typeof(HelpWindow)));
                            }

                            if (ImGui.MenuItem("Enable Verbose Logging".Tr(), "",
                                    this._pluginLog.MinimumLogLevel == LogEventLevel.Verbose))
                            {
                                if (this._pluginLog.MinimumLogLevel == LogEventLevel.Verbose)
                                {
                                    this._pluginLog.MinimumLogLevel = LogEventLevel.Debug;
                                }
                                else
                                {
                                    this._pluginLog.MinimumLogLevel = LogEventLevel.Verbose;
                                }
                            }

                            if (ImGui.MenuItem("Generate Support Dump".Tr()))
                            {
                                this.MediatorService.Publish(new OpenGenericWindowMessage(typeof(SupportDumpWindow)));
                            }

                            if (ImGui.MenuItem("Report a Issue".Tr()))
                            {
                                "https://github.com/Critical-Impact/InventoryTools".OpenBrowser();
                            }

                            if (ImGui.MenuItem("Ko-Fi".Tr()))
                            {
                                "https://ko-fi.com/critical_impact".OpenBrowser();
                            }

                            if (ImGui.MenuItem("Close".Tr()))
                            {
                                this.IsOpen = false;
                            }
                        }
                    }


                    var groupings = _compendiumType.GetGroupings();
                    if (groupings != null)
                    {
                        using (var groupingMenu = ImRaii.Menu("Group By"))
                        {
                            if (groupingMenu)
                            {
                                if (ImGui.MenuItem("None".Tr(), _compendiumGrouping == null))
                                {
                                    _compendiumGrouping = null;
                                    _lastFollowedGroup = null;
                                    _table.Value.ClearGrouping();
                                }
                                foreach (var grouping in groupings)
                                {
                                    if (ImGui.MenuItem(grouping.Name, _compendiumGrouping?.Equals(grouping) ?? false))
                                    {
                                        _compendiumGrouping = grouping;
                                        _compendiumTabs = null;
                                        _lastFollowedGroup = null;
                                        SetSavedGrouping(grouping.Key);
                                    }
                                }
                            }
                        }
                    }

                    DrawCurrentGroupMenu();

                    using (var menu = ImRaii.Menu("Windows"))
                    {
                        if (menu)
                        {
                            foreach (var window in _menuWindows)
                            {
                                if (ImGui.MenuItem(window.GenericName))
                                {
                                    this.MediatorService.Publish(new OpenGenericWindowMessage(window.GetType()));
                                }
                            }
                        }
                    }

                    using (var menu = ImRaii.Menu("Compendium"))
                    {
                        if (menu)
                        {
                            foreach (var compendiumType in _compendiumTypes)
                            {
                                if (ImGui.MenuItem(compendiumType.Plural))
                                {
                                    this.MediatorService.Publish(new ToggleCompendiumListMessage(compendiumType));
                                }
                            }
                        }
                    }

                    if (ImGui.IsItemHovered())
                    {
                        using (ImRaii.Tooltip())
                        {
                            ImGui.Text("Compendium is a WIP feature, expect more here soon!".Tr());
                        }
                    }

                }
            }
        }

    private void DrawCurrentGroupMenu()
    {
        var grouping = _compendiumGrouping;
        if (grouping?.CurrentGroupFunc == null)
        {
            return;
        }

        var label = grouping.CurrentGroupLabel ?? "Current ".Tr() + grouping.Name;
        using var menu = ImRaii.Menu(label);
        if (!menu)
        {
            return;
        }

        var currentGroup = grouping.CurrentGroupFunc();
        var canShow = currentGroup != null && HasTab(currentGroup);
        using (ImRaii.Disabled(!canShow))
        {
            if (ImGui.MenuItem("Show ".Tr() + label) && currentGroup != null)
            {
                _pendingTab = currentGroup;
            }
        }

        if (!canShow && ImGui.IsItemHovered(ImGuiHoveredFlags.AllowWhenDisabled))
        {
            using (ImRaii.Tooltip())
            {
                ImGui.TextUnformatted(currentGroup == null
                    ? string.Format("You are not in a {0} this list can show.".Tr(), grouping.Name.ToLower())
                    : string.Format("There are no {0} recorded in {1}.".Tr(), _compendiumType.Plural.ToLower(), grouping.GroupMapping?.Invoke(currentGroup) ?? currentGroup.ToString()));
            }
        }

        var follow = IsFollowingCurrentGroup(grouping);
        if (ImGui.MenuItem("Follow ".Tr() + label, "", follow))
        {
            SetFollowingCurrentGroup(grouping, !follow);

            _lastFollowedGroup = null;
        }

        if (ImGui.IsItemHovered())
        {
            using (ImRaii.Tooltip())
            {
                ImGui.TextUnformatted(string.Format("When {0} changes, open its tab.".Tr(), label.ToLower()));
            }
        }
    }

    public override void Invalidate()
    {

    }

    public override FilterConfiguration? SelectedConfiguration => null;
    public override string GenericKey => CompendiumType.Plural.ToLower();
    public override string GenericName => CompendiumType.Plural + " Window";
    public override bool DestroyOnClose => true;
    public override bool SaveState => false;
    public override Vector2? DefaultSize => new Vector2(800, 500);
    public override Vector2? MaxSize => null;
    public override Vector2? MinSize => null;

    public ICompendiumType CompendiumType => _compendiumType;

    public override void Initialize()
    {
    }

    protected override void Dispose(bool disposing)
    {
        base.Dispose(disposing);
        if (disposing)
        {
            _sectionStateTask?.Dispose();
        }
    }
}