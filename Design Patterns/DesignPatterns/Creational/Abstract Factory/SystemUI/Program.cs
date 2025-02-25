using System;

namespace DesignPatterns_AbstractFactory_OS
{
    public static class Program
    {
        static void Main()
        {
            GUIFactory factory = GUIFactory.GetFactory(OS_TYPE.Windows);
            Button button = factory.CreateButton();
            button.Paint();
            Console.ReadLine();

            // Wyświetlony zostanie tekst:
            //   "Przycisk WinButton"
            // lub:
            //   "Przycisk OSXButton"
        }
    }
}
