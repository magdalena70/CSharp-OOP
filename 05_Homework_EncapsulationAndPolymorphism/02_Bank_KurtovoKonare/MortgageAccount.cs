using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Bank_KurtovoKonare
{
    public class MortgageAccount : Account, IAccount, IDepositable
    {
        public MortgageAccount(ICustomer customer, decimal balance, decimal monthlyInterestRate)
            : base(customer, balance, monthlyInterestRate)
        {
        }

        // Loan and mortgage accounts can only deposit money.
        // Mortgage accounts have ½ interest for the first 12 months for companies 
        // and no interest for the first 6 months for individuals.
        public override decimal CalculateRate(double months)
        {

            if (this.Customer is CompanyCustomer)
            {
                if (months <= 12)
                {
                    return base.CalculateRate(months) / 2;
                }
                else
                {
                    return (base.CalculateRate(12) / 2) + base.CalculateRate(months - 12);
                }
            }

            if (this.Customer is IndividualCustomer)
            {
                if (months >= 6)
                {
                    return base.CalculateRate(months - 6);
                }
                else
                {
                    return this.Balance;
                }
            }

            return base.CalculateRate(months);
        }
    }
}
