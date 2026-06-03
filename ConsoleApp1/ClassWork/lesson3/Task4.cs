using System;
using System.IO;

namespace ClassWork.Lesson3;

class FileLogger
{
    private readonly string filePath;

    public FileLogger(string filePath)
    {
        this.filePath = filePath;
    }

    public void LogInfo(string message)
    {
        WriteLog("INFO", message);
    }

    public void LogWarning(string message)
    {
        WriteLog("WARNING", message);
    }

    public void LogError(string message)
    {
        WriteLog("ERROR", message);
    }

    private void WriteLog(string level, string message)
    {
        string logText = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} [{level}] {message}";
        File.AppendAllText(filePath, logText + Environment.NewLine);
    }
}

static class Task4
{
    public static void Run()
    {
        string filePath = Path.Combine(AppContext.BaseDirectory, "log.txt");
        FileLogger logger = new FileLogger(filePath);

        logger.LogInfo("Программа запущена");
        logger.LogWarning("Это предупреждение");
        logger.LogError("Произошла ошибка");

        Console.WriteLine($"Логи записаны в файл: {filePath}");
    }
}
