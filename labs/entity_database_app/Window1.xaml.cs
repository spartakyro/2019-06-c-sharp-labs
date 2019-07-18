﻿using System;
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

namespace entity_database_app
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        List<Customer> customers;
        public Window1()
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
            ListViewCustomers.ItemsSource = customers;
        }

        private void ListViewCustomers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
