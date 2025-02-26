using AbstractFactoryOS.AbstractProduct;
using AbstractFactoryOS.ConcreteProduct;
using AbstractFactoryOS.Factories;

namespace AbstractFactoryOS.ConcreteFactory;

public class OSXFactory : AbstractGUIFactory
{
    public override Button CreateButton()
    {
        return new OSXButton();
    }
}
