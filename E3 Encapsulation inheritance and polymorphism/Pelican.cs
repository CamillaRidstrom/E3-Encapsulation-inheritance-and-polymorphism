using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3_Encapsulation_inheritance_and_polymorphism
{
    // Sub-subclass
    internal class Pelican : Bird
    {
        //Properties
        public int NumberOfFishInBeak { get; set; } = 0;

        //Constructor
        public Pelican(string name, string color, int power, int wingSpan, int numberOfFishInBeak /* , nyttAttribut*/)
           :base(name, color, power, wingSpan /* , nyttAttribut*/)
        {
                Name = name;
                Color = color;
                Power = power;

            WingSpan = wingSpan;
            //NyttAttribut = nyttAttribut;

            NumberOfFishInBeak = numberOfFishInBeak;
        }
        //Method/s
        public override void DoSound()
        {
            Console.WriteLine($"{Name} says tweeeeet!");
        }
    }
}
