using System;



namespace JogoDaVelha
{
    class Program
    {
        static void Main(string[] args)
        {
            
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
                        Console.WriteLine(((e.Message)));
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.ReadLine();
                    }                    
                    catch (Exception e)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine((((e.Message))));
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.ReadLine();
                    }

                }
                
                try
                {
                    Console.WriteLine((("DO YOU WANT TO PLAY AGAIN[Y/N]?")));
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
                }
                catch (Exception e)
                {
                    Console.WriteLine(((e.Message)));
                }


            }




        }
    }
}
