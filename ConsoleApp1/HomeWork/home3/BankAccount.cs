using System;

class BankAccount
{
    public string Name { get; }
    public decimal Balance { get; protected set; }

    public BankAccount(string name, decimal balance)
    {
        Name = name;
        Balance = balance;
    }

    public bool Withdraw(decimal amount)
    {
        if (amount <= 0 || amount > Balance)
        {
            return false;
        }

        Balance -= amount;
        return true;
    }

    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            Balance += amount;
        }
    }

    public virtual void ShowInfo()
    {
        Console.WriteLine($"{Name}: {Balance} руб.");
    }
}
