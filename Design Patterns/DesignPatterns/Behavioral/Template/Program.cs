using System;

namespace DesignPatterns.Template
{
    static class Program
    {
        static void Main()
        {
            Hoagie cust12Hoohie = new ItalianHoagie();
            cust12Hoohie.MakeSandwitch();
            Console.Read();
        }
    }
}
