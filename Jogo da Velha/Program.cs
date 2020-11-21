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

            while (playAgain)
            {
                while (!match.Ended)
                {
                    try
                    {
                        Console.Clear();
                        Screen.printMatch(match);

                        Console.Write((("Where do you want to insert your piece[0-8]? ")));
                        Console.ForegroundColor = ConsoleColor.Green;
                        match.insertPiece(int.Parse(Console.ReadLine()));
                        Console.ForegroundColor = ConsoleColor.White;

                    }
                    catch (CustomException e)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(((e.Message)));
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.ReadLine();
                    }
                    catch (ArgumentOutOfRangeException e)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(("The position you choose was not between 0 and 8"));
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
                Console.ReadLine();
                Console.Clear();

                try
                {
                    Console.WriteLine((("DO YOU WANT TO PLAY AGAIN[Y/N]?")));
                    string again = Console.ReadLine().Substring(0, 1).ToUpper();
                    if (again == "Y")
                    {

                        match = new Match();
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
