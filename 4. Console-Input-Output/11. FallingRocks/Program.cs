using System;
using System.Threading;

class FallingRocks
{

    static int dwarfPositionX;
    static int dwarfPositionY;
    static bool collision;
    static double fps;
    static string dwarf = "(O)";
    static int minFps = 15, maxFps = 40;

    static void RemoveScrollBars()
    {
        Console.BufferWidth = Console.WindowWidth;
        Console.BufferHeight = Console.WindowHeight;
    }
    static void CenterPlayer()
    {
        dwarfPositionX = (Console.WindowWidth - dwarf.Length) / 2;
        dwarfPositionY = Console.WindowHeight - 1;
    }

    static void MovePlayer(ConsoleKeyInfo keyInfo)
    {
        if (keyInfo.Key == ConsoleKey.LeftArrow && dwarfPositionX > 0) dwarfPositionX--;
        if (keyInfo.Key == ConsoleKey.RightArrow && dwarfPositionX + dwarf.Length - 1 < Console.WindowWidth - 1) dwarfPositionX++;
    }

    static void PrintAtPosition(int playerPositionX, int playerPositionY, string dwarf)
    {
        Console.SetCursorPosition(playerPositionX, playerPositionY);
        Console.Write(dwarf);
    }

    static void CalculateFPS()
    {
        fps += collision ? -15 : .5;
        fps = Math.Min(Math.Max(fps, minFps), maxFps);
    }

    static void DrawDwarf()
    {
        PrintAtPosition(dwarfPositionX, dwarfPositionY, dwarf);
    }



    static void Main()
    {
        RemoveScrollBars();
        CenterPlayer();
        while (true)
        {
            if (Console.KeyAvailable)

                MovePlayer(Console.ReadKey());
            CalculateFPS();
            Console.Clear();
            DrawDwarf();
            Thread.Sleep(150 / (int)fps);
        }
    }
}
