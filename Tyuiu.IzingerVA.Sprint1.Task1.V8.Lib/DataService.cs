using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.IzingerVA.Sprint1.Task1.V8.Lib
{
    public class DataService : ISprint1Task1V8
    {
        public double Calculate(double x, double a)
        {
            return (x * Math.PI) / a;
        }
    }
}
