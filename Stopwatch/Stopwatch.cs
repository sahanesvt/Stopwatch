using System;

namespace Stopwatch
{
    public class Stopwatch
    {
        public DateTime StartTime { get; private set; } = DateTime.Now;
        public DateTime StopTime { get; private set; } = DateTime.Now;
        public TimeSpan Duration { get; private set; } = new TimeSpan(0, 0, 0);
        public bool Running { get; private set; } = false;
        public string State { get; private set; } = "Stopped";
        private TimeSpan _zeroTime = new TimeSpan(0, 0, 0);
        private DateTime _pauseTime = DateTime.Now;


        public Stopwatch() { }
        
        private void _duration()
        {
            Duration += StopTime - StartTime;
        }
        
        public void Start()
        {
            if (!Running)
            {
                Running = true;
                State = "Running";
                StartTime = DateTime.Now;
            }
            else
            {
                throw new InvalidOperationException("Invalid input! Stopwatch is currently running.");
            }
        }

        public void Stop()
        {
            if (Running)
            {
                Running = false;
                State = "Paused";
                StopTime = DateTime.Now;
            }
            else
            {
                throw new InvalidOperationException("Invalid input! Stopwatch has not been started.");
            }
            _duration();
        }

        public void TimeCheck()
        {
            if (Running)
            {
                StopTime = DateTime.Now;
                _duration();
                StartTime = DateTime.Now;
            }
        }

        public void ResetStopwatch()
        {
            Running = false;
            State = "Stopped";
            Duration = _zeroTime;
        }

    }
}
