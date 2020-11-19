using System;
using System.Collections.Generic;
using JogoDaVelha.Enum;
namespace JogoDaVelha
{
    class Grid
    {
        
        public List<Piece> pieces;

        public Grid()
        {
            pieces = new List<Piece>();
            for(int i = 0; i < 9; i++)
            {
                pieces.Add(new Piece(CrossOrCircle.Placeholder, this));
            }

        }

        public string piece(int position)
        {
            if (pieces[position].CrossOrCircle == CrossOrCircle.Placeholder)
            {
                return (position).ToString();
            }
            else
            {
                return pieces[position].ToString();
            }
               
        }
        public void showPieces()
        {
            Console.Write("[");
            foreach(Piece p in pieces)
            {
                if (pieces[8] == p)
                {
                    Console.Write(p);
                }
                else
                {
                    Console.Write(p+";");
                }
            }
            Console.WriteLine("]");
        }

        
        
    }


}

