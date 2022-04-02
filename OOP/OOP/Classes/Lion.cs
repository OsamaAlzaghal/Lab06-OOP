using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Classes
{
    // Derived class.
    // Concrete class, public access modifier.
    public class Lion : Mammal
    {
        public string breed
        {
            set;get;
        }
        public bool isPlayful
        {
            set;get;
        }
        public Lion(string animalName, int age, string sex, bool specializedTeeth) : base(animalName, age, sex, specializedTeeth)
        { }
        // Virtual property overrive.
        public override bool specializedTeeth
        {
            get
            {
                return true;
            }
            set
            {
                if (specializedTeeth == true)
                {
                    Console.WriteLine("It has specialized teeth");
                }
                else
                {
                    Console.WriteLine("It does not have specialized teeth");
                }
            }
        }
        // Abstract property overrive.
        public override bool hasHair
        {
            get
            {
                return true;
            }
        }
        public void Roar()
        {
            Console.WriteLine("Roar is the sound of a Lion!");
        }
        // Abstract method overrive.
        public override void Shape()
        {
            Console.WriteLine("Lions have strong, compact bodies and powerful forelegs, teeth and jaws for pulling down and killing prey.");
        }
        // Abstract method overrive.
        public override void Sound()
        {
            Console.WriteLine("Lion's sound: roar, growl, snarl.");
        }
        // Virtual method overrive.
        public override void Eat()
        {
            Console.WriteLine("Lion eats meat.");
        }
        // Virtual method overrive.
        public override string Sleep()
        {
            string output = "Called virtual sleep Lion method!";
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
