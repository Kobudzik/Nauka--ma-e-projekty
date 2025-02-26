using System;

namespace Template.Hoagies;

class VeggieSandwich : Sandwich
{
    readonly string[] veggiesUsed = ["Lettuce", "Tomatoes", "Onions", "Sweet Peppers"];
    readonly string[] condimentsUsed = ["Oil", "Vinegar"];

    public override void AddCheese()
    {
    }

    public override void AddMeat()
    {
    }

    public override void AddCondiments()
    {
        Console.WriteLine("Adding the condiments: ");
        foreach (string condiments in condimentsUsed)
            Console.WriteLine(condiments + " ");
    }

    public override void AddVegetables()
    {
        Console.WriteLine("Adding the vegetables: ");
        foreach (string vegetables in veggiesUsed)
            Console.WriteLine(vegetables + " ");
    }

    public void MakeSandwitch()
    {
        CutBun();
    }

    public override bool CustomerWantsMeat()
    {
        return true;
    }

    public override bool CustomerWantsCheese()
    {
        return true;
    }
}
