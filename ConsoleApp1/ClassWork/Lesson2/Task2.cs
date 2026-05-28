using System;
using System.Linq;

static class Task2
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

        Console.Write("Введите минимальную длину строки: ");
        if (!int.TryParse(Console.ReadLine(), out int minLength) || minLength < 0)
        {
            Console.WriteLine("Минимальная длина должна быть неотрицательным целым числом");
            return;
        }

        var selected = lines
            .Where(s => s.Length >= minLength)
            .OrderBy(s => s.Length)
            .ThenBy(s => s);

        int totalCount = lines.Length;
        int selectedCount = selected.Count();
        double averageLength = lines.Average(s => s.Length);
        string shortest = lines.OrderBy(s => s.Length).FirstOrDefault() ?? "";
        string longest = lines.OrderByDescending(s => s.Length).FirstOrDefault() ?? "";

        Console.WriteLine();
        Console.WriteLine($"Всего строк: {totalCount}");
        Console.WriteLine($"Средняя длина строк: {averageLength:F2}");
        Console.WriteLine($"Самая короткая строка: \"{shortest}\"");
        Console.WriteLine($"Самая длинная строка: \"{longest}\"");
        Console.WriteLine($"Количество строк длиной не менее {minLength}: {selectedCount}");
        Console.WriteLine($"Отфильтрованные строки (по возрастанию длины): {string.Join(", ", selected.Select(s => $"\"{s}\""))}");
    }
}