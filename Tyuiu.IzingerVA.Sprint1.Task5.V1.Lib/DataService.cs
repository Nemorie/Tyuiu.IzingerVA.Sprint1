using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.IzingerVA.Sprint1.Task5.V1.Lib
{
    public class DataService : ISprint1Task5V1
    {
        public double Calculate(double x, double y)
        {
            double d = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            return Convert.ToInt32(d);
        }
    }
}
