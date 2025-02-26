using System;
using Template.Hoagies;

namespace Template;

static class Program
{
    static void Main()
    {
        var hoagie = new ItalianSandwich();
        hoagie.MakeSandwitch();
        Console.Read();
    }
}
