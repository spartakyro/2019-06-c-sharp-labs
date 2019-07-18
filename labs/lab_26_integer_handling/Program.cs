using System;

namespace lab_26_integer_handling
{
    class Program
    {
        static void Main(string[] args)
        {
            //signed integer can be positive or negative
            short s01;      //length is 16 bits, 16 bit for the data and 1 bit for +/-
            int i01;        //32, 31 bit for the data and 1 bit for +/-
            long l01;       //64, 63 bit for the data and 1 bit for +/-

            Console.WriteLine(short.MaxValue);          
            Console.WriteLine(ushort.MaxValue);         //16 ^ 2 =>65536
            Console.WriteLine(ulong.MaxValue);         //16 ^ 2 =>65536
                                                        // 16 bit 65535
                                                        // start at 0 finish @ 65535
            Int16 s02;      //16
            Int32 i02;      //32
            Int64 l02;      //64

            //unsigned Integer
            ushort us03;    //unsigned 16 bit..
            uint ui02;      //unsigned 32
            ulong ul03;     //unsigned 64
        }
    }
}
