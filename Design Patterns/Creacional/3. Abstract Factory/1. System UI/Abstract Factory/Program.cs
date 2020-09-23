using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    public class Program
    {          
  
    static void Main(string[] args)
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
