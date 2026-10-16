using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IzingerVA.Sprint1.Task7.V24.Lib;

namespace Tyuiu.IzingerVA.Sprint1.Task7.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 3;
            double y = 2;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(0.766, res);
        }
    }
}
