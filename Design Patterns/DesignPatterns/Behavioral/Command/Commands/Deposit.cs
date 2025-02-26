using System;

namespace Command.Commands;

public class Deposit(int id, Account account, decimal amount) : ITransaction
{
    public int Id { get; set; } = id;
    public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
    public CommandState Status { get; set; } = CommandState.Unprocessed;

    public void Execute()
    {
        account.Balance += amount;
        Status = CommandState.ExecuteSucceeded;
    }

    public void Undo()
    {
        if (account.Balance >= amount)
        {
            account.Balance -= amount;

            Status = CommandState.UndoSucceeded;
        }
        else
        {
            Status = CommandState.UndoFailed;
        }
    }
}
