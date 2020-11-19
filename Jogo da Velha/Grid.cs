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
                pieces.Add(new Piece(CrossOrCircle.P, this));
            }

        }

        public string piece(int position)
        {
            if (pieces[position].CrossOrCircle == CrossOrCircle.P)
            {
                return (position + 1).ToString();
            }
            else
            {
                return pieces[position].ToString();
            }
               
        }

        public bool existingPiece(int position)
        {
            if (pieces[position] == null)
            {
                return pieces[position] == null;
            }
            else
            {
                return pieces[position] != null;
            }
        }
        public void fillList()
        {
            Piece P = new Piece(CrossOrCircle.P, this);
            for (int i = 0; i < 9; i++)
            {
                pieces.Add(P);
            }

        }
    }


}

