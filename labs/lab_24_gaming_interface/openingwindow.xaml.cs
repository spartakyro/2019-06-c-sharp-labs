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
using System.Windows.Navigation;

namespace lab_24_gaming_interface
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        bool nextWindow;

        public Window1()
        {
            InitializeComponent();
            Intro.Play();
        }

        private void NameEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            

            nameTextbox.Content = nameEntry.Text;

            
            
            


        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {

           

            /* Q1 q = new Q1();
             this.Content = q;*/


            if (string.IsNullOrWhiteSpace(nameEntry.Text))
             {
                 nameTextbox.Content = "invalid name";
             }
             else
             {
                 Console.WriteLine("");
                 nextWindow = true;
                 if(nextWindow == true)
                 {
                     Input_message.Visibility = Visibility.Collapsed;
                     nameTextbox.Visibility = Visibility.Collapsed;
                     startButton.Visibility = Visibility.Collapsed;
                     nameEntry.Visibility = Visibility.Collapsed;
                     Q1 question01 = new Q1();
                     this.Content = question01;           






                 }
             }



        }

        
    }


    
}
