using System;

namespace lab_57_abrstract_revision
{
    class Program
    {
        static void Main(string[] args)
        {
            var holiday = new Going();
            holiday.Views();
           // var Flights = new ();
        }

        abstract class revision
        {
            internal void Location() { Console.WriteLine("Pariiiii"); }

            public abstract void Views();


        }

        abstract class catchingFlights
        {
            public abstract DateTime departureTime { get; set; }
            public abstract DateTime arrivalTime { get; set; }
        }

        /*class leavingtimes : catchingFlights
        {
            //public override DateTime departureTime {  }
        }*/

        class Going : revision
        {
            public override void Views() { Console.WriteLine("visiting the eiffel tower");   }
        }

    }




}
