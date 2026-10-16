using System;
using Tyuiu.IzingerVA.Sprint1.Task5.V1.Lib;

namespace Tyuiu.IzingerVA.Sprint1.Task5.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Изингер В. А. | РППб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Преобразование типов и класс Convert                              *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил: Изингер Владислав Александрович | РППб-26-1                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Найти расстояние между двумя точками с заданными координатами           *");
            Console.WriteLine("* (x1, y1) и (x2, y2). Ответ привести к целому с помощью класса Convert.  *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double x1, y1, x2, y2;

            Console.WriteLine("Введите координату X1:");
            x1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите координату Y1:");
            y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите координату X2:");
            x2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите координату Y2:");
            y2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.DistanceBetweenDots(x1, y1, x2, y2);
            Console.WriteLine(res);

            Console.ReadLine();
        }
    }
}
