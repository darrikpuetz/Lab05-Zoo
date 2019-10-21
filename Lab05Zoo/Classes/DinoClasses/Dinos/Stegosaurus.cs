using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class Omnivore
    {
       

        }
        public string Name { get; }
        public int HasCats { get; set; }
        public bool IsIdiot { get; private set; }
        public string HairColor { get; set; }
        bool canHelp()
        {
            if (IsIdiot)
            {
                return true;
            }
            return false;
        }
        //    void canHelp()
        //    {

        //    }
    }
}
