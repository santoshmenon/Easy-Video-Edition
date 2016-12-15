using EasyVideoEdition.ViewModel;
using System.Windows;
using System.Windows.Controls;
namespace EasyVideoEdition.View
{
    /// <summary>
    /// Logique d'interaction pour ViewVideoPlayer.xaml
    /// </summary>
    public partial class ViewVideoPlayer : UserControl
    {

        public ViewVideoPlayer()
        {
            InitializeComponent();
            VideoPlayerViewModel.InitializeVM(this);
        }
    } 
}
