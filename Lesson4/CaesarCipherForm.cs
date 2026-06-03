using System.Globalization;
using System.Text;

namespace Lesson4;

public partial class CaesarCipherForm : Form
{
    public CaesarCipherForm()
    {
        InitializeComponent();
    }

    private void ShiftButton_Click(object? sender, EventArgs e)
    {
        if (!int.TryParse(shiftTextBox.Text, out int shift))
        {
            resultTextBox.Text = "Введите целое число для сдвига";
            return;
        }

        resultTextBox.Text = Encrypt(inputTextBox.Text, shift);
    }

    private void SquareAreaButton_Click(object? sender, EventArgs e)
    {
        if (!TryReadPositiveNumber(squareSideTextBox.Text, out double side))
        {
            areaResultTextBox.Text = "Введите корректную сторону квадрата";
            return;
        }

        areaResultTextBox.Text = $"Площадь квадрата: {GetSquareArea(side):0.##}";
    }

    private void CircleAreaButton_Click(object? sender, EventArgs e)
    {
        if (!TryReadPositiveNumber(circleRadiusTextBox.Text, out double radius))
        {
            areaResultTextBox.Text = "Введите корректный радиус круга";
            return;
        }

        areaResultTextBox.Text = $"Площадь круга: {GetCircleArea(radius):0.##}";
    }

    private void TriangleAreaButton_Click(object? sender, EventArgs e)
    {
        if (!TryReadPositiveNumber(triangleBaseTextBox.Text, out double triangleBase))
        {
            areaResultTextBox.Text = "Введите корректное основание треугольника";
            return;
        }

        if (!TryReadPositiveNumber(triangleHeightTextBox.Text, out double height))
        {
            areaResultTextBox.Text = "Введите корректную высоту треугольника";
            return;
        }

        areaResultTextBox.Text = $"Площадь треугольника: {GetTriangleArea(triangleBase, height):0.##}";
    }

    private static double GetSquareArea(double side)
    {
        return side * side;
    }

    private static double GetCircleArea(double radius)
    {
        return Math.PI * radius * radius;
    }

    private static double GetTriangleArea(double triangleBase, double height)
    {
        return triangleBase * height / 2;
    }

    private static bool TryReadPositiveNumber(string text, out double value)
    {
        text = text.Replace(',', '.');

        return double.TryParse(text, NumberStyles.Float, CultureInfo.InvariantCulture, out value)
               && value > 0;
    }

    private static string Encrypt(string text, int shift)
    {
        var result = new StringBuilder(text.Length);

        foreach (char symbol in text)
        {
            result.Append(ShiftLetter(symbol, shift));
        }

        return result.ToString();
    }

    private static char ShiftLetter(char symbol, int shift)
    {
        const string russianLower = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        const string russianUpper = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
        const string englishLower = "abcdefghijklmnopqrstuvwxyz";
        const string englishUpper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        if (TryShift(symbol, shift, russianLower, out char shiftedRussianLower))
        {
            return shiftedRussianLower;
        }

        if (TryShift(symbol, shift, russianUpper, out char shiftedRussianUpper))
        {
            return shiftedRussianUpper;
        }

        if (TryShift(symbol, shift, englishLower, out char shiftedEnglishLower))
        {
            return shiftedEnglishLower;
        }

        if (TryShift(symbol, shift, englishUpper, out char shiftedEnglishUpper))
        {
            return shiftedEnglishUpper;
        }

        return symbol;
    }

    private static bool TryShift(char symbol, int shift, string alphabet, out char shifted)
    {
        int index = alphabet.IndexOf(symbol);
        if (index < 0)
        {
            shifted = symbol;
            return false;
        }

        int shiftedIndex = (index + shift) % alphabet.Length;
        shifted = alphabet[shiftedIndex];
        return true;
    }
}
