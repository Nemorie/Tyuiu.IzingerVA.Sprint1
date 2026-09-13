using System;
using Tyuiu.IzingerVA.Sprint1.Task0.V19.Lib;

namespace Tyuiu.IzingerVA.Sprint1.Task0.V19
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService dataService = new DataService();
            double result = dataService.Calculate();

            Console.WriteLine("4/2*5/(3+2)*5");
            Console.WriteLine(" = " + result);

            Console.ReadKey();
        }
    }
}