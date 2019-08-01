using System;
using System.IO;
using System.Diagnostics;
using System.Text;

namespace lab_62_streaming
{
    class Program
    {
        static void Main(string[] args)
        {
            /*var stoppy = new Stopwatch();
            stoppy.Start();

            //stream to a writer

            using (var writer = new StreamWriter("output.txt"))
            {
                for (int i = 0; i < 10000; i++)
                {
                    writer.WriteLine($"Line {i} - adding some text {DateTime.Now} : elapsed time {stoppy.ElapsedTicks}");
                }
            }

            var s = new Stopwatch();
            s.Start();
            //see if string builder is a bit faster
            var sbuilder = new StringBuilder();
           

            for (int i = 0; i < 10000; i++)
           {
              sbuilder.Append($"Line {i} - adding some text {DateTime.Now} : elapsed times {s.ElapsedTicks}\n");
           }

            using (var writer = new StreamWriter("output2.txt"))
            {
                writer.WriteLine(sbuilder);
            }
            s.Stop();


            var u = new Stopwatch();
            u.Start();
            string nextline;
            var stringbuilder2 = new StringBuilder();

            using (var reader = new StreamReader("output.txt"))
            {
                //two operarions 1) read nextline and assign into string 'nextline' 2) check has not returned null
                while((nextline = reader.ReadLine()) != null)
                {
                    stringbuilder2.AppendLine(nextline);
                }
                    
            }
            Console.WriteLine($"read file to memory: {u.ElapsedTicks}");
            //Console.ReadLine();
           // Console.WriteLine(stringbuilder2);
            Console.WriteLine($"output file to console: {u.ElapsedTicks}");
            u.Stop();*/


            //use a 'pointer' which is a reference to an address in memory
            // read data from pointer forwards

            using (var memorystream = new MemoryStream())
            {
                var buffer = new byte[100];
                buffer[0] = (int)'h';
                buffer[1] = (int)'e';
                buffer[2] = (int)'l';
                buffer[3] = (int)'l';
                buffer[4] = (int)'o';
               
                //write data to memory
                memorystream.Write(buffer);
                memorystream.Flush();   //actively push remaining data to memory

                //get meaningful data back?
                //reset pointer to 0
                memorystream.Position = 0;
                var reader = new StreamReader(memorystream);
                Console.WriteLine(reader.ReadToEnd());
            }
        }
    }
}
