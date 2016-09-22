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
using System.Media;
using System.IO;

namespace BatalhaNaval
{
    /// <summary>
    /// Interaction logic for GameOverWindow.xaml
    /// </summary>
    public partial class GameOverWindow : Window
    {
        public Board board;


        public GameOverWindow()
        {
            InitializeComponent();
        }

        public GameOverWindow(Board brd, String winner)
        {
            board = brd;
            InitializeComponent();
            tbkScore.Text = winner;
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.click);
            player.Play();
            board.resetGame();
            board.changePlayer(1);
            this.Close();
        }
    }
}
