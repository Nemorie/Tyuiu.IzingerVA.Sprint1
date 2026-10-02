using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.IzingerVA.Sprint1.Task3.V1.Lib
{
    public class DataService : ISprint1Task3V1
    {
        public void Calculate()
        {
        }

        public double Calculate(double r, double h)
        {
            return Math.Round(Math.PI * r * r * h, 3);
        }
    }
}
