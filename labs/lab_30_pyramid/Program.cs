using System;

namespace lab_30_pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            //pass in an integer
            int counter = 0;

            for (int i = 1; i <= 5; ++i)
            {

                for (int j = 1; j <= i; ++j)
                {
                    Console.Write(" * ");
                }

                Console.Write("\n");
            }//a) output a left justified pyramid
            //4



            Pyramid2(10);

            Console.WriteLine("\n\n");
            //bonus b center justufied pyramid
        }

        static void Pyramid2(int levels)
        {
            //pass in an integer
            int counter = 0;

       for (int a = 0; a< levels;a++)
            {
                for(int b = levels; b > a; b--)
                {
                    Console.Write(" ");
                }

                for(int c = 0; c < a; c++)
                {
                    Console.Write("* ");
                }

                Console.Write("\n");
            }
        }
    }
}
