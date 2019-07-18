using System;
using System.Collections.Generic;
using System.Collections;


namespace Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ar = new int[] { 1, 2, 3, 5, 6, 7, 8, 9, 10, 11 };
            int[] tr = new int[] { 10, 20, 30, 50, 60, 70, 80, 90, 100, 110 };
            //return array
            int[] ra = new int[] { 1, 2, 3, 4, 5, 6 };
            //xyz
            int[] xyz = new int[] { 94, 101, 20, 45,57 };

            var numArray = new int[] { 10, 20, 30, 40 };

            var snaptest = new int[] { 5, 6, 7, 8, 9 };
            int[] rabbits01 = new int[] { };



            //Console.WriteLine("Hello World!");
            //Console.WriteLine(Eng35Tests.CreateArrayFromSentence(" "));
            Eng35Tests.Mega_Multiple_Coding_Loops(ar);
            Eng35Tests.Mega_Loops_TrialRun(tr);
            //xyz
            Eng35Tests.Accept_Xyz(xyz);
            //Console.WriteLine(Eng35Tests.Accept_Xyz(xyz));
            Eng35Tests.Array_loop_queue_stack(numArray);
            //How_Many_Numbers_Divisible_by
            Eng35Tests.How_Many_Numbers_Divisible_by(2,10,4);
            Console.WriteLine(Eng35Tests.How_Many_Numbers_Divisible_by(2, 10, 4));

            //return sum
            Console.WriteLine( Eng35Tests.Return_Sum_of_array(ra));

            
            //method to accept x,y,n

            //snap test
            Eng35Tests.snapTest(snaptest);      
            


        }
    }

    public class Eng35Tests
    {
        //pass in a sentance return an array of individual words
        public static string[] CreateArrayFromSentence(string sentence)
        {

            string[] words = sentence.Split(' ');

            foreach (var w in words)
            {
                //Console.WriteLine($"{w}");
            }

            return new string[] { };
        }

        //pass in a sentance return the number of words
        public static int Calculate_Words_In_Sentence(string sentence)
        {


            return -1;
        }

        public static string Turn_First_Words_To_Upper_Case(string sentence)
        {
            return "";
        }

        public static string Turn_Allt_Words_To_Upper_Case_But_Last_Word_To_Lower_Case(string sentence)
        {
            return "";
        }

        public static int Return_Sum_of_array(int [] ReturnArray)
        {
            int counter = 0;
            int sum = 0;
            
            
            foreach(int num in ReturnArray)
            {
                
                sum += num * ReturnArray[counter];
                counter++;
            }
           return sum;
            //return -1;
            

        }

        public static int Accept_Xyz( int [] XyzAccept)
        {
            string counter = "";

            Array.Sort(XyzAccept);
            Console.WriteLine("array after sorting: \n");
           foreach(int num in XyzAccept)
            {
                 Console.WriteLine(num + "");
            }

                return 0;


            
        }


        public static int How_Many_Numbers_Divisible_by(int start,int end,int divisor)
        {
            Console.WriteLine("\n\n\n");
            //how many integers are divisable by given divisor in the given range
            //example(2,10,4) means srats at 2 and count up to 10
            //only 4,8 are divisable by 4
            //so answer is 2

            int counter = 0;

            for(int i = start; i<end;i++)
            {
                if(i%divisor == 0)
                {
                    counter++;
                    Console.WriteLine($" the counter result is{counter}");
                }
            }

            return counter;
        }


        static List<cats> cats = new List<cats>();
        public static int Mega_Multiple_Coding_Loops(int[] myarray)
        {

            int counter = 0;

            while (counter < myarray.Length)
            {
                myarray[counter]++;
                //Console.WriteLine(myarray[counter]);
                counter++;

            }

            int c = 0;
            //Console.WriteLine("\n\n");

            do
            {
                myarray[c] += 3;
                //Console.WriteLine(myarray[c]);
                c++;



            } while
            (c < myarray.Length);

            int i = 0;
            //Console.WriteLine("\n\n");

            foreach (int num in myarray)
            {
                myarray[i] = num * 2; //could also put myarray[i] *=2;
               // Console.WriteLine(myarray[i]);
                var ca = new cats("cat" + i.ToString(), i);
                cats.Add(ca);

                i++;
            }
            int totalAge = 0;

            foreach(var ca in cats)
            {
                totalAge += ca.age;
               //Console.WriteLine($"{ca.name,-20} is {ca.age}");
                

            }


           // Console.WriteLine(totalAge);

            return totalAge;




           
        }
         
        public static int Mega_Loops_TrialRun(int[] TestingArray)
        {

            int counter = 0;

            while(counter < TestingArray.Length)
            {
                TestingArray[counter] ++;
                //Console.WriteLine(TestingArray[counter]);
                counter++;
            }

            int count = 0;
            do
            {
                TestingArray[count] += 3;
                //Console.WriteLine(TestingArray[count]);
                count++;

            } while (count < TestingArray.Length);

            int co = 0;
            foreach(int i in TestingArray)
            {
                TestingArray[co] = i * 2;
               // Console.WriteLine(TestingArray[co]);
                co++;
            }


            return 45;
            

            

            


        }

        public static int Array_loop_queue_stack(int[] numArray)
        {
            
            var numlist = new List<int>();




            foreach (var num in numArray)
            {
                numlist.Add(num * 10);



            }

            foreach (var listI in numlist)
            {
                Console.WriteLine(listI);
            }

            var numQueue = new Queue<int>();

            foreach (var i in numlist)
            {

                numQueue.Enqueue(i + 1);


            }

            var numStack = new Stack<int>();

            foreach (int i in numQueue)
            {
                numStack.Push(i + 2);
            }
            int total = 0;
            foreach (var i in numStack)
            {
                Console.WriteLine(i);

                total += i;

            }

            Console.WriteLine(total);

            return total;
        }

        public static int snapTest(int[] stest)
        {
            

            foreach(var num in stest)
            {
                Console.WriteLine($"this is the test {num}");
            }

            var array01 = new int[5];
            var counter = 0;

            foreach (int num in stest)
            {
                array01[counter] = num * 4;

                counter++;

            }

            List<int> list01 = new List<int>();
            var count = 0;
            foreach (int num in array01)
            {
                list01.Add(num * 4);
                //Console.WriteLine(num);
                //count++;
            }

            var queue01 = new Queue<int>();
            foreach (var num in list01)
            {
                queue01.Enqueue(num * 4);
            }

            var stack01 = new Stack<int>();
            foreach (var num in queue01)
            {
                stack01.Push(num * 4);
                // Console.WriteLine(num);
            }

            Dictionary<int, int> dict01 = new Dictionary<int, int>();
            int cou = 0;
            foreach (var num in stack01)
            {

                dict01.Add(num, num * 4);
            }
            int total = 0;

            foreach (var num in dict01.Keys)
            {
                total += dict01[num];
            }

            Console.WriteLine($"this is the end test {total}");



            return total;
        }

        public static double Rabbit_Population(int populationCount)
        {
            //var populationCount = 1_000_000;
            var counter = 0;
            double rabbitpop = 0;


            while (rabbitpop < populationCount)
            {
                rabbitpop = Math.Pow(2, counter);


                //Console.WriteLine($"there are {rabbitpop} rabbits after {counter} seconds");

                counter++;
                System.Threading.Thread.Sleep(100);

            }

            return rabbitpop;
        }
    }


    public class cats
    {
        public string name { get; set; }
        public int age { get; set; }

        public cats(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }


    
}