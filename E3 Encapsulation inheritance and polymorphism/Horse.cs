using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3_Encapsulation_inheritance_and_polymorphism
{
    // Subclass 
    internal class Horse : Animal
    {
        //Properties
        public int HorsePower { get; set; } = 0;

        //Constructor
        public Horse(string name, string color, int power, int horsepower)
        {
            base.Name = name;
            base.Color = color;
            base.Power = power;
            HorsePower = horsepower;
        }
        //Method/s
        public override void DoSound()
        {
            Console.WriteLine($"{Name} says neigh!");
        }
        public override string Stats()
        {
            return $"Name: {Name}, Color:{Color} Power: {Power}, HorsePower: {HorsePower}";
        }
    }
}
