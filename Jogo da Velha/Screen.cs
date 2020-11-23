using System;
using System.Collections.Generic;

namespace JogoDaVelha
{
    class Screen
    {
        public static void DrawGrid(Grid grid)
        {
            string line1 = "   |   |   ";

            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("{0," + (Console.WindowWidth / 2 + line1.Length / 2) + "}", "   |   |   ");
            if (grid.pieces[0].CrossOrCircle == Enum.CrossOrCircle.X) { Console.ForegroundColor = ConsoleColor.Red; }
            else if (grid.pieces[0].CrossOrCircle == Enum.CrossOrCircle.O) { Console.ForegroundColor = ConsoleColor.Green; }
            //Utilizei "-8" pois a função está centralizando apenas o primeiro objeto  que são apenas 3 caracteres em vez de centralizar a linha completa que possui 11 caracteres. (11 - 3 = 8).
            Console.Write("{0," + ((Console.WindowWidth / 2) + line1.Length / 2 - 8) + "}", grid.pieces[0].ToString());
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"|");
            if (grid.pieces[1].CrossOrCircle == Enum.CrossOrCircle.X) { Console.ForegroundColor = ConsoleColor.Red; }
            else if (grid.pieces[1].CrossOrCircle == Enum.CrossOrCircle.O) { Console.ForegroundColor = ConsoleColor.Green; }
            Console.Write(grid.pieces[1].ToString());
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"|");
            if (grid.pieces[2].CrossOrCircle == Enum.CrossOrCircle.X) { Console.ForegroundColor = ConsoleColor.Red; }
            else if (grid.pieces[2].CrossOrCircle == Enum.CrossOrCircle.O) { Console.ForegroundColor = ConsoleColor.Green; }
            Console.WriteLine(grid.pieces[2].ToString());
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("{0," + (Console.WindowWidth / 2 + line1.Length / 2) + "}", "___|___|___");
            Console.WriteLine("{0," + (Console.WindowWidth / 2 + line1.Length / 2) + "}", "   |   |   ");

