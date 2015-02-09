using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Bank_KurtovoKonare
{
    public abstract class Account : IAccount, IDepositable
    {
        private decimal monthlyInterestRate;
        private decimal balance;
        private ICustomer customer;

        //All accounts have customer, balance and interest rate (monthly based). 
        public Account(ICustomer customer, decimal balance, decimal monthlyInterestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.MonthlyInterestRate = monthlyInterestRate;
        }

        public ICustomer Customer
        {
            get
            {
                return this.customer;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Account cannot be empty.");
                }
                this.customer = value;
            }
        }

        public decimal Balance
        {
            get
            {
                return this.balance;
            }
            set
            {
                this.balance = value;
            }
        }

        public decimal MonthlyInterestRate
        {
            get
            {
                return this.monthlyInterestRate;
            }
            set
            {
                this.monthlyInterestRate = value;
            }
        }

        // All accounts can calculate their interest for a given period (in months) using the formula:
        // A = money * (1 + interest rate * months)
        public virtual decimal CalculateRate(double months)
        {
            return this.Balance * (1 + ((this.MonthlyInterestRate * (decimal)months) / 100));
        }

        public virtual void Deposit(decimal amount)
        {
            this.Balance += amount;
        }
    }
}
