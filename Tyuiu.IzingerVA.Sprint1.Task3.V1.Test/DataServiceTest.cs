using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IzingerVA.Sprint1.Task3.V1.Lib;

namespace Tyuiu.IzingerVA.Sprint1.Task3.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double r = 2.0;
            double h = 3.0;
            var res = ds.Calculate(r, h);
            Assert.AreEqual(37.699, res);
        }
    }
}
