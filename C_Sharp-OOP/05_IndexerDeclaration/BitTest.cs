using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_IndexerDeclaration
{
    class BitTest
    {
        public static void Main()
        {
            int num = 7;
            BitArray32 number = new BitArray32(num);
            Console.Write("Input number: " + number);
            Console.WriteLine("; bit at index 0: " + number[0] + ";"); //use index[0] -> bit = 1;
            BitArray32 savedNumber = new BitArray32(num);
            if (number[0] == 1)
            {
                number[0] = 0; //change bit
            }
            else if(number[0] == 0)
            {
                number[0] = 1; //change bit
            }
            Console.WriteLine("if bit = 1,make it equal 0,if bit = 0,make it 1;\r\nThe new number is: " + number); //print new number

            BitArray32 sum = number + savedNumber;
            Console.WriteLine(number + " + " + savedNumber + " = " + sum);
            sum += sum;
            Console.WriteLine("Sum += sum = {0}", sum);

        }
    }
}
