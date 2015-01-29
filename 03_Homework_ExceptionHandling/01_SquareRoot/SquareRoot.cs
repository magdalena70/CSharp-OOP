using System;

namespace _01_SquareRoot
{
    public class SquareRoot
    {
        public static void Main()
        {
            Console.WriteLine("Enter an integer number");
            string input = Console.ReadLine();

            try
            {
                int number = Int32.Parse(input);
                if (number < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                double sqrtNum = Math.Sqrt(number);
                Console.WriteLine("Square Root({0}) = {1:f3}.", number, sqrtNum);
            }
            catch (FormatException FormEx)
            {
                Console.WriteLine("Invalid number.{0}\r\nPlease,enter valid integer number.\r\n", FormEx.Message);
            }
            catch (ArgumentOutOfRangeException ArgOutEx)
            {
                Console.WriteLine("Invalid number.{0}\r\nPlease,enter valid integer number.\r\n", ArgOutEx.Message);
            }
            catch (OverflowException OverFEx)
            {
                Console.WriteLine("Invalid number.{0}\r\nPlease,enter valid integer number.", OverFEx.Message);
            }
            finally
            {
                Console.WriteLine("Good bye!");
            }
        }
    }
}
