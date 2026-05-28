using System;

static class HomeWork3
{
    public static void Run()
    {
        BankUser user = new BankUser("Пользователь");
        BankAccount debitAccount = new DebitAccount(10000);
        BankAccount savingsAccount = new SavingsAccount(2500);

        Console.WriteLine($"Клиент: {user.Name}");
        Console.WriteLine("Счета до перевода:");
        debitAccount.ShowInfo();
        savingsAccount.ShowInfo();

        Console.Write("Введите сумму перевода с дебетового счета на накопительный: ");

        if (!decimal.TryParse(Console.ReadLine(), out decimal amount))
        {
            Console.WriteLine("Нужно ввести число");
            return;
        }

        user.Transfer(debitAccount, savingsAccount, amount);

        Console.WriteLine("Счета после перевода:");
        debitAccount.ShowInfo();
        savingsAccount.ShowInfo();
    }
}
