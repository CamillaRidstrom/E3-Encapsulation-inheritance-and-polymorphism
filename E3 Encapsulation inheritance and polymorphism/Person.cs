using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace E3_Encapsulation_inheritance_and_polymorphism
{
    internal class Person
    {
        //Fields

        private int age;
        private string fName;
        private string lName;
        private double height;
        private double weight;

        //Properties
        public int Age
        {
            get
            {
                //Validation
                if (age > 0)
                {
                    return age;

                }
                else
                {
                    return 0; //Eftersom jag måste returnera ett värde, vad väljer man då?
                    throw new ArgumentException("Error:The Age property cannot be zero or lower");
                }
            }
            set
            {
                age = value;
            }

        }
        public string FName
        {
            get
            {
                //Validation
                int count = fName.Length;
                if (count >= 2 & count <= 10)
                {
                    return fName;
                }
                else
                {
                    return " "; 
                    throw new ArgumentException("Error:The FName must be beteween 2 and 10 characters.");
                }
            }
            set
            {
                fName = value;
            }
        }
        public string LName
        { 
            get
            {
                //Validation
                int count = LName.Length;
                if (count >= 3 & count <= 15)
                {
                    return lName;
                }
                else
                {
                    return " "; 
                    throw new ArgumentException("Error:The LName must be beteween 3 and 15 characters.");
                }
            }
            set
            {
                fName = value;
            }
        }
        public double Height { get; set; }
        public double Weight { get; set; }

        public Person()
        {
                
        }
        public Person(string fName, string lName, int age, double height, double weight)
        {
            FName = fName;
            LName = lName;
            Age = age;
            Height = height;
            Weight = weight;
                
        }
        //Methos/s 
        //N/A
    }
}
