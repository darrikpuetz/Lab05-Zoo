using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class Stegosaurus : OmniVore
    {
        public Stegosaurus(string name, bool scary, bool doesnotcare)
        {
            Name = name;
            Scary = scary;
            DoesNotCare = doesnotcare;

        }
        public override string Name { get; set; }
        public override bool Scary { get; set; } = false;
        public override bool DoesNotCare { get; set; } = false;

        public override bool Chillin()
        {
            Console.WriteLine("Sorry I'm going to go relax.");
            return Chillin();
        }
    }
}
