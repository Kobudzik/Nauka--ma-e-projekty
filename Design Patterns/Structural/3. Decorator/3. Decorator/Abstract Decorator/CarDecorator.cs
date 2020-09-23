using DecoratorDemo.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DecoratorDemo.Decorator
{
    public abstract class CarDecorator : ICar
    {
        private ICar _car;

        public CarDecorator(ICar Car)   //constructor
        {
            _car = Car;
        }

        public string Make { get { return _car.Make; } }    //property



        public double GetPrice()
        {
            return _car.GetPrice();
        }

        public abstract double GetDiscountedPrice();
    }
}
