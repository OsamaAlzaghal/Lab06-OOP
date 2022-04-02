using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Classes
{
    // Parent and derived class.
    // Abstract class, public access modifier.
    abstract public class Reptile : Animal
    {
        public int numberOfLegs
        {
            set;get;
        }
        public Reptile(string animalName, int age, string sex) : base(animalName, age, sex)
        { }
    }
}
