using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Adapter
{
    /// <summary>
    /// The 'Adapter' class
    /// </summary>
    public class RichCompound : Compound
    {
        private ChemicalDatabank _bank;

        // Constructor
        public RichCompound(string name)
          : base(name)
        {
        }

        public override void Display()
        {
            // The Adaptee
            _bank = new ChemicalDatabank(); // z tego obiektu wyciąga dane

            _boilingPoint = _bank.GetCriticalPoint(_chemicalName, "B");
            _meltingPoint = _bank.GetCriticalPoint(_chemicalName, "M");
            _molecularWeight = _bank.GetMolecularWeight(_chemicalName);
            _molecularFormula = _bank.GetMolecularStructure(_chemicalName);

            base.Display();
            Console.WriteLine(" Formula: {0}", _molecularFormula);
            Console.WriteLine(" Weight : {0}", _molecularWeight);
            Console.WriteLine(" Melting Pt: {0}", _meltingPoint);
            Console.WriteLine(" Boiling Pt: {0}", _boilingPoint);
        }
    }
}
