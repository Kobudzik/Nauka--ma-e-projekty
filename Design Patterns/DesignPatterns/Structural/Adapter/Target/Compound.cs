using System;

namespace Adapter.Target;

/// <summary>
/// The 'Target' class
/// </summary>
public class Compound(string chemicalName)
{
    protected string _chemicalName = chemicalName;
    protected float _boilingPoint;
    protected float _meltingPoint;
    protected double _molecularWeight;
    protected string _molecularFormula;

    //this will be overridden by adapter
    public virtual void Display()
    {
        Console.WriteLine("\n Compound: {0} ------ ", _chemicalName);
    }
}
