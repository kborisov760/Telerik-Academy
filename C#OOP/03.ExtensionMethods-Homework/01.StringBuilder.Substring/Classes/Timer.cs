namespace ExtensionMethods.Classes
{
    using System;
    using System.Threading;
    public class Timer
    {
        private int pausetime;

        public Timer(int interval)
        {
            this.Frequence = interval;
        }

        public int Frequence { get; set; }

        public TestTimer Methods { get; set; }
        public delegate void TestTimer();

        public void ExecuteMethods()
        {
            while (true)
            {
                this.Methods();
                Thread.Sleep(this.Frequence * 1000);
            }
        }
    }
}
