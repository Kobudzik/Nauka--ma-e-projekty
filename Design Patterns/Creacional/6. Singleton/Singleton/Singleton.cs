namespace Singleton
{
    public sealed class Config
    {
        private static Config _instance;
        private static readonly object _syncLock = new object();

        private static string _param1;
        private static string _param2;

        private Config() //constructor
        {
            _param1 = "default";
            _param2 = "default";
        }

        public static Config GetConfig()
        {
            if (_instance == null) //jeśli docelowy obiekt nie istnieje
            {
                lock (_syncLock) //nakłada blokadę
                {
                    if (_instance == null) //jeśli dalej nie ma obiektu
                        _instance = new Config(); //tworzy obiekt
                } //here lock releases
            }

            return _instance;
        }
    }
}