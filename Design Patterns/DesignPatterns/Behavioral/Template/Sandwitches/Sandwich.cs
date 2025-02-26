using System;

namespace Template.Hoagies;

public abstract class Sandwich
{
    public void MakeSandwitch()
    {
        CutBun();

        if (CustomerWantsMeat())
        {
            AddMeat();
            Console.WriteLine();
        }

        if (CustomerWantsCheese())
        {
            AddCheese();
            Console.WriteLine();
        }

        if (CustomerWantsVegetables())
        {
            AddVegetables();
            Console.WriteLine();
        }

        if (CustomerWantsCondiments())
        {
            AddCondiments();
            Console.WriteLine();
        }

        WrapTheHoogie();
    }

    public void CutBun()
    {
        Console.WriteLine("The Hoogie is cut!");
    }

    public abstract void AddMeat();
    public abstract void AddCheese();
    public abstract void AddVegetables();
    public abstract void AddCondiments();

    public virtual bool CustomerWantsMeat()
    {
        return true;
    }

    public virtual bool CustomerWantsCheese()
    {
        return true;
    }

    public virtual bool CustomerWantsVegetables()
    {
        return true;
    }

    public virtual bool CustomerWantsCondiments()
    {
        return true;
    }

    public void WrapTheHoogie()
    {
        Console.WriteLine("Wrapping the Hoogie!");
    }
}