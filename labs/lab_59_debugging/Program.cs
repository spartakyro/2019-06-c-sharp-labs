using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
namespace lab_59_debugging
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                Debug.WriteLine($"debugging : i is {i}");
                Trace.WriteLine($"trace to output window (in final release mode and debug mode) : i is {i}");
                File.AppendAllText("output.txt", $" logging to text file {DateTime.Now} i has value {i}");
                var output = $" logging to text file {DateTime.Now} i has value {i}";
                //can also log to the windows application event log

                //log to c:\log folder                
                File.AppendAllText("C:\\Log\\output.txt", output + Environment.NewLine);

                //log to my documents\ log folder
                File.AppendAllText("C:\\Users\\knewman\\Documents\\Log\\output.txt", output + Environment.NewLine);
                //Any users>>> special folders
                File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Log\\output.txt", output + Environment.NewLine);
                //@ literal String notation As well
                File.AppendAllText(@"C:\Users\knewman\Documents\Log\output.txt", output + Environment.NewLine);


                //can also log to the windows application event  
                EventLog.WriteEntry("Application", "your window has been hacked!!", EventLogEntryType.Information, 5678, 123);
            }

           // 

            for (int j = 0; j<10;j++)
            {
                Console.WriteLine($"J has value {j}");
            }

            Console.ReadLine();
            //1 => debug which is F5
            //2 => not debug mode which is control F5 in debug ==> still shows all output
            //3 => not debug mode plus build => configerations => Release then...only 
        }
    }
}
