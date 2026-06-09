namespace Lesson8;

public partial class AreaForm : Form
{
    private readonly Random random = new();

    public AreaForm()
    {
        InitializeComponent();
    }

    private void CreatePasswordButton_Click(object? sender, EventArgs e)
    {
        string password = inputTextBox.Text;

        if (string.IsNullOrWhiteSpace(password))
        {
            resultTextBox.Text = "Введите основу пароля";
            return;
        }

        if (digitsCheckBox.Checked)
        {
            password += random.Next(100, 1000);
        }

        if (uppercaseCheckBox.Checked)
        {
            password += "ABC";
        }

        if (symbolsCheckBox.Checked)
        {
            password += "!@#";
        }

        resultTextBox.Text = password;
    }
}
