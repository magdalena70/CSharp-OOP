using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_HandlingExeptions
{
    class ParseInt32
    {
        static void Main()
        {
            Console.Write("Enter first number:  ");
            string number1 = Console.ReadLine();
            Console.Write("Enter second number:  ");
            string number2 = Console.ReadLine();
            try
            {
                int numberOne = Int32.Parse(number1);
                Console.WriteLine("\r\nYou entered first number\"{0}\".It is valid Int32 number", number1);
                int numberTwo = Int32.Parse(number2);
                Console.WriteLine("\r\nYou entered second number\"{0}\".It is valid Int32 number", number2);
                int result = numberOne / numberTwo;
                Console.WriteLine(result);
            }
            catch (FormatException FormatEx)
            {
                Console.Error.WriteLine("\r\nYou entered \"{0}\".{1}", 
                    number1, FormatEx.Message);
                Console.WriteLine(FormatEx.StackTrace);
            }
            catch (OverflowException OFEx){
                Console.Error.WriteLine("\r\nEntered number is \"{0}\".\r\n{1}", 
                    number1, OFEx.Message);
                Console.WriteLine(OFEx.StackTrace);
            }
            catch(ArithmeticException ArEx)
            {
                Console.Error.WriteLine("\r\n{0}\r\n{1}", 
                    ArEx.Message, ArEx.StackTrace);
            }
            finally
            {
                Console.WriteLine("\r\nPlease,enter some valid number.");
            }
        }
    }
}
