using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Bank_KurtovoKonare
{
    public class IndividualCustomer : Customer, ICustomer
    {
        // Customers could be individuals or companies.
        public IndividualCustomer(string name)
            : base(name)
        {
        }
    }
}
