using AbstractFactoryOS.AbstractProduct;
using AbstractFactoryOS.ConcreteProduct;

namespace AbstractFactoryOS.Factories;

public class WinFactory : AbstractGUIFactory
{
    public override Button CreateButton() => new WinButton();
}
