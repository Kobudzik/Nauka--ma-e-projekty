using DecoratorDemo.Component;
using DecoratorDemo.ConcreteComponent;
using DecoratorDemo.ConcreteDecorator;
using DecoratorDemo.Decorator;
using System;

namespace DecoratorDemo
{
    static class Program
    {
        static void Main()
        {
            ICar car = new Suzuki();

            CarDecorator decorator = new OfferPrice(car);

            Console.WriteLine(string.Format
                (
                "Make :{0} ,Price:{1}, DiscountPrice : {2}",
                decorator.Make,
                decorator.GetPrice().ToString(),
                decorator.GetDiscountedPrice().ToString()
                )
            );

            Console.ReadLine();
        }
    }
}