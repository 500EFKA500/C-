using System;

static class Lesson1
{
    public static void Run()
    {
        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("Урок 1");
            Console.WriteLine("1 - Сортировка 5 строк по алфавиту");
            Console.WriteLine("2 - Сортировка txt файла по алфавиту");
            Console.WriteLine("3 - Шифратор Цезаря");
            Console.WriteLine("0 - Назад");
            Console.Write("Выберите задание: ");

            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Zadanie1.Run();
                    break;

                case "2":
                    Zadanie2.Run();
                    break;

                case "3":
                    Zadanie3.Run();
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
