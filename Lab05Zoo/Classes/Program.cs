﻿using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chris is a class
            //chriscummings is an intance (a.k.a object)
            PlantEater corythosaurus = new PlantEater("corythosaurus", true, 0);
            OmniVore chrisCummings = new OmniVore("ChrisCummings", true, 999);
            MeatEater chrisCummings = new MeatEater("ChrisCummings", true, 999);
            MeatEater chrisCummings = new MeatEater("ChrisCummings", true, 999);
        }
    }
}
