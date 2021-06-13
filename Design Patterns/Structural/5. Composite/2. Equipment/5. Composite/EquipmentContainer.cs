using System;
using System.Collections.Generic;
using System.Linq;

namespace CompositeDesignPattern
{
    public class EquipmentContainer : EquipmentObject
    {
        public EquipmentContainer(int containerId)
        {
            ObjectList = new List<EquipmentObject>();
            ContainerId = containerId;
        }

        public int ContainerId { get; set; }
        public List<EquipmentObject> ObjectList { get; set; }

        private float Weight
        {
            get
            {
                return GetWeight();
            }
        }

        public override void GetDescription(int indentation)
        {
            Console.WriteLine();

            Console.WriteLine(string.Format(
                "{0}> ContainerId: {1}, Weight: {2}kg (Composite)",
                new String('-', indentation),
                ContainerId,
                Weight));

            foreach (var eqObject in ObjectList)
                eqObject.GetDescription(indentation + 1);
        }

        public override float GetWeight()
        {
            float totalWeight = 0;

            foreach (var eqObject in ObjectList)
                totalWeight += eqObject.GetWeight();

            return totalWeight;
        }

        public EquipmentContainer FindContainer(int containerId)
        {
            if (ContainerId == containerId)
                return this;

            foreach(var innerContainer in ObjectList.OfType<EquipmentContainer>())
                return innerContainer.FindContainer(containerId);

            return null;
        }

        public EquipmentContainer FindLighterContainer(EquipmentContainer container)
        {
            if (Weight < container.Weight)
                container = this;

            foreach (var innerContainer in ObjectList.OfType<EquipmentContainer>())
            {
                container =  innerContainer.FindLighterContainer(container);
            }

            return container;
        }
    }
}