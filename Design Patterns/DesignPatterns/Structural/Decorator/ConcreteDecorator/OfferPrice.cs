using Decorator.AbstractDecorator;
using Decorator.Component;

namespace Decorator.ConcreteDecorator;

public class OfferPrice(ICar car) : CarDecorator(car)
{
    public override double GetDiscountedPrice() => .8 * GetPrice();
}