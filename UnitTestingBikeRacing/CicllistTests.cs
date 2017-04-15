using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BikeRacingConsole;
using System.Diagnostics;

namespace UnitTestingBikeRacing
{
    [TestClass]
    public class CicllistTests
    {

        private Ciclist GetInstance()
        {
            Bike bike = new Bike
            {
                Name = "Gitane",
                Brake = new Brake { Model = "2017", Power = 3 },
                Gear = new Gear { Model = "2016", Size = 8 }
            };

            Ciclist ciclist = new Ciclist(bike);
            ciclist.Name = "Mohammadreza";
            ciclist.PushPower = 6;
            ciclist.RoundPerMinutes = 9;

            return ciclist;
        }
        
        [TestMethod]
        public void TestCiclistPedal()
        {
            Ciclist ciclist = GetInstance();

            ciclist.Pedal();

            Assert.AreEqual(72, ciclist.Speed);
        }

        [TestMethod]
        public void TestCiclistBraking()
        {
            Ciclist ciclist = GetInstance();
            ciclist.Pedal();
            ciclist.Breaking();

            Assert.AreEqual(54, ciclist.Speed);
        }

    }
}
