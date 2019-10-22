using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class Diplodocus : PlantEater, IHibernate
    {
        public Diplodocus(string name, bool scary, bool likesLeafs)
        {
            Name = name;
            Scary = scary;
            LikesLeafs = likesLeafs;

        }
        public override string Name { get; set; }
        public override bool Scary { get; set; } = false;
        public bool LikesLeafs { get; private set; }
        public override bool LikeLeafs { get; set; } = true;

        public bool Hibernate()
        {
            bool leafs = false;
            if (LikeLeafs == true)
            {
                leafs = true;
                Console.WriteLine(" Time to go to sleep for a long............time....");
                return leafs;
            }
            else
                return
                    leafs;
        }
    }
}