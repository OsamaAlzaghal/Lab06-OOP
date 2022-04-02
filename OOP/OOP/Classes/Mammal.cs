using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Classes
{
    // Parent and derived class.
    // Abstract class, public access modifier.
    public abstract class Mammal : Animal
    {
        // abstract property.
        public abstract bool hasHair
        {
            get;
        }
        // virtual property.
        public virtual bool specializedTeeth
        {
            set; get;
        }

        public Mammal(string animalName, int age, string sex, bool specializedTeeth) : base(animalName, age, sex)
        { }
    }
}
