using System;

namespace Command;

public interface ITransaction
{
    void Execute();

    int Id { get; set; }
    DateTime CreatedOn { get; set; }
    CommandState Status { get; set; }
    void Undo();
}
