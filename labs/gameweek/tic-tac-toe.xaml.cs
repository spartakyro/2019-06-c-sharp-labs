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
using System.Threading;

namespace gameweek
{
    /// <summary>
    /// Interaction logic for tic_tac_toe.xaml
    /// </summary>
    public partial class tic_tac_toe : Page
    {
        public tic_tac_toe()
        {
            InitializeComponent();
            backgroundVid.Play();
            string selectedplayer1 = (App.Current as App).player1;
            playerturn.Content = selectedplayer1;
        }
        private bool turn = true;
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var player1 = turn;
            var player2 = !turn;
            Button b = (Button)sender;

            if(turn)
            {
                b.Content = "X";
               

            }
            else
            {
                b.Content = "O";
                
            }
            turn = !turn;
            b.IsEnabled = false;
            CheckWinner();
        }

        private void CheckWinner()
        {
            bool winner = false;
            if((TLbtn.Content == TCbtn.Content) &&(TCbtn.Content == TRbtn.Content) && (!TLbtn.IsEnabled))
            {
                winner = true;
            } else if ((MLbtn.Content == MCbtn.Content) && (MCbtn.Content == MRbtn.Content) && (!MLbtn.IsEnabled))
            {
                winner = true;
            } else if ((BLbtn.Content == BCbtn.Content) && (BCbtn.Content == BRbtn.Content) && (!BLbtn.IsEnabled))
            {
                winner = true;
            }

            else if ((TLbtn.Content == MLbtn.Content) && (MLbtn.Content == BLbtn.Content) && (!TLbtn.IsEnabled))
            {
                winner = true;
            }
            else if ((TCbtn.Content == MCbtn.Content) && (MCbtn.Content == BCbtn.Content) && (!TCbtn.IsEnabled))
            {
                winner = true;
            }
            else if ((TRbtn.Content == MRbtn.Content) && (MRbtn.Content == BRbtn.Content) && (!TRbtn.IsEnabled))
            {
                winner = true;
            }

            else if ((TLbtn.Content == MCbtn.Content) && (MCbtn.Content == BRbtn.Content) && (!TLbtn.IsEnabled))
            {
                winner = true;
            }
            else if ((TRbtn.Content == MCbtn.Content) && (MCbtn.Content == BLbtn.Content) && (!TRbtn.IsEnabled))
            {
                winner = true;
            }


            if (winner)
            {
                if(turn)
                {
                    MessageBox.Show("O Wins");

                } else
                {
                    MessageBox.Show("X wins");
                }
            }
        }

        private void BackgroundVid_MediaEnded(object sender, RoutedEventArgs e)
        {
            backgroundVid.Position = new TimeSpan(0);
        }
    }
}
