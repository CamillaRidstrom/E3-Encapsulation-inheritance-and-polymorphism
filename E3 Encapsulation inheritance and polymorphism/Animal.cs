using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3_Encapsulation_inheritance_and_polymorphism
{
    //Abstract base class
    internal abstract class Animal
    {
        //Properties 
        public string Name { get; set; } = "";
        public string Color { get; set; } = "";
        public int Power { get; set; } = 0;

        /*public string NyttDjurAttribut { get; set; } = "";*/

        //Constructor not needed or wanted because abstract (?)

        //Method/s
        public abstract void DoSound();

        //public abstract string Stats();
    }
}
