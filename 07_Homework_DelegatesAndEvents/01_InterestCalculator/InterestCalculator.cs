using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Messaging;

namespace _01_InterestCalculator
{
    // Create a delegate CalculateInterest (or use Func<…>) with parameters 
    // sum of money, interest and years that calculates the interest according to the method it points to. 
    public delegate decimal CalculateInterest(decimal sumOfMoney, decimal interest, int years);

    // Create a class InterestCalculator that takes in its constructor 
    // money, interest, years and interest calculation delegate. 
    class InterestCalculator
    {
        private decimal money;
        private decimal interest;
        private int years;
        private CalculateInterest calcInterestDelegate;

        public InterestCalculator(decimal money, decimal interest, int years, CalculateInterest calcInterestDelegate)
        {
            this.Money = money;
            this.Interest = interest;
            this.Years = years;
            this.CalcInterestDelegate = calcInterestDelegate;
        }

        public decimal Money 
        { 
            get
            {
                return this.money; 
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative.");
                }
                this.money = value;
            } 
        }

        public decimal Interest 
        {
            get 
            {
                return this.interest;
            }
            private set
            {
                this.interest = value;
            } 
        
        }

        public int Years
        {
            get 
            {
                return this.years;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Years cannot be negative.");
                }

                this.years = value;
            } 
        }

        public CalculateInterest CalcInterestDelegate 
        {
            get
            {
                return this.calcInterestDelegate;
            }
            private set
            {
                this.calcInterestDelegate = value;
            } 
        
        }

        // The result should be rounded to 4 places after the decimal point.
        public override string ToString()
        {
            return string.Format("{0:F4}", this.CalcInterestDelegate(this.Money, this.Interest, this.Years));
        }
    }
}
