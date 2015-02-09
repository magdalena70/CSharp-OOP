using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Bank_KurtovoKonare
{
    public abstract class Customer : ICustomer
    {
        private string name;

        public Customer(string name)
        {
            this.Name = name;
        }

        public string Name 
        {
            get
            {
                return this.name;
            }
            set
            {
                ValidationBankKomponents.CheckForNullOrEmptyExeption(value);
                this.name = value;
            }
        }
    }
}
