namespace Command;

public enum CommandState
{
    Unprocessed,
    ExecuteFailed,
    ExecuteSucceeded,
    UndoFailed,
    UndoSucceeded
}
