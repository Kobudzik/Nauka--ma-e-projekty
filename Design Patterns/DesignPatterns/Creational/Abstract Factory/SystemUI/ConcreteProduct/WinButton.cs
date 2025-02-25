using System;

namespace DesignPatterns_AbstractFactory_OS
{
    public class WinButton : Button
    {
        public override void Paint()
        {
            Console.WriteLine("Przycisk WinButton");
        }
    }
}
