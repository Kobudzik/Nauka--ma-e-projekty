using AbstractFactoryOS.AbstractProduct;
using AbstractFactoryOS.ConcreteFactory;
using System;

namespace AbstractFactoryOS.Factories;

public abstract class AbstractGUIFactory
{
    public static AbstractGUIFactory GetFactory(OS_TYPE type)
    {
        return type switch
        {
            OS_TYPE.Windows => new WinFactory(),
            OS_TYPE.OsX => new OSXFactory(),
            _ => throw new NotImplementedException(),
        };
    }

    public abstract Button CreateButton();
}
