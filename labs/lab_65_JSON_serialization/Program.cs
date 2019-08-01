using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Net;
using System.Diagnostics;

namespace lab_65_JSON_serialization
{
    class Program
    {
        static void Main(string[] args)
        {

            Uri gitpull = new Uri ("https://raw.githubusercontent.com/philanderson888/data/master/customers.json");

            var downloadgitpull = new WebClient { Proxy = null };
            downloadgitpull.DownloadFile(gitpull, "gitpull.json");
           //Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", "gitpull.json");



            var c01 = new Customer(01, "callum", "3 my bee stree", "CN487639h");
            var c02 = new Customer(01, "brad", "2 my bee stree", "br484639h");
            var c03 = new Customer(01, "lumiere", "1 my bee stree", "lu478639h");


            var customer = new List<Customer>() { c01, c02, c03 };

            var jsonInstance = JsonConvert.SerializeObject(c01);
            File.WriteAllText("data.json", jsonInstance);

            Console.WriteLine(File.ReadAllText("data.json"));

            var customerListAsJson = JsonConvert.SerializeObject(customer);
            File.WriteAllText("customer.json", customerListAsJson);
            Console.WriteLine(File.ReadAllText("customer.json"));

            //read one customer

            var customerFromJson = JsonConvert.DeserializeObject<Customer>(File.ReadAllText("data.json"));

            Console.WriteLine($"reconstructed customer : {customerFromJson.CustomerID} {customerFromJson.Address} {customerFromJson.CustomerName}");
            Console.WriteLine($"Nino is blank {customerFromJson.GetNino()}");
            Console.WriteLine("\n\n =======READ ARRAY OF CUSTOMERS===========\n\n");
            var customerArray = JsonConvert.DeserializeObject<List<Customer>>(File.ReadAllText("customer.json"));

            foreach(var c in customerArray)
            {
                Console.WriteLine($"reconstructed customer : {c.CustomerID}, {c.CustomerName}, {c.Address} ");
                Console.WriteLine($"Nino is blank {c.GetNino()}");
            }


        }
    }


    [Serializable]
    class Customer
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }

        public string Address { get; set; }

        [NonSerialized]
        private string NINO;



        public Customer(int customerid, string name, string address, string nino)
        {
            this.CustomerID = customerid;
            this.CustomerName = name;
            this.Address = address;
            this.NINO = nino;
        }

        public string GetNino()
        {
            return this.NINO;
        }
    }
}
