using System.Timers;
using AliaRobinson.OpenComposer.Tracks;

namespace UsageExample
{
    public class RecurringBeatTimer //: //IRecurringBeat
    {
        private Timer timer;
        private double interval;

        public void Start()
        {
            timer = new Timer();
            timer.Interval = interval;
          //  timer.Elapsed += OnBeatFunction;
            timer.Start();
        }

        public void Stop()
        {
            timer.Stop();
        }

        public void SetInterval(double interval)
        {
            this.interval = interval;
        }

       // public OnBeat OnBeatFunction { get; set; }
    }
}