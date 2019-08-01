using System;

namespace Lab_58_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new Child();
            c.Name = "Kieron Newman";
            c.property01 = 100;
            c.UseTool01();

            Console.WriteLine(c.DoThat());
            
        }

    }

    interface IToolShedItem01 {
        //no fields
        //public int field01
        //yes property

        int property01 { get; set; } //public is present but not stated
        void UseTool01(); // abstract (ALSO Public) - again, present but not stated
    }

    interface IToolShedItem02
    {
        int property02 { get; set; }
        string DoThat();
    }

    abstract class Parent
    {
        public string Name { get; set; }
        public abstract void DoThis();
    }

    class Child : Parent, IToolShedItem01, IToolShedItem02
    {
        public int property01 { get; set; }
        public int property02 { get; set; }
        public override void DoThis() { } // mandaroty abstract override

        public void UseTool01() { Console.WriteLine("using Tool01"); }

        public string DoThat() => "Shovel";


    }
}
