using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.IzingerVA.Sprint1.Task6.V11.Lib
{
    public class DataService : ISprint1Task6V11
    {
        public bool CheckeFirstLetterRepetition(string value)
        {
            if (string.IsNullOrEmpty(value) || value.Length < 2)
            {
                return false;
            }

            char firstChar = value[0];
            return value.IndexOf(firstChar, 1) != -1;
        }
    }
}
