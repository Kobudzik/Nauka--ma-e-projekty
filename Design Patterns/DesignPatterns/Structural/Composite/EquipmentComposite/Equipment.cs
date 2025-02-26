using EquipmentComposite.Component;
using EquipmentComposite.Composite;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EquipmentComposite;

public class Equipment
{
    public List<EquipmentObject> ObjectList { get; set; } = [];

    public void AddObject(EquipmentObject equipmentObject, int containerId)
    {
        if (containerId == 0)
        {
            ObjectList.Add(equipmentObject);
        }
        else
        {
            FindLightestContainer().ObjectList.Add(equipmentObject);
        }
    }

    public EquipmentContainer FindContainer(int containerId)
    {
        var mainContainers = ObjectList
               .OfType<EquipmentContainer>()
               .ToList();

        foreach (var container in mainContainers)
        {
            var containerFound = container.FindContainer(containerId);

            if (containerFound == null)
                throw new ApplicationException($"Container with id {containerId} not found.");

            return containerFound;
        }

        throw new ApplicationException($"Container with id {containerId} not found.");
    }

    public EquipmentContainer FindLightestContainer()
    {
        var mainContainers = ObjectList
               .OfType<EquipmentContainer>()
               .ToList();

        EquipmentContainer lightestContainer = mainContainers.OrderBy(x => x.Weight).FirstOrDefault();

        if (lightestContainer == null)
            throw new ApplicationException("No containers in EQ");

        foreach (var container in mainContainers)
            lightestContainer = container.FindLighterContainer(lightestContainer);

        return lightestContainer;
    }
}