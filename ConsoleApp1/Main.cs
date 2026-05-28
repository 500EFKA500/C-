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
            Console.WriteLine("1 - Собрать слово из 3 файлов");
            Console.WriteLine("2 - Проверка пароля");
            Console.WriteLine("3 - Банковский перевод");
            Console.WriteLine("4 - Сортировка строк по алфавиту");
            Console.WriteLine("5 - Поиск слова в txt файлах");
            Console.WriteLine("6 - Делегат и событие");
            Console.WriteLine("7 - Validator<T>");
            Console.WriteLine("8 - Enum и Flags");
            Console.WriteLine("0 - Назад");
            Console.Write("Выберите домашнее задание: ");

            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    string word = HomeWork1Part1.Text + HomeWork1Part2.Text + HomeWork1Part3.Text;
                    Console.WriteLine($"Слово целиком: {word}");
                    break;

                case "2":
                    HomeWork2.Run();
                    break;

                case "3":
                    HomeWork3.Run();
                    break;

                case "4":
                    HomeWork4.Run();
                    break;

                case "5":
                    HomeWork5.Run();
                    break;

                case "6":
                    HomeWork6.Run();
                    break;

                case "7":
                    HomeWork7.Run();
                    break;

                case "8":
                    HomeWork8.Run();
                    break;

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
