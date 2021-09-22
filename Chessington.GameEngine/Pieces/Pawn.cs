using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class Pawn : Piece
    {
        public Pawn(Player player) 
            : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            
            

            // find current location
            Square currentPosition = board.FindPiece(this);

            // find square one up from it
            Square newPosition;

            if (Player == Player.White)
            {
                newPosition = Square.At(currentPosition.Row - 1, currentPosition.Col);
            }
            else
            {
                newPosition = Square.At(currentPosition.Row + 1, currentPosition.Col);
            }


            // board.findpiece

            //put square in list

            var moves = new List<Square>();
            moves.Add(newPosition);
            return moves;

        }
    }
}