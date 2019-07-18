using System;

namespace lab_40_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // for: for is used for counting fixed numbers/ iterations and then get a result when said numbers or number is hit
            // foreach: foreach looks at individuals within an array
            // while: while (condition) is checked before loop, however it may never be called
            // do / while: condition is checked after loops, always enters atleast once

            // break: useful when looking for 1 item only, and looping until find this item
            string[] items = new string[] { "first", "second", "third" };
            foreach(var item in items)
            {
                if (item == "second")
                {
                    break; //exit foreach structure completely
                }

                Console.WriteLine("items before break point -" + item);
            }
            //continue:

            foreach (var item in items)
            {
                if (item == "second")
                {
                    continue; // finish this loop and start on next loop
                }

                Console.WriteLine("items not including continue -" + item);
            }
            //return: use return to save lots of if else conditions and nested

            var output = DoThis(10); //prints -150

            int DoThis(int inputnumber)
            {

                if (inputnumber == 5)
                {
                    return -100;
                }


                if (inputnumber == 10)
                {
                    return -150;
                }
                
                return -1000;
                
            }

            




            //throw: create a loop but maually throw exception and exit loop if certain condition is reached


        }
    }
}
