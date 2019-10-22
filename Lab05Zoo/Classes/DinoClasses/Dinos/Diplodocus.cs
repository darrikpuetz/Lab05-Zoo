using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class Diplodocus : PlantEater
    {
        public Diplodocus(string name, bool scary, bool likesLeafs)
        {
            Name = name;
            Scary = scary;
            LikesLeafs = likesLeafs;

        }
        public override string Name { get; set; }
        public override bool Scary { get; set; } = false;
        public override bool LikesLeafs { get; set; } = true;
        public override bool Eat()
        {
            return base.Eat();
        }
        public override bool Run()
        {
            return Scary;
        }
        public override bool Ride()
        {
            Console.WriteLine("Yeehaw!");
            return Ride();
        }
    }
}
