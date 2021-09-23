using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class Bishop : Piece
    {
        public Bishop(Player player)
            : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            var moves = new List<Square>();

            Square currentPosition = board.FindPiece(this);

            Square newPosition;

            for (int i = 1; i < GameSettings.BoardSize; i++)
            {
                newPosition = Square.At(currentPosition.Row + i, currentPosition.Col + i);
                if (newPosition.Row < GameSettings.BoardSize && newPosition.Row >= 0 && newPosition.Col < GameSettings.BoardSize && newPosition.Col >= 0)
                {
                    moves.Add(newPosition);
                }
                newPosition = Square.At(currentPosition.Row + i, currentPosition.Col - i);
                if (newPosition.Row < GameSettings.BoardSize && newPosition.Row >= 0 && newPosition.Col < GameSettings.BoardSize && newPosition.Col >= 0)
                {
                    moves.Add(newPosition);
                }
                newPosition = Square.At(currentPosition.Row - i, currentPosition.Col - i);
                if (newPosition.Row < GameSettings.BoardSize && newPosition.Row >= 0 && newPosition.Col < GameSettings.BoardSize && newPosition.Col >= 0)
                {
                    moves.Add(newPosition);
                }
                newPosition = Square.At(currentPosition.Row - i, currentPosition.Col + i);
                if (newPosition.Row < GameSettings.BoardSize && newPosition.Row >= 0 && newPosition.Col < GameSettings.BoardSize && newPosition.Col >= 0)
                {
                    moves.Add(newPosition);
                }
            }

            return moves;
            
        }        
    }
}