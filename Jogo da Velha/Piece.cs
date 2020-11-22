using JogoDaVelha.Enum;

namespace JogoDaVelha
{
    class Piece
    {

        public CrossOrCircle CrossOrCircle { get; set; }
        public Grid Grid { get; set; }
        public bool Cursor;

        public Piece(CrossOrCircle crossOrCircle, Grid grid, bool cursor = false)
        {

            CrossOrCircle = crossOrCircle;
            Grid = grid;
            Cursor = cursor;
        }
        public override string ToString()
        {
            if (Cursor)
            {
                if (CrossOrCircle == CrossOrCircle.X)
                {
                    return "[X]";
                }
                else if (CrossOrCircle == CrossOrCircle.O)
                {
                    return "[O]";
                }
                else
                {
                    return "[ ]";
                }
            }
            else
            {
                if (CrossOrCircle == CrossOrCircle.X)
                {
                    return " X ";
                }
                else if (CrossOrCircle == CrossOrCircle.O)
                {
                    return " O ";
                }
                else
                {
                    return "   ";
                }
            }
        }
        public override int GetHashCode()
        {
            return CrossOrCircle.GetHashCode() + Grid.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            if (!(obj is Piece))
            {
                return false;
            }
            Piece other = obj as Piece;

            return CrossOrCircle.Equals(other.CrossOrCircle) && Grid.Equals(other.Grid);
        }


    }
}
