using System;

namespace _01_InterestCalculator
{
    class TestInterestCalculator
    {
        // Create a method GetSimpleInterest(sum, interest, years). 
        // The interest should be calculated by the formula A = sum * (1 + interest * years).
        public static decimal GetSimpleInterest(decimal sum, decimal interest, int years)
        {
            decimal simpleInterest = sum * (1 + (interest / 100) * years);
            return simpleInterest;
        }

        // Create a method GetCompoundInterest(sum, interest, years).  
        // The interest should be calculated by the formula A = sum * (1 + interest / n)year * n, 
        // where n is the number of times per year the interest is compounded. Assume n is always 12.
        public static decimal GetCompoundInterest(decimal sum, decimal interest, int years)
        {
            decimal compoundInterest = sum * (decimal)Math.Pow((double)(1 + (interest / 100) / 12), years * 12);
            return compoundInterest;
        }

        public static void Main()
        {
            InterestCalculator simpleInterestCalc = new InterestCalculator(2500m, 7.2m, 15, GetSimpleInterest);
            Console.WriteLine(simpleInterestCalc);

            InterestCalculator compoundInterestCalc = new InterestCalculator(-500m, 5.6m, 10, GetCompoundInterest);
            Console.WriteLine(compoundInterestCalc);

            /*CalculateInterest calcInterest = new CalculateInterest(GetSimpleInterest);
            // The result should be rounded to 4 places after the decimal point.
            Console.WriteLine("{0:F4}", calcInterest(2500m, 7.2m, 15));
            calcInterest = GetCompoundInterest;
            Console.WriteLine("{0:F4}", calcInterest(500m, 5.6m, 10));*/
        }
    }
}
