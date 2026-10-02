using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IzingerVA.Sprint1.Task2.V16.Lib;

namespace Tyuiu.IzingerVA.Sprint1.Task2.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double r = 2.0;
            var res = ds.Calculate(r);
            Assert.AreEqual(13, res);
        }
    }
}
