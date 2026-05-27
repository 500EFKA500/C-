using System;
using System.IO;

static class Zadanie2
{
    public static void Run()
    {
        // Console.Write("Введите путь к txt файлу: ");
        // string? path = Console.ReadLine();
        //
        // if (string.IsNullOrWhiteSpace(path))
        // {
        //     Console.WriteLine("Пу2
        // ть к файлу не указан");
        //     return;
        // }
        //
        // path = path.Trim('"');
        //
        // if (!File.Exists(path))
        // {
        //     Console.WriteLine("Файл не найден");
        //     return;
        // }
        //
        // if (!string.Equals(Path.GetExtension(path), ".txt", StringComparison.OrdinalIgnoreCase))
        // {
        //     Console.WriteLine("Нужен файл с расширением .txt");
        //     return;
        // }
        
        try
        {
            string[] lines = File.ReadAllLines("NewFile1.txt");
            Array.Sort(lines, StringComparer.CurrentCulture);
            File.WriteAllLines("NewFile1.txt", lines);

            Console.WriteLine($"Файл отсортирован по алфавиту и сохранен. Строк обработано: {lines.Length}");
        }
        catch (Exception ex) when (ex is IOException or UnauthorizedAccessException)
        {
            Console.WriteLine($"Ошибка при работе с файлом: {ex.Message}");
        }
    }
}
