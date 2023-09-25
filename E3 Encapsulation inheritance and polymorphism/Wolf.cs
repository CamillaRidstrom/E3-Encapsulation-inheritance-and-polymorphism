using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3_Encapsulation_inheritance_and_polymorphism
{
    // Subclass

    internal class Wolf : Animal
    {
        //Properties
        public bool LoneWolf { get; set; } = false;

        //Constructor
        public Wolf(string name, string color, int power, bool loneWolf)
        {
            base.Name = name;
            base.Color = color;
            base.Power = power;
            LoneWolf = loneWolf;
        }
        //Method/s
        public override void DoSound()
        {
            Console.WriteLine($"{Name} says ahooo!");
        }
    }
}
