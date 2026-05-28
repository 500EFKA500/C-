using System;
using System.Linq;

static class HomeWork2
{
    public static void Run()
    {
        while (true)
        {
            Console.Write("Введите пароль: ");
            string password = Console.ReadLine() ?? "";

            int numbersCount = password.Count(char.IsDigit);
            int specialSymbolsCount = password.Count(symbol => !char.IsLetterOrDigit(symbol));

            if (password.Length == 5 && numbersCount == 3 && specialSymbolsCount == 1)
            {
                Console.WriteLine("Пароль подходит");
                break;
            }

            Console.WriteLine("Пароль должен состоять из 5 символов, 3 чисел и 1 спецсимвола");
        }
    }
}
