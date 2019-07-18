using NUnit.Framework;
using lab_22_First_Test;
using Tests;
using System;

namespace Tests
{
    public class NUnitTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(10, 10, 10, 1000)]
        [TestCase(10, 11, 12, 1320)]
        [TestCase(1, 123, 185, 22755)]
        public void CubicNumbersTest(int x, int y, int z, int expected)
        {
            //arrange

            var instance = new LabWork();
            //act
            var actual = instance.CubeNumbers(x, y, z);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(10, 10, 10, 1000)]
        [TestCase(10, 11, 12, 1320)]
        [TestCase(1, 123, 185, 22755)]
        public void CubicNumbersTestStatic(int x, int y, int z, int expected)
        {
            //arrange

            //act
            var actual = LabWork.CubeNumbersStatic(x, y, z);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3 }, 3)]
        [TestCase(new int[] { 1, 2, 3, 300, 500 }, 5)]
        [TestCase(new int[] { 1, 2, 3, -10, -30, -50 }, 6)]

        public void ArrayLengthTest(int[] testArray, int expected)
        {

            var actual = LabWork.GetLengthOfArray(testArray);
            Assert.AreEqual(expected, actual);

        }

        public static int SumTotalOfArrayMembers(int[] array, int expected)
        {
            var actual = LabWork.SumTotalOfArrayMembers(array);
            return -1;
        }


        [TestCase (new int[]{1,2,3,5,6,7,8,9,10,11}, 45)]

         public void Mega_Multiple_Coding_Loops(int[] myarray, int expected)
        {
            var actual = Eng35Tests.Mega_Multiple_Coding_Loops(myarray);

            Assert.AreEqual(expected, actual);


           
         



            /*Pass in array of 10 numbers[10, 11, 15, 25..While loop ==> add one to each number[11, 12, 16

            Do..While loop ==> add 3 to each number[14, 15, 19..Foreach loop ==> double each number[28, 30, 38...
            Create a Cat class with string Name and int Age.Have a Constructor.

           Create a list of Cats and foreach loop => create new cat with name 'Cat'+number' and Age=number
                            eg first cat is called 'Cat28' and has Age 28.
           print the list of cats with names and ages
           Return the total of all the ages of all cats!*/
        }
 
        [TestCase(new int[] { 10, 20, 30, 50, 60, 70, 80, 90, 100, 110 }, 45)]
        public void Mega_Loops_TrialRun(int [] testingArray , int expected)
        {
            var actual = Eng35Tests.Mega_Loops_TrialRun(testingArray);

            Assert.AreEqual(expected, actual);
            
        }

        [TestCase(new int[] { 1,2,3,4,5,6},91)]
         public void Return_Sum_of_array(int [] ReturnArray, int expected)
        {
            var actual = Eng35Tests.Return_Sum_of_array(ReturnArray);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 20, 94 ,45, 101,57 }, 8)]
        public void Accept_xyz(int [] XyzAccept, int expected)
        {
            

        }

        [TestCase(new int[] { 10,20,30,40 }, 1012)]
        public void arrayloopqueuestack(int [] array, int expected)
        {
            var actual = Eng35Tests.Array_loop_queue_stack(array);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(2,10,4,2)]
        public void How_Many_Numbers_Divisible_by(int x, int y, int div, int expected)
        {
            var actual = Eng35Tests.How_Many_Numbers_Divisible_by(x,y,div);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 5, 6, 7, 8, 9 }, 35840)]
        public void snapTest(int [] stest, int expected)
        {
            var actual = Eng35Tests.snapTest(stest);
            Assert.AreEqual(expected, actual);
        }

        [TestCase (1000000, 1048576)]
        public void Rabbits_Population_Counter(int i, int expected)
        {
            var actual = Eng35Tests.Rabbit_Population(i);
            Assert.AreEqual(expected, actual);


        }
    }
}
