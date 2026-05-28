using System;
using System.IO;
using System.Linq;

static class HomeWork5
{
    public static void Run()
    {
        string folderPath = Path.Combine(AppContext.BaseDirectory, "HomeWork", "home5");
        string[] files = Directory.GetFiles(folderPath, "*.txt");

        Console.Write("Введите слово для поиска: ");
        string searchWord = Console.ReadLine() ?? "";

        bool isFound = files.Any(file => File.ReadAllText(file)
            .Split(' ', '.', ',', '!', '?', ':', ';', '-', '\r', '\n')
            .Any(word => word.Equals(searchWord, StringComparison.OrdinalIgnoreCase)));

        Console.WriteLine(isFound);
    }
}
