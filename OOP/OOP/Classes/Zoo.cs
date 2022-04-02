using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Classes
{
    /// <summary>
    /// Zoo class, public access modifier.
    /// </summary>
    public class Zoo
    {
        string zooName;
        string city;
        int capacity;
        Animal[] animals;
        int counter;

        public Zoo(string zooName, string city, int capacity)
        {
            animals = new Animal[capacity];
            this.zooName = zooName;
            this.city = city;
            this.capacity = capacity;
        }
        /// <summary>
        /// Polymorphism.
        /// </summary>
        /// <param name="animal"></param>
        public void AddAnimal(Animal animal)
        {
            if (counter < capacity)
            {
                animals[counter++] = animal;
            }
            else
            {
                Console.WriteLine("Zoo is full!");
            }
        }
        public void PrintAnimals()
        {
            GetZooInfo();
            for (int i = 0; i < counter; i++)
            {
                animals[i].FullInfo();
                Console.WriteLine("");
            }
        }
        public void GetZooInfo()
        {
            Console.WriteLine($"Zoo name: {zooName}, Location: {city} and capacity: {capacity}");
        }
    }
}
