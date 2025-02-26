using AbstractFactoryOS.AbstractProduct;
using AbstractFactoryOS.Factories;
using System;

namespace AbstractFactoryOS;

public static class Program
{
    static void Main()
    {
        AbstractGUIFactory factory = AbstractGUIFactory.GetFactory(OS_TYPE.Windows);
        Button button = factory.CreateButton();
        button.Paint();
        Console.ReadLine();

        // Wyświetlony zostanie tekst:
        //   "Przycisk WinButton"
        // lub:
        //   "Przycisk OSXButton"
    }
}
