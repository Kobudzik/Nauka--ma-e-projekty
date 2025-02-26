namespace Mediator;

// Mediates the common tasks
public class Mediator
{
    public IComponent Component1 { get; set; }
    public IComponent Component2 { get; set; }

    public void ChangeState(object state)
    {
        Component1.SetState(state);
        Component2.SetState(state);
    }
}
