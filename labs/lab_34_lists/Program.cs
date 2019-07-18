using System;
using System.Collections.Generic;
using System.Collections;


namespace lab_34_lists
{
    class Program
    {
        //inside a method makes them private to other methods(void DoThis) 
        //so put outside of class to make public to all inside the class
        static List<int> list01 = new List<int>();
        static List<string> list02 = new List<string>();
        
        static void Main(string[] args)
        {
            var array01 = new int[10]; // size[10] is fixed

            //2d array
            var Grid2D = new int[10, 10];
            //3d array
            var Cube3D = new int[5, 5, 5];
            //4d array
            var Grid4D = new int[15, 15, 15, 15];

            //above arrays are all fixed in size 100%
            //but its possible to create an array of arrays where each array can be a different size

            //jagged array
            int[][] jaggedArray01 = new int[3][];
            //first array's[0] size[10] is 10
            jaggedArray01[0] = new int[10];
            //second arrays[1] size[100] is 100
            jaggedArray01[1] = new int[100];
            //third arrays[2] size[1000] is 1000
            jaggedArray01[2] = new int[1000];


            list01.Add(10); //index 0
            list01.Add(20); //index 1
            list01.Insert(0, 100); //index 0, push others along
            
            foreach(var item in list01)
            {
                Console.WriteLine($"{item}");
            }
            Console.WriteLine("\n\n remove index 0\n");

            list01.RemoveAt(0);

            foreach (var item in list01)
            {
                Console.WriteLine($"{item}");
            }

            Console.WriteLine("\n\n");

            //list of strings x 3
            //insert new item at index 1 and view results


            list02.Add("Kieron");
            list02.Add("James");
            list02.Add("Newman");

            list02.Insert(1,"bartholemew");

            foreach(var name in list02)
            {
                Console.WriteLine(name);
            }

            //foreach block : used often

            Console.WriteLine("\n\n Dictionary\n");
            var dictionary01 = new Dictionary<int, string>();

            dictionary01.Add(10, "hi");
            dictionary01.Add(20, "there");
            dictionary01.Add(30, "spartans");
            dictionary01.Add(31, "spartans2");
           

            //Iterate ==> loop the process. loop over the dictionary

            foreach(var key in dictionary01.Keys)
            {
                Console.WriteLine($"Key{key,-15} Value {dictionary01[key]}");
            }



            Console.WriteLine("\n\n");

            var queue = new Queue<int>();
            queue.Enqueue(10); //add first
            queue.Enqueue(20); // add second
            queue.Enqueue(30); // add third

            //...............30.......20......10.....BusStop
            var itemThatjustgotonthebus = queue.Dequeue(); //first item got on bus
            //...............30.......20......BusStop
            Console.WriteLine($"item that just got on is {itemThatjustgotonthebus}");

            Console.WriteLine($"queue contains number 50? {queue.Contains(50)}");
            Console.WriteLine($"queue contains number 20? {queue.Contains(20)}");

            // stack
            Console.WriteLine($"Check out who is the first in line{queue.Peek()}");

            //iterate == foreach loop

            foreach(var cust in queue)
            {
                Console.WriteLine($"{cust} is still here");
            }

            Console.WriteLine($"\n\n Stack ");
            var stack = new Stack<string>();

            stack.Push("first");
            stack.Push("second");
            stack.Push("third");
            stack.Push("fourth");
            Console.WriteLine($"\ncheck who is first in line {stack.Peek()}\n");
            foreach(var word in stack)
            {
                Console.WriteLine(word);
            }
            Console.WriteLine("\n remove one item 'pop' off top");
                stack.Pop();
            foreach(var word in stack)
            {
                Console.WriteLine(word);
            }
            Console.WriteLine($"this stack contains fourth ? {stack.Contains("fourth")}");

            //snap code till lunch
            //take numbers 10 20 30 40
            //create a list mult by 10
            //create a queue, add 1
            //create a stack, add 2
            //whats the sum
            Console.WriteLine("\n\n");
            var numArray = new int[] { 10, 20, 30, 40 };
            var numlist = new List<int>();
        



            foreach(var num in numArray)
            {
                numlist.Add(num*10);
                
               
                
            }

            foreach (var listI in numlist)
            {
                Console.WriteLine(listI);
            }

            var numQueue = new Queue<int>();
            
            foreach(var i in numlist)
            {

                numQueue.Enqueue(i + 1);
                

            }         

            var numStack = new Stack<int>();

            foreach(int i in numQueue)
            {
                numStack.Push(i + 2);
            }
            int total = 0;
            foreach (var i in numStack)
            {
                Console.WriteLine(i);

                total += i;

            }

            Console.WriteLine(total);


            var objectList = new ArrayList();
            objectList.Add(10);
            objectList.Add("hi there");
            objectList.Add(true);
            objectList.Add(DateTime.Now);
            foreach(var item in objectList)
            {
                Console.WriteLine($"{item.GetType()} = {item}");
            }




        }

        void DoThis()
        {

        }

        void Dothat()
        {

        }
    }
}
