using System;

namespace Fluent_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            FluentEmployee obj = new FluentEmployee();

            obj.NameOfTheEmployee("Anurag Mohanty")
                    .Born("10/10/1992")
                    .WorkingOn("IT")
                    .StaysAt("Mumbai-India");




            FluentEmployee konrad = new FluentEmployee();

            konrad.NameOfTheEmployee("Konrad")
                .Born("12/12/12/")
                .StaysAt("Home");



            Console.Read();
        }
    }
}


