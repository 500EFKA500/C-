using System;
using System.IO;
using System.Text.Json;

namespace ClassWork.Lesson3;

class Settings
{
    public string Theme { get; set; } = "";
    public int FontSize { get; set; }
    public bool NotificationsEnabled { get; set; }
}

static class Task1
{
    public static void Run()
    {
        Settings settings = new Settings
        {
            Theme = "Dark",
            FontSize = 16,
            NotificationsEnabled = true
        };

        JsonSerializerOptions options = new JsonSerializerOptions
        {
            WriteIndented = true
        };

        string json = JsonSerializer.Serialize(settings, options);
        string filePath = Path.Combine(AppContext.BaseDirectory, "settings.json");

        File.WriteAllText(filePath, json);

        Console.WriteLine("Объект Settings сериализован в JSON:");
        Console.WriteLine(json);
        Console.WriteLine($"Файл сохранен: {filePath}");

        string loadedJson = File.ReadAllText(filePath);
        Settings? loadedSettings = JsonSerializer.Deserialize<Settings>(loadedJson);

        if (loadedSettings == null)
        {
            Console.WriteLine("Не удалось загрузить Settings");
            return;
        }

        Console.WriteLine("Объект Settings загружен из JSON:");
        Console.WriteLine($"Theme: {loadedSettings.Theme}");
        Console.WriteLine($"FontSize: {loadedSettings.FontSize}");
        Console.WriteLine($"NotificationsEnabled: {loadedSettings.NotificationsEnabled}");
    }
}
