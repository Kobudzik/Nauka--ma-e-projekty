using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Factory_Method
{
    public class DeluxePizza : Pizza
    {
        private decimal price = 10.5M;


        public override decimal GetPrice()
        {
            return price;
        }
    }
}
