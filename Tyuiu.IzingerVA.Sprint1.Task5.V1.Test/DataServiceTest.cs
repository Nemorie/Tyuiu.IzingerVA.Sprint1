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
            double x = 3.0;
            double y = 4.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(5, res);
        }
    }
}
