using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Zachet;

namespace TestAir
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void HaveCorrectTemp1()
        {
            AirConditioner a = new AirConditioner(30,6);
            a.IncreaseTemp();
            Assert.AreEqual(30, a.Temperature);
        }

        [TestMethod]
        public void HaveCorrectTemp2()
        {
            AirConditioner a = new AirConditioner(10, 6);
            a.DecreaseTemp();
            Assert.AreEqual(10, a.Temperature);
        }

        [TestMethod]
        public void HaveCorrectTemp3()
        {
            AirConditioner a = new AirConditioner(15, 6);
            a.IncreaseTemp();
            Assert.AreEqual(16, a.Temperature);
        }

        [TestMethod]
        public void HaveCorrectTemp4()
        {
            AirConditioner a = new AirConditioner(15, 6);
            a.DecreaseTemp();
            Assert.AreEqual(14, a.Temperature);
        }
        [TestMethod]
        public void HaveCorrectSpeed1()
        {
            AirConditioner a = new AirConditioner(15, 10);
            a.IncreaseSpeed();
            Assert.AreEqual(1, a.Speed);
        }

        [TestMethod]
        public void HaveCorrectSpeed2()
        {
            AirConditioner a = new AirConditioner(15, 1);
            a.DecreaseSpeed();
            Assert.AreEqual(10, a.Speed);
        }

        [TestMethod]
        public void HaveCorrectSpeed3()
        {
            AirConditioner a = new AirConditioner(15, 5);
            a.IncreaseSpeed();
            Assert.AreEqual(6, a.Speed);
        }

        [TestMethod]
        public void HaveCorrectSpeed4()
        {
            AirConditioner a = new AirConditioner(15, 5);
            a.DecreaseSpeed();
            Assert.AreEqual(4, a.Speed);
        }
    }
}
