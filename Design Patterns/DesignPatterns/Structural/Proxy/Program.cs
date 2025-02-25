using System;

namespace DesignPatterns.Proxy
{
    public class Driver
    {
        public int Age { get; set; }

        public Driver(int age)
        {
            this.Age = age;
        }
    }

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
}
