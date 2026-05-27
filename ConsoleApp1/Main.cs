using System;

class MainProgram
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("Выбор раздела");
            Console.WriteLine("1 - Домашняя работа");
            Console.WriteLine("2 - Классная работа");
            Console.WriteLine("0 - Выход");
            Console.Write("Выберите раздел: ");

            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ShowHomeWorkMenu();
                    break;

                case "2":
                    ShowClassWorkMenu();
                    break;

                case "0":
                    return;

                default:
                    Console.WriteLine("Неверный выбор");
                    break;
            }
        }
    }

    private static void ShowHomeWorkMenu()
    {
        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("Домашняя работа");
            Console.WriteLine("0 - Назад");
            Console.Write("Выберите домашнее задание: ");

            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "0":
                    return;

                default:
                    Console.WriteLine("Домашних заданий пока нет");
                    break;
            }
        }
    }

    private static void ShowClassWorkMenu()
    {
        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("Классная работа");
            Console.WriteLine("1 - Урок 1");
            Console.WriteLine("2 - Урок 2");
            Console.WriteLine("0 - Назад");
            Console.Write("Выберите урок: ");

            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Lesson1.Run();
                    break;

                case "2":
                    Lesson2.Run();
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
