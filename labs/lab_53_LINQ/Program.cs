using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lab_53_LINQ
{
    
    class Program
    {
        static List<Customer> customers;
        static List<Product> products;
        static List<Order> orders;
        static List<Order_Detail> ordersdeets;
        static List<Category> categories;
        static string[] cities;  //list of all cities
        static string[] suppliers;
        static void Main(string[] args)
        {
            using (var db = new NorthwindEntities())
            {
                customers = db.Customers.ToList();
                products = db.Products.ToList();
                orders = db.Orders.ToList();
                ordersdeets = db.Order_Details.ToList();

            }

            int counter = 0;
            foreach(var c in customers)
            {
                counter++;
                
            }
           // Console.WriteLine($" how many customers: {counter}");

            int count = 0;
            foreach(var p in products)
            {
                count++;
            }
           // Console.WriteLine($"how many products: {count}");

            int co = 0;

            foreach(var o in orders)
            {
                co++;
            }

            //Console.WriteLine($"how many orders: {co}");

            int counte = 0;
            decimal total = 0;

            foreach(var od in ordersdeets)
            {
                counte++;
                total += (od.UnitPrice * od.Quantity) * (decimal)(1 - od.Discount);
            }

            var average = total / counte;
           // Console.WriteLine(average);
            

            //list categories in order for each category 1) count products 2) list individual product name

            using(var db1 = new NorthwindEntities())
            {
                Console.WriteLine("\n\n=====Categories======\n\n");
                categories = db1.Categories.ToList();
                products = db1.Products.ToList();

                foreach (var c in categories)
                {

                    //repeat code and find out/print out customerid customername 1)how many orders does this customer have????
                    //2) print out orderid of each using this .dot notation

                    Console.WriteLine("\n\n\n\ncustomerID and Orders\n\n\n\n\n");

                    customers = db1.Customers.ToList();
                    orders = db1.Orders.ToList();

                    foreach(var cu in customers)
                    {
                       // Console.WriteLine($"\n ID) {cu.CustomerID,-10}{cu.ContactName} has {cu.Orders.Count} orders");

                        foreach(var or in cu.Orders)
                        {
                           // Console.Write($" {or.OrderID}");
                        }
                    }



                    customers.ForEach(cust=> Console.WriteLine(cust.ContactName));

                    //Console.ReadLine();

                    //create a subArray from a larger list
                    //for example : create an arrat of cities from out list of customers

                    cities = db1.Customers.Select(customers => customers.City).OrderBy(city => city).ToArray();
                    
                    //traditional
                    foreach(var city in cities) {Console.WriteLine(city);}
                    //lambda
                    Array.ForEach(cities, city => Console.WriteLine(city));

                    //Console.ReadLine();

                    // repeat this code getting a list of supplier names from the suppliers database!
                    Console.WriteLine("\n\n=======================suppliers==========================\n\n");
                    suppliers = db1.Suppliers.Select(suppliers => suppliers.CompanyName).Distinct().OrderBy(supplier => supplier).ToArray();
                    Console.WriteLine($"there are {suppliers.Count()} different suppliers\n");
                    Array.ForEach(suppliers, supplier => Console.WriteLine(supplier));
                   // Console.ReadLine();

                    //quiz 2 min max avg order in orderdetails looking at unit price * quanitity forget discount

                    var Minordersdeets = db1.Order_Details.Min(ordersdeets => ordersdeets.UnitPrice);
                    var Maxordersdeets = db1.Order_Details.Max(ordersdeets => ordersdeets.UnitPrice);
                    var Avgordersdeets = db1.Order_Details.Average(ordersdeets => ordersdeets.UnitPrice);
                    var Countordersdeets = db1.Order_Details.Select(ordersdeets => ordersdeets.UnitPrice).Distinct().Count();

                    Console.WriteLine($"Min num of orders: {Minordersdeets}");
                    Console.WriteLine($"Max num of orders: {Maxordersdeets}");
                    Console.WriteLine($"Avg num of orders: {Avgordersdeets}");
                    Console.WriteLine($"Count num of orders: {Countordersdeets}");
                    //Console.ReadLine();

                    //var x = db........ .where( => )  .where( => )

                    //count of orderdetails where discount is not null and price > x


                    var array1 = new string[] { "one", "two", null, null, "five" };
                    List<string> arr2 = new List<string>();
                    foreach(var a in array1.Where(a =>a != null))
                    {
                        //Console.WriteLine(a);
                        arr2.Add(a);
                    }

                    //Console.WriteLine(arr2.Count);
                    var array2 = arr2.ToArray();

                    Console.WriteLine("\n\n\n=============Null Region==================\n\n\n\n");
                    List<Customer> nullregion = new List<Customer>();
                    foreach (var cus in customers.Where(cus => cus.Region != null))
                    {
                        nullregion.Add(cus);
                    }
                    //Console.WriteLine(nullregion);
                    foreach(var v in nullregion)
                    {
                        //Console.WriteLine($"{v.ContactName}   {v.Country}");

                                           
                      
                       
                    }
                    //Console.WriteLine(nullregion.Count());

                    var orderbyCTC = db1.Customers.OrderBy(x => x.Country).ThenBy(d => d.City).ThenBy(e => e.ContactName).ToList();
                    List<Customer> oct = new List<Customer>();
                    foreach(var ctc in orderbyCTC)
                    {
                        oct.Add(ctc);
                        //Console.WriteLine($"{ctc.Country,-10}{ctc.City,-10}{ctc.ContactName}");
                    }

                    var subseuofCustomer = db1.Customers.OrderBy(q => q.Region).ThenBy(d => d.ContactName).Skip(30).Take(10).ToList();
                    //subseuofCustomer.ForEach(subseuofCustomer, subs => Console.WriteLine(subs));



                    
                }

                for (int i = 0; i < db1.Customers.Count(); i += 10)
                {
                    var secs = db1.Customers.OrderBy(r => r.CustomerID).Skip(i).Take(10).ToList();
                    secs.ForEach(j => Console.WriteLine($"{j.ContactName,-10}{j.CompanyName}"));
                    Console.WriteLine("\n\n");
                    System.Threading.Thread.Sleep(1000);
                }

            }



        }
    }
}
