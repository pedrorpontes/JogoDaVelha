using System;
using JogoDaVelha.Enum;



namespace JogoDaVelha
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Match match = new Match();
            Tela.printMatch(match);

            while (!match.Ended)
            {
                try
                {
                    Console.Clear();
                    Tela.printMatch(match);
                    Console.Write("Where do you want to insert your piece[1-9]? ");
                    match.insertPiece(int.Parse(Console.ReadLine()));
                    match.didGameEnd();
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
           



        }
    }
}
