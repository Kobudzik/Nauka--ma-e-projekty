using Decorator.Component;

namespace Decorator.ConcreteComponent;

public sealed class Hyndai : ICar
{
    public string Make => "HatchBack";

    public double GetPrice() => 800000;
}