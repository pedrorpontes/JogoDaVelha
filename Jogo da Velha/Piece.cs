using JogoDaVelha.Enum;
using JogoDaVelha;
using System;
using System.Collections.Generic;
using System.Text;

namespace JogoDaVelha
{
    class Piece
    {

        public CrossOrCircle CrossOrCircle { get; set; }
        public Grid Grid { get; set; }

        public Piece(CrossOrCircle crossOrCircle, Grid grid)
        {

            CrossOrCircle = crossOrCircle;
            Grid = grid;
        }
        public override string ToString()
        {
            if (CrossOrCircle == CrossOrCircle.X)
            {
                return "X";
            }
            else if (CrossOrCircle == CrossOrCircle.O)
            {
                return "O";
            }
            else
            {
                return " ";
            }
        }


    }
}
