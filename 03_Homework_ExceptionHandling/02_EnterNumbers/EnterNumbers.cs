using System;

namespace _02_EnterNumbers
{
    class EnterNumbers
    {
        //Write a method ReadNumber(int start, int end) that enters an integer number in given range [start…end]. 
        //If an invalid number or non-number text is entered, the method should throw an exception.
       public static int ReadNumber(int start, int end)
        {
            
            string inputNum = Console.ReadLine();
            int number = 0;
            try
            {
                number = int.Parse(inputNum);
            }
            catch(FormatException FormEx){
                Console.WriteLine(FormEx.Message);
            }
            catch (OverflowException OverEx)
            {
                Console.WriteLine(OverEx.Message);
            }
           
            return number;
        }

        public static void Main()
        {
            //Using method ReadNumber(int start, int end) write a program that enters 10 numbers: 
            //a1, a2, … a10, such that 1 < a1 < … < a10 < 100. 
            //If the user enters an invalid number, let the user to enter again.
            int start = 1;
            int end = 100;
            Console.WriteLine("Enter 10 numbers:  a1, a2,... a10, such that {0} < a1 < ... < a10 < {1}.", start, end);
            int[] tenNumbers = new int[10];
            
            for (int i = 0; i < tenNumbers.Length; i++)
            {
                tenNumbers[i] = ReadNumber(start, end);
                if (tenNumbers[i] <= start || tenNumbers[i] >= end)
                {
                    Console.WriteLine("Enter number in range[number > {0} and number < {1}].", start, end);
                    i--;
                    continue;
                }
                if (tenNumbers[i] == end-1 && i < tenNumbers.Length)
                {
                    Console.WriteLine("No more valid numbers");
                    break;
                }

                start = tenNumbers[i];
            }
            foreach (int num in tenNumbers)
            {
                Console.Write(num + " ");
            }
        }
    }
}
