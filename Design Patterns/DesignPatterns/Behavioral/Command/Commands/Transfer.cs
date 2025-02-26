using System;

namespace Command.Commands;

public class Transfer(int id, Account fromAccount, Account toAccount, decimal amount) : ITransaction
{
    public int Id { get; set; } = id;
    public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
    public CommandState Status { get; set; } = CommandState.Unprocessed;

    public void Execute()
    {
        if (fromAccount.Balance >= amount)
        {
            fromAccount.Balance -= amount;
            toAccount.Balance += amount;

            Status = CommandState.ExecuteSucceeded;
        }
        else
        {
            Status = CommandState.ExecuteFailed;
        }
    }

    public void Undo()
    {
        // Remove the money from the original "to" account,
        // and add it back to the original "from" account.
        if (toAccount.Balance >= amount)
        {
            toAccount.Balance -= amount;
            fromAccount.Balance += amount;

            Status = CommandState.UndoSucceeded;
        }
        else
        {
            Status = CommandState.UndoFailed;
        }
    }
}