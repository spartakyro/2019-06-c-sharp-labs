using System;

namespace lab_22_First_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

   public class LabWork
    {
        public int CubeNumbers(int x, int y, int z)
        {
            return (x*y*z);
        }

        public static int CubeNumbersStatic(int x, int y, int z)
        {
            return (x * y * z);
        }

        public static int GetLengthOfArray(int[] myArray)
        {
            return myArray.Length;
        }

        public static int SumTotalOfArrayMembers(int[] array)
        {
            return -1;
        }
    }
}
