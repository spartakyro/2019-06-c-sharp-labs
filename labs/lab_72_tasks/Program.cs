using System;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace lab_72_tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            //old
            var actionMethod01 = new Action(doThis);
            var task01 = new Task (actionMethod01);
            task01.Start();

            //OLD
            // hey computer please create a backgorund task, and, whenever the cpu has resources available, run this task. please. thanks
            //cpu :  hey, no problem.
            var task02 = Task.Factory.StartNew(

                //placeholder for a method, == delegates whcih are placeholders for method

                () => { Console.WriteLine("inside task02 which is called by task factory"); }

                );



            var task03 = new Task(
                () => { Console.WriteLine("inside task03"); }
                );
            task03.Start();


            var task04 = Task.Run(
                () => { Console.WriteLine("inside task04 - use this way to create and run tasks");
                    doThis();
                }
                
                );

            //hang the program so it does not terminate
            Console.WriteLine("program has finished");
            Thread.Sleep(3000);
            Console.ReadLine();
        }

        static void doThis()
        {
            Thread.Sleep(10);
            Console.WriteLine("i am doing something");
        }
    }
}
