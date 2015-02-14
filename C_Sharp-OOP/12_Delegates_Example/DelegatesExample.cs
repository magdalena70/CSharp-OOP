using System;

// Declaration of delegate
public delegate void SimpleDelegate(string param);

namespace _12_Delegates_Example
{
    public class DelegatesExample
    {

        static void TestMethod(string param)
        {
            Console.WriteLine("I am the 'TestMethod'. I was called by a delegate.");
            Console.WriteLine("I got parameter '{0}'.\n", param);
        }

        static void AnotherTestMethod(string anotherParam)
        {
            Console.WriteLine("I am the 'AnotherTestMethod'.");
            Console.WriteLine("I got parameter '{0}'.\n", anotherParam);
        }

        static void Main(string[] args)
        {
            // Instantiate the delegate
            SimpleDelegate simpleDelegate = new SimpleDelegate(TestMethod);
            // Instantiate the delegate by a shorter way and call method Testmethod()
            simpleDelegate = TestMethod;
            simpleDelegate("Hello, testMethod!");

            // call method AnotherTestMethod()
            simpleDelegate = AnotherTestMethod;
            simpleDelegate("Hello, AnotherTestMethod!");

        }
    }
}
