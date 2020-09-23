using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Adapter
{
    /// <summary>
    /// The 'Target' class
    /// </summary>
    public class Compound
    {
        protected string _chemicalName;
        protected float _boilingPoint;
        protected float _meltingPoint;
        protected double _molecularWeight;
        protected string _molecularFormula;

        // Constructor
        public Compound(string chemicalName)
        {
            this._chemicalName = chemicalName;
        }

        //this will be overrided by adapter
        public virtual void Display()
        {
            Console.WriteLine("\n Compound: {0} ------ ", _chemicalName);
        }
    }
}
