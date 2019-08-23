using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System.Linq;
using System.Xml.Linq;
using System.IO;
using System.Xml.Serialization;
using System.Diagnostics;

namespace lab_69_XML_from_northwind
{
    class Program
    {
        static void Main(string[] args)
        {
            //customer list
            List<Product> products = new List<Product>();   //from northwind
            Products productsFromXML = new Products(); // from XML, deserialize
            using (var db = new Northwind()) 
            {
                //select * products and fill list;

                products = db.Products.ToList();

                
                //Console.WriteLine(products);
            }



            //find first product (use Entity and .firstordefault or take(1)) & print to screen
            var product = products.FirstOrDefault();
            Console.WriteLine($"{product.ProductID}, {product.ProductName}, {product.CategoryID}, {product.UnitPrice}");
            //output to XML

            var xmlProduct = new XElement("Product",
                new XElement("ProductID", product.ProductID),
                new XElement("ProductName", product.ProductName),
                new XElement("CategoryID", product.CategoryID),
                new XElement("UnitPrice", product.UnitPrice));

            //Console.WriteLine(xmlProduct);

            Console.WriteLine("\n\n First 5 products\n\n");

            var XMLproducts = new XElement("Products",
               from p in products.Take(5)
               select new XElement("Product",
               new XElement("ProductID", p.ProductID),
                new XElement("ProductName", p.ProductName),
                new XElement("CategoryID", p.CategoryID),
                new XElement("UnitPrice", p.UnitPrice)));


            var XMLproducts1 = new XElement("Products",
            from p in products.Take(5)
            select new XElement("Product",
             new XAttribute("ProductID", p.ProductID),
             new XAttribute("ProductName", p.ProductName),
             new XAttribute("CategoryID", p.CategoryID),
             new XAttribute("UnitPrice", p.UnitPrice)));



            XMLproducts.Save("products.xml");
           
            Console.WriteLine(XMLproducts);
            //Console.WriteLine(XMLproducts1);


            //send out products XML list across the world to our suppliers
            //at the other side of the world, now deserialise 

            //streamread into memory first, then deserialize

            using (var reader = new StreamReader ("products.xml"))
            {
                //now deserialise the stream
                var serializer = new XmlSerializer(typeof(Products));

                productsFromXML = (Products)serializer.Deserialize(reader);

                
            }
            Console.WriteLine("=======================Deserialize==================================================");
            Console.WriteLine(productsFromXML.ProductList.Count());
            productsFromXML.ProductList.ForEach(p => Console.WriteLine($"{p.ProductID}{p.ProductName}{p.UnitPrice}"));
        }
    }

    [XmlRoot("Products")]
    public class Products
    {
        [XmlElement("Product")]
        public List <Product> ProductList { get; set; }
    }

    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Product> Products { get; set; }

        public Category()
        {
            this.Products = new List<Product>();
        }
    }



    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int? CategoryID { get; set; }
       // public virtual Category Category { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal? UnitPrice { get; set; } = 0;
        public short? UnitsInStock { get; set; } = 0;
        public short? UnitsOnOrder { get; set; } = 0;
        public short? ReorderLevel { get; set; } = 0;
        public bool Discontinued { get; set; } = false;
    }




    public class Northwind : DbContext
    {
        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;" +
                   "Initial Catalog=Northwind;" + "Integrated Security = true;" +
                   "MultipleActiveResultSets=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>()
                .Property(c => c.CategoryName)
                .IsRequired()
                .HasMaxLength(15);

            //// define a one-to-many relationship
            //modelBuilder.Entity<Category>()
            //    .HasMany(c => c.Products)
            //    .WithOne(p => p.Category);

            modelBuilder.Entity<Product>()
                .Property(c => c.ProductName)
                .IsRequired()
                .HasMaxLength(40);

            //modelBuilder.Entity<Product>()
            //    .HasOne(p => p.Category)
            //    .WithMany(c => c.Products);

        }
    }
}

