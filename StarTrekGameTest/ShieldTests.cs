using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarTrekGame;

namespace StarTrekGameTest
{
    [TestClass]
    public class ShieldTests
    {

        private Shield shield;

        [TestInitialize()]
        public void Startup()
        {
            shield = new Shield();
        }

        [TestMethod]
        public void ShieldDownByDefualt()
        {
            //Given

            //When

            //Then
            Assert.IsFalse(shield.IsUp());
        }

        [TestMethod]
        public void ShieldIsUp()
        {
            //Given

            //When
            shield.Raise();
            //Then
            Assert.IsTrue(shield.GetIsUp());
        }
        
        [TestMethod]
        public void ShieldDefaultStrength()
        {
            Assert.AreEqual(8000, shield.GetCurrentEnergyLevel());
        }

        [TestMethod]
        public void ShieldTransferToShield()
        {
            shield.AddEnergy(2000);
            Assert.AreEqual(10000, shield.GetCurrentEnergyLevel());
        }

        [TestMethod]
        public void ShieldTransferDoesNotExceedMaximum()
        {
            shield.AddEnergy(2001);
            Assert.AreEqual(Shield.SHIELD_MAX, shield.GetCurrentEnergyLevel());
        }


        [TestMethod]
        public void ShieldMaximum()
        {
            Assert.AreEqual(10000, Shield.SHIELD_MAX);
        }


    }
}
