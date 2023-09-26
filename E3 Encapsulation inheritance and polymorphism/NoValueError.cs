using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3_Encapsulation_inheritance_and_polymorphism
{
    // Subclass 
    public class NoValueError : UserError
    {
        public override string UEMessage()
        {
            return "You did not submit any input, a value is needed. This fired an error! \n";
        }
    }
}
