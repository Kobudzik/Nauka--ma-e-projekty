namespace BuilderExample
{
    public class CarBuilder : ICarTypeBuilder
    {
        public CarBuilder()
        {
            Reset();
        }

        private Car CarInstance { get; set; }

        public void Reset()
        {
            CarInstance = new Car();
        }

        public void SetEngineCc(int engineCC)
        {
            CarInstance.EngineCC = engineCC;
        }

        public void SetFuelType(string fuelType)
        {
            CarInstance.FuelType = fuelType;
        }

        public void SetSeats(int numberOfSeats)
        {
            CarInstance.Seats = numberOfSeats;
        }

        public void SetWheelNumber(int numberOfWheels)
        {
            CarInstance.WheelNumber = numberOfWheels;
        }
        public void SetRoof(bool hasRoof)
        {
            CarInstance.Roof = hasRoof;
        }

        public Car GetProduct()
        {
            var product = CarInstance;
            Reset();
            return product;
        }
    }
}
