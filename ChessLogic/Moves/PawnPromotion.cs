namespace ChessLogic
{
    public class PawnPromotion:Move
    {
        public override MoveType Type => MoveType.PawnPromotion;
        public override Position FromPos { get; }
        public override Position ToPos { get; }
        private readonly PieceType newType;
        public PawnPromotion(Position from,  Position to, PieceType newType)
        {
            FromPos = from;
            ToPos = to;
            this.newType = newType;
        }
        private Piece CreatePromotionPiece(Player color)
        {
            return newType switch
            {
                PieceType.Knight => new Knight(color),
                PieceType.Bishop => new Bishop(color),
                PieceType.Rook => new Rook(color),
                PieceType.Queen => new Queen(color),
                _ => new Queen(color)
            };
        }
        public override void Execute(Board board)
        {
            Piece pawn = board[FromPos];
            board[FromPos] = null;

            Piece promotedPiece = CreatePromotionPiece(pawn.Color);
            promotedPiece.HasMoved = true;
            board[ToPos] = promotedPiece;
        }

    }
}
