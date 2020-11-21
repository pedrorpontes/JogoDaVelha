using System;

namespace JogoDaVelha
{
    class Screen
    {
        public static void DrawGrid(Grid grid)
        {
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("   |   |   ");

            Console.Write($" {grid.piece(0)} ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"|");
            Console.Write($" {grid.piece(1)} ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"|");
            Console.WriteLine($" {grid.piece(2)} ");
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("___|___|___");
            Console.WriteLine("   |   |   ");

            Console.Write($" {grid.piece(3)} ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"|");
            Console.Write($" {grid.piece(4)} ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"|");
            Console.WriteLine($" {grid.piece(5)} ");
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("___|___|___");
            Console.WriteLine("   |   |   ");

            Console.Write($" {grid.piece(6)} ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"|");
            Console.Write($" {grid.piece(7)} ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"|");
            Console.WriteLine($" {grid.piece(8)} ");
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("   |   |   ");
            Console.ForegroundColor = ConsoleColor.White;


        }
        public static void printMatch(Match match)
        {
            DrawGrid(match.Grid);
            Console.WriteLine("Turn: " + match.Turn);
            Console.WriteLine("Waiting for: " + match.playerTurn);
            Console.WriteLine();
        }
        /*public static string CenterText(string text)
        {
            string textToCenter = text;
            return String.Format("{0," + ((Console.WindowWidth / 2) + (textToCenter.Length / 2)) + "}", textToCenter);

        }*/
    }

}