            if (grid.pieces[3].CrossOrCircle == Enum.CrossOrCircle.X) { Console.ForegroundColor = ConsoleColor.Red; }
            else if (grid.pieces[3].CrossOrCircle == Enum.CrossOrCircle.O) { Console.ForegroundColor = ConsoleColor.Green; }
            Console.Write("{0," + ((Console.WindowWidth / 2) + line1.Length / 2 - 8) + "}", grid.pieces[3].ToString());
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"|");
            if (grid.pieces[4].CrossOrCircle == Enum.CrossOrCircle.X) { Console.ForegroundColor = ConsoleColor.Red; }
            else if (grid.pieces[4].CrossOrCircle == Enum.CrossOrCircle.O) { Console.ForegroundColor = ConsoleColor.Green; }
            Console.Write(grid.pieces[4].ToString());
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"|");
            if (grid.pieces[5].CrossOrCircle == Enum.CrossOrCircle.X) { Console.ForegroundColor = ConsoleColor.Red; }
            else if (grid.pieces[5].CrossOrCircle == Enum.CrossOrCircle.O) { Console.ForegroundColor = ConsoleColor.Green; }
            Console.WriteLine(grid.pieces[5].ToString());
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("{0," + (Console.WindowWidth / 2 + line1.Length / 2) + "}", "___|___|___");
            Console.WriteLine("{0," + (Console.WindowWidth / 2 + line1.Length / 2) + "}", "   |   |   ");

            if (grid.pieces[6].CrossOrCircle == Enum.CrossOrCircle.X) { Console.ForegroundColor = ConsoleColor.Red; }
            else if (grid.pieces[6].CrossOrCircle == Enum.CrossOrCircle.O) { Console.ForegroundColor = ConsoleColor.Green; }
            Console.Write("{0," + ((Console.WindowWidth / 2) + line1.Length / 2 - 8) + "}", grid.pieces[6].ToString());
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"|");
            if (grid.pieces[7].CrossOrCircle == Enum.CrossOrCircle.X) { Console.ForegroundColor = ConsoleColor.Red; }
            else if (grid.pieces[7].CrossOrCircle == Enum.CrossOrCircle.O) { Console.ForegroundColor = ConsoleColor.Green; }
            Console.Write(grid.pieces[7].ToString());
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"|");
            if (grid.pieces[8].CrossOrCircle == Enum.CrossOrCircle.X) { Console.ForegroundColor = ConsoleColor.Red; }
            else if (grid.pieces[8].CrossOrCircle == Enum.CrossOrCircle.O) { Console.ForegroundColor = ConsoleColor.Green; }
            Console.WriteLine(grid.pieces[8].ToString());
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("{0," + (Console.WindowWidth / 2 + line1.Length / 2) + "}", "   |   |   ");
            Console.ForegroundColor = ConsoleColor.White;


        }
        public static void printMatch(Match match)
        {
            string line1 = "Turn: " + match.Turn;
            string line2 = "Waiting for: " + match.playerTurn;
            string line3 = "SCOREBOARD";
            string line4 = "Wins from X: " + match.WinsFromX;
            string line5 = "Wins from X: " + match.WinsFromO;



            DrawGrid(match.Grid);
            Console.WriteLine("{0," + (Console.WindowWidth / 2 + line1.Length / 2) + "}", line1);
            Console.WriteLine("{0," + (Console.WindowWidth / 2 + line2.Length / 2) + "}", line2);
            Console.WriteLine();
            Console.WriteLine("{0," + (Console.WindowWidth / 2 + line3.Length / 2) + "}", line3);
            Console.Write("{0," + (Console.WindowWidth / 2 + line4.Length / 2) + "}", line4);
            Console.WriteLine();
            Console.Write("{0," + (Console.WindowWidth / 2 + line5.Length / 2) + "}", line5);
            Console.WriteLine();
        }

        public static int moveCursor(int cursor, Match match)
        {

            Console.WriteLine("{0," + ((Console.WindowWidth / 2 + "Use the Arrow Keys to move around the Grid.".Length / 2)) + "}", "Use the Arrow Keys to move around the Grid.");
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
                else if (cursorKey.Key == ConsoleKey.Escape)
                {
                    match.Ended = true;
                    Console.WriteLine();
                    break;

                }
                Console.Clear();

                printMatch(match);
                Console.WriteLine("{0," + ((Console.WindowWidth / 2 + "Use the Arrow Keys to move around the Grid.".Length / 2)) + "}", "Use the Arrow Keys to move around the Grid.");
                cursorKey = Console.ReadKey();

            }
            return cursor;
        }

        public static int CursorPlayAgain(int cursorIndex, Match match)
        {
            
            List<string> cursorText = new List<string>() { "[YES]", "[NO]", " YES ", " NO " };
            Console.WriteLine("{0," + ((Console.WindowWidth / 2 + (cursorText[0] + " " + cursorText[3]).Length / 2)) + "}", (cursorText[0] + " " + cursorText[3]));
            ConsoleKeyInfo cursorPlayAgainKey = Console.ReadKey();
            
            while (cursorPlayAgainKey.Key != ConsoleKey.Enter)
            {

                if (cursorPlayAgainKey.Key == ConsoleKey.LeftArrow)
                {
                    Console.Clear();
                    printMatch(match);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("{0," + ((Console.WindowWidth / 2 + "DO YOU WANT TO PLAY AGAIN? ".Length / 2)) + "}", "DO YOU WANT TO PLAY AGAIN? ");
                    Console.WriteLine("{0," + ((Console.WindowWidth / 2 + (cursorText[0] + " " + cursorText[3]).Length / 2)) + "}", (cursorText[0] + " " + cursorText[3]));
                    cursorIndex = 0;
                    
                }
                else if (cursorPlayAgainKey.Key == ConsoleKey.RightArrow)
                {
                    Console.Clear();
                    printMatch(match);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("{0," + ((Console.WindowWidth / 2 + "DO YOU WANT TO PLAY AGAIN? ".Length / 2)) + "}", "DO YOU WANT TO PLAY AGAIN? ");
                    Console.WriteLine("{0," + ((Console.WindowWidth / 2 + (cursorText[2] + " " + cursorText[1]).Length / 2)) + "}", (cursorText[2] + " " + cursorText[1]));
                    cursorIndex = 1;
                    
                }
                cursorPlayAgainKey = Console.ReadKey();
            }
            return cursorIndex;
            /*public static string CenterText(string text)
            {
                string textToCenter = text;
                return String.Format("{0," + ((Console.WindowWidth / 2) + (textToCenter.Length / 2)) + "}", textToCenter);

            }*/
        }

    }
}
