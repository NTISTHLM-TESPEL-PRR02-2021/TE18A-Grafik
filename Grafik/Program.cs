using System;
using Raylib_cs;

namespace Grafik
{
  class Program
  {
    static void Main(string[] args)
    {
      Raylib.InitWindow(800, 600, "Goodbye world");

      Texture2D ok = Raylib.LoadTexture("ok.png");

      Color hotPink = new Color(255, 105, 180, 255);

      float xPos = 10;

      while (!Raylib.WindowShouldClose())
      {
        // LOGIC
        if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
        {
          xPos += 0.1f;
        }

        // DRAWING
        Raylib.BeginDrawing();

        Raylib.ClearBackground(hotPink);

        //Raylib.DrawRectangle((int) xPos, 10, 50, 50, Color.WHITE);

        Raylib.DrawTexture(ok, (int) xPos, 10, Color.WHITE);

        Raylib.EndDrawing();

      }



    }
  }
}
