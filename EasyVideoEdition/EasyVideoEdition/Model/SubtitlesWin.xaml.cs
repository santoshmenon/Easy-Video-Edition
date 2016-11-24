using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace EasyVideoEdition.Model
{
    /// <summary>
    /// Logique d'interaction pour SubtitlesWin.xaml
    /// </summary>
    public partial class SubtitlesWin : Window
    {
        Subtitles subtitles;
        public SubtitlesWin()
        {
            InitializeComponent();
            subtitles = new Subtitles("H:/Mes documents/4A/Videos/test.avi");
            this.DataContext = this;
            subtitles.ReadSrtFile();
            subtitles.PrintAllSubtitles();
     
        }

        private void buttonAddSub_Click(object sender, RoutedEventArgs e)
        {
            subtitles.AddSubtitle(textBoxStart.Text, textBoxEnd.Text, textBoxText.Text);
        }

        private void buttonCreateFile_Click(object sender, RoutedEventArgs e)
        {
            subtitles.CreateSrtFile();
        }
    }
}
