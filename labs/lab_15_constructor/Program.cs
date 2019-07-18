using System;

namespace lab_15_constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            
           // var Bob = new Person("def456", "donttellthat", "bob");
            var Peter = new Person("abc123", "donttellthis", "Peter");
            Peter.getNINO("Peter", "donttellthis");
            Console.WriteLine(Peter.setNINO("DEF456", "donttellthis"));
        }
        
        class Person
        {
            private string NINO;
            private string password;
            public string Name;

            //constructor : public + name of class public person
            public Person (string NINO,String password,String Name)
            {
                this.NINO = NINO ;
                this.password = password;
                this.Name = Name;
            }

            public bool setNINO (string newNINO,string password)
            {
                bool itWorked = false;

                if (this.password == password)
                {
                    this.NINO = newNINO;
                    itWorked = true;
                }

                return itWorked;
            }

            public bool getNINO(string Name, string password)
            {
                bool itWorked = false;
                if (this.password == password)
                {
                    
                    itWorked = true;
                    Console.WriteLine(this.NINO);
                }

                return itWorked;
            }


        }
    }
}
