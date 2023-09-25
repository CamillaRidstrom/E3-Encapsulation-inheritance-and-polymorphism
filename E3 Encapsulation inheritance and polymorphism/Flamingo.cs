using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3_Encapsulation_inheritance_and_polymorphism
{
    // Sub-subclass
    internal class Flamingo : Bird
    {
        //Properties
        public int NumberOfMinOnOneLeg { get; set; } = 0;

        //Constructor
        public Flamingo(string name, string color, int power, int wingSpan, int numberOfMinOnOneLeg)
           : base(name, color, power, wingSpan /* , nyttAttribut*/)
        {
            Name = name;
            Color = color;
            Power = power;

            WingSpan = wingSpan;
            //NyttAttribut = nyttAttribut;

            NumberOfMinOnOneLeg = numberOfMinOnOneLeg;
        }
        //Method/s
        public override void DoSound()
        {
            Console.WriteLine($"{Name} says tweet tweet!");
        }
    }
}
