using System;
using System.Linq;

static class Task1
{
    public static void Run()
    {
        Console.Write("Введите размер массива: ");
        if (!int.TryParse(Console.ReadLine(), out int size) || size <= 0)
        {
            Console.WriteLine("Размер массива должен быть положительным целым числом");
            return;
        }

        int[] numbers = new int[size];

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"Введите число {i + 1}: ");
            if (!int.TryParse(Console.ReadLine(), out numbers[i]))
            {
                Console.WriteLine("Нужно ввести целое число");
                return;
            }
        }

        var result = numbers
            .Where(n => n % 2 == 0)
            .OrderBy(n => n)
            .Select(n => n * n);

        int evenSum = numbers
            .Where(n => n % 2 == 0)
            .Sum();

        int min = numbers.Min();
        int max = numbers.Max();

        Console.WriteLine();
        Console.WriteLine($"Сумма четных чисел: {evenSum}");
        Console.WriteLine($"Минимальное число: {min}");
        Console.WriteLine($"Максимальное число: {max}");
        Console.WriteLine($"Квадраты четных чисел по возрастанию: {string.Join(", ", result)}");
    }
}
