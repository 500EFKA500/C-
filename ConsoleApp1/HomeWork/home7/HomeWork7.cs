using System;

static class HomeWork7
{
    public static void Run()
    {
        Validator<string> passwordValidator = new Validator<string>();

        passwordValidator.AddRule(password => password.Length >= 5);
        passwordValidator.AddRule(password => password.Any(char.IsDigit));
        passwordValidator.AddRule(password => password.Any(symbol => !char.IsLetterOrDigit(symbol)));

        Console.Write("Введите пароль для проверки: ");
        string password = Console.ReadLine() ?? "";

        bool isValid = passwordValidator.Validate(password);

        Console.WriteLine(isValid);
    }
}
