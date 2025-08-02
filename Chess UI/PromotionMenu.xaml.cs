using System.Windows.Controls;
using System.Windows.Input;
using ChessLogic;

namespace Chess_UI
{
    public partial class PromotionMenu : UserControl
    {
        public event Action<PieceType> PieceSelected;
        public PromotionMenu(Player player)
        {
            InitializeComponent();
            QueenImage.Source = Images.GetImage(player, PieceType.Queen);
            BishopImage.Source = Images.GetImage(player, PieceType.Bishop);
            KnightImage.Source = Images.GetImage(player, PieceType.Knight);
            RookImage.Source = Images.GetImage(player, PieceType.Rook);
        }

        private void QueenImg_MouseDown(object sender, MouseButtonEventArgs e)
        {
            PieceSelected?.Invoke(PieceType.Queen);
        }
        private void RookImg_MouseDown(object sender, MouseButtonEventArgs e)
        {
            PieceSelected?.Invoke(PieceType.Rook);
        }
        private void KnightImg_MouseDown(object sender, MouseButtonEventArgs e)
        {
            PieceSelected?.Invoke(PieceType.Knight);
        }
        private void BishopImg_MouseDown(object sender, MouseButtonEventArgs e)
        {
            PieceSelected?.Invoke(PieceType.Bishop);
        }
    }
}
