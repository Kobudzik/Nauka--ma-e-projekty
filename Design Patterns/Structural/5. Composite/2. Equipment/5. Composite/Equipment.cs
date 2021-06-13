using System;
using System.Collections.Generic;
using System.Linq;

namespace CompositeDesignPattern
{
    public class Equipment
    {
        public Equipment()
        {
            _objectList = new List<EquipmentObject>();
        }

        internal List<EquipmentObject> _objectList;

        public void AddObject(EquipmentObject eqObject, int containerId)
        {
            if (containerId == 0)
                _objectList.Add(eqObject);
            else
            {
                FindLightestContainer().ObjectList.Add(eqObject);
            }
        }

        public EquipmentContainer FindContainer(int containerId)
        {
            var mainContainers = _objectList
                   .OfType<EquipmentContainer>()
                   .ToList();

            EquipmentContainer containerFound = null;

            foreach (var container in mainContainers)
            {
                containerFound = container.FindContainer(containerId);

                if (containerFound == null)
                    throw new ApplicationException($"Container with id {containerId} not found.");

                return containerFound;
            }
            throw new ApplicationException($"Container with id {containerId} not found.");
        }

        public EquipmentContainer FindLightestContainer()
        {
            var mainContainers = _objectList
                   .OfType<EquipmentContainer>()
                   .ToList();

            EquipmentContainer lightestContainer = null;

            lightestContainer = mainContainers.OrderBy(x=> x.Weight).FirstOrDefault();

            if(lightestContainer == null)
                throw new ApplicationException($"No containers in EQ");

            foreach (var container in mainContainers)
                lightestContainer = container.FindLighterContainer(lightestContainer);

            return lightestContainer;
        }
    }
}