namespace Lesson5;

partial class TextListForm
{
    private System.ComponentModel.IContainer components = null;
    private Label inputLabel;
    private TextBox inputTextBox;
    private Button addButton;
    private Button deleteButton;
    private Label listLabel;
    private ListBox textListBox;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        inputLabel = new Label();
        inputTextBox = new TextBox();
        addButton = new Button();
        deleteButton = new Button();
        listLabel = new Label();
        textListBox = new ListBox();
        SuspendLayout();
        // 
        // inputLabel
        // 
        inputLabel.AutoSize = true;
        inputLabel.Location = new Point(12, 82);
        inputLabel.Name = "inputLabel";
        inputLabel.Size = new Size(79, 15);
        inputLabel.TabIndex = 1;
        inputLabel.Text = "Введите текст:";
        // 
        // inputTextBox
        // 
        inputTextBox.Font = new Font("Segoe UI", 12F);
        inputTextBox.Location = new Point(12, 100);
        inputTextBox.Name = "inputTextBox";
        inputTextBox.Size = new Size(360, 29);
        inputTextBox.TabIndex = 2;
        // 
        // addButton
        // 
        addButton.Location = new Point(392, 100);
        addButton.Name = "addButton";
        addButton.Size = new Size(120, 29);
        addButton.TabIndex = 3;
        addButton.Text = "Добавить";
        addButton.UseVisualStyleBackColor = true;
        addButton.Click += AddButton_Click;
        // 
        // deleteButton
        // 
        deleteButton.Location = new Point(392, 135);
        deleteButton.Name = "deleteButton";
        deleteButton.Size = new Size(120, 29);
        deleteButton.TabIndex = 4;
        deleteButton.Text = "Удалить";
        deleteButton.UseVisualStyleBackColor = true;
        deleteButton.Click += DeleteButton_Click;
        // 
        // listLabel
        // 
        listLabel.AutoSize = true;
        listLabel.Location = new Point(12, 174);
        listLabel.Name = "listLabel";
        listLabel.Size = new Size(118, 15);
        listLabel.TabIndex = 5;
        listLabel.Text = "Сохраненный текст:";
        // 
        // textListBox
        // 
        textListBox.Font = new Font("Segoe UI", 12F);
        textListBox.FormattingEnabled = true;
        textListBox.ItemHeight = 21;
        textListBox.Location = new Point(12, 198);
        textListBox.Name = "textListBox";
        textListBox.Size = new Size(500, 172);
        textListBox.TabIndex = 6;
        textListBox.DoubleClick += TextListBox_DoubleClick;
        // 
        // TextListForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(544, 391);
        Controls.Add(textListBox);
        Controls.Add(listLabel);
        Controls.Add(deleteButton);
        Controls.Add(addButton);
        Controls.Add(inputTextBox);
        Controls.Add(inputLabel);
        MinimumSize = new Size(560, 430);
        Name = "TextListForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Lesson 5 - Text List";
        ResumeLayout(false);
        PerformLayout();
    }
}
