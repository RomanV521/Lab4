using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Utils
    {
        /// <summary>
        /// Значение которое присваевается в случаи ввода неправильного числа
        /// </summary>
        public int incorrectValue = -1;

        /// <summary>
        /// Функция которая проверяет корректность ввода string формата
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public string CheckForNonEmptyValue(string value)
        {
            if (value is not null && value.Length > 0)
            {
                return value;
            }
            else
            {
                return "(Error, you did not enter a value)";
            }
        }
    }
}
