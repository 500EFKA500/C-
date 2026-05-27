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
            Console.WriteLine("0 - Назад");
            Console.Write("Выберите задание: ");

            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Lesson2Task1.Run();
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
