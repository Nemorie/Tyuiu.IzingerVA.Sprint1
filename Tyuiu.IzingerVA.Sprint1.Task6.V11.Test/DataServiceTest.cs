using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IzingerVA.Sprint1.Task6.V11.Lib;

namespace Tyuiu.IzingerVA.Sprint1.Task6.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string str = "тест";
            var res = ds.CheckeFirstLetterRepetition(str);
            Assert.IsTrue(res);
        }
    }
}
