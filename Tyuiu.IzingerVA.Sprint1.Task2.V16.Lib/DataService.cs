using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.IzingerVA.Sprint1.Task2.V16.Lib
{
    public class DataService : ISprint1Task2V16
    {
        public int Calculate(double value)
        {
            return Convert.ToInt32(2 * Math.PI * value);
        }
    }
}
