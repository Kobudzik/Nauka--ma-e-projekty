using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Builder
{
    public class Pizza //FRAME for pizza object- Product
    {
        string _dough;
        string _sauce;
        string _topping;
        public string Dough { get { return _dough; } set { _dough = value; } }
        public string Sauce { get { return _sauce; } set { _sauce = value; } }
        public string Topping { get { return _topping; } set { _topping = value; } }

        public override string ToString()
        {
            return string.Format(
                    "Pizza with Dough as {0}, Sauce as {1} and Topping as {2}",
                    Dough,
                    Sauce,
                    Topping);
        }
    }
}
