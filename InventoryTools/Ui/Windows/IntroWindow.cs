using System.Numerics;
using CriticalCommonLib.Services.Mediator;
using DalaMock.Host.Mediator;
using Dalamud.Bindings.ImGui;
using InventoryTools.Logic;
using Dalamud.Interface.Utility.Raii;
using InventoryTools.Mediator;
using InventoryTools.Services;
using Microsoft.Extensions.Logging;

namespace InventoryTools.Ui
{
    public class IntroWindow : GenericWindow
    {
        public IntroWindow(ILogger<IntroWindow> logger, MediatorService mediator, ImGuiService imGuiService, InventoryToolsConfiguration configuration, string name = "Intro Window") : base(logger, mediator, imGuiService, configuration, name)
        {
        }
        public override void Initialize()
        {
            WindowName = "Allagan Tools".Tr();
            Flags =
                ImGuiWindowFlags.NoResize | ImGuiWindowFlags.NoTitleBar | ImGuiWindowFlags.NoScrollbar;
            Key = "intro";
        }


        public override void Invalidate()
        {
        }

        public override FilterConfiguration? SelectedConfiguration => null;
        public override string GenericKey { get; } = "intro";
        public override string GenericName { get; } = "Intro";
        public override bool DestroyOnClose => true;

        public override void DrawWindow()
        {
            using (var leftChild = ImRaii.Child("Left", new Vector2(200, 0)))
            {
                if (leftChild.Success)
                {
                    ImGui.SetCursorPosY(40);
                    ImGui.Image(ImGuiService.GetImageTexture("icon-hor").Handle, new Vector2(200, 200) * ImGui.GetIO().FontGlobalScale);
                }
            }
            ImGui.SameLine();
            using (var rightChild = ImRaii.Child("Right", new Vector2(0, 0), false, ImGuiWindowFlags.NoScrollbar))
            {
                if (rightChild.Success)
                {
                    using (var textChild = ImRaii.Child("Text", new Vector2(0, -32)))
                    {
                        if (textChild.Success)
                        {
                            ImGui.TextWrapped("Welcome to Allagan Tools.".Tr());
                            ImGui.TextWrapped(
                                "Allagan Tools is a plugin for Final Fantasy XIV that provides the following features:");
                            using (ImRaii.PushIndent())
                            {
                                ImGui.Bullet();
                                ImGui.Text("Track your inventories".Tr());
                                ImGui.Bullet();
                                ImGui.Text("Plan your crafts".Tr());
                                ImGui.Bullet();
                                ImGui.Text("Provide information about items, monsters, duties and much more".Tr());
                            }

                            ImGui.TextWrapped(
                                "You can open various new windows using command shortcuts(the main filter  or from the main window.".Tr());
                            ImGui.TextWrapped(
                                "If you're unsure, right-click on an item or a table row for more options!".Tr());
                            ImGui.TextWrapped(
                                "To learn about the different features, I recommend going to the settings section and reading the information provided by the ? icons.".Tr());
                        }
                    }

                    using (var buttonsChild = ImRaii.Child("Buttons", new Vector2(0, 32)))
                    {
                        if (buttonsChild.Success)
                        {
                            if (ImGui.Button("Close".Tr()))
                            {
                                Close();
                            }

                            ImGui.SameLine(0, 4);
                            if (ImGui.Button("Close & Open Main Window".Tr()))
                            {
                                Close();
                                MediatorService.Publish(new OpenGenericWindowMessage(typeof(FiltersWindow)));
                            }
                        }
                    }
                }
            }
        }

        public override Vector2? DefaultSize { get; } = new Vector2(800, 300);
        public override Vector2? MaxSize { get; } = new Vector2(800, 300);
        public override Vector2? MinSize { get; } = new Vector2(800, 300);
        public override bool SaveState => false;
    }
}