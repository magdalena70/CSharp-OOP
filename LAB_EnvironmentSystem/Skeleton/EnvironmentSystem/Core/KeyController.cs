using EnvironmentSystem.Interfaces;
using System;

namespace EnvironmentSystem.Core
{
    public class KeyController : IController
    {

        public event EventHandler Pause;

        public void ProcessInput()
        {
            if (Console.KeyAvailable)
            {
                var keyPressed = Console.ReadKey();
                if (keyPressed.Key == ConsoleKey.Spacebar)
                {
                    if (this.Pause == null)
                    {
                        this.Pause(this, new EventArgs());
                    }
                }
            }
        }
    }
}
