namespace Lesson10;

public partial class ListViewForm : Form
{
    private ListViewItem? currentItem;

    public ListViewForm()
    {
        InitializeComponent();
        columnComboBox.SelectedIndex = 0;
    }

    private void AddButton_Click(object? sender, EventArgs e)
    {
        string value = valueTextBox.Text.Trim();

        if (value.Length == 0)
        {
            MessageBox.Show("Введите значение.", "Пустое поле",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (currentItem == null)
        {
            currentItem = new ListViewItem("");
            currentItem.SubItems.Add("");
            currentItem.SubItems.Add("");
            dataListView.Items.Add(currentItem);
        }

        currentItem.SubItems[columnComboBox.SelectedIndex].Text = value;

        if (currentItem.SubItems.Cast<ListViewItem.ListViewSubItem>()
            .All(subItem => subItem.Text.Length > 0))
        {
            currentItem = null;
        }

        valueTextBox.Clear();
        valueTextBox.Focus();
    }
}
