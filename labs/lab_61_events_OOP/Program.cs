using System;

namespace lab_61_events_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            
            /*scenario : child will have a birthday
                         birthday is the event
                         HaveAParty is a method
                         We attach to an OOP instance ie var james = new child();
             */
            var james = new child();
            for(int i = 0; i<12;i++)
            {
                james.Grow();
            }

        }
    }

    class child
    {
        public delegate int BirthdayDelegate(); //Matches haveaparty() method
        public event BirthdayDelegate OneMoreYearOlder;
        public int Age { get; set; }

        public child()
        {
            Age = 0;
            Console.WriteLine($"Congratulations on the birth of your new baby! Age is {Age}");
            OneMoreYearOlder += HaveAParty; //event is now not null
        }
        

        public int HaveAParty()
        {
            Age++;
            Console.WriteLine($"Celebrating Birthday : Age is now {Age}");
            return Age;
        }

        public void Grow()
        {
            OneMoreYearOlder();
        }
    }
}
