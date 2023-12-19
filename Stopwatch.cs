namespace Ejercicios_Clases_Udemy_18_12
{
    public class Stopwatch
    {
        private DateTime _startTime;
        private DateTime _endTime;
        public void Start()
        {
            _startTime = DateTime.Now;
        }

        public void Stop()
        {
            _endTime = DateTime.Now;
        }

        public TimeSpan GetDuration()
        {
            return _endTime - _startTime;
        }

    }
}
