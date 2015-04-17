namespace Timer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading;

    public class Timer
    {
        public delegate void MethodDelegate();

        public int Delay { get; set; }

        public MethodDelegate MethodProperty { get; set; }

        public Timer(int delay, MethodDelegate invokeMethod)
        { 
            this.Delay = delay;
            this.MethodProperty = invokeMethod;
            Thread newThread = new Thread(() =>
                {
                    while (true)
                    {
                        this.MethodProperty();
                        Thread.Sleep((int)this.Delay);
                    }
                });

            newThread.Start();
        }
    }
}
