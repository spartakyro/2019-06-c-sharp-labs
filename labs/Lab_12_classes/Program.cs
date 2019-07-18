using System;
using System.Collections.Generic;

namespace Lab_12_classes
{
    class Program
    {
        static List<Dog> dogs = new List<Dog>();
        
        static void Main(string[] args)
        {
            
            var m01 = new Mammal();
            m01.Height = 100;
            m01.Length = 150;
            m01.Weight = 2000;

            var c01 = new Cat();
            

            var d01 = new Dog();
            d01.Height = 807;
            d01.Length = 50;
            d01.Weight = 1000;
            d01.dogID = "dog01";
            d01.growth = d01.Height / d01.Length;

            Console.WriteLine($"{d01.growth}");

            for (int i = 1; i <= 20; i++)
            {
                //create dog
                var newdog = new Dog();
                newdog.dogID = $" dog {i}";
                newdog.Length = 100;
                newdog.Height = 50;
                newdog.Weight = 20;
                //adds dog to list
                dogs.Add(newdog);




                
            }
            
            foreach(var dog in dogs)
            {
                Console.WriteLine($"{dog.dogID} has height of {d01.Height} CM, weight of {d01.Weight} pounds and is {d01.Length} inches long");
            }


        }
    }

    class Dog : Mammal
    {
       
    }

    class Cat : Mammal
    {
    }
    class Mammal
    {
        public int Height;
        public int Weight;
        public int Length;
        public string dogID;
        public int growth;
    }
}
