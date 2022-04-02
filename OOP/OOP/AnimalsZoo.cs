using OOP.Classes;
using System;

namespace OOP
{
    class AnimalsZoo
    {
        static void Main(string[] args)
        {
            // Created Zoo that has animals.
            Zoo firstZoo = new Zoo("Irbid's zoo", "Irbid", 5);

            // Created different animals.
            Lion lion = new Lion("Leo", 7, "Male", true);
            Snake snake = new Snake("Sara", 1, "Female");
            Sparrow sparrow = new Sparrow("Hector", 2, "Male");
            Bat bat = new Bat("Alucard", 3, "Male", false);
            Parrot parrot = new Parrot("Jim", 5, "Male");

            // Added them inside the Zoo.
            firstZoo.AddAnimal(lion);
            firstZoo.AddAnimal(snake);
            firstZoo.AddAnimal(sparrow);
            firstZoo.AddAnimal(bat);
            firstZoo.AddAnimal(parrot);

            // Print list of Animals inside our Zoo.
            firstZoo.PrintAnimals();
        }
    }
}