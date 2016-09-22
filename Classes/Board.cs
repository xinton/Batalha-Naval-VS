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
using System.Collections;
using System.Media;
using System.IO;

namespace BatalhaNaval
{
    public class Board
    {
        static int BOARD_SIZE = 8;
        static int SHIPS_ON_BOARD = 6;
        int rightGuessesA, rightGuessesB;
        ArrayList ButtonsAL = new ArrayList();    
        Rectangle recP1, recP2;
        ProgressBar pBarP1, pBarP2;
        MainWindow mWindow;

        public static char EMPTY     = '0';
        public static char SUBMARINE = '1';
        public static char FRIGATE   = '2';
        public static char CARRIER   = '3';

        public char[,] theBoardA = new char[BOARD_SIZE, BOARD_SIZE];
        public char[,] theBoardB = new char[BOARD_SIZE, BOARD_SIZE];


        public Board(Rectangle r1, Rectangle r2, MainWindow mW, ProgressBar pA, ProgressBar pB)
        {
            recP1 = r1;
            recP2 = r2;

            pBarP1 = pA;
            pBarP2 = pB;

            mWindow = mW;
        }

        public void newBoard()
        {
            rightGuessesA = 10;
            rightGuessesB = 10;

            for (int i0=0; i0<BOARD_SIZE; i0++)
            {
                for(int i1=0; i1<BOARD_SIZE; i1++)
                {
                    theBoardA[i0,i1] = '0';
                }
            }
            for (int i0=0; i0<SHIPS_ON_BOARD; i0++)
            {
                if (i0 == 0) addCarrier(theBoardA);
                else if (i0 > 0 && i0 <= 2) addFrigate(theBoardA);
                else addSubmarine(theBoardA);
            }

            //#######################

            for (int i0 = 0; i0 < BOARD_SIZE; i0++)
            {
                for (int i1 = 0; i1 < BOARD_SIZE; i1++)
                {
                    theBoardB[i0, i1] = '0';
                }
            }
            for (int i0 = 0; i0 < SHIPS_ON_BOARD; i0++)
            {
                if (i0 == 0) addCarrier(theBoardB);
                else if (i0 > 0 && i0 <= 2) addFrigate(theBoardB);
                else addSubmarine(theBoardB);
            }
            printBoards();
        }


        private void addCarrier(char[,] theBoard)
        {
            Random rdnX = new Random();
            Random rdnY = new Random();
            Random rdnO = new Random();
            int Or = rdnO.Next(2);

            if (Or == 0)
            {
                int[] randonsX = new int[10000];
                int[] randonsY = new int[10000];
                for (int i0 = 0; i0 < randonsX.Length; i0++)
                {
                    randonsX[i0] = rdnY.Next(BOARD_SIZE - 2);
                }
                for (int i0 = 0; i0 < randonsX.Length; i0++)
                {
                    randonsY[i0] = rdnX.Next(BOARD_SIZE);
                }
                int x = randonsX[rdnO.Next(10000)];
                int y = randonsY[rdnO.Next(10000)];
                if ((theBoard[y, x] == '0') && ((theBoard[y, x + 1] == '0') && (theBoard[y, x + 2] == '0')))
                {
                    theBoard[y, x] = CARRIER;
                    theBoard[y, x + 1] = CARRIER;
                    theBoard[y, x + 2] = CARRIER;
                }
                else addCarrier(theBoard);
            }
            else if (Or == 1)
            {
                int[] randonsX = new int[10000];
                int[] randonsY = new int[10000];
                for (int i0 = 0; i0 < randonsX.Length; i0++)
                {
                    randonsX[i0] = rdnY.Next(BOARD_SIZE);
                }
                for (int i0 = 0; i0 < randonsX.Length; i0++)
                {
                    randonsY[i0] = rdnX.Next(BOARD_SIZE - 2);
                }
                int x = randonsX[rdnO.Next(10000)];
                int y = randonsY[rdnO.Next(10000)];

                if ((theBoard[y, x] == '0') && ((theBoard[y + 1, x] == '0') && (theBoard[y + 2, x] == '0')))
                {
                    theBoard[y, x] = CARRIER;
                    theBoard[y + 1, x] = CARRIER;
                    theBoard[y + 2, x] = CARRIER;
                }
                else addCarrier(theBoard);
            }
        }

