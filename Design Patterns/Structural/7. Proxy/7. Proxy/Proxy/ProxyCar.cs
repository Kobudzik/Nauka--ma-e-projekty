using System;

namespace _7.Proxy
{
    // Proxy Object
    public class ProxyCar : ICar
    {
        private Driver _driver;
        private ICar _realCar;

        public ProxyCar(Driver driver)  //konstruktor
        {
            this._driver = driver;
            this._realCar = new Car();
        }

        public void DriveCar()
        {
            if (_driver.Age < 16)
                Console.WriteLine("Sorry, the driver is too young to drive.");
            else
                this._realCar.DriveCar();
        }
    }
}
