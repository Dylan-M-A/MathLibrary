using System;
using System.Collections.Generic;
using System.Linq;
using Raylib_cs;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    internal class AmongUs
    {
        public void Run()
        {
            Raylib.InitWindow(800, 800, "Hello World");

            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.White);
                
                Raylib.DrawRectangle(25, 100, 10, 70, Color.Black);
                Raylib.DrawRectangle(35, 90, 20, 10, Color.Black);
                Raylib.DrawRectangle(35, 170, 20, 10, Color.Black);
                Raylib.DrawRectangle(35, 100, 20, 70, Color.Red);
                Raylib.DrawRectangle(55, 60, 10, 150, Color.Black);
                Raylib.DrawRectangle(65, 210, 30, 10, Color.Black);
                Raylib.DrawRectangle(65, 50, 10, 10, Color.Black);
                Raylib.DrawRectangle(65, 130, 100, 50, Color.Red);
                Raylib.DrawRectangle(65, 180, 30, 30, Color.Red);
                Raylib.DrawRectangle(65, 120, 40, 10, Color.Red);
                Raylib.DrawRectangle(65, 110, 30, 10, Color.Red);
                Raylib.DrawRectangle(65, 80, 20, 30, Color.Red);
                Raylib.DrawRectangle(65, 70, 30, 10, Color.Red);
                Raylib.DrawRectangle(65, 60, 40, 10, Color.Red);
                Raylib.DrawRectangle(75, 40, 10, 10, Color.Black);
                Raylib.DrawRectangle(75, 50, 80, 10, Color.Red);
                Raylib.DrawRectangle(85, 30, 60, 10, Color.Black);
                Raylib.DrawRectangle(85, 80, 10, 30, Color.Black);
                Raylib.DrawRectangle(85, 40, 60, 10, Color.Red);
                Raylib.DrawRectangle(95, 70, 10, 10, Color.Black);
                Raylib.DrawRectangle(95, 180, 10, 30, Color.Black);
                Raylib.DrawRectangle(95, 110, 10, 10, Color.Black);
                Raylib.DrawRectangle(95, 80, 40, 30, Color.SkyBlue);
                Raylib.DrawRectangle(105, 180, 20, 10, Color.Black);
                Raylib.DrawRectangle(105, 70, 20, 10, Color.SkyBlue);
                Raylib.DrawRectangle(105, 60, 50, 10, Color.Black);
                Raylib.DrawRectangle(105, 120, 60, 10, Color.Black);
                Raylib.DrawRectangle(105, 90, 60, 30, Color.SkyBlue);
                Raylib.DrawRectangle(125, 180, 10, 30, Color.Black);
                Raylib.DrawRectangle(135, 180, 30, 30, Color.Red);
                Raylib.DrawRectangle(135, 210, 30, 10, Color.Black);
                Raylib.DrawRectangle(145, 40, 10, 10, Color.Black);
                Raylib.DrawRectangle(155, 50, 10, 20, Color.Black);
                Raylib.DrawRectangle(165, 110, 10, 100, Color.Black);
                Raylib.DrawRectangle(165, 70, 10, 10, Color.Black);
                Raylib.DrawRectangle(165, 80, 10, 30, Color.SkyBlue);
                Raylib.DrawRectangle(175, 80, 10, 30, Color.Black);

                Raylib.EndDrawing();
            }

            Raylib.CloseWindow();
        }
    }
}
