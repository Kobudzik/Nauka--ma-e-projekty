using BuilderCar.Builders;
using BuilderCar.Directors;
using BuilderCar.Product;
using System;
namespace BuilderCar;

static class Program
{
    public static void Main()
    {
        Director director = new();
        var builder = new CarBuilder();

        director.ConstructFamilyCar(builder);
        Car familyCar = builder.GetProduct();
        Console.WriteLine(familyCar.ToString());

        director.ConstructSportCar(builder);
        Car sportCar = builder.GetProduct();
        Console.WriteLine(sportCar.ToString());

        builder.Reset();
        builder.SetEngineCc(2137);
        builder.SetFuelType("Diesel");
        builder.SetSeats(4);
        builder.SetWheelNumber(4);
        builder.SetRoof(true);
        var customProduct = builder.GetProduct();
        Console.WriteLine(customProduct.ToString());

        Console.ReadKey();
    }
}