        private void addFrigate(char[,] theBoard)
        {
            Random rdnX = new Random();
            Random rdnY = new Random();
            Random rdnO = new Random();
            int Or = rdnO.Next(2);

            if (Or == 0)
            {
                int[] randonsX = new int[10000];
                int[] randonsY = new int[10000];
                for (int i0 = 0; i0 < randonsX.Length; i0++)
                {
                    randonsX[i0] = rdnY.Next(BOARD_SIZE - 1);
                }
                for (int i0 = 0; i0 < randonsX.Length; i0++)
                {
                    randonsY[i0] = rdnX.Next(BOARD_SIZE);
                }
                int x = randonsX[rdnO.Next(10000)];
                int y = randonsY[rdnO.Next(10000)];

                if ((theBoard[y, x] == '0') && (theBoard[y, x + 1] == '0'))
                {
                    theBoard[y, x] = FRIGATE;
                    theBoard[y, x + 1] = FRIGATE;
                }
                else addFrigate(theBoard);
            }
            else if (Or == 1)
            {
                int[] randonsX = new int[10000];
                int[] randonsY = new int[10000];
                for (int i0 = 0; i0 < randonsX.Length; i0++)
                {
                    randonsX[i0] = rdnY.Next(BOARD_SIZE);
                }
                for (int i0 = 0; i0 < randonsX.Length; i0++)
                {
                    randonsY[i0] = rdnX.Next(BOARD_SIZE - 1);
                }
                int x = randonsX[rdnO.Next(10000)];
                int y = randonsY[rdnO.Next(10000)];

                if ((theBoard[y, x] == '0') && (theBoard[y + 1, x] == '0'))
                {
                    theBoard[y, x] = FRIGATE;
                    theBoard[y + 1, x] = FRIGATE;
                }
                else addFrigate(theBoard);
            }
        }

        private void addSubmarine(char[,] theBoard)
        {
            Random rdnX = new Random();
            Random rdnY = new Random();
            int x = rdnX.Next(BOARD_SIZE);
            int y = rdnY.Next(BOARD_SIZE);

            if (theBoard[y, x] == '0') theBoard[y, x] = SUBMARINE;
            else addSubmarine(theBoard);
        }

 // UTIL ##################################################################
        SoundPlayer explosion = new SoundPlayer(Properties.Resources.explosion);
        SoundPlayer wExplosion = new SoundPlayer(Properties.Resources.water_explosion);

        public void attWindow(Button btn)
        {
            //Console.WriteLine(btn.Name.Substring(0,1));
            if ( btn.Name.Substring(0,1).Equals("a") ) 
            {
                attWindow2(btn, theBoardA, btn.Name.Substring(0, 1)); 
            }
            else if (btn.Name.Substring(0,1).Equals("b")) 
            {
                attWindow2(btn, theBoardB, btn.Name.Substring(0, 1)); 
            }

        }//attWindow()

