using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_to_LINQ_test
{
    class Program
    {
        static List<Customer> customers = new List<Customer>();
        Customer customer;
        static void Main(string[] args)
        {
            using (var db = new NorthwindEntities())
            {
                var customer = db.Customers.ToList();
                var product = db.Products.ToList();
                

                
                
                foreach (var city in customer)
                {
                    if(city.City == "London" ||city.City == "Paris")
                    {
                        var Address = city.Address + city.PostalCode;
                       // Console.WriteLine($"ID) {city.CustomerID,-10} Name: {city.ContactName,-20} City: {city.CompanyName,-20}   Address: {Address}");
                    }
                    //var Address = city.Address + city.PostalCode;
                    

                }

                var products1 = from p in db.Products where p.QuantityPerUnit.Contains("Bottle") select p;
                foreach(var p in products1)
                {
                   // Console.WriteLine($"{p.ProductID,-5}{p.ProductName,-20}{p.QuantityPerUnit}");
                }

                var products2 = from prod in db.Products
                                join supplier in db.Suppliers on prod.SupplierID equals supplier.SupplierID 
                                where prod.QuantityPerUnit.Contains("bottles") select prod;
                foreach(var p in products2)
                {
                    //Console.WriteLine($"{p.QuantityPerUnit,20}{p.Supplier.Country,-20}{p.SupplierID}");
                }

                var products3 = from p in db.Products
                                join c in db.Categories on p.CategoryID equals c.CategoryID
                                group c by c.CategoryID
                                into Categories
                                orderby Categories.Count() descending
                                select new
                                {
                                    Category = Categories.Key,
                                    count = Categories.Count()
                                };
                foreach(var p in products3)
                {
                    //Console.WriteLine($"{p.Category,-5} no of products: {p.count}");
                }
                      
                foreach (var cus in customer)
                {
                    var title = ($"{cus.ContactTitle,-20} {cus.ContactName,-20}");
                    Console.WriteLine($"Title) {title,-20} {cus.City,-10}");
                }


            }
        }
    }
}
