using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace lab_35_b
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //dodgy code here
                var data01 = File.ReadAllText("thisdoesnotexcist.txt");
            }
            catch (Exception e)
            {
                Console.WriteLine("exception was thrown and caught here");
                Console.WriteLine("details are : ");
                //Console.WriteLine(e);
                //Console.WriteLine(e.Data);
                //Console.WriteLine(e.Message);
                Console.WriteLine("your an amazing user using this " + "program beautifully");
                Console.WriteLine("we couldnt find that file you where looking for though");

                var d = DateTime.Now;

                File.AppendAllText("logoutput.txt", $"exception at{d} - file not found");

                EventLog.WriteEntry("Application", "Kieron Newman is in windows", EventLogEntryType.Information, 5001, 1234);





                Console.WriteLine("\n\n look at divide by Zero exception also\n\n");

                int x = 10;
                int y = 0;

                //throw and catch x/y please and output 'you divided by 0'

                try
                {
                    int num = x / y;
                       
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("hey you divided by 0");
                    
                }

            }
        }
    }
}