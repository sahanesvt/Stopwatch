using System;

namespace Stopwatch
{
    public class Stopwatch
    {
        public DateTime StartTime { get; private set; }
        public DateTime StopTime { get; private set; }
        public TimeSpan Duration { get; private set; } = new TimeSpan(0, 0, 0);
        public bool Running { get; private set; } = false;
        public string State { get; private set; } = "Stopped";
        private TimeSpan _zeroTime = new TimeSpan(0, 0, 0);
        //private TimeSpan _pauseTime = new TimeSpan(0, 0, 0);


        public Stopwatch() { }
        
        private void _duration()
        {
            /*if (Duration > _zeroTime & State == "Paused")
            {
                _pauseTime += StartTime - StopTime;
            }*/

            if (StartTime <= StopTime)
            {
                if (State == "Paused")
                {
                    Duration += StopTime - StartTime;// - _pauseTime;
                }
                else
                {
                    Duration = StopTime - StartTime;
                }
            }
        }

        private void _duration(DateTime startTime, DateTime stopTime)
        {
            /*if (Duration > _zeroTime & State == "Paused")
            {
                _pauseTime += StartTime - StopTime;
            }*/

            if (startTime <= stopTime)
            {
                if (State == "Paused")
                {
                    Duration += stopTime - startTime;// - _pauseTime;
                }
                else
                {
                    Duration = stopTime - startTime;
                }
            }
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
            //_duration();
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
            //StopTime = DateTime.Now;
            if (State == "Running")
            {
                _duration(StartTime, DateTime.Now);
            }
            else
            {
                throw new InvalidOperationException("Invalid input! Stopwatch is not currently running.");
            }
        }

        public void ResetStopwatch()
        {
            Running = false;
            State = "Stopped";
            Duration = _zeroTime;
            //_pauseTime = _zeroTime;
        }

    }
}
