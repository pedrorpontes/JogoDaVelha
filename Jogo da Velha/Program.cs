﻿using System;



namespace JogoDaVelha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title= "Tic-Tac-Toe";
            bool playAgain = true;
            Match match = new Match();
            Screen.printMatch(match);
            int cursor = 0;

            while (playAgain)
            {
                while (!match.Ended)
                {
                    try
                    {
                        Console.Clear();
                        Screen.printMatch(match);
                        int cursorSelection = Screen.moveCursor(cursor, match);
                        match.insertPiece(cursorSelection);
                    }
                    catch (CustomException e)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;                       
                        Console.Write("{0," + ((Console.WindowWidth / 2 + e.Message.Length / 2)) + "}", e.Message);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.ReadLine();
                    }                    
                    catch (Exception e)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("{0," + ((Console.WindowWidth / 2 + e.Message.Length / 2)) + "}", e.Message);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.ReadLine();
                    }

                }
                
                try
                {
                    Console.Write("{0," + ((Console.WindowWidth / 2 + "DO YOU WANT TO PLAY AGAIN[Y/N]?".Length / 2)) + "}", "DO YOU WANT TO PLAY AGAIN[Y/N]?");

                    Console.ForegroundColor = ConsoleColor.Green;
                    string again = Console.ReadLine().Substring(0, 1).ToUpper();
                    if (again == "Y")
                    {
                        int winFromX = match.WinsFromX;
                        int winFromO = match.WinsFromO;
                        match = new Match(winFromX, winFromO);
                    }
                    else
                    {
                        playAgain = false;
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                }
                catch (Exception e)
                {
                    Console.Write("{0," + ((Console.WindowWidth / 2 + e.Message.Length / 2)) + "}", e.Message);
                }


            }




        }
    }
}
