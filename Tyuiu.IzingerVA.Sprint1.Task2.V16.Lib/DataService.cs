using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.IzingerVA.Sprint1.Task2.V16.Lib
{
    public class DataService : ISprint1Task2V16
    {
        public double Calculate(double value)
        {
            return Math.Round(2 * Math.PI * value, 3);
        }

        int ISprint1Task2V16.Calculate(double value)
        {
            return (int)Calculate(value);
        }
    }
}
