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
            if (Grid.pieces[position].CrossOrCircle == CrossOrCircle.Placeholder)
            {

                Piece p = new Piece(playerTurn, Grid);
                if (p.CrossOrCircle == CrossOrCircle.X)
                {

                    Grid.pieces.RemoveAt(position);
                    Grid.pieces.Insert(position, p);
                    didGameEnd();
                    ChangeTurn();
                }
                else
                {
                    Grid.pieces.RemoveAt(position);
                    Grid.pieces.Insert(position, p);
                    didGameEnd();
                    ChangeTurn();
                }
            }
            else
            {
                throw new CustomException("There is already a piece in this position! \nChoose another.");
            }
        }

        public int getCode(int position)
        {
            return Grid.pieces[position].GetHashCode();
        }


        public void didGameEnd()
        {

            //Winning Condition Horizontal
            if ((Grid.pieces[0].GetHashCode() == Grid.pieces[1].GetHashCode() && Grid.pieces[0].GetHashCode() == Grid.pieces[2].GetHashCode() && Grid.pieces[0].CrossOrCircle != CrossOrCircle.Placeholder))
            {
                Ended = true;
                Console.WriteLine(playerTurn + " WON");
            }
            else if ((Grid.pieces[3].GetHashCode() == Grid.pieces[4].GetHashCode() && Grid.pieces[3].GetHashCode() == Grid.pieces[5].GetHashCode() && Grid.pieces[3].CrossOrCircle != CrossOrCircle.Placeholder))
            {
                Ended = true;
                Console.WriteLine(playerTurn + " WON");
            }
            else if (Grid.pieces[6].GetHashCode() == Grid.pieces[7].GetHashCode() && Grid.pieces[6].GetHashCode() == Grid.pieces[8].GetHashCode() && Grid.pieces[6].CrossOrCircle != CrossOrCircle.Placeholder)
            {
                Ended = true;
                Console.WriteLine(playerTurn + " WON");
            }
            //Winning Condition Vertical
            else if ((Grid.pieces[0].GetHashCode() == Grid.pieces[3].GetHashCode() && Grid.pieces[0].GetHashCode() == Grid.pieces[6].GetHashCode() && Grid.pieces[0].CrossOrCircle != CrossOrCircle.Placeholder))
            {
                Ended = true;
                Console.WriteLine(playerTurn + " WON");
            }
            else if ((Grid.pieces[1].GetHashCode() == Grid.pieces[4].GetHashCode() && Grid.pieces[1].GetHashCode() == Grid.pieces[7].GetHashCode() && Grid.pieces[1].CrossOrCircle != CrossOrCircle.Placeholder))
            {
                Ended = true;
                Console.WriteLine(playerTurn + " WON");
            }
            else if ((Grid.pieces[2].GetHashCode() == Grid.pieces[5].GetHashCode() && Grid.pieces[2].GetHashCode() == Grid.pieces[8].GetHashCode() && Grid.pieces[2].CrossOrCircle != CrossOrCircle.Placeholder))
            {
                Ended = true;
                Console.WriteLine(playerTurn + " WON");
            }
            //Winning Condition Diagonal
            else if ((Grid.pieces[0].GetHashCode() == Grid.pieces[4].GetHashCode() && Grid.pieces[0].GetHashCode() == Grid.pieces[8].GetHashCode() && Grid.pieces[0].CrossOrCircle != CrossOrCircle.Placeholder))
            {
                Ended = true;
                Console.WriteLine(playerTurn + " WON");
            }
            else if ((Grid.pieces[2].GetHashCode() == Grid.pieces[4].GetHashCode() && Grid.pieces[2].GetHashCode() == Grid.pieces[6].GetHashCode() && Grid.pieces[2].CrossOrCircle != CrossOrCircle.Placeholder))
            {
                Ended = true;
                Console.WriteLine(playerTurn + " WON");
            }

            else if (Turn == 9)
            {
                Console.Clear();
                Screen.DrawGrid(Grid);
                Console.WriteLine("The game ended in a Draw!");
                Console.ReadLine();
                Ended = true;

            }
            
        }

    }
}


