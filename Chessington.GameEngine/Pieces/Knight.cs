using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class Knight : Piece
    {
        public Knight(Player player)
            : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            var moves = new List<Square>();
            // find current location
            Square currentPosition = board.FindPiece(this);

            // find square one up from it
            Square newPosition;

            newPosition = Square.At(currentPosition.Row + 2, currentPosition.Col + 1);
            if (newPosition.Row < GameSettings.BoardSize && newPosition.Row >= 0 && newPosition.Col < GameSettings.BoardSize && newPosition.Col >= 0)
            {
                moves.Add(newPosition);
            }
            newPosition = Square.At(currentPosition.Row + 2, currentPosition.Col - 1);
            if (newPosition.Row < GameSettings.BoardSize && newPosition.Row >= 0 && newPosition.Col < GameSettings.BoardSize && newPosition.Col >= 0)
            {
                moves.Add(newPosition);
            }
            newPosition = Square.At(currentPosition.Row - 2, currentPosition.Col + 1);
            if (newPosition.Row < GameSettings.BoardSize && newPosition.Row >= 0 && newPosition.Col < GameSettings.BoardSize && newPosition.Col >= 0)
            {
                moves.Add(newPosition);
            }
            newPosition = Square.At(currentPosition.Row - 2, currentPosition.Col - 1);
            if (newPosition.Row < GameSettings.BoardSize && newPosition.Row >= 0 && newPosition.Col < GameSettings.BoardSize && newPosition.Col >= 0)
            {
                moves.Add(newPosition);
            }
            newPosition = Square.At(currentPosition.Row - 1, currentPosition.Col + 2);
            if (newPosition.Row < GameSettings.BoardSize && newPosition.Row >= 0 && newPosition.Col < GameSettings.BoardSize && newPosition.Col >= 0)
            {
                moves.Add(newPosition);
            }
            newPosition = Square.At(currentPosition.Row + 1, currentPosition.Col + 2);
            if (newPosition.Row < GameSettings.BoardSize && newPosition.Row >= 0 && newPosition.Col < GameSettings.BoardSize && newPosition.Col >= 0)
            {
                moves.Add(newPosition);
            }
            newPosition = Square.At(currentPosition.Row - 1, currentPosition.Col - 2);
            if (newPosition.Row < GameSettings.BoardSize && newPosition.Row >= 0 && newPosition.Col < GameSettings.BoardSize && newPosition.Col >= 0)
            {
                moves.Add(newPosition);
            }
            newPosition = Square.At(currentPosition.Row + 1, currentPosition.Col - 2);
            if (newPosition.Row < GameSettings.BoardSize && newPosition.Row >= 0 && newPosition.Col < GameSettings.BoardSize && newPosition.Col >= 0)
            {
                moves.Add(newPosition);
            }


            // diagonal twice, left one down one 
            //up two row one coloum left 
            return moves;
        }
    }
}