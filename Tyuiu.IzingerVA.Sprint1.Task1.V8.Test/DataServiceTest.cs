using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IzingerVA.Sprint1.Task1.V8.Lib;

namespace Tyuiu.IzingerVA.Sprint1.Task1.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2.0;
            double a = 2.0;
            var res = ds.Calculate(x, a);
            Assert.AreEqual(3.14, res);
        }
    }
}
