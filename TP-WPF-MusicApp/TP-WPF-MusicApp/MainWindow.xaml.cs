using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TP_WPF_MusicApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataBase.Initialize();
        }

        private void Pop_Click(object sender, RoutedEventArgs e)
        {
            SortAndDisplayByGenre("Pop");
        }

        private void Rap_Click(object sender, RoutedEventArgs e)
        {
            SortAndDisplayByGenre("Rap");
        }

        private void Folk_Click(object sender, RoutedEventArgs e)
        {
            SortAndDisplayByGenre("Folk");
        }

        private void SortAndDisplayByGenre(string genre)
        {
            DisplayMusics.Text = "";
            foreach (Music music in DataBase.Musics.Where(x => x.Genre == genre))
            {
                DisplayMusics.Text += "\n- \"" + music.Title + "\" by " + music.Artist + " (" + music.Duration + "min) [streamed " + music.NumberOfStreams + " times]";
            }
        }
    }
}