using System;
using System.Linq;

static class HomeWork4
{
    public static void Run()
    {
        string[] words = { "banana", "apple", "orange", "grape", "lemon" };

        var sortedWords = words.OrderBy(word => word);

        Console.WriteLine("Массив строк:");
        Console.WriteLine(string.Join(", ", words));

        Console.WriteLine("Отсортированный массив строк:");
        Console.WriteLine(string.Join(", ", sortedWords));
    }
}
