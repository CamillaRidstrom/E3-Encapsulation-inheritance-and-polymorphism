using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3_Encapsulation_inheritance_and_polymorphism
{
    // Subclass 
    public class TextInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a text input in a numeric only field. This fired an error! \n";
        }
        //public override string UEMessage()
        //{
        //    return "You tried to enter a first name that were tpp short. It must be at least 2 characters. This fired an error! \n";
        //}
    }
}
