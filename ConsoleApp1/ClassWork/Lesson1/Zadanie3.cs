using System;
using System.IO;

static class Zadanie3
{
    public static void Run()
    {
        // Console.Write("Введите путь к исходному файлу: ");
        // string? inputPath = Console.ReadLine();
        //
        // if (string.IsNullOrWhiteSpace(inputPath))
        // {
        //     Console.WriteLine("Путь к исходному файлу не указан");
        //     return;
        // }
        //
        // inputPath = inputPath.Trim('"');
        //
        // if (!File.Exists(inputPath))
        // {
        //     Console.WriteLine("Исходный файл не найден");
        //     return;
        // }
        //
        // Console.Write("Введите путь к файлу для сохранения результата: ");
        // string? outputPath = Console.ReadLine();
        //
        // if (string.IsNullOrWhiteSpace(outputPath))
        // {
        //     Console.WriteLine("Путь к файлу результата не указан");
        //     return;
        // }
        //
        // outputPath = outputPath.Trim('"');

        Console.Write("Введите сдвиг: ");
        if (!int.TryParse(Console.ReadLine(), out int shift))
        {
            Console.WriteLine("Сдвиг должен быть целым числом");
            return;
        }

        try
        {
            string text = File.ReadAllText("NewFile1.txt");
            string encryptedText = EncryptCaesar(text, shift);
            File.WriteAllText("NewFile1.txt", encryptedText);

            Console.WriteLine("Текст зашифрован и сохранен в другой файл");
        }
        catch (Exception ex) when (ex is IOException or UnauthorizedAccessException)
        {
            Console.WriteLine($"Ошибка при работе с файлом: {ex.Message}");
        }
    }

    private static string EncryptCaesar(string text, int shift)
    {
        char[] result = new char[text.Length];

        for (int i = 0; i < text.Length; i++)
        {
            result[i] = ShiftChar(text[i], shift);
        }

        return new string(result);
    }

    private static char ShiftChar(char symbol, int shift)
    {
        if (symbol >= 'A' && symbol <= 'Z')
        {
            return ShiftInAlphabet(symbol, 'A', 26, shift);
        }

        if (symbol >= 'a' && symbol <= 'z')
        {
            return ShiftInAlphabet(symbol, 'a', 26, shift);
        }

        if (symbol >= 'А' && symbol <= 'Я')
        {
            return ShiftInAlphabet(symbol, 'А', 32, shift);
        }

        if (symbol >= 'а' && symbol <= 'я')
        {
            return ShiftInAlphabet(symbol, 'а', 32, shift);
        }

        return symbol;
    }

    private static char ShiftInAlphabet(char symbol, char firstLetter, int alphabetLength, int shift)
    {
        int index = symbol - firstLetter;
        int shiftedIndex = (index + shift) % alphabetLength;

        if (shiftedIndex < 0)
        {
            shiftedIndex += alphabetLength;
        }

        return (char)(firstLetter + shiftedIndex);
    }
}
