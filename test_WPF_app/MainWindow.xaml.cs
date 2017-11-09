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

namespace test_WPF_app
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int counter = 0;
        public bool gameActive = true;
        public bool[] bc = new bool[9];
        //public Button btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9;

        Button btn1 = new Button();

        public MainWindow()
        {
            InitializeComponent();
            Reset();
        }

        // Enables or disables all the buttons.
        public void EnableButtons(bool b)
        {
            for (int i = 0; i < 9; i++)
            {
                bc[i] = !b;
            }
        }

        public void CheckForWinner()
        {
            /** 
             * The idea is to find a match for the game to end and set the 
             * gameActive variable to false and colour certain buttons.
             */

            // 1-2-3    1-4-7   1-5-9
            if (One.Content.Equals(Two.Content) && One.Content.Equals(Three.Content) && !One.Content.Equals(" ") && gameActive)
            {
                One.Background = Brushes.Green;
                Two.Background = Brushes.Green;
                Three.Background = Brushes.Green;
                EnableButtons(false);
                gameActive = false;
                Statement.Text = String.Format("The winner is player {0}!", One.Content);
            }
            if (One.Content.Equals(Four.Content) && One.Content.Equals(Seven.Content) && !One.Content.Equals(" ") && gameActive)
            {
                One.Background = Brushes.Green;
                Four.Background = Brushes.Green;
                Seven.Background = Brushes.Green;
                EnableButtons(false);
                gameActive = false;
                Statement.Text = String.Format("The winner is player {0}!", One.Content);
            }
            if (One.Content.Equals(Five.Content) && One.Content.Equals(Nine.Content) && !One.Content.Equals(" ") && gameActive)
            {
                One.Background = Brushes.Green;
                Five.Background = Brushes.Green;
                Nine.Background = Brushes.Green;
                EnableButtons(false);
                gameActive = false;
                Statement.Text = String.Format("The winner is player {0}!", One.Content);
            }

            // 2-5-8
            if (Two.Content.Equals(Five.Content) && Two.Content.Equals(Eight.Content) && !Two.Content.Equals(" ") && gameActive)
            {
                Two.Background = Brushes.Green;
                Five.Background = Brushes.Green;
                Eight.Background = Brushes.Green;
                EnableButtons(false);
                gameActive = false;
                Statement.Text = String.Format("The winner is player {0}!", Two.Content);
            }

            // 3-5-7    3-6-9
            if (Three.Content.Equals(Five.Content) && Three.Content.Equals(Seven.Content) && !Three.Content.Equals(" ") && gameActive)
            {
                Three.Background = Brushes.Green;
                Five.Background = Brushes.Green;
                Seven.Background = Brushes.Green;
                EnableButtons(false);
                gameActive = false;
                Statement.Text = String.Format("The winner is player {0}!", Three.Content);
            }
            if (Three.Content.Equals(Six.Content) && Three.Content.Equals(Nine.Content) && !Three.Content.Equals(" ") && gameActive)
            {
                Three.Background = Brushes.Green;
                Six.Background = Brushes.Green;
                Nine.Background = Brushes.Green;
                EnableButtons(false);
                gameActive = false;
                Statement.Text = String.Format("The winner is player {0}!", Three.Content);
            }

            // 4-5-6
            if (Four.Content.Equals(Five.Content) && Four.Content.Equals(Six.Content) && !Four.Content.Equals(" ") && gameActive)
            {
                Four.Background = Brushes.Green;
                Five.Background = Brushes.Green;
                Six.Background = Brushes.Green;
                EnableButtons(false);
                gameActive = false;
                Statement.Text = String.Format("The winner is player {0}!", Four.Content);
            }

            // 7-8-9
            if (Seven.Content.Equals(Eight.Content) && Seven.Content.Equals(Nine.Content) && !Seven.Content.Equals(" ") && gameActive)
            {
                Seven.Background = Brushes.Green;
                Eight.Background = Brushes.Green;
                Nine.Background = Brushes.Green;
                EnableButtons(false);
                gameActive = false;
                Statement.Text = String.Format("The winner is player {0}!", Seven.Content);
            }

            // Checks whether the match is draw or not
            if (counter == 9 && gameActive)
            {
                EnableButtons(false);
                gameActive = false;

                // Set the colour of the buttons to red.
                One.Background = Brushes.Red;
                Two.Background = Brushes.Red;
                Three.Background = Brushes.Red;
                Four.Background = Brushes.Red;
                Five.Background = Brushes.Red;
                Six.Background = Brushes.Red;
                Seven.Background = Brushes.Red;
                Eight.Background = Brushes.Red;
                Nine.Background = Brushes.Red;

                Statement.Text = "It's a tie! Press 'Restart' to play again.";
            }
        }

        private void One_Click(object sender, RoutedEventArgs e)
        {
            if (!bc[0])
            {
                if (counter % 2 == 0)
                {
                    (sender as Button).Content = "X";
                    if (gameActive)
                    {
                        Statement.Text = "Player O, make your move!";
                    }
                }
                else
                {
                    (sender as Button).Content = "O";
                    if (gameActive)
                    {
                        Statement.Text = "Player X, make your move!";
                    }
                }
                counter++;
            }
            bc[0] = true;
            CheckForWinner();
        }

        private void Two_Click(object sender, RoutedEventArgs e)
        {
            if (!bc[1])
            {
                if (counter % 2 == 0)
                {
                    (sender as Button).Content = "X";
                    if (gameActive)
                    {
                        Statement.Text = "Player O, make your move!";
                    }
                }
                else
                {
                    (sender as Button).Content = "O";
                    if (gameActive)
                    {
                        Statement.Text = "Player X, make your move!";
                    }
                }
                counter++;
            }
            bc[1] = true;
            CheckForWinner();
        }

        private void Three_Click(object sender, RoutedEventArgs e)
        {
            if (!bc[2])
            {
                if (counter % 2 == 0)
                {
                    (sender as Button).Content = "X";
                    if (gameActive)
                    {
                        Statement.Text = "Player O, make your move!";
                    }
                } else
                {
                    (sender as Button).Content = "O";
                    if (gameActive)
                    {
                        Statement.Text = "Player X, make your move!";
                    }
                }
                counter++;
            }
            bc[2] = true;
            CheckForWinner();
        }

        private void Four_Click(object sender, RoutedEventArgs e)
        {
            if (!bc[3])
            {
                if (counter % 2 == 0)
                {
                    (sender as Button).Content = "X";
                    if (gameActive)
                    {
                        Statement.Text = "Player O, make your move!";
                    }
                }
                else
                {
                    (sender as Button).Content = "O";
                    if (gameActive)
                    {
                        Statement.Text = "Player X, make your move!";
                    }
                }
                counter++;
            }
            bc[3] = true;
            CheckForWinner();
        }

        private void Five_Click(object sender, RoutedEventArgs e)
        {
            if (!bc[4])
            {
                if (counter % 2 == 0)
                {
                    (sender as Button).Content = "X";
                    if (gameActive)
                    {
                        Statement.Text = "Player O, make your move!";
                    }
                }
                else
                {
                    (sender as Button).Content = "O";
                    if (gameActive)
                    {
                        Statement.Text = "Player X, make your move!";
                    }
                }
                counter++;
            }
            bc[4] = true;
            CheckForWinner();
        }

        private void Six_Click(object sender, RoutedEventArgs e)
        {
            if (!bc[5])
            {
                if (counter % 2 == 0)
                {
                    (sender as Button).Content = "X";
                    if (gameActive)
                    {
                        Statement.Text = "Player O, make your move!";
                    }
                }
                else
                {
                    (sender as Button).Content = "O";
                    if (gameActive)
                    {
                        Statement.Text = "Player X, make your move!";
                    }
                }
                counter++;
            }
            bc[5] = true;
            CheckForWinner();
        }

        private void Seven_Click(object sender, RoutedEventArgs e)
        { 
            if (!bc[6])
            {
                if (counter % 2 == 0)
                {
                    (sender as Button).Content = "X";
                    if (gameActive)
                    {
                        Statement.Text = "Player O, make your move!";
                    }
                }
                else
                {
                    (sender as Button).Content = "O";
                    if (gameActive)
                    {
                        Statement.Text = "Player X, make your move!";
                    }
                }
                counter++;
            }
            bc[6] = true;
            CheckForWinner();
        }

        private void Eight_Click(object sender, RoutedEventArgs e)
        {
            if (!bc[7])
            {
                if (counter % 2 == 0)
                {
                    (sender as Button).Content = "X";
                    if (gameActive)
                    {
                        Statement.Text = "Player O, make your move!";
                    }
                }
                else
                {
                    (sender as Button).Content = "X";
                    if (gameActive)
                    {
                        Statement.Text = "Player X, make your move!";
                    }
                }
                counter++;
            }
            bc[7] = true;
            CheckForWinner();
        }

        private void Nine_Click(object sender, RoutedEventArgs e)
        {
            if (!bc[8])
            {
                if (counter % 2 == 0)
                {
                    (sender as Button).Content = "X";
                    if (gameActive)
                    {
                        Statement.Text = "Player O, make your move!";
                    }
                }
                else
                {
                    (sender as Button).Content = "O";
                    if (gameActive)
                    {
                        Statement.Text = "Player X, make your move!";
                    }
                }
                counter++;
            }
            bc[8] = true;
            CheckForWinner();
        }

        private void Restart_Click(object sender, RoutedEventArgs e)
        {
            Reset();
        }

        // Resets the game conditions.
        public void Reset()
        {
            Statement.Text = "Player X makes the first move!";

            counter = 0;
            gameActive = true;
            EnableButtons(true);

            One.Content = " ";
            Two.Content = " ";
            Three.Content = " ";
            Four.Content = " ";
            Five.Content = " ";
            Six.Content = " ";
            Seven.Content = " ";
            Eight.Content = " ";
            Nine.Content = " ";

            One.Background = Brushes.White;
            Two.Background = Brushes.White;
            Three.Background = Brushes.White;
            Four.Background = Brushes.White;
            Five.Background = Brushes.White;
            Six.Background = Brushes.White;
            Seven.Background = Brushes.White;
            Eight.Background = Brushes.White;
            Nine.Background = Brushes.White;
        }
    }
}
