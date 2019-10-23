using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public abstract class MeatEater : Dinosaurs, IDestroy
    {

        public override string Name { get; set; }
        public override bool Scary { get; set; } = true;
        virtual public bool SharpTeeth { get; set; } = true;
        public override bool Eat()
        {
            bool eating1 = false;
            if (SharpTeeth == true)
            {
                eating1 = true;
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
                    Console.WriteLine(" It's not scary. You'll be fine.");
                    return running1;
                }
            }
            catch (Exception)
            {

                Console.WriteLine(" Are you even scary ? ");
                return running1;
            }
        }
        public virtual bool Terrorizing()
        {
            bool terrorizing = false;
            if (Scary == true && SharpTeeth == true)
            {
                terrorizing = true;
                Console.WriteLine(" I am Terrorizing!");
            return terrorizing;
            }
            else
            {
                return terrorizing;
            }
        }
        public bool Destroy()
        {
            bool sharp = false;
            if (SharpTeeth == true)
            {
                sharp = true;
                Console.WriteLine(" Get Out Da Way!!! I'm DESTROYING things.");
                return sharp;
            }
            else
                return
                    sharp;
        }
    }
}
