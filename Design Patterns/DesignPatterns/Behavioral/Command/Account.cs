namespace Command;

public class Account(string ownerName, decimal balance)
{
    public string OwnerName { get; set; } = ownerName;
    public decimal Balance { get; set; } = balance;
}
