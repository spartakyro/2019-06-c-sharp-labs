using System;
using System.Linq; //<- talk to databases

namespace lab_42_operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int x01 = 10;
            int y01 = x01++; // y = 10   x = 11 

            int x02 = 10;
            int y02 = ++x02; // adds one  // y = 11   x = 11 

            Console.WriteLine(x01);
            Console.WriteLine(y01);
            //y = x then incriment x

            Console.WriteLine(x01);
            Console.WriteLine(y02);
            //increment x, then y = x

            //safety rule: only use x++ , on one line with nothing else 
            // ......
            // x++
            // ......

            //Binary

            //modulus
            Console.WriteLine(100 % 8); // 4 (remainder) 8 x 12 = 96 ....4 left over
            //whole number after division
            Console.WriteLine(100/8); // 12

            //&& AND: high if and only if both inputs high

            Console.WriteLine(1&1);
            Console.WriteLine(1&0);
            Console.WriteLine(0&1);
            Console.WriteLine(0&0);
            Console.WriteLine("\n\n");

            // | OR: output is high if one input is high

            Console.WriteLine(1 | 1);
            Console.WriteLine(1 | 0);
            Console.WriteLine(0 | 1);
            Console.WriteLine(0 | 0);
            Console.WriteLine("\n\n");

            // ^ XOR: out is high if exactly one item is high
            Console.WriteLine(1 ^ 1);
            Console.WriteLine(1 ^ 0);
            Console.WriteLine(0 ^ 1);
            Console.WriteLine(0 ^ 0);
            //&& and || save time if the right hand side takes time to evaluate
            // short curcuit operator : can never be true SO DONT BOTHER EVALUATE THE RIGHT HAND SIDE
            Console.WriteLine(false && (DoThisLongOperation()));


            //Bit shift(helps you understand computers)

            //1010 is 10
            //1101 is 13
            //1010 to 10100 ??? 10 to 20
            //10100 to 101000 ??? 20 to 40
            //1010 to 10 : 10 in Decimal to 5
            //101 to 10 : 5 to 2 

            Console.WriteLine(8 >> 2); // move 2 places smaller 8....4....2
            Console.WriteLine(8 << 2); // move 2 places bigger 8....16....32



            //ternery operators

            int num04 = 100;
            int num05 = 1000;
            if(num04 > num05)
            {

            }
            else
            {

            }

            //var output = (condition) ? "is true" : "is false";
            var output = (num04>num05) ? "high" : "low";
            Console.WriteLine(output);
            //can be confsing use only if confident

            int[] myArray = { 1, 2, 3,4,5,6 };
            //create clone arrat but only where values of a condition
            var outputArray01 = myArray.Where(item => item > 2);

           
            foreach(var item in outputArray01)
            {
                Console.WriteLine(item);

            }
            int?[] myArray2 = { null, 2, 3, null, 5, 6, null };
                

            
        }

        static bool DoThisLongOperation()
        {
            for(int i = 0; i < 1_000_000_000; i++)
            {
                Console.WriteLine(i);
            }
            return false;
        }

        
    }
}
