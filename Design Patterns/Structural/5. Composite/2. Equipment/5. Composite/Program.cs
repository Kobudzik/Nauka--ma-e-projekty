using System;

namespace CompositeDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var equipment = new Equipment();
            var equipmentManager = new EquipmentManager(equipment);


            #region containers
            var container1 = new EquipmentContainer(1);
            var container2 = new EquipmentContainer(2);
            var container3 = new EquipmentContainer(3);

            equipmentManager.AddItem(container1, 0);
            equipmentManager.AddItem(container2, 1);
            equipmentManager.AddItem(container3, 2);
            #endregion containers

            #region items
            var sword = new EquipmentItem("Sword", 12.6f);
            var bow = new EquipmentItem("Bow", 3.6f);
            var bracelet = new EquipmentItem("Bracelet", 1f);

            equipmentManager.AddItem(sword, 2);
            equipmentManager.AddItem(sword, 2);
            equipmentManager.AddItem(bow, 0);
            #endregion

            equipmentManager.AddItem(bracelet);
            equipmentManager.GetSummary();

            Console.ReadKey();
        }
    }
}
