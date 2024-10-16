using System;
using System.Collections.Generic;
using System.Linq;
using Raylib_cs;
using MathLibrary;

namespace Sandbox
{
    internal class AmongUs
    {
        public void Run()
        {
            Raylib.InitWindow(800, 480, "Hello World");

            Vector2 screenDimensions = new Vector2(Raylib.GetScreenWidth(), Raylib.GetScreenHeight());

            Vector2 playerPosition = new Vector2(screenDimensions.x * .5f, screenDimensions.y * .75f);
            float playerRadius = 10;
            Vector2 playerforward = new Vector2(0, 1).Normalized;
            float playerSpeed = 50f;

            Vector2 enemyPosition = new Vector2(screenDimensions.x * .5f, screenDimensions.y * .25f);
            float enemyRadius = 10;
            Color enemyColor = Color.Red;

            float playerViewAngle = 90;
            float playerViewDistance = 300;

            while (!Raylib.WindowShouldClose())
            {
                //Update

                //movement

                Vector2 movementInput = new Vector2();
                movementInput.y -= Raylib.IsKeyDown(KeyboardKey.W);
                movementInput.y += Raylib.IsKeyDown(KeyboardKey.S);
                movementInput.x -= Raylib.IsKeyDown(KeyboardKey.A);
                movementInput.x += Raylib.IsKeyDown(KeyboardKey.D);

                playerPosition += movementInput * playerSpeed * Raylib.GetFrameTime();

                //calculate los
                Vector2 playerToEnemyDirection = (playerPosition - enemyPosition).Normalized;
                float distance = enemyPosition.Distance(playerPosition);
                float angleToEnemy = (float)Math.Abs(playerToEnemyDirection.Angle(playerforward));

                if (Math.Abs(angleToEnemy) < (playerViewAngle / 2) * (Math.PI / 180) && distance < playerViewDistance)
                {
                    enemyColor = Color.Purple;
                }
                else
                {
                    enemyColor = Color.Red;
                }

                //draw stuff
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.White);

                //draw enemy
                Raylib.DrawCircleV(enemyPosition, enemyRadius, enemyColor);

                //draw player
                Raylib.DrawCircleV(playerPosition, playerRadius, Color.Green);

                //draw player forward
                Raylib.DrawLineV(playerPosition, playerPosition - (playerforward * 100), Color.Orange);

                //draw view cone
                Raylib.DrawCircleSectorLines(playerPosition, playerViewDistance, -90 - (playerViewAngle / 2), -90 + (playerViewAngle / 2), 10, Color.Blue);

                Raylib.EndDrawing();
            }
            Raylib.CloseWindow();
        }
    }
}
