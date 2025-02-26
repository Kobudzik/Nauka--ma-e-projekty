using Decorator.Component;

namespace Decorator.AbstractDecorator;

public abstract class CarDecorator(ICar car) : ICar
{
    public string Make => car.Make;

    public double GetPrice() => car.GetPrice();

    public abstract double GetDiscountedPrice();
}
