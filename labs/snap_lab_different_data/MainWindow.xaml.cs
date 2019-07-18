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

namespace snap_lab_different_data
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Customer> customers;
        Customer customer;
        public MainWindow()
        {
            InitializeComponent();
            Initialise();
        }



        void Initialise()
        {
            using(var db = new NorthwindEntities())
            {
                customers = db.Customers.ToList();
            }
            ListBoxCustomers.DisplayMemberPath = "ContactName";
            ListBoxCustomers.ItemsSource = customers;

            
        }





        private void ListBoxCustomers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            customer = (Customer)ListBoxCustomers.SelectedItem;
            NameInTotal.Content = ($"{customer.ContactName}");
        }

        private async void SelectName_Click(object sender, RoutedEventArgs e)
        {

            if(string.IsNullOrWhiteSpace(NameInTotal.Content.ToString()))
            {
                NameInTotal.Background = Brushes.Red;

                if(NameInTotal.Background == Brushes.Red)
                {
                    await Task.Delay(1000);
                    NameInTotal.Background = Brushes.LightSeaGreen;
                }
               
            }


            /*else
            {
                SelectName.Content = "Change Name";
                LBHider.Visibility = Visibility.Hidden;
            }*/
            

            


           


          

        }
    }
}
