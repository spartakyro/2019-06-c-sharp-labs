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

namespace lab_48_business_search
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    
    public partial class MainWindow : Window
    {
        List<string> cities;
        List<Customer> customers;
        List<Product> products;
        List<Order> orders;
        List<Customer> customerFound;


        Customer customer;
        public MainWindow()
        {
            InitializeComponent();
            Initialise();
        }

        void Initialise()
        {
            using (var db = new NorthwindEntities1())
            {
                customers = db.Customers.ToList();

                //cities = (from c in db.Customers select c.City).Distinct().ToList();
            }
            ListViewCustomer.ItemsSource = customers;
           // combotesterCity.ItemsSource = cities;
        }

          

        private void Textboxcust_IsMouseDirectlyOverChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
           searchcust.Text = "";

            
        }

        private void Combotyester_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            /*var city = combotesterCity.SelectedItem;
            using(var db = new NorthwindEntities1())
            {
                customerFound = db.Customers.Where(c => c.ContactName.Contains(searchcust.Text)).ToList();

            }*/

            
        }

        private void Searchcust_TextChanged(object sender, TextChangedEventArgs e)
        {



            using (var db = new NorthwindEntities1())
            {
                customers = db.Customers.ToList();
            }
            ListViewCustomer.DisplayMemberPath = "ContactName";
            ListViewCustomer.ItemsSource = customers;

            /*using (var db = new NorthwindEntities1())
                {

                    List<Customer> retCustomers = db.Customers.Where(p => p.ContactName.Contains(searchcust.Text)).ToList();

                    ListViewCustomer.DisplayMemberPath = null;
                    ListViewCustomer.DisplayMemberPath = "Contact Name";
                    //ListViewCustomer.ItemsSource = null;
                    //   ListViewCustomer.ItemsSource = retCustomers;

                }*/
            
        }

        private void ListViewCustomer_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
