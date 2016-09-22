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
using System.Media;
using System.IO;

namespace BatalhaNaval
{
    public partial class MainWindow : Window
    {
        Board board;

        public MainWindow()
        {
            InitializeComponent();
            startGame();
        }

        private void startGame()
        {
            board = new Board(rP1, rP2, this, pa, pb);
            board.newBoard();
        }

        public void newScoreWindow(String winner)
        {
            SoundPlayer victory = new SoundPlayer(Properties.Resources.Victory);
            victory.Play();
            var window = new GameOverWindow(board, winner); 
            window.Owner = this;
            window.ShowDialog();
        }

#region Buttons //############################################################

        private void b00_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(a00);
        }

        private void b01_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(a01);
        }

        private void b02_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(a02);
        }

        private void b03_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(a03);
        }

        private void b04_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(a04);
        }

        private void b05_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(a05);
        }

        private void b06_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(a06);
        }

        private void b07_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(a07);
        }

        private void b10_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(a10);
        }

        private void b11_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(a11);
        }

        private void b12_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(a12);
        }

        private void b13_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(a13);
        }

        private void b14_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(a14);
        }

        private void b15_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(a15);
        }

        private void b16_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(a16);
        }

        private void b17_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(a17);
        }

        private void b20_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(a20);
        }

        private void b21_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(a21);
        }

        private void b22_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(a22);
        }

        private void b23_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(a23);
        }

        private void b24_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(a24);
        }

        private void b25_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(a25);
        }

        private void b26_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(a26);
        }

        private void b27_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(a27);
        }

        private void b30_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(a30);
        }

        private void b31_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(a31);
        }

        private void b32_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(a32);
        }

        private void b33_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(a33);
        }

        private void b34_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(a34);
        }

        private void b35_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(a35);
        }

        private void b36_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(a36);
        }

        private void b37_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(a37);
        }

        private void b40_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(a40);
        }

        private void b41_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(a41);
        }

        private void b42_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(a42);
        }

        private void b43_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(a43);
        }

        private void b44_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(a44);
        }

        private void b45_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(a45);
        }

        private void b46_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(a46);
        }

        private void b47_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(a47);
        }

        private void b50_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(a50);
        }

        private void b51_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(a51);
        }

        private void b52_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(a52);
        }

        private void b53_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(a53);
        }

        private void b54_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(a54);
        }

        private void b55_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(a55);
        }

        private void b56_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(a56);
        }

        private void b57_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(a57);
        }

        private void b60_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(a60);
        }

        private void b61_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(a61);
        }

        private void b62_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(a62);
        }

        private void b63_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(a63);
        }

        private void b64_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(a64);
        }

        private void b65_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(a65);
        }

        private void b66_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(a66);
        }

        private void b67_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(a67);
        }

        private void b70_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(a70);
        }

        private void b71_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(a71);
        }

        private void b72_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(a72);
        }

        private void b73_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(a73);
        }

        private void b74_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(a74);
        }

        private void b75_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(a75);
        }

        private void b76_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(a76);
        }

        private void b77_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(a77);
        }


//PLAYER 2 BUTTONS ###################################################
        private void b00c_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(b00);
        }

        private void b01c_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(b01);
        }

        private void b02c_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(b02);
        }

        private void b03c_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(b03);
        }

        private void b04c_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(b04);
        }

        private void b05c_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(b05);
        }

        private void b06c_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(b06);
        }

        private void b07c_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(b07);
        }

        private void b10c_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(b10);
        }

        private void b11c_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(b11);
        }

        private void b12c_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(b12);
        }

        private void b13c_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(b13);
        }

        private void b14c_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(b14);
        }

        private void b15c_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(b15);
        }

        private void b16c_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(b16);
        }

        private void b17c_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(b17);
        }

        private void b20c_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(b20);
        }

        private void b21c_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(b21);
        }

        private void b22c_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(b22);
        }

        private void b23c_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(b23);
        }

        private void b24c_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(b24);
        }

        private void b25c_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(b25);
        }

        private void b26c_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(b26);
        }

        private void b27c_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(b27);
        }

        private void b30c_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(b30);
        }

        private void b31c_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(b31);
        }

        private void b32c_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(b32);
        }

        private void b33c_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(b33);
        }

        private void b34c_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(b34);
        }

        private void b35c_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(b35);
        }

        private void b36c_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(b36);
        }

        private void b37c_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(b37);
        }

        private void b40c_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(b40);
        }

        private void b41c_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(b41);
        }

        private void b42c_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(b42);
        }

        private void b43c_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(b43);
        }

        private void b44c_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(b44);
        }

        private void b45c_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(b45);
        }

        private void b46c_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(b46);
        }

        private void b47c_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(b47);
        }

        private void b50c_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(b50);
        }

        private void b51c_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(b51);
        }

        private void b52c_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(b52);
        }

        private void b53c_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(b53);
        }

        private void b54c_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(b54);
        }

        private void b55c_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(b55);
        }

        private void b56c_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(b56);
        }

        private void b57c_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(b57);
        }

        private void b60c_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(b60);
        }

        private void b61c_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(b61);
        }

        private void b62c_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(b62);
        }

        private void b63c_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(b63);
        }

        private void b64c_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(b64);
        }

        private void b65c_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(b65);
        }

        private void b67c_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(b67);
        }

        private void b70c_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(b70);
        }

        private void b71c_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(b71);
        }

        private void b72c_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(b72);
        }

        private void b73c_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(b73);
        }

        private void b74c_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(b74);
        }

        private void b75c_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(b75);
        }

        private void b76c_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(b76);
        }

        private void b77c_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(b77);
        }

        private void b66c_Click(object sender, RoutedEventArgs e)
        {
            board.attWindow(b66);
        }
#endregion //##########################################################
    }//class
}//namespace
