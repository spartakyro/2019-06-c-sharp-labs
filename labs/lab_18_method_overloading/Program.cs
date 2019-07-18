using System;

namespace lab_18_method_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Rabbit();
            r.Age = 0;
            for (int i = 0; i < 10; i++)
            {
                r.Grow();
                Console.WriteLine(r.Age);
            }
            Console.WriteLine("\n\n Hey its summer now - growth rate has increased\n\n");
            for (int i = 0; i < 10; i++)
            {
                r.Grow(2);
                Console.WriteLine(r.Age);
            }

            Console.WriteLine("\n\n its winter now - growth rate has decreased\n\n");
            for (int i = 0; i < 10; i++)
            {
                r.Grow(0.1);
                Console.WriteLine(r.Age);
            }

           
            Console.WriteLine("\n\n winters over - the sub rabbits are here\n\n");
            var s = new subRabbit();
            for (int i = 0; i < 10; i++)
            {
                r.Grow(3);
                Console.WriteLine(r.Age);
            }
            s.HereIsACustomField = "hey im changing the subrabbit";

        }
    }

    sealed class Rabbit
    {
        public double Age { get; set; }
        public void Grow()
        {
            Age++;
        }

        public void Grow(int growthFactor)
        {

            Age += growthFactor;
        }

        public void Grow(double winterGrowth)
        {

            Convert.ToDecimal(winterGrowth);
            Age += winterGrowth;
        }


           


}

    class subRabbit 
    {
        public string HereIsACustomField;
    }
}
