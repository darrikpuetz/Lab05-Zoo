using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public abstract class OmniVore : Dinosaurs
    {
        public override string Name { get; set; }
        public override bool Scary { get; set; } = false;
        virtual public bool doesNotCare { get; set; } = true;
        public override bool Eat()
        {
            Console.WriteLine("Nom Nom. Yummy!");
            return Eat();

        }
        public override bool Run()
        {
            try
            {
                if (Scary)
                {
                    Console.WriteLine(" Hurry this thing moves quick! Better move it.");
                    return Run();
                }
                else
                {
                    Console.WriteLine("It's not scary. You'll be fine.");
                    return Scary;
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Are you even scary ? ");
                return Scary;
            }
        }
        public virtual bool Chillin()
        {
            return Chillin();
        }
    }
}
