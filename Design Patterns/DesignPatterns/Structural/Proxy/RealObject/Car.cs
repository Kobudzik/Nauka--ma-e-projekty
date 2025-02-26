using Proxy.Object;
using System;

namespace Proxy.RealObject;

public class Car : ICar
{
    public void DriveCar()
    {
        Console.WriteLine("Car has been driven!");
    }
}
