using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3_Encapsulation_inheritance_and_polymorphism
{
    // Sub-subclass using Interface
    internal class Wolfman : Wolf, IPerson
    {

        //Constructor
        public Wolfman(string name, string color, int power, bool loneWolf)
           : base(name, color, power, loneWolf)
        {
            Name = name;
            Color = color;
            Power = power;
            LoneWolf = loneWolf;
        }
        //Method/s
        public override void DoSound()
        {
            Console.WriteLine($"{Name} says Hellahooooo! \n");
        }
        void IPerson.Talk()
        {
            Console.WriteLine($"{Name} says Hellahooooo ahooooo! \n");
        }
        public override string Stats()
        {
            return $"Name: {Name}, Color:{Color} Power: {Power}, LoneWolf: {LoneWolf}";
        }
    }
}
