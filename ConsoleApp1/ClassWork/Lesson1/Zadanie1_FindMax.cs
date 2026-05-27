using System;

static class Zadanie1
{
    public static void Run()
    {
        string[] lines = new string[5];

        Console.WriteLine("Введите 5 строк:");

        for (int i = 0; i < lines.Length; i++)
        {
            Console.Write($"{i + 1}: ");
            lines[i] = Console.ReadLine() ?? string.Empty;
        }

        Array.Sort(lines, StringComparer.CurrentCulture);

        Console.WriteLine();
        Console.WriteLine("Отсортированные строки:");
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }

        Console.WriteLine();
        Console.WriteLine($"Максимальное поколение GC: {GC.MaxGeneration}");
        Console.WriteLine($"Занятая память до очистки: {GC.GetTotalMemory(false)} байт");

        GC.Collect();

        Console.WriteLine($"Занятая память после очистки: {GC.GetTotalMemory(true)} байт");
    }
}
