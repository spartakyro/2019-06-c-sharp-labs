using System;
using System.IO;

namespace lab_44_crash_your_pc
{
    class Program
    {
        static void Main(string[] args)
        {

            string x = null;
            try
            {
                var filecontent = File.ReadAllText("wontfindme.txt");
                Console.WriteLine(x.Length);
            }
            catch(NullReferenceException e)
            {
                Console.WriteLine("null regerence");
            }
            catch(FileNotFoundException e)
            {
                Console.WriteLine("File not found");
            }
            catch(Exception e)
            {
                Console.WriteLine("general exception");
            }


        }

        /*public void crashPC()
        {
            for(int i = 0; i<10000;i++)
            {
                
               Console.WriteLine(i);
                crashPC();
            }
        }*/


    }
}
