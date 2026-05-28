using System;

class BankUser
{
    public string Name { get; }

    public BankUser(string name)
    {
        Name = name;
    }

    public void Transfer(BankAccount fromAccount, BankAccount toAccount, decimal amount)
    {
        if (fromAccount.Withdraw(amount))
        {
            toAccount.Deposit(amount);
            Console.WriteLine("Перевод выполнен");
        }
        else
        {
            Console.WriteLine("Перевод не выполнен. Проверьте сумму и баланс счета");
        }
    }
}
