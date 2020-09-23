using System;

namespace _1.Adapter
{
    public class MainApp
    {
        static void Main()
        {
            // Non-adapted chemical compound
            Compound unknown = new Compound("Unknown");
            unknown.Display();







            // Adapted chemical compounds
            Compound unknown2 = new RichCompound("Unknown");
            unknown2.Display();

            Compound water = new RichCompound("Water");
            water.Display();

            Compound benzene = new RichCompound("Benzene");
            benzene.Display();

            Compound ethanol = new RichCompound("Ethanol");
            ethanol.Display();



            // Wait for user
            Console.ReadKey();
        }
    }    
}