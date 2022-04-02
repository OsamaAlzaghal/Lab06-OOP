using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Classes
{
    // Derived class.
    // Concrete class, public access modifier.
    public class Snake :Reptile
    {
        public Snake(string animalName, int age, string sex) : base(animalName, age, sex)
        { }
        public void Hiss()
        {
            Console.WriteLine("Hisssssss is the sound of a snake.");
        }
        // Abstract method overrive.
        public override void Shape()
        {
            Console.WriteLine("The most characteristic aspect of the snake form is the elongate body and tail and the absence of limbs.");
        }
        // Abstract method overrive.
        public override void Sound()
        {
            Console.WriteLine("Snake's sound: hiss.");
        }
        // Virtual method overrive.
        public override void Eat()
        {
            Console.WriteLine("Snake eats Fish, Bats, Lizards, Mice and rats.");
        }
        // Virtual method overrive.
        public override string Sleep()
        {
            string output = "Called virtual sleep Snake method!";
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
