using System;
using Xunit;
using OOP.Classes;
using OOP.Interfaces;

namespace TestAnimals
{
    public class TestAnimals
    {
        [Fact]
        public void TestLion()
        {
            // Test inheritance.
            Lion lion = new Lion("Leo", 7, "Male", true);
            Assert.True(lion.specializedTeeth);
            Assert.Equal("Called virtual sleep Lion method!", lion.Sleep());
        }
        [Fact]
        public void TestBat()
        {
            // Test inheritance.
            Bat bat = new Bat("Hector", 7, "Male", true);
            Assert.False(bat.specializedTeeth);
            Assert.Equal("Called virtual sleep Bat method!", bat.Sleep());
        }
        [Fact]
        public void TestSnake()
        {
            // Test inheritance.
            Snake sara = new Snake("sara", 7, "Female");
            Assert.Equal("Called virtual sleep Snake method!", sara.Sleep());
            Assert.Equal(0, sara.numberOfLegs);
        }
        [Fact]
        public void TestSparrow()
        {
            // Test inheritance.
            Sparrow sparrow = new Sparrow("Ali", 7, "Male");
            Assert.Equal("Called virtual sleep Sparrow method!", sparrow.Sleep());
            Assert.False(sparrow.nightVision);
        }
        [Fact]
        public void TestParrot()
        {
            // Test inheritance.
            Parrot parrot = new Parrot("Jim", 7, "Male");
            Assert.Equal("Called virtual sleep Parrot method!", parrot.Sleep());
            Assert.False(parrot.nightVision);
        }
        // Test ISing method.
        [Fact]
        public void TestSing()
        {
            Sparrow sparrow = new Sparrow("Ali", 7, "Male");
            Bat bat = new Bat("Jim", 7, "Male", false);
            // Casting to access interface methods.
            // Proof that methods have been overridden.
            // Test that the classes that implement the interface actually implement it.
            ISing sing = (ISing)sparrow;
            Assert.True(sing.Sing());
            sing = (ISing)bat;
            Assert.False(sing.Sing());
        }
        // Test IColor method.
        [Fact]
        public void TestColor()
        {
            Bat bat = new Bat("Jim", 7, "Male", false);
            Sparrow sparrow = new Sparrow("Ali", 7, "Male");
            // Casting to access interface methods.
            IColor color = (IColor)bat;
            // Proof that methods have been overridden.
            // Test that the classes that implement the interface actually implement it.
            Assert.Equal("Bats are typically brown or black in color, but may have grey, red, white or orange fur.", color.Color());
            color = (IColor)sparrow;
            Assert.Equal("A unique dark gray with earthy brown undertones.", color.Color());
        }
        [Fact]
        public void TestPolymorphism()
        {
            // This will call lion's sleep method at run time and not the Animal's one,
            // so it's a proof that lion is an Animal.
            Animal lion = new Lion("Leo", 7, "Male", true);
            Assert.Equal("Called virtual sleep Lion method!", lion.Sleep());
        }

        [Fact]
        public void IsAnimalTest()
        {
            Animal lion = new Lion("Leo", 7, "Male", true);
            Assert.True(typeof(Lion).IsSubclassOf(typeof(Animal)));
        }
    }
}