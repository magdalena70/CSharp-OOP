using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Animals
{
    public static class Validation
    {
        public static void CheckForNullOrEmpty(string value, string argumentName)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("The string cannot be empty or null.", argumentName);
            }
        }

        public static void CheckForNegativeOrZero(object number, string argumentName)
        {
            if (double.Parse(number.ToString()) <= 0)
            {
                throw new ArgumentException("The number cannot be negative or zero.", argumentName);
            }
        }


    }
}
