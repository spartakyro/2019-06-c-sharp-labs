using System;
using System.Collections;
using System.Collections.Generic;

namespace snap_lab_02_array_list
{
    class Program
    {
        
        static void Main(string[] args)
        {
            ArrayList numbers = new ArrayList ();
            numbers.Add(5);
            numbers.Add(6);
            numbers.Add(7);
            numbers.Add(8);
            numbers.Add(9);

          
            var array01 = new int [5];
            var counter = 0;

            foreach(int num in numbers)
            {
                array01[counter] = num * 4;
               
                counter++;
               
            }

            List<int> list01 = new List<int>();
            var count = 0;
            foreach(int num in array01)
            {
                list01.Add(num * 4);
               //Console.WriteLine(num);
                //count++;
            }

            var queue01 = new Queue<int>();
            foreach(var num in list01)
            {
                queue01.Enqueue(num * 4);
            }

            var stack01 = new Stack<int>();
            foreach(var num in queue01)
            {
                stack01.Push(num * 4);
               // Console.WriteLine(num);
            }

            Dictionary<int, int> dict01 = new Dictionary<int, int>();
            int cou = 0;
            foreach(var num in stack01)
            {

                dict01.Add(num, num * 4);
            }
            int total = 0;

            foreach(var num in dict01.Keys)
            {
                total += dict01[num];
            }

            Console.WriteLine(total);



        }



        /*Snap Lab : 10 minutes
        Input 5 numbers and put into an ArrayList
        Create an Array, List, Queue, Stack, Dictionary.
        Move objects from Arraylist to each item and multiply by 4 each move.
        What's the total?
        Time starts*/

    }
}
