using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Customer
{
    // Define a class Payment which holds a product name and price.
    class Payment
    {
        private string productName;
        private decimal price;

        public Payment(string productName, decimal price)
        {
            this.ProductName = productName;
            this.Price = price;
        }

        public string ProductName
        {
            get { return this.productName; }
            set
            {
                Validation.CheckForNullOrEmptyString(value, "ProductName");
                this.productName = value;
            }
        }

        public decimal Price
        {
            get { return this.price; }
            set
            {
                Validation.CheckForNegativeOrZero(value, "Price");
                this.price = value;
            }
        }
    }
}
