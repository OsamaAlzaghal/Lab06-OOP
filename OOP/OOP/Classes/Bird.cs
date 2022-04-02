using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Classes
{
    // Parent and derived class.
    // Abstract class, public access modifier.
    public abstract class Bird : Animal
    {
        // Abstract property.
        public abstract bool nightVision
        {
            get;
        }
        // Virtual property overrive.
        public virtual int speed
        {
            set;get;
        }
        public Bird(string animalName, int age, string sex) :base(animalName, age, sex)
        { }
    }
}
