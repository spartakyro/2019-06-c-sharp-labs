using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hwllo kieron");
            

            var f = 1.23f;
            var f02 = 1.4564564564564564564567;

            Console.WriteLine(f);
            Console.WriteLine(f02); //silent truncuation

            Console.WriteLine(double.MinValue);
            Console.WriteLine(double.MaxValue);
            Console.WriteLine(float.MinValue);
            Console.WriteLine(float.MaxValue);

            //highest degree of precision in calculations (eg Money)
            Console.WriteLine(decimal.MinValue);
            Console.WriteLine(decimal.MaxValue);

            //take care when equating ddouble numbers
            var d01 = 0.1;
            var d02 = 0.2;
            Console.WriteLine(d01 + d02 == 0.3);

            //care when equating decimal numbers
            var d03 = 0.1M;
            var d04 = 0.2M;
            Console.WriteLine(d03 + d04 == 0.3M);

            //test less than small number
            Console.WriteLine ((d01+d02-0.3) < 0.00001);
        }

        

    }
}
