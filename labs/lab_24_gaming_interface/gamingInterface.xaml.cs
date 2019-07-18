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
using System.IO;

namespace lab_24_gaming_interface
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            

            InitializeComponent();
            Initialise();
            if(File.Exists("Title.txt"))
            {
                WelcomeLabel.Content = File.ReadAllText("Title.txt");
                InputName.Text = WelcomeLabel.Content.ToString();
            }
            else
            {
                File.Create("Title.txt");
            }


         
            
        }
        void Initialise()
        {
           
            
            
        }

        /*when key_up event takes place, object will be item which caused
        the event ie key we pressed eg letter 'h'. EventArgs is an array of STRINGS
        which contains any relevant data for that event*/
        private void KeyUp_ChangeTitle(object sender,EventArgs e)
        {

            WelcomeLabel.Content = InputName.Text;
            File.WriteAllText("Title.txt", InputName.Text);

            
                      
        }

        private void Play_Button_Click(object sender, RoutedEventArgs e)
        {
            Q1 q = new Q1();
            this.Content = q;


           /* switch (InputName.Text)
            {
                case "assassins creed":
                    WelcomeLabel.Content = "Assassins Creed";
                    Assassins.Visibility = Visibility.Visible;
                    Assassins.Play();

                    
                    Dynasty.Stop();
                    Dynasty.Visibility = Visibility.Hidden;
                    Lethal.Stop();
                    Lethal.Visibility = Visibility.Hidden;
                    Pokemon.Stop();
                    Pokemon.Visibility = Visibility.Hidden;
                    Crisis.Stop();
                    Crisis.Visibility = Visibility.Hidden;
                    Xcom.Stop();
                    Xcom.Visibility = Visibility.Hidden;
                    break;
                   
                case "dynasty warriors":
                    WelcomeLabel.Content = "Dynasty Warriors 6 \n\n Empires";
                    Dynasty.Visibility = Visibility.Visible;
                    Dynasty.Play();

                    Assassins.Stop();
                    Assassins.Visibility = Visibility.Hidden;
                    
                    Lethal.Stop();
                    Lethal.Visibility = Visibility.Hidden;
                    Pokemon.Stop();
                    Pokemon.Visibility = Visibility.Hidden;
                    Crisis.Stop();
                    Crisis.Visibility = Visibility.Hidden;
                    Xcom.Stop();
                    Xcom.Visibility = Visibility.Hidden;
                    break;
                   
                
                case "lethal league":
                    WelcomeLabel.Content = "Lethal league\n\n Blaze";
                    Lethal.Visibility = Visibility.Visible;
                    Lethal.Play();

                    Assassins.Stop();
                    Assassins.Visibility = Visibility.Hidden;
                    Dynasty.Stop();
                    Dynasty.Visibility = Visibility.Hidden;
                    Pokemon.Stop();
                    Pokemon.Visibility = Visibility.Hidden;
                    Crisis.Stop();
                    Crisis.Visibility = Visibility.Hidden;
                    Xcom.Stop();
                    Xcom.Visibility = Visibility.Hidden;
                    break;

                case "pokemon":
                    WelcomeLabel.Content = "Pokemon";
                    Pokemon.Visibility = Visibility.Visible;
                    Pokemon.Play();

                    Assassins.Stop();
                    Assassins.Visibility = Visibility.Hidden;
                    Dynasty.Stop();
                    Dynasty.Visibility = Visibility.Hidden;
                    Lethal.Stop();
                    Lethal.Visibility = Visibility.Hidden;
                    Crisis.Stop();
                    Crisis.Visibility = Visibility.Hidden;
                    Xcom.Stop();
                    Xcom.Visibility = Visibility.Hidden;
                    break;

                case "time crisis":
                    WelcomeLabel.Content = "Time Crisis";
                    Crisis.Visibility = Visibility.Visible;
                    Crisis.Play();

                    Assassins.Stop();
                    Assassins.Visibility = Visibility.Hidden;
                    Dynasty.Stop();
                    Dynasty.Visibility = Visibility.Hidden;
                    Lethal.Stop();
                    Lethal.Visibility = Visibility.Hidden;
                    Xcom.Stop();
                    Xcom.Visibility = Visibility.Hidden;
                    Pokemon.Stop();
                    Pokemon.Visibility = Visibility.Hidden;
                    break;

                case "xcom":
                    WelcomeLabel.Content = "Xcom 2";
                    Xcom.Visibility = Visibility.Visible;
                    Xcom.Play();

                    Assassins.Stop();
                    Assassins.Visibility = Visibility.Hidden;
                    Dynasty.Stop();
                    Dynasty.Visibility = Visibility.Hidden;
                    Lethal.Stop();
                    Lethal.Visibility = Visibility.Hidden;
                    Crisis.Stop();
                    Crisis.Visibility = Visibility.Hidden;
                    Pokemon.Stop();
                    Pokemon.Visibility = Visibility.Hidden;
                    break;




                default:
                    WelcomeLabel.Content = "no movie found";
                    break;


            }*/


        }

       

        private void InputName_KeyDown(object sender, KeyEventArgs e)
        { 
            if(e.Key == Key.Enter)
            {
                WelcomeLabel.Content = "youve pressed enter";
            }

        }
    }
}
