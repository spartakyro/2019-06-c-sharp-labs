using System;

namespace lab_19_polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var p = new Parent();
            p.ThrowAParty();
            var c01 = new Child01();
            c01.ThrowAParty();
            var c02 = new Child02();
            c02.ThrowAParty();
        }
    }
    class Parent
    {
        public virtual void ThrowAParty()
        {
            Console.WriteLine("parent is throwing a posh dinner party only for base classes");
        }
    }

    class Child01 : Parent
    {
        public override void ThrowAParty()
        {
            Console.WriteLine("have fun with kids in pool");
        }
    }

    class Child02 : Parent
    {
        public override void ThrowAParty()
        {
            Console.WriteLine("have fun with kids in house Party");
        }
    }
}
