namespace Lesson5;

public partial class TextListForm : Form
{
    public TextListForm()
    {
        InitializeComponent();
    }

    private void AddButton_Click(object? sender, EventArgs e)
    {
        string text = inputTextBox.Text.Trim();

        if (string.IsNullOrEmpty(text))
        {
            return;
        }

        if (textListBox.Items.Contains(text))
        {
            inputTextBox.Clear();
            inputTextBox.Focus();
            return;
        }

        textListBox.Items.Add(text);
        inputTextBox.Clear();
        inputTextBox.Focus();
    }

    private void DeleteButton_Click(object? sender, EventArgs e)
    {
        if (textListBox.SelectedItem == null)
        {
            return;
        }

        textListBox.Items.Remove(textListBox.SelectedItem);
        inputTextBox.Focus();
    }

    private void TextListBox_DoubleClick(object? sender, EventArgs e)
    {
        if (textListBox.SelectedItem == null)
        {
            return;
        }

        inputTextBox.Text = textListBox.SelectedItem.ToString();
        textListBox.Items.Remove(textListBox.SelectedItem);
        inputTextBox.Focus();
        inputTextBox.SelectionStart = inputTextBox.Text.Length;
    }
}
