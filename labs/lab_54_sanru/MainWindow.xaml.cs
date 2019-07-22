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
using MahApps.Metro.Controls;
namespace lab_54_sanru
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public Color textbcolour = new Color();
        
        public MainWindow()
        {
            InitializeComponent();
            initialise();
            Backgroundvid.Play();
         
        }

        void initialise()
        {
            
        }

        private void Flippy_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameTextBox.Text))
            {   
                
                MessageBox.Show("Please enter your name");


            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void MetroWindow_MediaOpened(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
