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

            var moves = new List<Square>();

            // find current location
            Square currentPosition = board.FindPiece(this);

            // find square one up from it
            Square newPosition;

            if (Player == Player.White)
            {
                newPosition = Square.At(currentPosition.Row - 1, currentPosition.Col);
                moves.Add(newPosition);

                if (currentPosition.Row == 6)
                {
                    newPosition = Square.At(currentPosition.Row - 2, currentPosition.Col);
                    moves.Add(newPosition);
                }
            }

            else 
            {
                newPosition = Square.At(currentPosition.Row + 1, currentPosition.Col);
                moves.Add(newPosition);

                if (currentPosition.Row == 1)
                {
                    newPosition = Square.At(currentPosition.Row + 2, currentPosition.Col);
                    moves.Add(newPosition);
                }
            }
            // board.findpiece


            //think about how we can make it so that it doesn't think you can moved on the lines
            //check if the piece has moved
            //

            //put square in list

   
            
            return moves;

        }
    }
}