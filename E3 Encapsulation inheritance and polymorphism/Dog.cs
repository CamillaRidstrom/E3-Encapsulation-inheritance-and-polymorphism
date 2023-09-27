using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3_Encapsulation_inheritance_and_polymorphism
{
    // Subclass 
    internal class Dog : Animal
    {
        //Properties
        public int NumberOfAverageBarks{ get; set; } = 0;

        //Constructor
        public Dog(string name, string color, int power, int numberOfAverageBarks)
        {
            base.Name = name;
            base.Color = color;
            base.Power = power;
            NumberOfAverageBarks = numberOfAverageBarks;
        }
        //Method/s
        public override void DoSound()
        {
            Console.WriteLine($"{Name} says woof!\n");
        }
        public override string Stats()
        {
            return $"Name: {Name}, Color:{Color} Power: {Power}, NumberOfAverageBarks: {NumberOfAverageBarks}";
        }
        public string ToiletBreak()
        {
            return $"{Name} shows you that it's time for a walk!\n";
        }
    }
}
