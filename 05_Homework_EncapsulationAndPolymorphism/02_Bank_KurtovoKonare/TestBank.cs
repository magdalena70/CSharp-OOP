using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Bank_KurtovoKonare
{
    public class TestBank
    {
        public static void Main()
        {
            ICustomer individualCustomer = new IndividualCustomer("Vasil Zahariev");
            ICustomer companyCustomar = new CompanyCustomer("Company Ltd.");

            IAccount mortgageAccauntIC = new MortgageAccount(individualCustomer, 1024m, 5.3m);
            IAccount loanAccauntIC = new LoanAccount(individualCustomer, 1024m, 5.3m);
            IAccount depositAccauntIC_Big = new DepositAccount(individualCustomer, 1000m, 5.3m);
            IAccount depositAccauntIC_Small = new DepositAccount(individualCustomer, -10m, 5.3m);

            IAccount mortgageAccauntCC = new MortgageAccount(companyCustomar, 1024m, 5.3m);
            IAccount loanAccauntCC = new LoanAccount(companyCustomar, 1024m, 5.3m);
            IAccount depositAccauntCC = new DepositAccount(companyCustomar, 11024m, 4.3m);

            List<IAccount> accounts = new List<IAccount>()
            {
                mortgageAccauntIC,
                loanAccauntIC,
                depositAccauntIC_Big,
                depositAccauntIC_Small,
                mortgageAccauntCC,
                loanAccauntCC,
                depositAccauntCC
            };

            foreach (var accaunt in accounts)
            {
                Console.WriteLine(
                    "{0} {1} -> {2:N2}; {3:N2}; {4:N2};",
                    accaunt.Customer.GetType().Name,
                    accaunt.GetType().Name,
                    accaunt.CalculateRate(12),
                    accaunt.CalculateRate(3),
                    accaunt.CalculateRate(6));
            }
        }
    }
}
