using System;

namespace Lab_60_events_trivial
{   
    class Program
    {
        //delegate ( restriction on  method type
        public delegate int Delegate01(string x);
        //events
        public static event Delegate01 Event01;
        static void Main(string[] args)
        {
            //1.declared event
            //2.Declared restriction on method types(delegate)
            Event01 += Method01; //no brackets so placeholder is created 
                                // but no method is called
            Event01("health");
            //3.Add a method
        }


        static int Method01(string input)
        {
            Console.WriteLine("Hey u printing");
            Console.WriteLine(input);
            return input.Length;
        }
    }
}
