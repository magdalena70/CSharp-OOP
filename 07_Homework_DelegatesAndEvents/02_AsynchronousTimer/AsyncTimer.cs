using System;
using System.Threading;

namespace _02_AsynchronousTimer
{
    // Create a class AsyncTimer that executes a given method each t seconds.
    class AsyncTimer
    {
        // The constructor should accept 3 arguments: 
        // Action (a method to be called on every t milliseconds), 
        // ticks (the number of times the method should be called) 
        // and t (time interval between each tick in milliseconds).
        private Action<string> actionMethod;
        private int ticks;
        private int timeInterval;

        public AsyncTimer(Action<string> actionMethod, int ticks, int timeInterval)
        {
            this.actionMethod = actionMethod;
            this.ticks = ticks;
            this.timeInterval = timeInterval;
        }

        // The main program's execution should NOT be paused at any time (use some kind of background execution).
        private void WorkingNonStop()
        {
            while (this.ticks > 0)
            {
                Thread.Sleep(this.timeInterval);

                if (actionMethod != null)
                {
                    actionMethod(this.ticks + "");
                }

                this.ticks--;
            }
        }

        public void Start()
        {
            Thread thread = new Thread(this.WorkingNonStop);
            thread.Start();
        }
    }
}
