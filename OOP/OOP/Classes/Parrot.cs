using OOP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Classes
{
    // Derived class.
    // Concrete class, public access modifier.
    public class Parrot : Bird
    {
        public bool canTalk
        {
            set;get;
        }
        public int numberOfWords
        {
            set;get;
        }
        // Abstract property overrive.
        public override bool nightVision
        {
            get
            {
                return false;
            }
        }
        public Parrot(string animalName, int age, string sex) : base(animalName, age, sex)
        { }
        // Abstract method overrive.
        public override void Shape()
        {
            Console.WriteLine("Parrots have compact body with a large head and a short neck.");
        }
        // Abstract method overrive.
        public override void Sound()
        {
            Console.WriteLine("When parrots feel happy, they chirp, whistle, purr, and click their tongues.");
        }
        // Virtual method overrive.
        public override void Eat()
        {
            Console.WriteLine("Parrots like to eat fruit and fruit seeds, nuts, flowers, and corn where they can find it.");
        }
        // Virtual method overrive.
        public override string Sleep()
        {
            string output = "Called virtual sleep Parrot method!";
            Console.WriteLine(output);
            return output;
        }
        // Abstract method overrive.
        public override void FullInfo()
        {
            GetAnimalInfo();
            Shape();
            Sound();
            Eat();
            Sleep();
        }
    }
}
