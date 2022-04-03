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
    // Interfaces IColor and ISing.
    public class Bat : Mammal, IColor,ISing
    {
        public int flightHeight
        {
            set;get;
        }
        public Bat(string animalName, int age, string sex, bool specializedTeeth) : base(animalName, age, sex, specializedTeeth)
        { }
        // Interface method implementaion.
        string IColor.Color()
        {
            return "Bats are typically brown or black in color, but may have grey, red, white or orange fur.";
        }
        bool ISing.Sing()
        {
            return false;
        }
        int ISing.numberOfSongs
        {
            set; get;
        }
        // Abstract property overrive.
        public override bool hasHair
        {
            get
            {
                return false;
            }
        }
        public int numberOfColors
        {
            set
            {
                numberOfColors =10;
            }
            get
            {
                return numberOfColors;
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
