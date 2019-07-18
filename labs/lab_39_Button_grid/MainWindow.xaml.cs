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

namespace lab_39_Button_grid
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Button> buttons = new List<Button>();
        public MainWindow()
        {
            InitializeComponent();
            Initialise();
        }

        void Initialise()
        {
            for(int i = 0; i < 100; i++)
            {
                var b = new Button();
                int buttonNumber = (i + 1); 
                b.Name = "Button" + buttonNumber.ToString();
                b.Content = buttonNumber.ToString();
                b.Click += new RoutedEventHandler(button_click);
                buttons.Add(b);

                MainGrid.Children.Add(b);

                Grid.SetColumn(b, i % 10);
                Grid.SetRow(b, i / 10);

               int rand = RandomNumberGenerator(0, 6);
                System.Threading.Thread.Sleep(15);

                switch (rand)
                {
                    case 1:
                        b.Background = Brushes.Blue;
                        break;
                    case 2:
                        b.Background = Brushes.Red;
                        break;
                    case 3:
                        b.Background = Brushes.Green;
                        break;
                    case 4:
                        b.Background = Brushes.Purple;
                        break;
                    case 5:
                        b.Background = Brushes.Yellow;
                        break;
                    default:
                        b.Background = Brushes.Pink;
                        break;
                }
            }
        }

        private void button_click(object sender, EventArgs e)
        {
            var b = (Button)sender;
            MessageBox.Show($"hey you clicked button {b.Name}, its at row {Grid.GetRow(b)} and column {Grid.GetColumn(b)}");


            /* generate random number between 1 and 6
               match number with enum number(use casting)
               set colour of button to be chosen colour
             */

            int rand = RandomNumberGenerator(1, 5);

            switch (rand)
            {
                case 1:
                    b.Background = Brushes.Blue;
                    break;
                case 2:
                    b.Background = Brushes.Red;
                    break;
                case 3:
                    b.Background = Brushes.Green;
                    break;
                case 4:
                    b.Background = Brushes.Purple;
                    break;
                case 5:
                    b.Background = Brushes.Yellow;
                    break;
            }


        }
        private int RandomNumberGenerator(int start,int end)
        {
            Random randomizer = new Random();
            int RandomNum = randomizer.Next(start, end);

            return RandomNum;
        }
        
    }

    

    enum colours
    {
        blue,red,green,yellow,purple,pink
    }
}
