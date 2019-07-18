using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace lab_51_Entity_crud_app
{
    class Program
    {
        static List<Customer> customers = new List<Customer>();
        static Customer customer = new Customer();
        static void Main(string[] args)
        {
            AddCustomer();
            UpdateCustomer();
            DeleteCustomer();
            
           /* using (var db = new NorthwindEntities())
            {
                 customers = db.Customers.ToList();
                
            }

            foreach (var item in customers)
            {
                Console.WriteLine($"names: {item.ContactName,-20} company: { item.CompanyName}");
               
            }

            Console.WriteLine("\n\n adding new customer \n===========================\n\n");

            // new customer
            var newCustomer2 = new Customer()
            {
                ContactName = "Kieron Newman",
                CompanyName = "Yaboi industries",
                ContactTitle = "Sir",
                CustomerID = "KINGU",
                Country = "Wales",
                City = "Cardiff"


            };

            var newCustomer1 = new Customer()
            {
                ContactName = "Kieron Newman",
                CompanyName = "industries",
                ContactTitle = "Knight",
                CustomerID = "JAMES",
                Country = "Wales",
                City = "Cardiff"


            };



            //ADD TO DB

            using (var db = new NorthwindEntities())
            {
             //  db.Customers.Add(newCustomer1);
              // db.Customers.Add(newCustomer2);
                int affected = db.SaveChanges();
                Console.WriteLine($"Added {affected} records");
                customers = db.Customers.ToList();
            }

            //select a customer & find a customer
            using (var db = new NorthwindEntities())
            {

                var updateCustomer = new Customer();
                updateCustomer = db.Customers.Find("JAMES");
                updateCustomer.ContactName = "tobias";
                int affected = db.SaveChanges();
                Console.WriteLine($"{affected} records updated");

                listAll(db.Customers.ToList());
               

            }
            

            
            
            //delete and edit
            using (var db = new NorthwindEntities())
            {
                var deleteCustomer = new Customer();
                deleteCustomer = db.Customers.Find("NEWMA");
               // db.Customers.Remove(deleteCustomer);
                int affected = db.SaveChanges();
                Console.WriteLine($"{affected} records deleted");


                foreach (var c in db.Customers)
                { Console.WriteLine($"names: {c.ContactName,-20} company: { c.CompanyName}"); }

                listAll(db.Customers.ToList());
            }*/

           

        }

        static void AddCustomer()
        {
            using (var db = new NorthwindEntities())
            {
                customers = db.Customers.ToList();

            }

            foreach (var item in customers)
            {
                Console.WriteLine($"names: {item.ContactName,-20} company: { item.CompanyName}");

            }

            Console.WriteLine("\n\n adding new customer \n===========================\n\n");

            // new customer
            var newCustomer2 = new Customer()
            {
                ContactName = "Kieron Newman",
                CompanyName = "Yaboi industries",
                ContactTitle = "Sir",
                CustomerID = "KINGU",
                Country = "Wales",
                City = "Cardiff"


            };

            var newCustomer1 = new Customer()
            {
                ContactName = "Kieron Newman",
                CompanyName = "industries",
                ContactTitle = "Knight",
                CustomerID = "JAMES",
                Country = "Wales",
                City = "Cardiff"


            };



            //ADD TO DB

            using (var db = new NorthwindEntities())
            {
                //  db.Customers.Add(newCustomer1);
                // db.Customers.Add(newCustomer2);
                int affected = db.SaveChanges();
                Console.WriteLine($"Added {affected} records");
                customers = db.Customers.ToList();
            }

        }

        static void UpdateCustomer()
        {
            using (var db = new NorthwindEntities())
            {

                var updateCustomer = new Customer();
                updateCustomer = db.Customers.Find("JAMES");
                updateCustomer.ContactName = "tobias";
                int affected = db.SaveChanges();
                Console.WriteLine($"{affected} records updated");

                listAll(db.Customers.ToList());


            }


        }

        static void DeleteCustomer()
        {
            using (var db = new NorthwindEntities())
            {
                var deleteCustomer = new Customer();
                deleteCustomer = db.Customers.Find("NEWMA");
                // db.Customers.Remove(deleteCustomer);
                int affected = db.SaveChanges();
                Console.WriteLine($"{affected} records deleted");


                foreach (var c in db.Customers)
                { Console.WriteLine($"names: {c.ContactName,-20} company: { c.CompanyName}"); }

                listAll(db.Customers.ToList());
            }
        }
        static void listAll(List<Customer> customerList)
        {
            foreach(var c in customerList)
            {
                Console.WriteLine($"names: {c.ContactName,-20} company: { c.CompanyName}");
            }

        }
    }
}
