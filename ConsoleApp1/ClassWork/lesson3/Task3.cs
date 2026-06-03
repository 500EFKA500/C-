using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace ClassWork.Lesson3;

class GameState
{
    public int Level { get; set; }
    public int Health { get; set; }
    public List<string> Inventory { get; set; } = new List<string>();
}

static class Task3
{
    public static void Run()
    {
        GameState gameState = new GameState
        {
            Level = 5,
            Health = 80,
            Inventory = new List<string> { "Sword", "Shield", "Potion" }
        };

        JsonSerializerOptions options = new JsonSerializerOptions
        {
            WriteIndented = true
        };

        string filePath = Path.Combine(AppContext.BaseDirectory, "gameState.json");
        string json = JsonSerializer.Serialize(gameState, options);

        File.WriteAllText(filePath, json);
        Console.WriteLine("Игра сохранена:");
        Console.WriteLine(json);

        string loadedJson = File.ReadAllText(filePath);
        GameState? loadedGameState = JsonSerializer.Deserialize<GameState>(loadedJson);

        if (loadedGameState == null)
        {
            Console.WriteLine("Не удалось загрузить игру");
            return;
        }

        Console.WriteLine("Игра загружена:");
        Console.WriteLine($"Уровень: {loadedGameState.Level}");
        Console.WriteLine($"Здоровье: {loadedGameState.Health}");
        Console.WriteLine($"Инвентарь: {string.Join(", ", loadedGameState.Inventory)}");
    }
}
