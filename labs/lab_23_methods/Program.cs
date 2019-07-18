using System;

namespace lab_23_methods
{
    
    class Program
    {
        static void Main(string[] args)
        {
            //Grow(); instance method
            var X01 = new X();
            X01.Age = 1;
            X01.Grow();
            //ReturnFixedData(); static method
            X.ReturnFixedData();
            Console.WriteLine(X01.Age);

            //Remember static maths class which returns PI, Logx ect;
            Console.WriteLine(Math.PI);


            DoThis();
            doThat();
            DoingLots(c: false, b: "there", a: 10_000_000);

            //can put methods here
            void DoThis(){ Console.WriteLine("i am doing something"); }

            doingBits(new DateTime(2019,6,27)); // set date but others default
            doingBits(new DateTime(2019, 06, 27), 'a', 1.3f, 100.222);
            

        }
        static void doThat() { Console.WriteLine("i am doing something"); }
        //can put methods here


        static void DoingLots (int a ,string b,bool c)
        {
            Console.WriteLine($"doing lots that {a} {b} is {c}");
        }

        static void doingBits(DateTime date, char c = 'z', float f = 1.2f, double d = 100.32900001)
        {
            Console.WriteLine($"{date}, {c}, {f}, {d}");
            string newday = date.ToShortDateString();
            Console.WriteLine($"{newday}, {c}, {f}, {d}");
            newday = date.ToLongDateString();
            Console.WriteLine($"{newday}, {c}, {f}, {d}");
            newday = date.AddDays(3).ToLongDateString();
            string weekday = date.DayOfWeek.ToString();
            Console.WriteLine($"{weekday},{c},{f},{d}");

        }
    }

    class X
    {
        public int Age;
        
        
        //can put instance method
        public void Grow()
        {
            Age++;
        }

        //Static method : useful for fixed data : static = stock warehouse(whole App)
        public static string ReturnFixedData()
        {
            return "here is some fixed data";
        }

    }
}
