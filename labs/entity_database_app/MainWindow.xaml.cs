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

namespace entity_database_app
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
            using (var db = new NorthwindEntities())
            {
                customers = db.Customers.ToList();
            }

            // ListboxCustomer.DisplayMemberPath = "ContactName";
            ListboxCustomer.ItemsSource = customers;

           

            



        }

       
            
          

        private void ListboxCustomer_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            customer = (Customer)ListboxCustomer.SelectedItem;
            ListboxCustomerLog.Items.Insert(0,"");
            ListboxCustomerLog.Items.Insert(0,DateTime.Now);
            ListboxCustomerLog.Items.Insert(0,"Customer Selected");
            ListboxCustomerLog.Items.Insert(0,$"{customer.CustomerID, -7},{customer.ContactName}");

            IdLabel.Content = ($"{customer.CustomerID}");
            NameLabel.Content = ($"{customer.ContactName}");
            CompanyLabel.Content = ($"{customer.CompanyName}");
            CityLabel.Content = ($"{customer.City}");
            CountryLabel.Content = ($"{customer.Country}");
        }

        private async void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            var newCustomer = new Customer() { };
            if(IdText.Text != "" && CompanyText.Text != "")
            {
                newCustomer.ContactName = NameText.Text;
                newCustomer.CompanyName = CompanyText.Text;
                newCustomer.City = CityText.Text;
                newCustomer.CompanyName = CountryText.Text;
                newCustomer.CustomerID = IdText.Text;

                customers.Add(newCustomer);

                ListboxCustomer.ItemsSource = null;
                ListboxCustomer.ItemsSource = customers;

            }




            
            if(string.IsNullOrWhiteSpace(IdText.Text))
            {
                IdText.Background = Brushes.Red;
                IdText.Opacity = 0.3;

                if (IdText.Background == Brushes.Red)
                {

                    await Task.Delay(1000);
                    IdText.Background = Brushes.Snow;
                    IdText.Opacity = 0.7;

                }       


            }
           
        }

        private void ClearBtn_Click(object sender, RoutedEventArgs e)
        {
           IdLabel.Content = "";
           NameLabel.Content = "";
           CityLabel.Content = "";
           CompanyLabel.Content = "";
           CountryLabel.Content = "";

            IdText.Text = "";
            NameText.Text = "";
            CityText.Text = "";
            CompanyText.Text = "";
            CountryText.Text = "";

        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            if(EditBtn.Content.ToString() == "Edit")
            {
                EditBtn.Content = "Save";
                if (customer != null)
                {
                    MessageBox.Show($"about to edit customer {customer.CustomerID}");
                }

                NameText.Text = customer.ContactName;
                CompanyText.Text = customer.CompanyName;
                CityText.Text = customer.City;
                CountryText.Text = customer.Country;
                IdText.Text = customer.CustomerID;
                IdText.IsEnabled = false;

            }
            else if(EditBtn.Content.ToString() == "Save")
            {
                if (customer != null)
                {
                    using(var db = new NorthwindEntities())
                    {
                        Customer customerToEdit = db.Customers.Where(c => c.CustomerID == customer.CustomerID).FirstOrDefault();
                        MessageBox.Show($" customer {customerToEdit.CustomerID} has been edited");
                        customerToEdit.ContactName = NameText.Text;
                        customerToEdit.City = CityText.Text;
                        customerToEdit.CompanyName = CompanyText.Text;
                        customerToEdit.Country = CountryText.Text;
                        customerToEdit.ContactName = NameText.Text;
                        db.SaveChanges();
                        ListboxCustomer.ItemsSource = null;
                        customers = db.Customers.ToList();
                        ListboxCustomer.ItemsSource = customers;
                    }

                    EditBtn.Content = "Edit";

                }

            }


            
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            if(DeleteBtn.Content.ToString() == "Delete")
            {
                
                if(customer == null)
                {
                    MessageBox.Show("no customer selected");
                }
                else
                {
                    DeleteBtn.Content = "Confirm";
                    DeleteBtn.Background = Brushes.Red;
                }
                   
            }
        }

        private void CityText_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }

   
}

            

