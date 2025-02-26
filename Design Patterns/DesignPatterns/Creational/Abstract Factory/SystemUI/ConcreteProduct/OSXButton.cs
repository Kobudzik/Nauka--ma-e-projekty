using AbstractFactoryOS.AbstractProduct;
using System;

namespace AbstractFactoryOS.ConcreteProduct;

public class OSXButton : Button
{
    public override void Paint()
    {
        Console.WriteLine("Przycisk OSXButton");
    }
}
