using JogoDaVelha.Enum;
using System;
using System.Collections.Generic;
namespace JogoDaVelha
{
    class Grid
    {

        public List<Piece> pieces;

        public Grid()
        {
            pieces = new List<Piece>();
            for (int i = 0; i < 9; i++)
            {
                if (i == 0)
                {
                    pieces.Add(new Piece(CrossOrCircle.Placeholder, this, true));
                }
                else
                {
                    pieces.Add(new Piece(CrossOrCircle.Placeholder, this));
                }
            }

        }


        public void showPieces()
        {
            Console.Write("[");
            foreach (Piece p in pieces)
            {
                if (pieces[8] == p)
                {
                    Console.Write(p);
                }
                else
                {
                    Console.Write(p + ";");
                }
            }
            Console.WriteLine("]");
        }



    }


}

