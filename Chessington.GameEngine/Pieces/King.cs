using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class King : Piece
    {
        public King(Player player)
            : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            var moves = new List<Square>();

            Square currentPosition = board.FindPiece(this);

            Square newPosition;
            newPosition = Square.At(currentPosition.Row + 1, currentPosition.Col + 1);
            if (newPosition.Row < GameSettings.BoardSize && newPosition.Row >= 0 && newPosition.Col < GameSettings.BoardSize && newPosition.Col >= 0)
            {
                moves.Add(newPosition);
            }
            newPosition = Square.At(currentPosition.Row - 1, currentPosition.Col - 1);
            if (newPosition.Row < GameSettings.BoardSize && newPosition.Row >= 0 && newPosition.Col < GameSettings.BoardSize && newPosition.Col >= 0)
            {
                moves.Add(newPosition);
            }
            newPosition = Square.At(currentPosition.Row - 1, currentPosition.Col + 1);
            if (newPosition.Row < GameSettings.BoardSize && newPosition.Row >= 0 && newPosition.Col < GameSettings.BoardSize && newPosition.Col >= 0)
            {
                moves.Add(newPosition);
            }
            newPosition = Square.At(currentPosition.Row + 1, currentPosition.Col - 1);
            if (newPosition.Row < GameSettings.BoardSize && newPosition.Row >= 0 && newPosition.Col < GameSettings.BoardSize && newPosition.Col >= 0)
            {
                moves.Add(newPosition);
            }
            newPosition = Square.At(currentPosition.Row + 1, currentPosition.Col);
            if (newPosition.Row < GameSettings.BoardSize && newPosition.Row >= 0 && newPosition.Col < GameSettings.BoardSize && newPosition.Col >= 0)
            {
                moves.Add(newPosition);
            }
            newPosition = Square.At(currentPosition.Row - 1, currentPosition.Col);
            if (newPosition.Row < GameSettings.BoardSize && newPosition.Row >= 0 && newPosition.Col < GameSettings.BoardSize && newPosition.Col >= 0)
            {
                moves.Add(newPosition);
            }
            newPosition = Square.At(currentPosition.Row , currentPosition.Col + 1);
            if (newPosition.Row < GameSettings.BoardSize && newPosition.Row >= 0 && newPosition.Col < GameSettings.BoardSize && newPosition.Col >= 0)
            {
                moves.Add(newPosition);
            }
            newPosition = Square.At(currentPosition.Row, currentPosition.Col - 1);
            if (newPosition.Row < GameSettings.BoardSize && newPosition.Row >= 0 && newPosition.Col < GameSettings.BoardSize && newPosition.Col >= 0)
            {
                moves.Add(newPosition);
            }

            return moves;
        }
    }
}