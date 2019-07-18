using System;
using System.Threading;
using System.Collections.Generic;

namespace lab_16_rabbits
{
    class Program
    {
        static List<Rabbit> rabbits = new List<Rabbit>(); 
        static void Main(string[] args)
        {
            
            //Console.WriteLine();
            //var r = new Rabbit(50);
            //rabbits.Add(r);

            for (int i = 1; i < 100; i++)
            {
                Console.WriteLine("Loop" + i);

                foreach (Rabbit r in rabbits)
                {
                    
                    r.age++;
                    Console.WriteLine($"ages are :{r.Name} is {r.age}");
                }

                Thread.Sleep(200);

                var rabbit = new Rabbit(i);
                rabbits.Add(rabbit);
                //Rabbit is the CLASS(blueprint)
                //rabbit is the actual real rabbit

                Console.WriteLine($"{rabbit.Name,-20}{rabbit.age}");

                

            }

            Console.WriteLine("\n\n pringting all rabbits \n\n");

            foreach(var rabbit in rabbits)
            {
                Console.WriteLine($"{rabbit.Name,-20}{rabbit.age}");
            }
        }
    }

    public class Rabbit
    {
        public int age { get; set; }
        public string Name { get; set; }

        public Rabbit(int counter)
        {
            this.age = 0;
            this.Name = "Rabbit" + counter;

        }
    }
}
