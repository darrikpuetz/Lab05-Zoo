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
        virtual public bool DoesNotCare { get; set; } = true;
        public override bool Eat()
        {
            return base.Eat();

        }
        public override bool Run()
        {
            return Scary;

        }
        public override bool Chillin()
        {
            Console.WriteLine("Sorry I'm going to go relax.");
            return Chillin();
        }
    }
}
