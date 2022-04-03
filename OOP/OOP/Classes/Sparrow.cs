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
    public class Sparrow :Bird, IColor, ISing
    {
        public string size
        {
            set;get;
        }
        public Sparrow(string animalName, int age, string sex) : base(animalName, age, sex)
        { }
        // Interface methods implementation.
        string IColor.Color()
        {
            return "A unique dark gray with earthy brown undertones.";
        }
        bool ISing.Sing()
        {
            return true;
        }
        int ISing.numberOfSongs
        {
            set; get;
        }
        int IColor.numberOfColors
        {
            set; get;
        }
        // Override abstract property.
        public override bool nightVision
        {
            get
            {
                return false;
            } 
        }
        // Override virtual property.
        public override int speed
        {
            set
            {
                if (speed > 0)
                {
                    Console.WriteLine("Added the speed.");
                }
                else
                {
                    Console.WriteLine("Speed can't be below zero!");
                }
            }
            get
            {
                return speed * speed;
            }
        }
        // Abstract method overrive.
        public override void Shape()
        {
            Console.WriteLine("Sparrow is a compact bird with a full chest and a large, rounded head.");
        }
        // Abstract method overrive.
        public override void Sound()
        {
            Console.WriteLine("House Sparrows have a rather simple song of one or a series of cheep or chirrup notes.");
        }
        // Virtual method overrive.
        public override void Eat()
        {
            Console.WriteLine("Sparrows primarily eat livestock feed, including cracked corn, cereal grains, oats, wheat, rice, and dried insects.");
        }
        // Virtual method overrive.
        public override string Sleep()
        {
            string output = "Called virtual sleep Sparrow method!";
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
