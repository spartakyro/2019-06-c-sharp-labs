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

namespace snaplab_03_wpf_crud
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Product> products;
        Product product;
        public MainWindow()
        {
            InitializeComponent();
            Initialise();
        }
        private void Initialise()
        {
            using (var db = new NorthwindEntities())
            {
                products = db.Products.ToList();
            }
            productListView.ItemsSource = products;
            
        }

        private void ProductListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            using (var db = new NorthwindEntities())
            {
                 products = db.Products.ToList();
            }

            var ProID = productListView.DisplayMemberPath = "ProductID";
            productListView.DisplayMemberPath = "ProductName";
            ProductName.Text = ;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ProductName_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void ProductName_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
           if(ProductName.Text == null)
            {

            }
        }
    }
}
