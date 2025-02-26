using EquipmentComposite.Component;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EquipmentComposite.Composite;

public class EquipmentContainer(int containerId) : EquipmentObject
{
    public int ContainerId { get; set; } = containerId;
    public List<EquipmentObject> ObjectList { get; set; } = [];

    new private float Weight => GetTotalWeight();

    public override void GetDescription(int indentation)
    {
        Console.WriteLine();

        Console.WriteLine(string.Format(
            "{0}> ContainerId: {1}, Weight: {2}kg (Composite)",
            new string('-', indentation),
            ContainerId,
            Weight)
        );

        foreach (var eqObject in ObjectList)
            eqObject.GetDescription(indentation + 1);
    }

    public override float GetTotalWeight()
    {
        float totalWeight = 0;

        foreach (var eqObject in ObjectList)
            totalWeight += eqObject.GetTotalWeight();

        return totalWeight;
    }

    public EquipmentContainer FindContainer(int containerId)
    {
        if (ContainerId == containerId)
            return this;

        foreach (var innerContainer in ObjectList.OfType<EquipmentContainer>())
            return innerContainer.FindContainer(containerId);

        return null;
    }

    public EquipmentContainer FindLighterContainer(EquipmentContainer container)
    {
        if (Weight < container.Weight)
            container = this;

        foreach (var innerContainer in ObjectList.OfType<EquipmentContainer>())
        {
            container = innerContainer.FindLighterContainer(container);
        }

        return container;
    }
}