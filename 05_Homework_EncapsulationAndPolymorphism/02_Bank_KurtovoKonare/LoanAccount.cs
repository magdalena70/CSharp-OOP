using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Bank_KurtovoKonare
{
    public class LoanAccount : Account, IAccount, IDepositable
    {
        public LoanAccount(ICustomer customer, decimal balance, decimal monthlyInterestRate)
            : base(customer, balance, monthlyInterestRate)
        {
        }

        // Loan and mortgage accounts can only deposit money.
        // Loan accounts have no interest for the first 3 months if held by individuals 
        // and for the first 2 months if held by a company.
        public override decimal CalculateRate(double months)
        {
            if (this.Customer is IndividualCustomer)
            {
                if (months >= 3)
                {
                    return base.CalculateRate(months - 3);
                }
                else
                {
                    return this.Balance;
                }
            }

            if (this.Customer is CompanyCustomer)
            {
                if (months >= 2)
                {
                    return base.CalculateRate(months - 2);
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
