namespace Lesson6;

partial class CategoryListForm
{
    private System.ComponentModel.IContainer components = null;
    private Label wordLabel;
    private TextBox wordTextBox;
    private Label categoryLabel;
    private ComboBox categoryComboBox;
    private Button addButton;
    private Label firstCategoryLabel;
    private ListBox firstCategoryListBox;
    private Label firstFiltersLabel;
    private TextBox firstFilterTextBox1;
    private TextBox firstFilterTextBox2;
    private TextBox firstFilterTextBox3;
    private TextBox firstFilterTextBox4;
    private TextBox firstFilterTextBox5;
    private TextBox firstFilterTextBox6;
    private TextBox firstFilterTextBox7;
    private TextBox firstFilterTextBox8;
    private TextBox[] firstCategoryFilterTextBoxes;
    private Label secondCategoryLabel;
    private ListBox secondCategoryListBox;
    private Label secondFiltersLabel;
    private TextBox secondFilterTextBox1;
    private TextBox secondFilterTextBox2;
    private TextBox secondFilterTextBox3;
    private TextBox secondFilterTextBox4;
    private TextBox secondFilterTextBox5;
    private TextBox secondFilterTextBox6;
    private TextBox secondFilterTextBox7;
    private TextBox secondFilterTextBox8;
    private TextBox[] secondCategoryFilterTextBoxes;

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
        wordLabel = new Label();
        wordTextBox = new TextBox();
        categoryLabel = new Label();
        categoryComboBox = new ComboBox();
        addButton = new Button();
        firstCategoryLabel = new Label();
        firstCategoryListBox = new ListBox();
        firstFiltersLabel = new Label();
        firstFilterTextBox1 = new TextBox();
        firstFilterTextBox2 = new TextBox();
        firstFilterTextBox3 = new TextBox();
        firstFilterTextBox4 = new TextBox();
        firstFilterTextBox5 = new TextBox();
        firstFilterTextBox6 = new TextBox();
        firstFilterTextBox7 = new TextBox();
        firstFilterTextBox8 = new TextBox();
        secondCategoryLabel = new Label();
        secondCategoryListBox = new ListBox();
        secondFiltersLabel = new Label();
        secondFilterTextBox1 = new TextBox();
        secondFilterTextBox2 = new TextBox();
        secondFilterTextBox3 = new TextBox();
        secondFilterTextBox4 = new TextBox();
        secondFilterTextBox5 = new TextBox();
        secondFilterTextBox6 = new TextBox();
        secondFilterTextBox7 = new TextBox();
        secondFilterTextBox8 = new TextBox();
        firstCategoryFilterTextBoxes = new[]
        {
            firstFilterTextBox1,
            firstFilterTextBox2,
            firstFilterTextBox3,
            firstFilterTextBox4,
            firstFilterTextBox5,
            firstFilterTextBox6,
            firstFilterTextBox7,
            firstFilterTextBox8
        };
        secondCategoryFilterTextBoxes = new[]
        {
            secondFilterTextBox1,
            secondFilterTextBox2,
            secondFilterTextBox3,
            secondFilterTextBox4,
            secondFilterTextBox5,
            secondFilterTextBox6,
            secondFilterTextBox7,
            secondFilterTextBox8
        };
        SuspendLayout();
        // 
        // wordLabel
        // 
        wordLabel.AutoSize = true;
        wordLabel.Location = new Point(12, 18);
        wordLabel.Name = "wordLabel";
        wordLabel.Size = new Size(85, 15);
        wordLabel.TabIndex = 0;
        wordLabel.Text = "Введите слово:";
        // 
        // wordTextBox
        // 
        wordTextBox.Font = new Font("Segoe UI", 12F);
        wordTextBox.Location = new Point(12, 36);
        wordTextBox.Name = "wordTextBox";
        wordTextBox.Size = new Size(250, 29);
        wordTextBox.TabIndex = 1;
        // 
        // categoryLabel
        // 
        categoryLabel.AutoSize = true;
        categoryLabel.Location = new Point(280, 18);
        categoryLabel.Name = "categoryLabel";
        categoryLabel.Size = new Size(148, 15);
        categoryLabel.TabIndex = 2;
        categoryLabel.Text = "Категория: 1 или 2";
        // 
        // categoryComboBox
        // 
        categoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        categoryComboBox.Font = new Font("Segoe UI", 12F);
        categoryComboBox.FormattingEnabled = true;
        categoryComboBox.Items.AddRange(new object[] { "Категория 1", "Категория 2" });
        categoryComboBox.Location = new Point(280, 36);
        categoryComboBox.Name = "categoryComboBox";
        categoryComboBox.Size = new Size(180, 29);
        categoryComboBox.TabIndex = 3;
        categoryComboBox.SelectedIndex = 0;
        // 
        // addButton
        // 
        addButton.Location = new Point(480, 36);
        addButton.Name = "addButton";
        addButton.Size = new Size(120, 29);
        addButton.TabIndex = 4;
        addButton.Text = "Добавить";
        addButton.UseVisualStyleBackColor = true;
        addButton.Click += AddButton_Click;
        // 
        // firstCategoryLabel
        // 
        firstCategoryLabel.AutoSize = true;
        firstCategoryLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        firstCategoryLabel.Location = new Point(12, 92);
        firstCategoryLabel.Name = "firstCategoryLabel";
        firstCategoryLabel.Size = new Size(91, 19);
        firstCategoryLabel.TabIndex = 5;
        firstCategoryLabel.Text = "Категория 1";
        // 
        // firstCategoryListBox
        // 
        firstCategoryListBox.Font = new Font("Segoe UI", 12F);
        firstCategoryListBox.FormattingEnabled = true;
        firstCategoryListBox.ItemHeight = 21;
        firstCategoryListBox.Location = new Point(12, 118);
        firstCategoryListBox.Name = "firstCategoryListBox";
        firstCategoryListBox.Size = new Size(282, 151);
        firstCategoryListBox.TabIndex = 6;
        // 
        // firstFiltersLabel
        // 
        firstFiltersLabel.AutoSize = true;
        firstFiltersLabel.Location = new Point(12, 286);
        firstFiltersLabel.Name = "firstFiltersLabel";
        firstFiltersLabel.Size = new Size(107, 15);
        firstFiltersLabel.TabIndex = 7;
        firstFiltersLabel.Text = "Фильтры начала:";
        // 
        // firstFilterTextBox1
        // 
        firstFilterTextBox1.Location = new Point(12, 308);
        firstFilterTextBox1.Name = "firstFilterTextBox1";
        firstFilterTextBox1.Size = new Size(60, 23);
        firstFilterTextBox1.TabIndex = 8;
        // 
        // firstFilterTextBox2
        // 
        firstFilterTextBox2.Location = new Point(82, 308);
        firstFilterTextBox2.Name = "firstFilterTextBox2";
        firstFilterTextBox2.Size = new Size(60, 23);
        firstFilterTextBox2.TabIndex = 9;
        // 
        // firstFilterTextBox3
        // 
        firstFilterTextBox3.Location = new Point(152, 308);
        firstFilterTextBox3.Name = "firstFilterTextBox3";
        firstFilterTextBox3.Size = new Size(60, 23);
        firstFilterTextBox3.TabIndex = 10;
        // 
        // firstFilterTextBox4
        // 
        firstFilterTextBox4.Location = new Point(222, 308);
        firstFilterTextBox4.Name = "firstFilterTextBox4";
        firstFilterTextBox4.Size = new Size(60, 23);
        firstFilterTextBox4.TabIndex = 11;
        // 
        // firstFilterTextBox5
        // 
        firstFilterTextBox5.Location = new Point(12, 338);
        firstFilterTextBox5.Name = "firstFilterTextBox5";
        firstFilterTextBox5.Size = new Size(60, 23);
        firstFilterTextBox5.TabIndex = 12;
        // 
        // firstFilterTextBox6
        // 
        firstFilterTextBox6.Location = new Point(82, 338);
        firstFilterTextBox6.Name = "firstFilterTextBox6";
        firstFilterTextBox6.Size = new Size(60, 23);
        firstFilterTextBox6.TabIndex = 13;
        // 
        // firstFilterTextBox7
        // 
        firstFilterTextBox7.Location = new Point(152, 338);
        firstFilterTextBox7.Name = "firstFilterTextBox7";
        firstFilterTextBox7.Size = new Size(60, 23);
        firstFilterTextBox7.TabIndex = 14;
        // 
        // firstFilterTextBox8
        // 
        firstFilterTextBox8.Location = new Point(222, 338);
        firstFilterTextBox8.Name = "firstFilterTextBox8";
        firstFilterTextBox8.Size = new Size(60, 23);
        firstFilterTextBox8.TabIndex = 15;
        // 
        // secondCategoryLabel
        // 
        secondCategoryLabel.AutoSize = true;
        secondCategoryLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        secondCategoryLabel.Location = new Point(318, 92);
        secondCategoryLabel.Name = "secondCategoryLabel";
        secondCategoryLabel.Size = new Size(91, 19);
        secondCategoryLabel.TabIndex = 16;
        secondCategoryLabel.Text = "Категория 2";
        // 
        // secondCategoryListBox
        // 
        secondCategoryListBox.Font = new Font("Segoe UI", 12F);
        secondCategoryListBox.FormattingEnabled = true;
        secondCategoryListBox.ItemHeight = 21;
        secondCategoryListBox.Location = new Point(318, 118);
        secondCategoryListBox.Name = "secondCategoryListBox";
        secondCategoryListBox.Size = new Size(282, 151);
        secondCategoryListBox.TabIndex = 17;
        // 
        // secondFiltersLabel
        // 
        secondFiltersLabel.AutoSize = true;
        secondFiltersLabel.Location = new Point(318, 286);
        secondFiltersLabel.Name = "secondFiltersLabel";
        secondFiltersLabel.Size = new Size(107, 15);
        secondFiltersLabel.TabIndex = 18;
        secondFiltersLabel.Text = "Фильтры начала:";
        // 
        // secondFilterTextBox1
        // 
        secondFilterTextBox1.Location = new Point(318, 308);
        secondFilterTextBox1.Name = "secondFilterTextBox1";
        secondFilterTextBox1.Size = new Size(60, 23);
        secondFilterTextBox1.TabIndex = 19;
        // 
        // secondFilterTextBox2
        // 
        secondFilterTextBox2.Location = new Point(388, 308);
        secondFilterTextBox2.Name = "secondFilterTextBox2";
        secondFilterTextBox2.Size = new Size(60, 23);
        secondFilterTextBox2.TabIndex = 20;
        // 
        // secondFilterTextBox3
        // 
        secondFilterTextBox3.Location = new Point(458, 308);
        secondFilterTextBox3.Name = "secondFilterTextBox3";
        secondFilterTextBox3.Size = new Size(60, 23);
        secondFilterTextBox3.TabIndex = 21;
        // 
        // secondFilterTextBox4
        // 
        secondFilterTextBox4.Location = new Point(528, 308);
        secondFilterTextBox4.Name = "secondFilterTextBox4";
        secondFilterTextBox4.Size = new Size(60, 23);
        secondFilterTextBox4.TabIndex = 22;
        // 
        // secondFilterTextBox5
        // 
        secondFilterTextBox5.Location = new Point(318, 338);
        secondFilterTextBox5.Name = "secondFilterTextBox5";
        secondFilterTextBox5.Size = new Size(60, 23);
        secondFilterTextBox5.TabIndex = 23;
        // 
        // secondFilterTextBox6
        // 
        secondFilterTextBox6.Location = new Point(388, 338);
        secondFilterTextBox6.Name = "secondFilterTextBox6";
        secondFilterTextBox6.Size = new Size(60, 23);
        secondFilterTextBox6.TabIndex = 24;
        // 
        // secondFilterTextBox7
        // 
        secondFilterTextBox7.Location = new Point(458, 338);
        secondFilterTextBox7.Name = "secondFilterTextBox7";
        secondFilterTextBox7.Size = new Size(60, 23);
        secondFilterTextBox7.TabIndex = 25;
        // 
        // secondFilterTextBox8
        // 
        secondFilterTextBox8.Location = new Point(528, 338);
        secondFilterTextBox8.Name = "secondFilterTextBox8";
        secondFilterTextBox8.Size = new Size(60, 23);
        secondFilterTextBox8.TabIndex = 26;
        // 
        // CategoryListForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(624, 391);
        Controls.Add(secondFilterTextBox8);
        Controls.Add(secondFilterTextBox7);
        Controls.Add(secondFilterTextBox6);
        Controls.Add(secondFilterTextBox5);
        Controls.Add(secondFilterTextBox4);
        Controls.Add(secondFilterTextBox3);
        Controls.Add(secondFilterTextBox2);
        Controls.Add(secondFilterTextBox1);
        Controls.Add(secondFiltersLabel);
        Controls.Add(firstFilterTextBox8);
        Controls.Add(firstFilterTextBox7);
        Controls.Add(firstFilterTextBox6);
        Controls.Add(firstFilterTextBox5);
        Controls.Add(firstFilterTextBox4);
        Controls.Add(firstFilterTextBox3);
        Controls.Add(firstFilterTextBox2);
        Controls.Add(firstFilterTextBox1);
        Controls.Add(firstFiltersLabel);
        Controls.Add(secondCategoryListBox);
        Controls.Add(secondCategoryLabel);
        Controls.Add(firstCategoryListBox);
        Controls.Add(firstCategoryLabel);
        Controls.Add(addButton);
        Controls.Add(categoryComboBox);
        Controls.Add(categoryLabel);
        Controls.Add(wordTextBox);
        Controls.Add(wordLabel);
        MinimumSize = new Size(640, 430);
        Name = "CategoryListForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Lesson 6 - Categories";
        ResumeLayout(false);
        PerformLayout();
    }
}
