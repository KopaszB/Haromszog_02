using System;
using Haromszog;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HaromszogTest
{
    [TestClass]
    public class HaromszogTipusaTeszt
    {
        [TestMethod]
        public void Teszt_SzabalyoHaromszog()
        {
            //Arrange
            var ellenoriz = new HaromszogTipus();
            int a = 5, b = 5, c = 5;
            //Act
            string eredmeny = ellenoriz.HaromszogTipusEllenorzes(a, b, c);
            //Assert
            Assert.AreEqual("Szabályos háromszög", eredmeny);
        }
        [TestMethod]
        public void Teszt_EgyenloSzaruHaromszog()
        {
            //Arrange
            var ellenoriz = new HaromszogTipus();
            int a = 3, b = 5, c = 5;
            //Act
            string eredmeny = ellenoriz.HaromszogTipusEllenorzes(a, b, c);
            //Assert
            Assert.AreEqual("Egyenlő szárú háromszög", eredmeny);
        }
        [TestMethod]
        public void Teszt_AltalanosHaromszog()
        {
            //Arrange
            var ellenoriz = new HaromszogTipus();
            int a = 3, b = 4, c = 5;
            //Act
            string eredmeny = ellenoriz.HaromszogTipusEllenorzes(a, b, c);
            //Assert
            Assert.AreEqual("Általános háromszög", eredmeny);
        }
        [TestMethod]
        public void Teszt_NemHaromszogAtetelSzerint()
        {
            //Arrange
            var ellenoriz = new HaromszogTipus();
            int a = 1, b = 2, c = 3;
            //Act
            string eredmeny = ellenoriz.HaromszogTipusEllenorzes(a, b, c);
            //Assert
            Assert.AreEqual("Nem háromszög!", eredmeny);
        }
        [TestMethod]
        public void Teszt_NemHaromszogMertNulla()
        {
            //Arrange
            var ellenoriz = new HaromszogTipus();
            int a = 0, b = 2, c = 3;
            //Act
            string eredmeny = ellenoriz.HaromszogTipusEllenorzes(a, b, c);
            //Assert
            Assert.AreEqual("Nem háromszög!", eredmeny);
        }
        [TestMethod]
        public void Teszt_NemHaromszogMertNegativ()
        {
            //Arrange
            var ellenoriz = new HaromszogTipus();
            int a = -4, b = 5, c = 3;
            //Act
            string eredmeny = ellenoriz.HaromszogTipusEllenorzes(a, b, c);
            //Assert
            Assert.AreEqual("Nem háromszög!", eredmeny);
        }

    }
}
