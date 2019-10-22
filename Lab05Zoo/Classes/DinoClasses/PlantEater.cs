using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public abstract class PlantEater: Dinosaurs
    {
        public override string Name { get; set; }
        public override bool Scary { get; set; } = false;
        virtual public bool LikeLeafs { get; set; } = true;
        public override bool Eat()
        {

        }
        public override bool Run()
        {

        }
        public virtual bool Ride()
        {

        }

    }
}
