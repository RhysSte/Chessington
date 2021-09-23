using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class Rook : Piece
    {
        public Rook(Player player)
            : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            var moves = new List<Square>();
            // find current location
            Square currentPosition = board.FindPiece(this);

            // find square one up from it
            Square newPosition;
         
            for (int i = currentPosition.Row + 1; i < GameSettings.BoardSize; i++)
            {
                newPosition = Square.At(i, currentPosition.Col); // 5, 5
                moves.Add(newPosition);
            }
            for (int i = currentPosition.Row - 1; i >= 0; i--)
            {
                newPosition = Square.At(i, currentPosition.Col);
                moves.Add(newPosition);
            }
            for (int i = currentPosition.Col + 1; i < GameSettings.BoardSize; i++)
            {
               newPosition = Square.At(currentPosition.Row, i);
               moves.Add(newPosition);
            }
            for (int i = currentPosition.Col -1; i >= 0; i--)
            {
                newPosition = Square.At(currentPosition.Row, i);
                moves.Add(newPosition);
            }

            return moves;

            


        }
    }
}