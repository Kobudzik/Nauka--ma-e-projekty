using AbstractFactoryOS.AbstractProduct;
using System;

namespace AbstractFactoryOS.ConcreteProduct;

public class WinButton : Button
{
    public override void Paint()
    {
        Console.WriteLine("WinButton");
    }
}
