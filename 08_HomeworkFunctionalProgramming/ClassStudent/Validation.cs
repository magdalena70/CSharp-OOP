using System;

namespace ClassStudent
{
    public class Validation
    {
        public static void CheckForNegativeOrZero(decimal value, string argumentName)
        {
            if (value <= 0)
            {
                throw new ArgumentException("The argument cannot be negative or zero.", argumentName);
            }
        }

        public static void CheckForNullOrEmptyString(string value, string argumentName)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("The argument cannot be empty string or null.", argumentName);
            }
        }

        public static void CheckObjectForNull(object value, string argumentName)
        {
            if (value == null)
            {
                throw new ArgumentException("The argument cannot be null.", argumentName);
            }
        }

        public static void CheckEmail(string email, string argumentName)
        {
            if (!email.Contains("@"))
            {
                throw new ArgumentException("Invalid email.", argumentName);
            }
        }
    }
}
