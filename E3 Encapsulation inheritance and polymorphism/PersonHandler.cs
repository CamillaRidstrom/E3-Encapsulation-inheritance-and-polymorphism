using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3_Encapsulation_inheritance_and_polymorphism
{
    internal class PersonHandler
    {
        //Fields or properties

        //Constructor
        public PersonHandler()
        {

        }
        //Method/s
    
        public Person CreatePerson(int age, string fname, string lname, double height, double weight) 
        {  
             return new Person(fname, lname, age, height, weight);
        }
        public void SetAge(Person pers, int age)
        {
            pers.Age = age;
        }

    }
}
