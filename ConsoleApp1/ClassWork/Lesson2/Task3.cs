using System;
using System.Linq;

static class Task3
{
    public static void Run()
    {
        Console.Write("Введите количество строк: ");
        if (!int.TryParse(Console.ReadLine(), out int count) || count <= 0)
        {
            Console.WriteLine("Количество строк должно быть положительным целым числом");
            return;
        }

        string[] lines = new string[count];

        for (int i = 0; i < lines.Length; i++)
        {
            Console.Write($"Введите строку {i + 1}: ");
            lines[i] = Console.ReadLine() ?? "";
        }

        var sorted = lines.OrderBy(s => s).ToArray();
        int totalA = lines.Sum(s => s.Count(c => c == 'а'));

        Console.WriteLine();
        Console.WriteLine($"Общее количество буквы 'а' во всех строках: {totalA}");
        Console.WriteLine("Строки в алфавитном порядке:");
        for (int i = 0; i < sorted.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {sorted[i]}");
        }
    }
}