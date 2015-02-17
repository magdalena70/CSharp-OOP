using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Customer
{
    class TestCustomer
    {
        static void Main()
        {
            var firstCustomer = new Customer(
                "Ivan", 
                "Ivanov", 
                "Vasilev", 
                123456789, 
                "Sofia bul.\"V.Levsky\"",
                "0898 123 123",
                "ivan@abv.bg"
                );
            var secondCustomer = new Customer(
                "Ivan", 
                "Ivanov", 
                "Vasilev", 
                123456788, 
                "Burgas ul.Veslec",
                "0899 123 456",
                "ivanivanov@abv.bg"
                );
            var thirdCustomer = new Customer(
                "Maria", 
                "Peneva", 
                "Shopova", 
                100230001,
                "Sliven ul.355",
                "0888 000 225",
                "maria@abv.bg"
                );

            Console.WriteLine("firstCustomer:\n{0}", firstCustomer);
            Console.WriteLine("secondCustomer:\n{0}", secondCustomer);
            Console.WriteLine("thirdCustomer:\n{0}", thirdCustomer);

            Payment[] payments =
            {
                new Payment("Iphone", 789.99m),
                new Payment("tablet", 700.99m),
                new Payment("phone", 250),
                new Payment("tablet", 500),
                new Payment("TV", 1599.99m)
            };

            decimal totalPrice = 0;
            foreach (var payment in payments)
            {
                firstCustomer.AddPayment(payment);
                totalPrice += payment.Price;
            }

            secondCustomer.AddPayment(payments[0]);
            secondCustomer.AddPayment(payments[4]);
            thirdCustomer.AddPayment(payments[1]);

            Console.WriteLine("\n-----CustomerType-----\n");
            Console.WriteLine("firstCustomer.CustomerType: {0}; Products Total Price: {1}", 
                firstCustomer.CustomerType, totalPrice);
            Console.WriteLine("secondCustomer.CustomerType: {0}; Products Total Price: {1}",
                secondCustomer.CustomerType, secondCustomer.Payments[0].Price + secondCustomer.Payments[1].Price);
            Console.WriteLine("thirdCustomer.CustomerType: {0}; Products Total Price: {1}", 
                thirdCustomer.CustomerType, thirdCustomer.Payments[0].Price);

            Console.WriteLine("\n-----Clone()-----\n");
            var thirdCustomerClonе = (Customer)thirdCustomer.Clone();
            Console.WriteLine("thirdCustomerClonе:\n{0}CustomerType:{1}\n",
                thirdCustomerClonе, thirdCustomerClonе.CustomerType);
            Customer firstCustomerClone = (Customer)firstCustomer.Clone();
            Console.WriteLine("firstCustomerClonе:\n{0}CustomerType:{1}\n", 
                firstCustomerClone, firstCustomerClone.CustomerType);

            Console.WriteLine("-----GetHashCode()-----\n");
            Console.WriteLine("firstCustomer.GetHashCode() -> {0}", firstCustomer.GetHashCode());
            Console.WriteLine("firstCustomerClone.GetHashCode() -> {0}", firstCustomerClone.GetHashCode());

            Console.WriteLine("\n-----bool operator == ----\n");
            Console.WriteLine("firstCustomer == firstCustomerClone -> {0}",
                firstCustomer == firstCustomerClone);
            Console.WriteLine("firstCustomer == secondCustomer -> {0}", 
                firstCustomer == secondCustomer);
            Console.WriteLine("firstCustomer == thirdCustomer -> {0}", 
                firstCustomer == thirdCustomer);
            Console.WriteLine("thirdCustomer == thirdCustomerClonе -> {0}", 
                thirdCustomer == thirdCustomerClonе);

            Console.WriteLine("\n-----bool operator != ----\n");
            Console.WriteLine("firstCustomer != secondCustomer -> {0}",
                firstCustomer != secondCustomer);
            Console.WriteLine("firstCustomer != thirdCustomer -> {0}",
                firstCustomer != thirdCustomer);
            Console.WriteLine("thirdCustomer != thirdCustomerClonе -> {0}",
                thirdCustomer != thirdCustomerClonе);

            Console.WriteLine("\n-----CompareTo()-----\n");
            Console.WriteLine("firstCustomer.CompareTo(secondCustomer) -> {0}", 
                firstCustomer.CompareTo(secondCustomer));
            Console.WriteLine("firstCustomer.CompareTo(thirdCustomer) -> {0}", 
                firstCustomer.CompareTo(thirdCustomer));
            Console.WriteLine("thirdCustomer.CompareTo(thirdCustomerClonе) -> {0}", 
                thirdCustomer.CompareTo(thirdCustomerClonе));

            
        }
    }
}
