using System;
using System.Collections;

namespace lab_41_casting
{
    class Program
    {
        static void Main(string[] args)
        {
            //implicit cast: usefull when its impossible for data to be lost
            //from int 1 to double 1.0

            int num01 = 100;
            double d01 = num01;



            //explicit cast
            //this is required when data will definetly be lost
            //double 2.314 to int 2 : truncate 0.314
            double d02 = 2.134;
            int num02 = (int)d02;
            Console.WriteLine($"{d02} has become {num02}");

            //Is

            var p = new Parent();
            var c = new Child();

            if(c is Parent)
            {
                Console.WriteLine("your child is a member of the parent family");
            }

            if(!(c is AnotherParent))
            {
                Console.WriteLine("c id not related to another parent");
            }

            //As

            //cast from one type to another
            var P02 = new Parent();
            var C02 = new Child();
            var ParentOfChild2 = C02 as Parent;
            var ParentOfChildv2 = (Parent)C02;


            //boxing and unboxing

            var O = new object();
            int i = 10;

            //may have a structure dealing with multiple objects :
            //have to cast from a type to general object

            int num03 = 100;
            var o3 = num03;  //'box' integer as an object

            //when finished cast back as a number
            int num04 = (int)o3;
            Console.WriteLine(num04);






            //Array list

            var mixedlist = new ArrayList();
            mixedlist.Add(10);
            mixedlist.Add("hello");
            mixedlist.Add(DateTime.Now);
            mixedlist.Add(10.0);
            mixedlist.Add(10f);
            mixedlist.Add(10m);
            foreach(var item in mixedlist)
            {
                Console.WriteLine($"{item} is a{item.GetType()}");
            }

            //var mixedlist = new Array[];

           
                 
        }
    }

    class Parent { }
    class Child : Parent { }

    class AnotherParent { }
}
