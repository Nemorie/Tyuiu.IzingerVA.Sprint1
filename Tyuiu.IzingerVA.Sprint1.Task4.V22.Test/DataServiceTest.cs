using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IzingerVA.Sprint1.Task4.V22.Lib;

namespace Tyuiu.IzingerVA.Sprint1.Task4.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double y = 1.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(0.1, res);
        }
    }
}
