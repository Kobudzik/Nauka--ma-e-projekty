using EquipmentComposite.Component;
using System;

namespace EquipmentComposite.Leaf;

public class EquipmentItem : EquipmentObject
{
    public EquipmentItem(string name, float weight)
    {
        Weight = weight;
        Name = name;
    }

    public string Name { get; set; }

    public override void GetDescription(int indentation)
    {
        Console.WriteLine();

        Console.WriteLine(string.Format(
          "{0}> Name: {1}, Weight: {2}kg (Leaf) ",
          new string('-', indentation),
          Name,
          Weight));
    }

    public override float GetTotalWeight() => Weight;
}