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

        
        public MainWindow()
        {
            InitializeComponent();
            backgroundVid.Play();
            Nameboxp2.Visibility = Visibility.Hidden;

        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {

            if (Startbtn.Content == "Start")
            {
                Wordjumble game1 = new Wordjumble();
                this.Content = game1;
                
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
    }
}
