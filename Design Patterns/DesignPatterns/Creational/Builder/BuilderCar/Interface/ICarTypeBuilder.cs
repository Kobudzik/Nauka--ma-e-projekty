namespace BuilderCar.Interface;

public interface ICarTypeBuilder
{
    void Reset();

    void SetFuelType(string fuelType);
    void SetWheelNumber(int numberOfWheels);
    void SetEngineCc(int engineCc);
    void SetSeats(int numberOfSeats);
    void SetRoof(bool hasRoof);
}
