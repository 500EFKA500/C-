using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace ClassWork.Lesson3;

static class Task2
{
    public static void Run()
    {
        Dictionary<string, int> products = new Dictionary<string, int>
        {
            { "Apple", 15 },
            { "Bread", 7 },
            { "Milk", 10 },
            { "Cheese", 4 }
        };

        JsonSerializerOptions options = new JsonSerializerOptions
        {
            WriteIndented = true
        };

        string json = JsonSerializer.Serialize(products, options);
        string filePath = Path.Combine(AppContext.BaseDirectory, "products.json");

        File.WriteAllText(filePath, json);

        Console.WriteLine("Словарь товаров сериализован в JSON:");
        Console.WriteLine(json);
        Console.WriteLine($"Файл сохранен: {filePath}");

        string loadedJson = File.ReadAllText(filePath);
        Dictionary<string, int>? loadedProducts = JsonSerializer.Deserialize<Dictionary<string, int>>(loadedJson);

        if (loadedProducts == null)
        {
            Console.WriteLine("Не удалось загрузить товары");
            return;
        }

        Console.WriteLine("Словарь товаров загружен из JSON:");

        foreach (var product in loadedProducts)
        {
            Console.WriteLine($"{product.Key}: {product.Value}");
        }
    }
}
