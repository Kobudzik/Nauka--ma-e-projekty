using System;

namespace CompositeDesignPattern
{
    class EquipmentManager
    {

        public EquipmentManager(Equipment equipment)
        {
            this.equipment = equipment;
        }

        private Equipment equipment;

        public void AddItem(EquipmentObject obj, int? containerId = null)
        {
            if(containerId == null)
            {
                var container = equipment.FindLightestContainer();
                equipment.AddObject(obj, container.ContainerId);
            }
            else
                equipment.AddObject(obj, containerId.Value);
        }


        public void GetSummary()
        {
            Console.WriteLine("Your backpack (container 0) contains:");

            foreach (var eqObject in equipment._objectList)
                eqObject.GetDescription(0);
        }
    }
}
