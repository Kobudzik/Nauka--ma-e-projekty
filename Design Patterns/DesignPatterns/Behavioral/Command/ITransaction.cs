using System;

namespace DesignPatterns.Command
{
    public interface ITransaction
    {
        void Execute();

        int ID { get; set; }
        DateTime CreatedOn { get; set; }
        CommandState Status { get; set; }
        void Undo();
    }
}
