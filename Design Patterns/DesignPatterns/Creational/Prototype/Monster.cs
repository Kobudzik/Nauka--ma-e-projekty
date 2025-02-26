using System.Collections.Generic;

namespace Prototype;

public class Monster
{
    public string Name { get; }
    public int HitPoints { get; private set; }
    public List<LootTableEntry> LootTable { get; set; }

    // Public constructor, called to create the prototype Monster object.
    public Monster(string name, int hitPoints)
    {
        Name = name;
        HitPoints = hitPoints;

        // In this part, pretend we are populating LootTable using a database query.
        LootTable =
        [
            new() { ItemID = 1, DropPercentage = 10 },
            new() { ItemID = 2, DropPercentage = 5 },
            new() { ItemID = 5, DropPercentage = 1 },
            new() { ItemID = 12, DropPercentage = 50 },
            new() { ItemID = 27, DropPercentage = 33 },
            new() { ItemID = 42, DropPercentage = 100 }
        ];
    }

    // Private constructor called by Clone method.
    // Does not need to connect to the database to populate the LootTable property.
    private Monster(string name, int hitPoints, List<LootTableEntry> lootTable)
    {
        Name = name;
        HitPoints = hitPoints;
        LootTable = lootTable;
    }

    public void ApplyDamage(int amountOfDamage)
    {
        HitPoints -= amountOfDamage;
    }

    public Monster Clone()
    {
        // This version of Clone calls the private constructor,
        // to prevent re-running the database query to populate LootTable.
        return new Monster(Name, HitPoints, LootTable);
    }
}
