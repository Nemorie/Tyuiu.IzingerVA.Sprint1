using System;
using Tyuiu.IzingerVA.Sprint1.Task0.V19.Lib;

namespace Tyuiu.IzingerVA.Sprint1.Task0.V19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил Изингер В. А. | РППб-26-1";
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* Спринт #1                                                            *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                     *");
            Console.WriteLine("* Задание #0                                                           *");
            Console.WriteLine("* Вариант #19                                                          *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                             *");
            Console.WriteLine("* Написать программу, которая вычисляет выражение                      *");
            Console.WriteLine("* 4/2*5/(3+2)*5 и печатает результат на экране.                        *");
            Console.WriteLine("*                                                                      *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
            Console.WriteLine("************************************************************************");

            Console.WriteLine("Выражение: 4/2*5/(3+2)*5");

            Console.WriteLine();
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
            Console.WriteLine("************************************************************************");

            DataService dataService = new DataService();
            double result = dataService.Calculate();

            Console.WriteLine("Ответ равен: " + result);

            Console.ReadKey();
        }
    }
}
