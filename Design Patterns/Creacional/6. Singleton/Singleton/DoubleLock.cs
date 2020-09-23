namespace DesignPatternDemos.Singleton
{
    public sealed class Logger1
    {
        private static Logger1 _logger1;
        private static readonly object _syncLock = new object();

        private Logger1()
        {
        }

        public static Logger1 GetLogger()
        {
            if (_logger1 == null)
            {
                lock (_syncLock)
                {
                    if (_logger1 == null)
                    {
                        _logger1 = new Logger1();
                    }
                }
            }

            return _logger1;
        }

        public void WriteMessage(string message)
        {
        }
    }
}
