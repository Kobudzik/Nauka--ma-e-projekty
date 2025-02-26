using BuilderCar.Interface;

namespace BuilderCar.Directors;

public class Director
{
    private ICarTypeBuilder CarBuilder { get; set; }

    public void SetBuilder(ICarTypeBuilder builder)
    {
        CarBuilder = builder;
    }

    public void ConstructSportCar(ICarTypeBuilder builder)
    {
        builder.Reset();
        builder.SetEngineCc(5122);
        builder.SetSeats(2);
        builder.SetFuelType("Pb98");
    }

    public void ConstructFamilyCar(ICarTypeBuilder builder)
    {
        builder.Reset();
        builder.SetEngineCc(2096);
        builder.SetSeats(7);
        builder.SetFuelType("Diesel");
    }
}
