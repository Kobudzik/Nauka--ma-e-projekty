using System;

namespace DesignPatternDemos.Singleton
{
    public sealed class Logger
    {
        private static Logger _logger;  //variable
        private static readonly object _syncLock = new object();    //new OBJECT


        private Logger() //constructor
        {
        }

        public static Logger GetLogger()
        {
            if (_logger == null)    //jeśli docelowy obiekt nie istnieje
            {
                lock (_syncLock)    //nakłada blokadę
                {
                    if (_logger == null)    //jeśli dalej nie ma obiektu
                    {
                        _logger = new Logger(); //tworzy obiekt
                    }
                }//here lock releases
            }
            return _logger;
        }

        public void WriteMessage(string message)
        {
        }
    }
}