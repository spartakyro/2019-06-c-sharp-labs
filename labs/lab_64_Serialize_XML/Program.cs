using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Soap;



namespace lab_64_Serialize_XML
{
    class Program
    {
        static void Main(string[] args)
        {
            var c01 = new Customer(1618,"james","24 lala land","nm958734d");

            //XML serialize into a file stream

            var formatter = new SoapFormatter();

            using(var filestream = new FileStream("data.xml",FileMode.Create,FileAccess.Write,FileShare.None))
            {
                //send data 
                formatter.Serialize(filestream, c01);
            }

            Console.WriteLine(File.ReadAllText("data.xml"));

            //imagine : were on another computer can we reconstruct an instance
            Customer customerFromXlm;
            using( var streamreader = File.OpenRead("data.xml"))
            {
                customerFromXlm = formatter.Deserialize(streamreader) as Customer;
            }

            Console.WriteLine($"Reconstructed customer : {customerFromXlm.CustomerID} " +
                $"{customerFromXlm.CustomerName}{customerFromXlm.Address}");
            Console.WriteLine($"NINO is blank!!! {customerFromXlm.GetNino()}");

            
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
