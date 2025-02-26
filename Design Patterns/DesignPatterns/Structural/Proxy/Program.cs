using Proxy.Object;
using Proxy.Proxy;
using System;

namespace Proxy;

static class Program
{
    static void Main()
    {
        // How to use above Proxy class?
        ICar car = new ProxyCar(new Driver(15));
        car.DriveCar();

        car = new ProxyCar(new Driver(25));
        car.DriveCar();

        Console.ReadKey();
    }
}
