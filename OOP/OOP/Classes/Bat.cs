using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Classes
{
    // Derived class.
    // Concrete class, public access modifier.
    public class Bat : Mammal
    {
        public int flightHeight
        {
            set;get;
        }
        public Bat(string animalName, int age, string sex, bool specializedTeeth) : base(animalName, age, sex, specializedTeeth)
        { }
        // Abstract property overrive.
        public override bool hasHair
        {
            get
            {
                return false;
            }
        }
        // Abstract method overrive.
        public override void Shape()
        {
            Console.WriteLine("A cricket bat is shaped like a paddle consisting of a long handle, which is cylindrical in shape.");
        }
        // Abstract method overrive.
        public override void Sound()
        {
            Console.WriteLine("Bats make chirping noises, especially at night.");
        }
        // Virtual method overrive.
        public override void Eat()
        {
            Console.WriteLine("Most bats eat insects and are called insectivores. These bats like to eat beetles, moths, mosquitoes, and more.");
        }
        // Virtual method overrive.
        public override string Sleep()
        {
            string output = "Called virtual sleep Bat method!";
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
