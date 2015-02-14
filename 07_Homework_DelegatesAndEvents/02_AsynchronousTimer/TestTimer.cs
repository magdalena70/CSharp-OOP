using System;
using System.Threading;

namespace _02_AsynchronousTimer
{
    class TestTimer
    {
        public static void SaidGoodMorning(string str)
        {
            Console.WriteLine("Good Morning...");
        }

        public static void Work2(string str)
        {
            Console.Beep();
        }



        static void Main()
        {
             AsyncTimer timer = new AsyncTimer(SaidGoodMorning, 1000, 10);
            timer.Start();

            timer = new AsyncTimer(Work2, 500, 20);
            timer.Start();
        }
    }
}
