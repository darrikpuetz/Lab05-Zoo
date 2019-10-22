using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class Trex : MeatEater
    {
        public Trex(string name, bool scary, bool sharpTeeth)
        {
            Name = name;
            Scary = scary;
            SharpTeeth = sharpTeeth;

        }
        public override string Name { get; set; }
        public override bool Scary { get; set; } = false;
        public override bool SharpTeeth { get; set; } = true;



    }
}