        private void attWindow2(Button btn, char[,] theBoard, String player)
        {
            ButtonsAL.Add(btn);

            String splX = btn.Name.Substring(1, 1);
            String splY = btn.Name.Substring(2);

            int x = convertButtonToCoord(splX);
            int y = convertButtonToCoord(splY);

            //Console.WriteLine(x+" | "+y);
            if (player == "a")
            {
                if (theBoard[y, x] == '0') { btn.IsEnabled = false; btn.Opacity = .5; changePlayer(0); wExplosion.Play(); }
                else if ((theBoard[y, x] == '1') && (btn.Background != Brushes.Yellow)) { btn.Background = Brushes.Yellow; rightGuessesA--; explosion.Play(); pBarP1.Value++; }
                else if ((theBoard[y, x] == '2') && (btn.Background != Brushes.Purple)) { btn.Background = Brushes.Purple; rightGuessesA--; explosion.Play(); pBarP1.Value++; }
                else if ((theBoard[y, x] == '3') && (btn.Background != Brushes.Green)) { btn.Background = Brushes.Green; rightGuessesA--; explosion.Play(); pBarP1.Value++; }
            }
            //Console.WriteLine(x+" | "+y);
            else if (player == "b")
            {
                if (theBoard[y, x] == '0') { btn.IsEnabled = false; btn.Opacity = .5; changePlayer(0); wExplosion.Play(); }
                else if ((theBoard[y, x] == '1') && (btn.Background != Brushes.Yellow)) { btn.Background = Brushes.Yellow; rightGuessesB--; explosion.Play(); pBarP2.Value++; }
                else if ((theBoard[y, x] == '2') && (btn.Background != Brushes.Purple)) { btn.Background = Brushes.Purple; rightGuessesB--; explosion.Play(); pBarP2.Value++; }
                else if ((theBoard[y, x] == '3') && (btn.Background != Brushes.Green)) { btn.Background = Brushes.Green; rightGuessesB--; explosion.Play(); pBarP2.Value++; }
            }
            //Console.WriteLine("gesses: " + guesses + " | Right: " + rightGuesses);
            //Console.WriteLine(rightGuessesA);
            if (rightGuessesA == 0)
                mWindow.newScoreWindow("P1");

            if (rightGuessesB == 0)
                mWindow.newScoreWindow("P2");

        }

        public void changePlayer(int player)
        {
            switch (player)
            {
                case 0:
                {
                    if(recP1.Opacity==0) {recP1.Opacity = 0.7; Canvas.SetZIndex(recP1, 10); recP2.Opacity = 0;  Canvas.SetZIndex(recP2, -1); }
                    else                 {recP1.Opacity = 0;   Canvas.SetZIndex(recP1, -1); recP2.Opacity = 0.7; Canvas.SetZIndex(recP2, 10);}
                    break;
                }
                case 1:
                {
                    recP1.Opacity = 0;   Canvas.SetZIndex(recP1, -1);
                    recP2.Opacity = 0.7; Canvas.SetZIndex(recP2, 10);
                    break;
                }
                case 2:
                {
                    recP1.Opacity = 0.7; Canvas.SetZIndex(recP1, 10);
                    recP2.Opacity = 0;   Canvas.SetZIndex(recP2, -1);
                    break;
                }  
            }
        }//changePlayer()

        public void resetGame()
        {
            Console.WriteLine("arraylist = "+ ButtonsAL.Count);
            for(int i=0; i<ButtonsAL.Count; i++)
            {
                Button bt = (Button)ButtonsAL[i];
                    SolidColorBrush seaColor = new SolidColorBrush();
                    seaColor = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF72AEF5"));
                bt.Background = seaColor;
                bt.IsEnabled=true;
                bt.Opacity=1;
            }
            ButtonsAL.Clear();
            Console.WriteLine("arraylist = "+ ButtonsAL.Count);
            pBarP1.Value = 0;
            pBarP2.Value = 0;

            newBoard();
        }     

        private int convertButtonToCoord(String sA)
        {
            char a = Convert.ToChar(sA);
            int coord=0;

            switch (a)
            {
                case '0':{coord=0; break;}
                case '1':{coord=1; break;}
                case '2':{coord=2; break;}
                case '3':{coord=3; break;}
                case '4':{coord=4; break;}
                case '5':{coord=5; break;}
                case '6':{coord=6; break;}
                case '7':{coord=7; break;}
            }
            return coord;
        }

        private void printBoards()
        {
            for (int i0 = 0; i0 < BOARD_SIZE; i0++)
            {
                for (int i1 = 0; i1 < BOARD_SIZE; i1++)
                {
                    Console.Write(theBoardA[i1, i0] + " ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");
            for (int i0 = 0; i0 < BOARD_SIZE; i0++)
            {
                for (int i1 = 0; i1 < BOARD_SIZE; i1++)
                {
                    Console.Write(theBoardB[i1, i0] + " ");
                }
                Console.WriteLine("");
            }
        }
    }//class
}//namspace
