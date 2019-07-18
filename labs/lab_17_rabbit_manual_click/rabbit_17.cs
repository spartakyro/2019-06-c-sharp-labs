using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_17_rabbit_manual_click
{
    public class Rabbit
    {
        public int age { get; set; }
        public string Name { get; set; }

        public Rabbit(int counter)
        {
            this.age = 0;
            this.Name = "Rabbit " + counter;

        }
    }
}
