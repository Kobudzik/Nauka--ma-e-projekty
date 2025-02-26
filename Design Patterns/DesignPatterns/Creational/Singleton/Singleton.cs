namespace Singleton;

public sealed class Config
{
    private static Config _instance;
    private static readonly object _syncLock = new();

    private static string _param1;
    private static string _param2;

    private Config() //constructor
    {
        _param1 = "default";
        _param2 = "default";
    }

    public static Config GetConfig()
    {
        if (_instance == null)
        {
            lock (_syncLock)
            {
                _instance ??= new Config();
            }
        }

        return _instance;
    }
}