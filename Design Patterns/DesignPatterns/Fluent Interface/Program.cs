using System;

namespace FluentInterface;

internal class Program
{
    private static void Main()
    {
        FluentEmployee obj = new();

        obj.NameOfTheEmployee("Anurag Mohanty")
                .Born("10/10/1992")
                .WorkingOn("IT")
                .StaysAt("Mumbai-India");

        FluentEmployee someEmploye = new();

        someEmploye.NameOfTheEmployee("Konrad")
            .Born("12/12/12/")
            .StaysAt("Home");

        Console.Read();
    }
}