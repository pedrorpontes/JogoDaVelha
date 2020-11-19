using System;
using JogoDaVelha.Enum;



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
                        match.Grid.showPieces();
                        Console.Write("Where do you want to insert your piece[0-8]? ");
                        match.insertPiece(int.Parse(Console.ReadLine()));

                    }
                    catch (CustomException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine((e.Message));
                        Console.ReadLine();
                    }

                }
                Console.ReadLine();
                Console.Clear();

                try
                {
                    Console.WriteLine("DO YOU WANT TO PLAY AGAIN[Y/N]?");
                    string again = Console.ReadLine().Substring(0,1).ToUpper();
                    if (again == "Y")
                    {
                        
                        match = new Match();
                    }
                    else
                    {
                        playAgain = false;
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }


            }
           



        }
    }
}
