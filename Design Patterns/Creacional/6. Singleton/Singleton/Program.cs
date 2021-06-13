
using Singleton;

namespace SingletonDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = Config.GetConfig();
        }
    }
}
