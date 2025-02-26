using Decorator.Component;

namespace Decorator.ConcreteComponent;

public sealed class Suzuki : ICar
{
    public string Make => "Sedan";

    public double GetPrice() => 1000000;
}