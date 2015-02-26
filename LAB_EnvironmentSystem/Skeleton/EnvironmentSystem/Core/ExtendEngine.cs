using EnvironmentSystem.Interfaces;
using EnvironmentSystem.Models;
using System;

namespace EnvironmentSystem.Core
{
    public class ExtendEngine : Engine
    {
        /// <summary>
        /// Solve Problem 7.Engine Modifications - 
        /// Step 2 – Pausing
        /// Wouldn't it be fun if you could pause and analyze the environment at any given time 
        /// with a single press of a button?
        /// This is where the IController interface comes in. It defines event Pause and void ProcessInput().
        /// </summary>
        private IController controller;
        private bool isPaused;

        public ExtendEngine(IController controller)
            : base()
        {
            this.controller = controller;
            this.AttachControllerEvent();
        }

        private void AttachControllerEvent()
        {
            this.controller.Pause += controller_Pause;
        }

        private void controller_Pause(object sender, EventArgs e)
        {
            this.isPaused = !isPaused;
        }

        protected override void ExecuteEnvironmentLoop()
        {
            this.controller.ProcessInput();

            if (!this.isPaused)
            {
                base.ExecuteEnvironmentLoop();
            }
        }

        /// <summary>
        /// Solve Problem 7.Engine Modifications
        /// We've seen that the engine is quite versatile and adding new objects with different behavior is fun. 
        /// What's missing though? 
        /// Step 1 – Validation
        /// Maybe you haven't noticed, but the Insert() method in the Engine does not validate whether the object is null. 
        /// However, we cannot simply edit the engine – we must obey the open/closed principle 
        /// (open for extension, closed for modification) and avoid directly editing someone else's code. 
        /// What we must do is inherit the Engine class and extend it using the best OOP practices.
        /// Extend the engine and perform validation in the Insert() method.
        /// Note: Do not repeat any of the base code! Find a way to reuse it.
        /// </summary>
        /// <param name="obj"></param>
        protected override void Insert(EnvironmentObject obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException("Object cannot be null.");
            }

            base.Insert(obj);
        }
    }
}
