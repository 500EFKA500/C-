namespace Lesson6;

public partial class CategoryListForm : Form
{
    public CategoryListForm()
    {
        InitializeComponent();
    }

    private void AddButton_Click(object? sender, EventArgs e)
    {
        string word = wordTextBox.Text.Trim();

        if (string.IsNullOrEmpty(word))
        {
            return;
        }

        ListBox targetListBox = categoryComboBox.SelectedIndex == 0
            ? firstCategoryListBox
            : secondCategoryListBox;
        TextBox[] targetFilters = categoryComboBox.SelectedIndex == 0
            ? firstCategoryFilterTextBoxes
            : secondCategoryFilterTextBoxes;

        if (!CanAddByFilters(word, targetFilters))
        {
            wordTextBox.Focus();
            wordTextBox.SelectAll();
            return;
        }

        if (!targetListBox.Items.Contains(word))
        {
            targetListBox.Items.Add(word);
        }

        wordTextBox.Clear();
        wordTextBox.Focus();
    }

    private static bool CanAddByFilters(string word, TextBox[] filters)
    {
        bool hasFilter = false;

        foreach (TextBox filterTextBox in filters)
        {
            string filter = filterTextBox.Text.Trim();

            if (string.IsNullOrEmpty(filter))
            {
                continue;
            }

            hasFilter = true;

            if (word.StartsWith(filter, StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
        }

        return !hasFilter;
    }
}
