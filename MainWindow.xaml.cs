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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace gecapp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            string playlist = Txt1.Text;
            string check = "https://open.spotify.com/playlist";
            if (playlist.Contains(check))
            {
                System.Diagnostics.Process.Start("https://open.spotify.com/playlist/6o8J71DQh6I8xaHZNb6Mvx?si=ggpnwIekSUCMw4fxprQLtQ");
            }
            else
            {
                MessageBox.Show("That doesn't look like a spotify playlist!", "Error!");
            }
        }
    }
}
