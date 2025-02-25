using DecoratorDemo.Component;
using DecoratorDemo.Decorator;

namespace DecoratorDemo.ConcreteDecorator
{
    public class OfferPrice : CarDecorator
    {
        public OfferPrice(ICar car)
            : base(car)
        {
        }

        public override double GetDiscountedPrice()
        {
            return .8 * base.GetPrice();
        }
    }
}