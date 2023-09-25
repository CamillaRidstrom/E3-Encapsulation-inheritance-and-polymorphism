using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3_Encapsulation_inheritance_and_polymorphism
{
    // Sub-subclass
    internal class Swan : Bird
    {
        //Properties
        public bool HavePartner { get; set; } = false;

        //Constructor
        public Swan(string name, string color, int power, int wingSpan, bool havePartner)
           : base(name, color, power, wingSpan /* , nyttAttribut*/)
        {
            Name = name;
            Color = color;
            Power = power;

            WingSpan = wingSpan;
            //NyttAttribut = nyttAttribut;

            HavePartner = havePartner;
        }
        //Method/s
        public override void DoSound()
        {
            Console.WriteLine($"{Name} says tweetaah hizzz!");
        }
    }
}
