using Adapter.Adaptee;
using Adapter.Target;
using System;

namespace Adapter.Adapter;

public class RichCompound(string name) : Compound(name)
{
    private ChemicalDataBank _bank;

    public override void Display()
    {
        _bank = new ChemicalDataBank(); // adaptee, this object is the data source

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
