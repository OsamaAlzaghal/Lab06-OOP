using System;
using Xunit;
using OOP.Classes;

namespace TestAnimals
{
    public class TestAnimals
    {
        [Fact]
        public void TestLion()
        {
            Lion lion = new Lion("Leo", 7, "Male", true);
            Assert.True(lion.specializedTeeth);
            Assert.Equal("Called virtual sleep Lion method!", lion.Sleep());
        }
        [Fact]
        public void TestBat()
        {
            Bat bat = new Bat("Hector", 7, "Male", true);
            Assert.False(bat.specializedTeeth);
            Assert.Equal("Called virtual sleep Bat method!", bat.Sleep());
        }
        [Fact]
        public void TestSnake()
        {
            Snake sara = new Snake("sara", 7, "Female");
            Assert.Equal("Called virtual sleep Snake method!", sara.Sleep());
            Assert.Equal(0, sara.numberOfLegs);
        }
        [Fact]
        public void TestSparrow()
        {
            Sparrow sparrow = new Sparrow("Ali", 7, "Male");
            Assert.Equal("Called virtual sleep Sparrow method!", sparrow.Sleep());
            Assert.False(sparrow.nightVision);
        }
        [Fact]
        public void TestParrot()
        {
            Parrot parrot = new Parrot("Jim", 7, "Male");
            Assert.Equal("Called virtual sleep Parrot method!", parrot.Sleep());
            Assert.False(parrot.nightVision);
        }
    }
}