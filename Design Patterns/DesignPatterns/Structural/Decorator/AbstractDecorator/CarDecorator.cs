using DecoratorDemo.Component;
namespace DecoratorDemo.Decorator
{
    public abstract class CarDecorator : ICar
    {
        private readonly ICar _car;

        protected CarDecorator(ICar Car)
        {
            _car = Car;
        }

        public string Make { get { return _car.Make; } }

        public double GetPrice()
        {
            return _car.GetPrice();
        }

        public abstract double GetDiscountedPrice();
    }
}
