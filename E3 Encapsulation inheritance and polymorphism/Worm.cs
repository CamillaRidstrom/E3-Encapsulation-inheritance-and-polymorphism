using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3_Encapsulation_inheritance_and_polymorphism
{   
    //Subklass
    internal class Worm : Animal
    {
        //Properties
        public bool IsPoisonous { get; set; } = false;

        //Constructor
        public Worm(string name, string color, int power, bool isPoisonous)
        {
            base.Name = name;
            base.Color = color;
            base.Power = power;
            IsPoisonous = isPoisonous;
        }
        //Method/s
        public override void DoSound()
        {
            Console.WriteLine($"{Name} says chirp!");
        }
    }
}
