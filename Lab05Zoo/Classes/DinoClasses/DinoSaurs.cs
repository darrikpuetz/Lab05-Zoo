using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public abstract class Dinosaurs
    {
        public abstract string Name { get; set; }
        public abstract bool Scary { get; set; } 
        public abstract bool Eat();
        public abstract bool Run();


    }
}
