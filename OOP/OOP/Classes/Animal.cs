using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Classes
{
    // Parent class.
    // Abstract class, public access modifier.
    public abstract class Animal
    {
        string animalName;
        int age;
        string sex;
        public Animal(string animalName, int age, string sex)
        {
            this.animalName = animalName;
            this.age = age;
            this.sex = sex;
        }
        public void GetAnimalInfo()
        {
            Console.WriteLine($"Animal name: {animalName}, Age: {age}, Sex: {sex}.");
        }
        // All methods were overriden in the concrete classes.
        // Abstract method.
        public abstract void FullInfo();
        // Abstract method.
        public abstract void Shape();
        // Abstract method.
        public abstract void Sound();
        // Virtual method.
        public virtual void Eat() { }
        // Virtual method.
        public virtual string Sleep() { return ""; }
    }
}
