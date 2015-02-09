using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Bank_KurtovoKonare
{
    public static class ValidationBankKomponents
    {
        public static void CheckForNullOrEmptyExeption(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("Name cannot be empty.");
            }
        }
    }
}
