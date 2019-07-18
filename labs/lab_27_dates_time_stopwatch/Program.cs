using System;
using System.Diagnostics;

namespace lab_27_dates_time_stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            // times

            var time01 = DateTime.Now;
            Console.WriteLine(time01);
            Console.WriteLine(time01.ToLongTimeString());

            //add units of time
            Console.WriteLine(time01.AddDays(2));
            Console.WriteLine(time01.AddSeconds(2));
            Console.WriteLine(time01.AddMilliseconds(000).ToUniversalTime());
            Console.WriteLine(time01.AddTicks(2000));


            //mesure time
            var s = new Stopwatch();
            Console.WriteLine("stopwatch is starting");
            s.Start();
            int count = 0;
            for(int i = 0; i<1_000_000_000; i++)
            {
                count++;
            }



            s.Stop();

            Console.WriteLine(s.ElapsedMilliseconds);
            Console.WriteLine(s.ElapsedTicks);
        }
    }
}
