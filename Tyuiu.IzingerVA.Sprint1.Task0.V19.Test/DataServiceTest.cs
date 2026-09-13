using System;
using Tyuiu.IzingerVA.Sprint1.Task0.V19.Lib;

namespace Tyuiu.IzingerVA.Sprint1.Task0.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculate_ReturnsCorrectResult()
        {
            DataService dataService = new DataService();
            double expected = 10.0;

            double actual = dataService.Calculate();

            Assert.AreEqual(expected, actual);
        }
    }
}