using System;
using System.Collections.Generic;

namespace SnapLab__18_Interfaces
{
    class Program
    {

        static List<Dog> DList = new List<Dog>();
        static List<Dog> Dogorder = new List<Dog>();
        static void Main(string[] args)
        {
            
            Dog dog01 = new Dog(100);
            Dog dog02 = new Dog(400);
            Dog dog03 = new Dog(250);

            DList.Add(dog01);
            DList.Add(dog02);
           // DList.Add(dog03);

            Dogorder.Add(dog03);

            foreach(var d in DList)
            {
                int index = 0;


                while (d.CompareTo(Dogorder[index]) == 1)
                {
                    if(index == Dogorder.Count-1)
                    {
                        index++;
                        break;
                    }
                    else
                    {
                        index++;
                    }
                }
                if (index == Dogorder.Count)
                {
                    Dogorder.Add(d);

                }
                else
                {
                    Dogorder.Insert(index, d);
                }
                index++;


               
                //Console.WriteLine(Dogorder);
                /* else if (d.CompareTo(Dogorder[index]) == -1)
                 {
                     index--;
                 }*/


            }

            foreach(var d in Dogorder)
            {
                Console.WriteLine(d.Height);
            }
            //dog01.CompareTo(dog02);


            //Console.WriteLine(dog01.CompareTo(dog02));
            //Console.WriteLine(dog03.CompareTo(dog01));


            Console.WriteLine();


        }
    }

    public class Dog : IComparable
    {
        public int Height { get; set; }

        public int CompareTo(object o)
        {
            Dog d = (Dog)o;

            //Console.WriteLine($"{this.Height} comparing to {d.Height}");
            
            if(this.Height == d.Height)
            {
                return 0;
            }

            if (this.Height > d.Height)
            {
                return 1;
            }

            if (this.Height < d.Height)
            {
                return -1;
            }



            return -1;
        }

        public Dog(int Height)
        {
            this.Height = Height;
        }
    }

   

  
}
