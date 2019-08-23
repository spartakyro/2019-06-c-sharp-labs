using System;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;
namespace lab_73_array_of_tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Stopwatch();
            s.Start();
            var taskArray = new Task[3];
            taskArray[0] = Task.Run( () => {
                Thread.Sleep(100);
                Console.WriteLine($"task 0 done at {s.ElapsedMilliseconds}");
            } );
            taskArray[1] = Task.Run( () => {
                Thread.Sleep(50);
                Console.WriteLine($"task 1 done {s.ElapsedMilliseconds}");
            }
            );
            taskArray[2] = Task.Run( () => {
                Thread.Sleep(25);
                Console.WriteLine($"task 2 done {s.ElapsedMilliseconds}");
            } );
            //let us wait for one to terminate first
           // Task.WaitAny(taskArray);


            Task.WaitAll(taskArray);

            //hang the program
            Console.WriteLine($"program terminated at {s.ElapsedMilliseconds}");
            

            //return DAT from a task

            //generics  task<t> T is the type of data to return

            var taskGiveMeDataBack = Task<string>.Run(
                () => {
                  Console.WriteLine("Task is running");
                  return "task is completed";
                });

            Console.WriteLine(taskGiveMeDataBack.Result);
            Console.ReadLine();
        }
    }
}
