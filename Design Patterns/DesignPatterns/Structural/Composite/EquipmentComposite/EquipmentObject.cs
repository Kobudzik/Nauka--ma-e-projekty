namespace CompositeDesignPattern
{
    public abstract class EquipmentObject
    {
        public float Weight { get; set; }

        public abstract float GetWeight();
        public abstract void GetDescription(int indentation);
    }
}