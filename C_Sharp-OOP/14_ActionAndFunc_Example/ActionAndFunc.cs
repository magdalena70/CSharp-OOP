using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace _14_ActionAndFunc_Example
{
    class ActionAndFunc
    {

        static void Main(string[] args)
        {
            Func<string, int> intParseFunction = int.Parse;
            int number = intParseFunction("100");

            Action<int> printParsedNumberAction = Console.WriteLine;
            printParsedNumberAction(number);

            Execute(intParseFunction, printParsedNumberAction, "-50");
            Execute(double.Parse, Console.WriteLine, "3,14");

            Action<string, int> printNameAge =
                (name, age) =>
                {
                    Console.WriteLine("Name: {0}, Age: {1}", name, age);
                };

            printNameAge("Georgy", 15); // call action by it's name

            // lambda expression
            Func<string> empty = () =>
                {
                    return "Function without parameters.";
                };

            Console.WriteLine(empty); // return reference
            Console.WriteLine(empty());

            // Different way to show the same message 
            InvokeLambdaFunction();
            ShowMesage("I'm a method ShowMessage(string msg).");
            InvokeDeleate();
            InvokeAnnonymousMethod();

        }

        static void Execute<T1, T2>(Func<T1, T2> func, Action<T2> action, T1 value) // generic
        {
            action(func(value));
        }

        // lambda function
        static void InvokeLambdaFunction()
            {
                Action<string> actionMsg = (msg) =>
                    {
                        Console.WriteLine(msg);
                    };

                actionMsg("I'm a lambda function.");
            }

        // method ShowMessage
        static void ShowMesage(string msg)
        {
            Console.WriteLine(msg);
        }

        // delegate ShowMessage
        static void InvokeDeleate()
        {
            Action<string> action = ShowMesage;
            action("I'm called by a delegate.");
        }

        // annonimus method
        static void InvokeAnnonymousMethod()
        {
            Action<string> actionAnnonymous = delegate(string msg)
            {
                Console.WriteLine(msg);
            };

            actionAnnonymous("I'm an annonymous method.");
        }
    
    }
}
