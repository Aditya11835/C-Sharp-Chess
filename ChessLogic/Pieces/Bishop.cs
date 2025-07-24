
namespace ChessLogic
{
    public class Bishop : Piece
    {
        public override PieceType Type => PieceType.Bishop;
        public override Player Color { get; }
        public Bishop(Player color)
        {
            Color = color;
        }
        public override Piece Copy()
        {
            Bishop copy = new Bishop(Color);
            copy.HasMoved = HasMoved;
            return copy;
        }
        private static readonly Direction[] dirs = new Direction[]
        {
            Direction.NorthWest,
            Direction.SouthEast,
            Direction.NorthEast,
            Direction.SouthWest
        };
        public override IEnumerable<Move> GetMoves(Position from, Board board)
        {
            return MovePositionsInDirs(from, board, dirs).Select(to => new NormalMove(from, to));
        }
    }
}
