using System;
using System.Collections.Generic;

namespace BuzzFizz_test
{
    class Program
    {
        static void Main(string[] args)
        {
            
            for (int up = 1; up < 101; up++)
            {
                Console.WriteLine(up);
               if(up % 3 == 0 && up % 5 ==0 )
                {
                    Console.Write( "fizzbuzz");
                }
               else if (up % 3 == 0)
                {
                    Console.Write("fizz");
                }
               else if ( up % 5 == 0)
                {
                    Console.Write("buzz");
                }

            }




            








            


















        }
    }
}
