namespace EquipmentComposite.Component;

public abstract class EquipmentObject
{
    public float Weight { get; set; }

    public abstract float GetTotalWeight();
    public abstract void GetDescription(int indentation);
}