using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IzingerVA.Sprint1.Task5.V1.Lib;

namespace Tyuiu.IzingerVA.Sprint1.Task5.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x1 = 0;
            double y1 = 0;
            double x2 = 3;
            double y2 = 4;
            var res = ds.DistanceBetweenDots(x1, y1, x2, y2);
            Assert.AreEqual(5, res);
        }
    }
}
