using Proxy.Object;
using Proxy.RealObject;
using System;

namespace Proxy.Proxy;

public class ProxyCar(Driver driver) : ICar
{
    private readonly Driver _driver = driver;
    private readonly ICar _realCar = new Car();

    public void DriveCar()
    {
        if (_driver.Age < 16)
            Console.WriteLine("Sorry, the driver is too young to drive.");
        else
            _realCar.DriveCar();
    }
}
