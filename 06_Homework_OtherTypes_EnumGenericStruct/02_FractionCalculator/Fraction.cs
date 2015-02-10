using System;

namespace _02_FractionCalculator
{
    // Create a struct Fraction that holds the numerator and denominator of a fraction as fields.
    public struct Fraction
    {
        //  fields are integer numbers in the range [-9223372036854775808…9223372036854775807]. 
        private long numerator;
        private long denominator;

        // The struct constructor takes the numerator and denominator as arguments.
        public Fraction(long numerator, long denominator)
            : this()
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
        }

        public long Numerator
        {
            get
            {
                return this.numerator;
            }
            set
            {
                checked
                {
                    this.numerator = value;
                }
            }
        }

        // Validate the input through properties. The denominator cannot be 0. 
        // Throw proper exceptions with descriptive messages.
        public long Denominator
        {
            get
            {
                return this.denominator;
            }
            set
            {
                if (value == 0)
                {
                    throw new DivideByZeroException("Denominator cannot be 0.");
                }

                checked
                {
                    this.denominator = value;
                }
            }
        }

        // Overload the + and - operators to perform addition and subtraction on objects of type Fraction. 
        // The result should be a new Fraction.
        public static Fraction operator +(Fraction firstFraction, Fraction secondFraction)
        {
            checked
            {
                firstFraction.Numerator *= secondFraction.Denominator;
                secondFraction.Numerator *= firstFraction.Denominator;
                long commonDenominator = firstFraction.Denominator * secondFraction.Denominator;

                return new Fraction(firstFraction.Numerator + secondFraction.Numerator, commonDenominator);
            }
        }

        public static Fraction operator -(Fraction firstFraction, Fraction secondFraction)
        {
            checked
            {
                firstFraction.Numerator *= secondFraction.Denominator;
                secondFraction.Numerator *= firstFraction.Denominator;
                long commonDenominator = firstFraction.Denominator * secondFraction.Denominator;

                return new Fraction(firstFraction.Numerator - secondFraction.Numerator, commonDenominator);
            }
        }

        // Override ToString() to print the fraction in floating-point format.
        public override string ToString()
        {
            return string.Format("{0}", (decimal)this.Numerator / this.Denominator);
        }
    }
}
