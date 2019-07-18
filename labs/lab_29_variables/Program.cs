using System;

namespace lab_29_variables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            byte b01 = 0; //min
            byte b02 = 255; //max
            byte b03 = 0b_1010_0101; //binary literal
            byte b04 = 0x_FF;       // 0x is a hexidecimal literal
            byte b05 = 0x_0c;       // 0x is a hexidecimal literal

            // buffer
            //youtube: video is split into tiny parts....each part is split into tiny parts
            //each part is size of a 'buffer'
            //video is buffering
            //buffer is an array of bytes
            byte[] mybuffer = new byte[4000];  //chunk size for send
                                               // my video

            //char
            //ASCII: first computers maps a number to every character
            // h is 104 H is 72
            char char01 = 'c';
            char char02 = 'd';

            Console.WriteLine((int)char01);
            Console.WriteLine((int)char02);

            //unicode is upgraded to ascii
            //utf-8 web getbootstrap.com
            //utf-16 unicode ==> chinease characters

            const int num10 = 10;
            //cannot change 'const'         num10 = 10;

            const double num_5_FIXED = 5;

            var num01 = 10;
            var num02 = "hi";

            //alias
            string x = "hi";        //use this, lover case s
            String y = "there";     //not this, capital 'S' String is the class: dont use
                                    //valid use would be : var s = new String();


            //readonly : use in preference to const
            //const change value to literal

            //Tuples
            void doThis() { }

            int doThat ()
            {
                return -1;
            }

            void doingSomething(out int result, out string result2)
            {
                result = -1;
                result2 = "hi";
            }

            //Tuple is an anonymous type

            //declare
            (string x01, int y01,bool z01) doingSomethingElse()
            {
                var name = "kieron";
                return (name,10,false);

            }

            var output01 = doingSomethingElse();

            //get individual items

            Console.WriteLine($"{output01.x01}{output01.y01}{output01.z01}");
            Console.WriteLine($"{output01.x01}{output01.y01}{output01.z01}");

            //Null Check

            string authorName = null;
            int nameLength = authorName.Length;
            if(authorName != null)
            {
                Console.WriteLine(authorName.Length);
            }

            int? nameLength2 = authorName?.Length;  //if name is null ==> return null otherwise return length

            int? nullableItem = null;
          //  int cannotmakeNull = null;



        }
    }
}
