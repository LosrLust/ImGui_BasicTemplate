using ClickableTransparentOverlay;
using ImGuiNET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RenderSpace
{
    public class RenderStart : Overlay
    {
        [DllImport("user32.dll")] static extern short GetAsyncKeyState(int vKey);

        // Bools
        bool Show = true;

        // Vectors
        Vector2 WindowSize = new Vector2(400, 200);

        protected override void Render()
        {
            if (GetAsyncKeyState(0x2D) != 0) // Insert to show/hide menu
            {
                Show = !Show;
                Thread.Sleep(100);
            }

            if (Show)
            {
                DrawMenu();
            }
        }

        void DrawMenu()
        {
            Theme.theme();
            ImGui.SetNextWindowSize(WindowSize, ImGuiCond.Always);
            if (ImGui.Begin("Tesla ", ImGuiWindowFlags.NoResize))
            {
                if (ImGui.BeginTabBar("TabBar"))
                {
                    if (ImGui.BeginTabItem("Main"))
                    {
                        ImGui.EndTabItem();
                    }
                    if (ImGui.BeginTabItem("Esp"))
                    {
                        ImGui.EndTabItem();
                    }
                    if (ImGui.BeginTabItem("Aimbot"))
                    {
                        ImGui.EndTabItem();
                    }
                    if (ImGui.BeginTabItem("Misc"))
                    {
                        ImGui.EndTabItem();
                    }
                    ImGui.EndTabBar();
                }
                ImGui.End();
            }
        }
    }
}