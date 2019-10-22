using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public abstract class OmniVore : Dinosaurs
    {
        public override string Name { get; set; }
        public override bool Scary { get; set; } = false;
        virtual public bool DoesNotCare { get; set; } = true;
        public override bool Eat()
        {
            bool eating1 = true;
            if (Scary == true)
            {
                eating1 = false;
                Console.WriteLine("Nom Nom. Yummy!");
                return eating1;
            }
            else
                return
                    eating1;
        }
        public override bool Run()
        {
            bool running1 = false;
            try
            {
                if (Scary == true)
                {
                    running1 = true;
                    Console.WriteLine(" Hurry this thing moves quick! Better move it.");
                    return running1;
                }
                else
                {
                    Console.WriteLine("It's not scary. You'll be fine.");
                    return running1;
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Are you even scary ? ");
                return running1;
            }
        }
        public virtual bool Chillin()
        {
            return Chillin();
        }
    }
}
