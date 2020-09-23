namespace _2._1_Mediator
{
    // Mediates the common tasks
    public class Mediator
    {
        public IComponent Component1 { get; set; }
        public IComponent Component2 { get; set; }

        public void ChangeState(object state)
        {
            this.Component1.SetState(state);
            this.Component2.SetState(state);
        }
    }
}
