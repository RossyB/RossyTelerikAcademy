namespace Timer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class TimerTest
    {
        public static void Main()
        {
            
            Timer timer1 = new Timer(2000, SampleMethod1);
            Timer timer2 = new Timer(1000, SampleMethod2);
        }

        private static void SampleMethod2()
        {
            Console.WriteLine("Call of SampleMethod 2 at: {0}", DateTime.Now);
        }

        private static void SampleMethod1()
        {
            Console.WriteLine("Call of SampleMethod 1 at: {0}", DateTime.Now);
        }
    }
}
