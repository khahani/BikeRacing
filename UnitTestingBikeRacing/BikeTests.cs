using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BikeRacingConsole;
using System.Diagnostics;

namespace UnitTestingBikeRacing
{
    [TestClass]
    public class BikeTests
    {
        private Bike Bike = new Bike
        {
            Name = "Gitane",
            Brake = new Brake { Model = "2017", Power = 3 },
            Gear = new Gear { Model = "2016", Size = 8 }
        };

        [TestMethod]
        public void TestBikePedal()
        {
            Bike bike = Bike;

            bike.Pedal(10);

            Debug.Write(bike.Speed);

            Assert.AreEqual(80, bike.Speed);
        }

        [TestMethod]
        public void TestBikeBraking()
        {
            Bike bike = Bike;

            bike.Pedal(10);

            bike.Braking(5);

            Debug.Write(bike.Speed);

            Assert.AreEqual(65, bike.Speed);
        }

        [TestMethod]
        public void TestBikeBrakingNotGetLessThanZero()
        {
            Bike bike = Bike;
            bike.Pedal(10);

            bike.Braking(100);

            Assert.AreEqual(0, bike.Speed);

            Debug.Write(bike.Speed);
        }
    }
}
