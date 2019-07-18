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

namespace lab_17_rabbit_manual_click
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static List<Rabbit> rabbits = new List<Rabbit>();
        static int counter = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button01_Click(object sender, RoutedEventArgs e)
        {
            counter++;
            var r = new Rabbit(counter);
            rabbits.Add(r);
            //display rabbits
            ListBox03.Items.Clear();

            foreach(var rabbit in rabbits)
            {
                rabbit.age++; 

                ListBox03.Items.Add($"{rabbit.Name} is {rabbit.age} years old");
            }

            //for (int i = 1; i < 100; i++)
            //{
            //    Console.WriteLine("Loop" + i);

            //    foreach (Rabbit r in rabbits)
            //    {

            //        r.age++;
            //        Console.WriteLine($"ages are :{r.Name} is {r.age}");
            //    }

            //    System.Threading.Thread.Sleep(200);



            //    var rabbit = new Rabbit(i);
            //    rabbits.Add(rabbit);
            //    //Rabbit is the CLASS(blueprint)
            //    //rabbit is the actual real rabbit

            //}
        }
    }
}
