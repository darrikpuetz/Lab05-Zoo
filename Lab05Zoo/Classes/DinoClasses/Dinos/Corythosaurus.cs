using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class Corythosaurous : MeatEater
    {
        public Corythosaurous(string name, bool scary, bool sharpTeeth)
        {
            Name = name;
            Scary = scary;
            SharpTeeth = sharpTeeth;

        }
        public override string Name { get; set; }
        public override bool Scary { get; set; } = true;
        virtual public bool SharpTeeth { get; set; } = true;
        public override bool Eat()
        {
            return base.Eat();
        }
        public override bool Run()
        {
            return Scary;
        }
        public override bool Terrorizing()
        {
            Console.WriteLine("ROAAAAWWWWWRRRRRRR!!!!!!!!");
            return Terrorizing();
        }
    }
}