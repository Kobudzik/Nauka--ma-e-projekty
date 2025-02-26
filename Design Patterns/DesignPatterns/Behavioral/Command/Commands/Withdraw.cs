using System;

namespace Command.Commands;

public class Withdraw(int id, Account account, decimal amount) : ITransaction
{
    public int Id { get; set; } = id;
    public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
    public CommandState Status { get; set; } = CommandState.Unprocessed;

    public void Execute()
    {
        if (account.Balance >= amount)
        {
            account.Balance -= amount;

            Status = CommandState.ExecuteSucceeded;
        }
        else
        {
            Status = CommandState.ExecuteFailed;
        }
    }

    public void Undo()
    {
        account.Balance += amount;

        Status = CommandState.UndoSucceeded;
    }
}