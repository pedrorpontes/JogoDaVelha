using JogoDaVelha.Enum;
using System;

namespace JogoDaVelha
{
    class Screen
    {
        public static void DrawGrid(Grid grid)
        {
            Console.WriteLine("   |   |   ");
            Console.WriteLine($" {grid.piece(0)} | {grid.piece(1)} | {grid.piece(2)} ");
            Console.WriteLine("___|___|___");
            Console.WriteLine("   |   |   ");
            Console.WriteLine($" {grid.piece(3)} | {grid.piece(4)} | {grid.piece(5)} ");
            Console.WriteLine("___|___|___");
            Console.WriteLine("   |   |   ");
            Console.WriteLine($" {grid.piece(6)} | {grid.piece(7)} | {grid.piece(8)} ");
            Console.WriteLine("   |   |   ");           
        }
        public static void printMatch(Match match)
        {
            DrawGrid(match.Grid);
            Console.WriteLine("Turn: " + match.Turn);
            Console.WriteLine("Aguardando jogada: " + match.playerTurn);
        }
    }
    
}
