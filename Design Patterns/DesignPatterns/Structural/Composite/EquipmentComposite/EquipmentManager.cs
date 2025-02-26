using EquipmentComposite.Component;
using System;

namespace EquipmentComposite;

class EquipmentManager(Equipment equipment)
{
    private readonly Equipment equipment = equipment;

    public void AddItem(EquipmentObject obj, int? containerId = null)
    {
        if (containerId == null)
        {
            var container = equipment.FindLightestContainer();
            equipment.AddObject(obj, container.ContainerId);
        }
        else
        {
            equipment.AddObject(obj, containerId.Value);
        }
    }

    public void GetSummary()
    {
        Console.WriteLine("Your backpack (container 0) contains:");

        foreach (var eqObject in equipment.ObjectList)
            eqObject.GetDescription(0);
    }
}
