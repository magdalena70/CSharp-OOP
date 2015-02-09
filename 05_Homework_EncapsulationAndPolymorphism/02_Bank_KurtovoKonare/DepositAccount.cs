using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Bank_KurtovoKonare
{
    public class DepositAccount : Account, IAccount, IDepositable, IWithdrawable
    {
        public DepositAccount(ICustomer customer, decimal balance, decimal monthlyInterestRate)
            : base(customer, balance, monthlyInterestRate)
        {
        }

        // Deposit accounts are allowed to deposit and withdraw money.
        public void Withdraw(decimal amount)
        {
            this.Balance -= amount;
        }

        // Deposit accounts have no interest if their balance is positive and less than 1000.
        public override decimal CalculateRate(double months)
        {
            if (this.Balance >= 0 && this.Balance < 1000)
            { 
                return this.Balance;
            }
            else
            {
                return base.CalculateRate(months);
            }
        }
    }
}
