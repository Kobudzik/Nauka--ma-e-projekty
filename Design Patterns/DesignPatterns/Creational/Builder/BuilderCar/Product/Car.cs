namespace BuilderCar.Product;

public class Car
{
    public string FuelType { get; set; }
    public int WheelNumber { get; set; }

    public int EngineCC { get; set; }
    public int Seats { get; set; }
    public bool Roof { get; set; }

    public override string ToString()
    {
        return string.Format(
            $"Car fueled by {FuelType}, with {WheelNumber} wheels, {EngineCC}cc engine. It has {Seats} seats and {(Roof ? "" : "no")} roof"
        );
    }
}
