using System;

namespace lab_49_reference_value_types
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int x = 10;
            int y = x;
            y = 100;
            Console.WriteLine($"x is {x} and y is {y}");

            int[] arrayA = new int[] { 10, 20, 30 };
            int[] arrayB = arrayA;

            //for every item in an array (array_name, do this)

            //do this can be wrotten in a LAMBDA Form

            //LAMBDA FORM (parameter in ==> method out)

            //if the method is a one lined method then can omit { Braces }
            Console.WriteLine("\n\nbefore change\n\n");
            Array.ForEach(arrayA, item => Console.WriteLine(item));
            Array.ForEach(arrayB, item => Console.WriteLine(item));

            arrayB[2] = 578;

            Console.WriteLine("\n\nafter change\n\n");
            Array.ForEach(arrayA, item => Console.WriteLine(item));
            Array.ForEach(arrayB, item => Console.WriteLine(item));

            var arrayC =(int []) arrayB.Clone();

            Console.WriteLine("\n\narrayC\n\n");

            Array.ForEach(arrayC, item => Console.WriteLine(item));
        }
    }
}
