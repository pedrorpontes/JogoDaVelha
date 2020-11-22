﻿using System;

namespace JogoDaVelha
{
    class Screen
    {
        public static void DrawGrid(Grid grid)
        {
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("   |   |   ");

            Console.Write(grid.pieces[0].ToString());
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"|");
            Console.Write(grid.pieces[1].ToString());
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"|");
            Console.WriteLine(grid.pieces[2].ToString());
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("___|___|___");
            Console.WriteLine("   |   |   ");

            Console.Write(grid.pieces[3].ToString());
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"|");
            Console.Write(grid.pieces[4].ToString());
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"|");
            Console.WriteLine(grid.pieces[5].ToString());
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("___|___|___");
            Console.WriteLine("   |   |   ");

            Console.Write(grid.pieces[6].ToString());
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"|");
            Console.Write(grid.pieces[7].ToString());
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"|");
            Console.WriteLine(grid.pieces[8].ToString());
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

        public static int moveCursor(int cursor, Match match)
        {

            Console.WriteLine("Use the Arrow Keys to move around the Grid.");
            ConsoleKeyInfo cursorKey = Console.ReadKey(); 
            
            while (cursorKey.Key != ConsoleKey.Enter)
            {
                
                if (cursorKey.Key == ConsoleKey.DownArrow)
                {
                    match.Grid.pieces[cursor].Cursor = false;
                    cursor += 3;
                    if (cursor > 8)
                    {
                        cursor = 8;
                    }
                    match.Grid.pieces[cursor].Cursor = true;
                }
                else if (cursorKey.Key == ConsoleKey.UpArrow)
                {
                    match.Grid.pieces[cursor].Cursor = false;
                    cursor -= 3;
                    if (cursor < 0)
                    {
                        cursor = 0;
                    }
                    match.Grid.pieces[cursor].Cursor = true;
                }
                else if (cursorKey.Key == ConsoleKey.LeftArrow)
                {
                    match.Grid.pieces[cursor].Cursor = false;
                    cursor -= 1;
                    if (cursor < 0)
                    {
                        cursor = 0;
                    }
                    match.Grid.pieces[cursor].Cursor = true;
                }
                else if (cursorKey.Key == ConsoleKey.RightArrow)
                {
                    match.Grid.pieces[cursor].Cursor = false;
                    cursor += 1;
                    if (cursor > 8)
                    {
                        cursor = 8;
                    }
                    match.Grid.pieces[cursor].Cursor = true;
                }
                Console.Clear();
               
                printMatch(match);
                Console.WriteLine("Use the Arrow Keys to move around the Grid.");
                cursorKey = Console.ReadKey();
                
            }
            return cursor;
        }
        /*public static string CenterText(string text)
        {
            string textToCenter = text;
            return String.Format("{0," + ((Console.WindowWidth / 2) + (textToCenter.Length / 2)) + "}", textToCenter);

        }*/
    }

}
