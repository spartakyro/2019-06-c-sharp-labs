using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace lab_66_serialize_binary
{
    class Program
    {
        static void Main(string[] args)
        {
            var c01 = new Customer(01, "callum", "3 my bee stree", "CN487639h");
            var c02 = new Customer(01, "brad", "2 my bee stree", "br484639h");
            var c03 = new Customer(01, "lumiere", "1 my bee stree", "lu478639h");
            var customers = new List<Customer> { c01, c02, c03 };

            var binaryformatter = new BinaryFormatter();

            using (var binarystream = new FileStream ("data.bin", FileMode.Create,FileAccess.Write,FileShare.None))
            {
                binaryformatter.Serialize(binarystream, customers);
            }

            Console.WriteLine(File.ReadAllText("data.bin"));


            using (var reader = File.OpenRead("data.bin"))
            {
                var customersFromBinary = binaryformatter.Deserialize(reader) as List<Customer>;

                foreach( var c in customersFromBinary)
                {
                    Console.WriteLine($"Reconstructed customer : {c.CustomerID} " +
                $"{c.CustomerName}, {c.Address}");
                }
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
