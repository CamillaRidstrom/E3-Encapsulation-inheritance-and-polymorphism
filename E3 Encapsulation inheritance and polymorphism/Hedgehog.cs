using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace E3_Encapsulation_inheritance_and_polymorphism
{
    // Subclass
    internal class Hedgehog : Animal
    {
        //Properties
        public int NrOfSpikes { get; set; } = 0;

        //Constructor
        public Hedgehog(string name, string color, int power, int nrOfSpikes)
        {
            base.Name = name;
            base.Color = color;
            base.Power = power;
            NrOfSpikes = nrOfSpikes;
        }
        //Method/s
        public override void DoSound()
        {
            Console.WriteLine($"{Name} says squeal!");
        }
    }
}
