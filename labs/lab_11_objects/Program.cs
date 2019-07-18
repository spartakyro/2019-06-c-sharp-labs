using System;

namespace lab_11_objects
{
    class Program
    {
        static void Main(string[] args)
        {
            object o2 = new
            {
                name = "bob",
                age = 22
            };

            Console.WriteLine(o2.ToString());
        }
    }
}
