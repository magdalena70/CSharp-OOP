using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_StaticClass
{
    public static class SqrtPrecalculated
    {
        //static fields(const is static default)
        public const int MAX_VALUE = 10000;
        private static int[] sqrtValues;

        //static constructor
        static SqrtPrecalculated()
        {
            sqrtValues = new int[MAX_VALUE + 1];
            for (int i = 0; i < sqrtValues.Length; i++)
            {
                sqrtValues[i] = (int)Math.Sqrt(i);
            }
        }

        //static methods
        public static int ReturnSqrtValue(int value)
        {
            return sqrtValues[value];
        }

        static void Main() // is always static
        {
            Console.WriteLine("Sqrt = " + SqrtPrecalculated.ReturnSqrtValue(316));

            string email = "absdfg@abv.bg";
            bool isValid = EmailValidator.ValidateEmail(email);
            Console.WriteLine("Is valid email: " + isValid);
        }
    }
}
