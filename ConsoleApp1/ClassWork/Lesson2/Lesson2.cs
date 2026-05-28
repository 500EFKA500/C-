using System;

static class Lesson2
{
    public static void Run()
    {
        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("Урок 2");
            Console.WriteLine("1 - Сумма четных чисел, максимум и минимум массива");
            Console.WriteLine("2 - Выбор строки длинной");
            Console.WriteLine("3 - Сортировка по алфавиту и подсчет букв 'a'");
            Console.WriteLine("0 - Назад");
            Console.Write("Выберите задание: ");

            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Task1.Run();
                    break;
                case "2":
                    Task2.Run();
                    break;
                case "3":
                    Task3.Run();
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Неверный выбор");
                    break;
            }
        }
    }
}
