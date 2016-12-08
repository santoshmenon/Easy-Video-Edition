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
        VideoPlayerViewModel mVM = new VideoPlayerViewModel();
        public ViewVideoPlayer()
        {
            InitializeComponent();
            this.mVM.InitializeVM(this);
            this.DataContext = mVM;
            
        }
    }
}
