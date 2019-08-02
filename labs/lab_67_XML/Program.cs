using System;
using System.IO;
using System.Xml.Linq;

namespace lab_67_XML
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n first XML example \n\n");
            var xml01 = new XElement("testData", 1);
            Console.WriteLine(xml01);


            Console.WriteLine("\n\n            \n\n");
            var xml02 = new XElement("XMLRoot", (new XElement("XMLData"), 100));
            Console.WriteLine(xml02);
            Console.WriteLine("\n          \n");
            var xml03 = new XElement("XMLRoot",
                new XElement("XMLData", 100),
                new XElement("XMLData", 200),
                new XElement("XMLData", 300),
                new XElement("XMLData", 400)
                );
            Console.WriteLine(xml03);

            //write to XML doxument
            var doc03 = new XDocument(xml03);
            doc03.Save("doc03.xml");
            Console.WriteLine(File.ReadAllText("doc03.xml"));

            Console.WriteLine("/n add Attributes\n");
            var xml04 = new XElement("XMLRoot",
                new XElement("XMLData",new XAttribute("height",300),100),
                new XElement("XMLData",new XAttribute("height",400),200),
                new XElement("XMLData",new XAttribute("height",500),300),
                new XElement("XMLData",new XAttribute("height",600),400));

            Console.WriteLine(xml04);

            //think of your data in database table
            //xml root is name of table
            //XAttribute is the name of a dield with the value
            //XMLData is individual entry in database
            var XMLprod01 = new XElement("Products",
                new XElement("products", 
                new XAttribute("ProductID", 1), 
                new XAttribute("ProductName", "Chai"), 
                new XAttribute("CategoryID", 1),
                new XAttribute("UnitPrice", 18.00)));


            var XMLprod02 = new XElement("Products",
                new XElement("products",
                new XElement("ProductID", 10),
                new XElement("ProductName", "Ikura"),
                new XElement("CategoryID", 8),
                new XElement("UnitPrice", 31.00)));

            Console.WriteLine($"\n   {XMLprod01}      \n");
            Console.WriteLine($"\n   {XMLprod02}      \n");
            Console.WriteLine("\n         \n");
            Console.WriteLine("\n         \n");
            Console.WriteLine("\n         \n");
            Console.WriteLine("\n         \n");

            //XML revision
            //create 'products' root XML
            //have 2 'products' items
            //populate with productID, productName, CategoryID,UnitPrice



        }
    }
}
