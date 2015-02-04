using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Shapes
{
    public static class Validation
    {
        public static void CheckForArgumentOutOfRange(string argument, double argValue)
        {
            if (argValue <= 0)
            {
                throw new ArgumentOutOfRangeException(argument, "The argument cannot be negative number.");
            }
        }

        public static void CheckForArithmeticException(double firstSide, double secondSide, double thirdSide)
        {
            if (firstSide >= thirdSide + secondSide ||
                secondSide >= thirdSide + firstSide ||
                thirdSide >= firstSide + secondSide)
            {
                throw new ArithmeticException("Invalid triangle.");
            }
        }
    }
}
