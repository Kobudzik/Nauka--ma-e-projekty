using System;

namespace DesignPatterns_AbstractFactory_OS
{
    public class OSXButton : Button
    {
        public override void Paint()
        {
            Console.WriteLine("Przycisk OSXButton");
        }
    }
}
