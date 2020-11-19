using JogoDaVelha.Enum;
using System;
using System.Collections.Generic;
using System.Text;


namespace JogoDaVelha
{
    class Match
    {
        public int Turn { get; private set; }
        public bool Ended { get; set; }
        public Grid Grid { get; set; }
        public CrossOrCircle playerTurn { get; set; }

        public Match()
        {
            Turn = 1;
            Ended = false;
            Grid = new Grid();
            playerTurn = CrossOrCircle.X;
        }
        public void ChangeTurn()
        {
            if (playerTurn == CrossOrCircle.X)
            {
                playerTurn = CrossOrCircle.O;
                Turn++;
            }
            else
            {
                playerTurn = CrossOrCircle.X;
                Turn++;
            }
        }
        public void insertPiece(int position)
        {
            if (Grid.pieces[position - 1].CrossOrCircle == CrossOrCircle.P)
            {

                Piece p = new Piece(playerTurn, Grid);
                if (p.CrossOrCircle == CrossOrCircle.X)
                {

                    Grid.pieces.RemoveAt(position - 1);
                    Grid.pieces.Insert(position - 1, p);
                    didGameEnd();
                    ChangeTurn();
                }
                else
                {
                    Grid.pieces.RemoveAt(position - 1);
                    Grid.pieces.Insert(position - 1, p);
                    didGameEnd();
                    ChangeTurn();
                }
            }
            else
            {
                throw new CustomException("There is already a piece in this position! \nChoose another.");
            }
        }



        public void didGameEnd()
        {
            //Winning Condition Horizontal
            if ((Grid.pieces[1] == Grid.pieces[2] && Grid.pieces[1] == Grid.pieces[3] && Grid.pieces[1].CrossOrCircle != CrossOrCircle.P)) 
            {
                Ended = true;
                Console.WriteLine(playerTurn + " WON");
            }
            else if ((Grid.pieces[4] == Grid.pieces[5] && Grid.pieces[4] == Grid.pieces[6] && Grid.pieces[4].CrossOrCircle != CrossOrCircle.P)) 
            {
                Ended = true;
                Console.WriteLine(playerTurn + " WON");
            }
            else if ((Grid.pieces[7] == Grid.pieces[8] && Grid.pieces[7] == Grid.pieces[9] && Grid.pieces[7].CrossOrCircle != CrossOrCircle.P)) 
            {
                Ended = true;
                Console.WriteLine(playerTurn + " WON");
            }
            //Winning Condition Vertical
            else if ((Grid.pieces[1] == Grid.pieces[4] && Grid.pieces[1] == Grid.pieces[7] && Grid.pieces[1].CrossOrCircle != CrossOrCircle.P)) 
            {
                Ended = true;
                Console.WriteLine(playerTurn + " WON");
            }
            else if ((Grid.pieces[2] == Grid.pieces[5] && Grid.pieces[2] == Grid.pieces[8] && Grid.pieces[2].CrossOrCircle != CrossOrCircle.P)) 
            {
                Ended = true;
                Console.WriteLine(playerTurn + " WON");
            }
            else if ((Grid.pieces[3] == Grid.pieces[6] && Grid.pieces[3] == Grid.pieces[9] && Grid.pieces[3].CrossOrCircle != CrossOrCircle.P)) 
            {
                Ended = true;
                Console.WriteLine(playerTurn + " WON");
            }
            //Winning Condition Diagonal
            else if ((Grid.pieces[1] == Grid.pieces[5] && Grid.pieces[1] == Grid.pieces[9] && Grid.pieces[1].CrossOrCircle != CrossOrCircle.P)) 
            {
                Ended = true;
                Console.WriteLine(playerTurn + " WON");
            }
            else if ((Grid.pieces[3] == Grid.pieces[5] && Grid.pieces[3] == Grid.pieces[7] && Grid.pieces[3].CrossOrCircle != CrossOrCircle.P)) 
            {
                Ended = true;
                Console.WriteLine(playerTurn + " WON");
            }

            else if (Turn > 9)
            {
                Console.WriteLine("DRAW");
                Console.ReadLine();
                Ended = true;
                
            }
        }
    }
}


