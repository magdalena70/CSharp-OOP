using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Customer 
{
    // Define a class Customer, which contains data about a customer – 
    // first name, middle name and last name, ID (EGN), permanent address, 
    // mobile phone, e-mail, list of payments and customer type.
    // Implement the ICloneable interface. The Clone() method should make a deep copy 
    // of all object fields into a new object of type Customer.
    class Customer : ICloneable, IComparable<Customer>
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private int id;
        private string address;
        private string phone;
        private string email;
        private IList<Payment> payments;
        private CustomerType customerType;

        public Customer(string firstName, string middleName, string lastName, int id, 
            string address, string phone, string email)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.Id = id;
            this.Address = address;
            this.Phone = phone;
            this.Email = email;
            this.Payments = new List<Payment>();
        }

        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                Validation.CheckForNullOrEmptyString(value, "FirstName");
                this.firstName = value;
            }

        }

        public string MiddleName
        {
            get { return this.middleName; }
            set 
            {
                Validation.CheckForNullOrEmptyString(value, "MiddleName");
                this.middleName = value; 
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                Validation.CheckForNullOrEmptyString(value, "LastName");
                this.lastName = value;
            }
        }

        public int Id
        {
            get { return this.id; }
            set
            {
                Validation.CheckForNegativeOrZero(value, "ID");
                this.id = value;
            }
        }

        public string Address
        {
            get { return this.address; }
            set
            {
                Validation.CheckForNullOrEmptyString(value, "Address");
                this.address = value;
            }
        }

        public string Phone
        {
            get { return this.phone; }
            set
            {
                Validation.CheckForNullOrEmptyString(value, "PhoneNumber");
                this.phone = value;
            }
        }

        public string Email
        {
            get { return this.email; }
            set
            {
                Validation.CheckForNullOrEmptyString(value, "Email");
                Validation.CheckEmail(value, "Email");
                this.email = value;
            }
        }

        public CustomerType CustomerType
        {
            get { return this.customerType; }
            private set 
            {
                Validation.CheckObjectForNull(value, "CustomerType");
                this.customerType = value; 
            }
        }

        public IList<Payment> Payments 
        {
            get { return this.payments; }
            private set 
            {
                Validation.CheckObjectForNull(value, "Payments");
                this.payments = value; 
            }
        }

        public void AddPayment(Payment payment)
        {
            this.Payments.Add(payment);
            var paymetsCount = this.Payments.Count;
            if (paymetsCount == 1)
            {
                this.CustomerType = CustomerType.OneTime;
            }

            if (paymetsCount > 1 && paymetsCount < 4)
            {
                this.CustomerType = CustomerType.Regular;
            }

            if (paymetsCount > 3 && paymetsCount < 7)
            {
                this.CustomerType = CustomerType.Golden;
            }

            if (paymetsCount > 6)
            {
                this.CustomerType = CustomerType.Diamond;
            }
        }

        // Override the standard methods, inherited by System.Object: 
        // Equals(), ToString(), GetHashCode() and operators == and !=.
        protected bool Equals(Customer other)
        {
            return string.Equals(FirstName, other.FirstName) && 
                string.Equals(MiddleName, other.MiddleName) && 
                string.Equals(LastName, other.LastName) && 
                Id == other.Id;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj.GetType() != this.GetType())
            {
                return false;
            }

            return Equals((Customer)obj);
        }

        public override string ToString()
        {
            
            
            string result = string.Format("{0} {1} {2}:\n ID: {3}\n Addres: {4}\n Phone: {5}\n Email: {6}\n",
                     this.FirstName, this.MiddleName, this.LastName, this.Id,
                     this.Address, this.Phone, this.Email);
            
            return result;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return this.Id.GetHashCode();
            }
        }

        public static bool operator ==(Customer firstCustomer, Customer secondCustomer)
        {
            return firstCustomer.Equals(secondCustomer);
        }

        public static bool operator !=(Customer firstCustomer, Customer secondCustomer)
        {
            return !firstCustomer.Equals(secondCustomer);
        }

        // Implement the IComparable<Customer> interface to compare customers by full name 
        // (as first criteria, in lexicographic order) and by ID (as second criteria, in ascending order).
        public object Clone()
        {
            var cloning = new Customer(this.FirstName, this.MiddleName, this.LastName,
            this.Id, this.Address, this.Phone, this.Email);

            cloning.Payments = new List<Payment>();
            foreach (var payment in this.Payments)
            {
                cloning.Payments.Add(new Payment(payment.ProductName, payment.Price));
            }
            cloning.CustomerType = this.CustomerType;

            return cloning;
        }

        public int CompareTo(Customer otherCustomer)
        {
            string fullNameThisCustomer = this.ToString();
            string fullNameOtherCustomer = otherCustomer.ToString();
            if (fullNameThisCustomer.CompareTo(fullNameOtherCustomer) == 0)
            {
                return this.Id.CompareTo(otherCustomer.Id);
            }

            return fullNameThisCustomer.CompareTo(fullNameOtherCustomer);
        }
    }
}
