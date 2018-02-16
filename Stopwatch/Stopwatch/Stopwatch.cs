using System;
namespace Intermediate_Excercises
{
    public class Stopwatch
    {
        private DateTime _start_time;
        private DateTime _end_time;
        private bool _running;

        public void Start()
        {
            
            if (_running)
                Console.WriteLine("Already running");
            _running = true;
            _start_time = DateTime.Now;
        }

        public void Stop()
        {
            
            if (!_running)
                Console.WriteLine("Already Stopped");
            _running = false;
            _end_time = DateTime.Now;
        }

        public string Interval()
        {
            return (_end_time - _start_time).ToString();
        }
    }
}
