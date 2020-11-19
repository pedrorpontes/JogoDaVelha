using JogoDaVelha.Enum;
using System;

namespace JogoDaVelha
{
    class Screen
    {
        public static void DrawGrid(Grid grid)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            
            Console.WriteLine(CenterText("   |   |   "));
            Console.WriteLine(CenterText($" {grid.piece(0)} | {grid.piece(1)} | {grid.piece(2)} "));
            Console.WriteLine(CenterText("___|___|___"));
            Console.WriteLine(CenterText("   |   |   "));
            Console.WriteLine(CenterText($" {grid.piece(3)} | {grid.piece(4)} | {grid.piece(5)} "));
            Console.WriteLine(CenterText("___|___|___"));
            Console.WriteLine(CenterText("   |   |   "));
            Console.WriteLine(CenterText($" {grid.piece(6)} | {grid.piece(7)} | {grid.piece(8)} "));
            Console.WriteLine(CenterText("   |   |   "));
            Console.ForegroundColor = ConsoleColor.White;
            
            
        }
        public static void printMatch(Match match)
        {
            DrawGrid(match.Grid);
            Console.WriteLine(CenterText("Turn: " + match.Turn));
            Console.WriteLine(CenterText("Waiting for: " + match.playerTurn));
            Console.WriteLine();
        }
        public static string CenterText(string text)
        {
            string textToCenter = text;
            return String.Format("{0," + ((Console.WindowWidth / 2) + (textToCenter.Length / 2)) + "}", textToCenter);
            
        }
    }
    
}
