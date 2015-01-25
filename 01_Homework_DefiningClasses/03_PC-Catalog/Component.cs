using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_PC_Catalog
{
    class Component
    {
        private string name;
        private decimal price;
        private string details;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                this.name = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("price", "Price cannot be negative number");
                }
                this.price = value;
            }
        }

        public string Details
        {
            get
            {
                return this.details;
            }
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("Details cannot be empty");
                }
                this.details = value;
            }
        }

        public Component(string name, decimal price, string details = null)
        {
            this.Name = name;
            this.Price = price;
            this.Details = details;
        }
    }
}
