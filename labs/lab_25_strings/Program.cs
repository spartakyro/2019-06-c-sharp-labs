using System;
using System.Text.RegularExpressions;

namespace lab_25_strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string s01 = "hi there";

            foreach(var c in s01)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine($"fifth character is {s01[1]}");
            Console.WriteLine("\n\n");
            for(int i = 0; i < s01.Length; i++)
            {
               // Console.WriteLine(i);
            }

            string s02 = "hi";
            String s03 = "there";

            //parsing to integer

            int num01 = int.Parse("1234");
          
            //Console.WriteLine($"Type of num01 is {num01}");

            try
            {
                int num02 = int.Parse("1234sometext");
               

                int num03 = int.Parse("sometext1234sometext");
               

                int num04 = int.Parse("22");
                
            }
            catch (Exception e)
            {
                Console.WriteLine("dont use parse");
               
            }
            finally
            {
                
            }

            //dont use parse it will throw an exception and crash your computer


            int.TryParse("123abc", out int output01);
            int.TryParse("abc123", out int output02);
            int.TryParse("abc", out int output03);
            int.TryParse("123", out int output04);



            //string.format and string interpolation
            double d01 = 1.234;
            Console.WriteLine(String.Format("{0,10:N0}", d01));
            Console.WriteLine(String.Format("{0,10:N0}", d01));
            Console.WriteLine(String.Format("{0,10:N0}", d01));

            Console.WriteLine($"{d01,10:N0}");
            Console.WriteLine($"{d01,10:N1}");
            Console.WriteLine($"{d01,10:N2}");

            //column width
            Console.WriteLine($"{d01,10:N0}{d01,10:N1}{d01,10:N2}");
            Console.WriteLine($"{d01,20:N0}{d01,20:N1}{d01,20:N2}");

            int result = Convert.ToInt32
             (
                 Regex.Replace
                 (
                     "7yu4805jqwfwei321",    // input
                     "[^0-9]",               // select everything that is not in the range of 0-9
                     ""                      // replace that with an empty string.
                 )


             );


            string sentance = "food is life";
            string[] words = sentance.Split(' ');
            foreach(var w in words)
            {
                Console.WriteLine($"{w}");
            }

            //array.join
            
            sentance = string.Join(" if ", words);
            Console.WriteLine(sentance);


            //startsWith
            if(sentance.StartsWith("f"))
            {
                Console.WriteLine("found the sentances start");
            }

            //IsNullOrWhiteSpace

            string a1 = null;

            // always returns true for = null
            bool b1 = String.IsNullOrWhiteSpace(a1);
            Console.WriteLine(b1);


            string a2 = " ";

            // for whitespace value always return true 
            bool b2 = String.IsNullOrWhiteSpace(a2);
            Console.WriteLine(b2);

            string a3 = " \n ";

            // for new line value return true 
            bool b3 = String.IsNullOrWhiteSpace(a3);
            Console.WriteLine(b3);

            string a4 = " this one will work ";

            // fthis line value returns true 
            bool b4 = String.IsNullOrWhiteSpace(a4);
            Console.WriteLine(b4);

            /*
            StartsWith
            Contains
            Trim/TrimStart/TrimEnd
            ToUpper/lower
            .Insert/Remove
            .Replace
            .Concat
            .IsNullOrEmpty
            .IsNullOrWhiteSpace
            .Empty



            startWith
            IsNullOrWhiteSpace

             
             
             */

        }
    }
}
