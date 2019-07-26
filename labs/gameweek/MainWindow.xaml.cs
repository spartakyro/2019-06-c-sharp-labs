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

namespace gameweek
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string playerOne = "";
        string playerTwo = "";
        int Player1Score = 0; 
        WordJumbleScoreBoardEntities3 db;
        Wordjumble jumble;
        List<LB> highscores;

        public MainWindow()
        {
            InitializeComponent();
            backgroundVid.Play();
            Nameboxp2.Visibility = Visibility.Hidden;

           

        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            playerOne = Player1name.Content.ToString();
            playerTwo = Player2name.Content.ToString();
            

            if (Startbtn.Content == "Start")
            {
                Wordjumble game1 = new Wordjumble();
                this.Content = game1;


                using (var db = new WordJumbleScoreBoardEntities3())
                {
                    LB newPlayer = new LB();
                    LB newPlayer2 = new LB();
                    newPlayer.Name = playerOne;
                    newPlayer.Score = 0;
                    newPlayer2.Name = playerTwo;
                    newPlayer2.Score = 0;
                    db.LBs.Add(newPlayer);
                    db.LBs.Add(newPlayer2);
                    db.SaveChanges();
                }


                //HighScore.ItemsSource = db.LBs.ToList();
            }

            if (string.IsNullOrWhiteSpace(Namebox.Text))
            {

                Namebox.Background = Brushes.Red;
                Namebox.Opacity = 0.3;

                if (Namebox.Background == Brushes.Red)
                {

                    await Task.Delay(500);
                    Namebox.Background = Brushes.Aqua;
                    Namebox.Opacity = 0.7;

                }

            }
            else
            {
                
                Player1name.Content = Namebox.Text;
                Namebox.Text = " ";
                Namebox.Visibility = Visibility.Hidden;
                (App.Current as App).player1 = Player1name.Content.ToString();

                if(Namebox.Visibility == Visibility.Hidden)
                {
                    Nameboxp2.Visibility = Visibility.Visible;

                }
            }


            

            if (string.IsNullOrWhiteSpace(Nameboxp2.Text))
            {

                Namebox.Background = Brushes.Red;
                Namebox.Opacity = 0.3;

                if (Namebox.Background == Brushes.Red)
                {

                    await Task.Delay(500);
                    Namebox.Background = Brushes.Aqua;
                    Namebox.Opacity = 0.7;

                }

            }
            else 
            {
                Player2name.Content = Nameboxp2.Text;
                Nameboxp2.Text = " ";
                (App.Current as App).player2 = Player2name.Content.ToString();
                Startbtn.Content = "Start";
                    
                    

                
            }

           









        }

        private void HighScore_Loaded(object sender, RoutedEventArgs e)
        {
            using (var db = new WordJumbleScoreBoardEntities3())
            {
                //highscores = db.LBs.ToList();
                highscores = db.LBs.OrderByDescending(o => o.Score).Take(8).ToList();
            }

            HighScore.ItemsSource = highscores;
        }
    }
}
