using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3_Encapsulation_inheritance_and_polymorphism
{
    // Subclass
    internal class Bird : Animal
    {
        //Properties
        public int WingSpan { get; set; } = 0;
        //public string NyttAttribut { get; set; } = "";

        //Constructor
        public Bird(string name, string color, int power, int wingSpan /*, string nyttAttribut*/)
        {
            base.Name = name;
            base.Color = color;
            base.Power = power;

            WingSpan = wingSpan;
            //NyttAttribut = nyttAttribut;
        }
        //Method/s
        public override void DoSound()
        {
            Console.WriteLine($"{Name} says tweet!");
        }
    }
}
