using System;
using System.IO;
using System.Diagnostics;

namespace lab_35_exception
{
    class Program
    {
        static void Main(string[] args)
        {

            try { }
            catch { };

            try { }
            catch { }
            finally { }

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

                
            }

            finally { }
        }
    }
}
