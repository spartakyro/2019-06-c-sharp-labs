using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;
using System.Data;

namespace Bluebay_sql_tests
{
    class Program
    {
        

        static void Main(string[] args)
        {
            var secret = Environment.GetEnvironmentVariable("kyrosSecretPassword");
            var connectionString = $"Data Source=localhost,1433;User ID=SA;Password={secret};Connect Timeout=30;Initial Catalog=Northwind;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            List<Customer> customers = new List<Customer>();
            

            using (var connection = new SqlConnection($"Data Source=localhost,1433;User ID=SA;Password={secret};Connect Timeout=30;Initial Catalog=Northwind;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                connection.Open();



                // 1.1
                /* using (var command = new SqlCommand("Select * From Customers where city in ('london' , 'paris')", connection))
                 {
                     var sqlreader = command.ExecuteReader();

                     while (sqlreader.Read())
                     {
                         string CustomerID = sqlreader["CustomerID"].ToString();
                         string CompanyName = sqlreader["CompanyName"].ToString();
                         string CustomerName = sqlreader["ContactName"].ToString();
                         string City = sqlreader["city"].ToString();


                         var customer = new Customer(CustomerID, CustomerName, CompanyName, City);


                         customers.Add(customer);

                         Console.WriteLine($"customerID : {customer.CustomerID,-10}, Name : {customer.ContactName,-20}, Company : {customer.CompanyName}, City : {customer.City}");

                     }



                 }*/

                //1.2
                List<Product> products = new List<Product>();
                using (var command01 = new SqlCommand("Select * from Products where QuantityPerUnit like ('%bottle%')", connection))
                {
                    /*var sqlreader01 = command01.ExecuteReader();

                    while(sqlreader01.Read())
                    {
                        int ProductID = (int)sqlreader01["ProductID"];
                        string ProductName = sqlreader01["ProductName"].ToString();
                        string QuantityPerUnit = sqlreader01["QuantityPerUnit"].ToString();
                        //string UnitPrice = sqlreader01["UnitPrice"].ToString();
                        //int UnitStock = (int)sqlreader01["UnitStock"];

                        //var product = new Product(ProductID, ProductName, QuantityPerUnit, UnitPrice, UnitStock);

                       // Console.WriteLine($"productID : {ProductID,-10},{ProductName,-20},{QuantityPerUnit}");
                    }*/

                    
                }

                //1.3
                using(var command02 = new SqlCommand("Select * from Products p join suppliers s on s.SupplierID = p.SupplierID where QuantityPerUnit like ('%bottle%') ", connection))
                {
                    /*var sqlreader02 = command02.ExecuteReader();

                    while(sqlreader02.Read())
                    {
                        int ProductID = (int)sqlreader02["ProductID"];
                        string ProductName = sqlreader02["ProductName"].ToString();
                        string QuantityPerUnit = sqlreader02["QuantityPerUnit"].ToString();
                        string SupplierName = sqlreader02["CompanyName"].ToString();
                        string Country = sqlreader02["Country"].ToString();
                        Console.WriteLine($"productID : {ProductID,-10},prod name : {ProductName,-20}, quantity : {QuantityPerUnit,-10}, supplier : {SupplierName,-10}, country {Country}");

                    }*/

                }
                //1.4
                using (var command03 = new SqlCommand("select c.categoryname, count(*) as products_in_category from products p join categories c on c.CategoryID = p.categoryID group by c.CategoryName order by products_in_category desc", connection))
                {
                   /* var sqlreader03 = command03.ExecuteReader();

                    while(sqlreader03.Read())
                    {
                        string CategoryName = sqlreader03["CategoryName"].ToString();
                        int productsin = (int)sqlreader03["products_in_category"];


                        Console.WriteLine($"name : {CategoryName}  {productsin}");
                    }*/
                }

                //1.5
                using(var command04 = new SqlCommand("select Concat(titleofcourtesy,' ',firstname,' ',lastname) as title_of_courtesy, city from employees",connection))
                {
                    /*var sqlreader04 = command04.ExecuteReader();

                    while(sqlreader04.Read())
                    {
                        string fullname = sqlreader04["title_of_courtesy"].ToString();
                        string city = sqlreader04["City"].ToString();

                        Console.WriteLine($"{fullname}, {city}");
                    }*/
                    
                }

                //1.6
                using(var command05 = new SqlCommand("select r.regiondescription, format(sum(unitprice*quantity), '#,##,###') as SalesTotal from [order details] od join orders o on od.OrderID = o.OrderID join EmployeeTerritories e on o.EmployeeID = e.EmployeeID join Territories t on e.TerritoryID = t.TerritoryID join Region r on t.RegionID = r.RegionID group by r.regiondescription having sum(unitPrice * Quantity) > 1000000", connection))
                {
                   /* var sqlreader05 = command05.ExecuteReader();

                    while (sqlreader05.Read())
                    {
                        string description = sqlreader05["regiondescription"].ToString();
                        string total = sqlreader05["SalesTotal"].ToString();
                        Console.WriteLine($"{description}  {total}");
                    }*/
                    


                }

                //1.7
                using (var command06 = new SqlCommand("select count(*) as freight_from_locations from Orders Where Freight > 100 and shipcountry in ('USA','UK')",connection))
                {
                   /* var sqlreader06 = command06.ExecuteReader();

                    while (sqlreader06.Read())
                    {
                        //string companyname = sqlreader06["shipname"].ToString();
                        string freightam = sqlreader06["freight_from_locations"].ToString();

                        Console.WriteLine($"{freightam}");
                    }*/
                }


                using(var command07 = new SqlCommand("select top 1 orderid,(UnitPrice * Quantity * Discount) as highestDiscount from [Order Details] order by highestDiscount desc",connection))
                {
                   /* var sqlreader07 = command07.ExecuteReader();
                    while(sqlreader07.Read())
                    {
                        string sID = sqlreader07["orderid"].ToString();
                        string highestorder = sqlreader07["highestdiscount"].ToString();

                        Console.WriteLine($"{sID}   {highestorder}");

                    }*/
                }







            }

        }
    }

    class Customer
    {
        public string CustomerID { get; set; }
        public string ContactName { get; set; }
        public string CompanyName { get; set; }
        public string City { get; set; }

        public Customer(string customerid, string name, string companyname, string city)
        {
            this.CustomerID = customerid;
            this.ContactName = name;
            this.CompanyName = companyname;
            this.City = city;
        }
    }

    class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitStock { get; set; }
       


        public Product(int productid, string productname, string quantityperunit, decimal unitprice, int unitstock)
        {
            this.ProductName = productname;
            this.ProductID = productid;
            this.QuantityPerUnit = quantityperunit;
            this.UnitPrice = unitprice;
            this.UnitStock = unitstock;

        }
        
           

    }
}
