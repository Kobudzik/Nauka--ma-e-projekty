using AbstractFactoryOS.AbstractProduct;
using AbstractFactoryOS.ConcreteProduct;

namespace AbstractFactoryOS.Factories;

public class OSXFactory : AbstractGUIFactory
{
    public override Button CreateButton() => new OSXButton();
}
