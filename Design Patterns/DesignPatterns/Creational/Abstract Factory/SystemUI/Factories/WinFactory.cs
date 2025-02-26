using AbstractFactoryOS.AbstractProduct;
using AbstractFactoryOS.ConcreteProduct;
using AbstractFactoryOS.Factories;

namespace AbstractFactoryOS.ConcreteFactory;

public class WinFactory : AbstractGUIFactory
{
    public override Button CreateButton()
    {
        return new WinButton();
    }
}
