using System;

static class Lesson3
{
    public static void Run()
    {
        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("Урок 3");
            Console.WriteLine("1 - Сериализация Settings в JSON");
            Console.WriteLine("2 - Сериализация словаря товаров в JSON");
            Console.WriteLine("3 - Сохранение и загрузка GameState");
            Console.WriteLine("4 - Логгер с уровнями");
            Console.WriteLine("0 - Назад");
            Console.Write("Выберите задание: ");

            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ClassWork.Lesson3.Task1.Run();
                    break;

                case "2":
                    ClassWork.Lesson3.Task2.Run();
                    break;

                case "3":
                    ClassWork.Lesson3.Task3.Run();
                    break;

                case "4":
                    ClassWork.Lesson3.Task4.Run();
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
