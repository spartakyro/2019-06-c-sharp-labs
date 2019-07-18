using System;

namespace Lab_28_enums
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(fruit.banana);
            Console.WriteLine(fruit.apple);
            Console.WriteLine(fruit.pear);
            Console.WriteLine(fruit.notfruit);

            Console.WriteLine(      (int)fruit.notfruit       );
            Console.WriteLine($"number of fruits is {(int)fruit.count}"       );


            //use with days of the week and months of the year
            //sunday is 0 , saturday is 6
            //jan is 0, dec is 12
            var d = DateTime.Now;
            Console.WriteLine(d);
            Console.WriteLine(d.Month); // =7
            Console.WriteLine(d.Day); // = 1 meaning first day of the month

            Console.WriteLine((int)d.DayOfWeek);
            Console.WriteLine(d.DayOfWeek);
            
        }
    }

    enum fruit
    {
        notfruit = -1, banana,apple,pear,count,nas
    }

    
}
