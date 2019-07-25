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
        //Wordjumble newConstructor = new Wordjumble();
        string selectedplayer1 = (App.Current as App).player1;
        string selectedplayer2 = (App.Current as App).player2;

        public List<Button> turnoff = new List<Button>();
        bool isoff;
        public tic_tac_toe()
        {
            
            InitializeComponent();

            turnoff.Add(TLbtn);
            turnoff.Add(TCbtn);
            turnoff.Add(TRbtn);
            turnoff.Add(MLbtn);
            turnoff.Add(MCbtn);
            turnoff.Add(MRbtn);
            turnoff.Add(BLbtn);
            turnoff.Add(BCbtn);
            turnoff.Add(BRbtn);

            isoff = false;
            
        }
        private bool turn = true;

        public void off()
        {
            foreach (var btn in turnoff)
            {
                btn.Visibility = Visibility.Collapsed;

                //myConstructor.WJToTTT();
            }
        }
        
        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            
            Button b = (Button)sender;

            if(playerturn.Content == selectedplayer1)
            {
                turn = turn;
            }


            if (playerturn.Content == selectedplayer2)
            {
                turn = !turn;
            }

            if (turn)
            {
               
                b.Content = "X";

               

            }
            else
            {
                
                b.Content = "O";
                
            }

            //turn = !turn;
            
            foreach(var item in turnoff)
            {
                item.IsEnabled = false;
                
                isoff = true;
            
            }

            foreach (var item in turnoff)
            {
                await Task.Delay(1000);
                item.Visibility = Visibility.Hidden;
            }

            KeepAlive = true;


            
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
                    MessageBox.Show("X Wins");

                } else
                {
                    MessageBox.Show("O wins");
                }
            }
        }

       /*private void BackgroundVid_MediaEnded(object sender, RoutedEventArgs e)
        {
           // backgroundVid.Position = new TimeSpan(0);
        }*/ 

            /*
        private void Backbtn_Click(object sender, RoutedEventArgs e)
        {
            if(isoff == true)
            {
                foreach(var btn in turnoff)
                {
                    btn.Visibility = Visibility.Hidden;

                //myConstructor.WJToTTT();
                }
                TTTToWJ();
            }
            
        }
        */
        public void TTTToWJ()
        {
            //NavigationService.GoBack();

            //myConstructor.WJToTTTOn();
            //System.Threading.Thread.Sleep(1000);
            //navwindow.Navigate(new Wordjumble());
        }
    }
}
