namespace TimerClass
{
    //Read in MSDN about the keyword event in C# and how to publish events.
    //Re-implement the above using .NET events and following the best practices.

    using System;

    public class EventListener
    {
        private Timer timer;
        private Action<object, EventArgs> methodPassed;

        public EventListener(Timer timer, Action<object, EventArgs> methodPassed)
        {
            this.timer = timer;
            this.methodPassed = methodPassed;
            timer.Tick += new TimerEventHandler(methodPassed);
        }

        public void Detach()
        {
            this.timer.Tick -= new TimerEventHandler(this.methodPassed);
            this.timer = null;
        }
    }
}