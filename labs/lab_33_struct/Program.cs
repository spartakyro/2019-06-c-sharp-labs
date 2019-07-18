using System;

namespace lab_33_struct
{
    class Program
    {
        static void Main(string[] args)
        {
            

            var p01 = new Point(10,11); //'new' calls the constructor
            var p02 = new Point(12,13); //'new' calls the constructor
            var p03 = new Point(14,15); //'new' calls the constructor
            Console.WriteLine($"{p01.X} and {p01.Y}"); 
            Console.WriteLine(p02); 
            Console.WriteLine(p03); 
        }
    }


    struct y { }

    public struct Point
    {
        //srote point on a graph
        public int X; //Capitals because public.
        public int Y;

        public  Point(int x, int y)
        {
            this.X = x;
            this.Y = y;

           
        }
    }
}
