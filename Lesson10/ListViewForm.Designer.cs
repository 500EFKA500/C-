namespace Lesson10;

partial class ListViewForm
{
    private System.ComponentModel.IContainer components = null;
    private Label titleLabel;
    private Label valueLabel;
    private Label columnLabel;
    private TextBox valueTextBox;
    private ComboBox columnComboBox;
    private Button addButton;
    private ListView dataListView;
    private ColumnHeader nameColumnHeader;
    private ColumnHeader ageColumnHeader;
    private ColumnHeader cityColumnHeader;

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
        titleLabel = new Label();
        valueLabel = new Label();
        columnLabel = new Label();
        valueTextBox = new TextBox();
        columnComboBox = new ComboBox();
        addButton = new Button();
        dataListView = new ListView();
        nameColumnHeader = new ColumnHeader();
        ageColumnHeader = new ColumnHeader();
        cityColumnHeader = new ColumnHeader();
        SuspendLayout();
        // 
        // titleLabel
        // 
        titleLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        titleLabel.Location = new Point(20, 15);
        titleLabel.Name = "titleLabel";
        titleLabel.Size = new Size(660, 30);
        titleLabel.TabIndex = 0;
        titleLabel.Text = "Имя, возраст и город";
        titleLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // valueLabel
        // 
        valueLabel.AutoSize = true;
        valueLabel.Location = new Point(90, 65);
        valueLabel.Name = "valueLabel";
        valueLabel.Size = new Size(107, 15);
        valueLabel.TabIndex = 1;
        valueLabel.Text = "Введите значение";
        // 
        // columnLabel
        // 
        columnLabel.AutoSize = true;
        columnLabel.Location = new Point(350, 65);
        columnLabel.Name = "columnLabel";
        columnLabel.Size = new Size(103, 15);
        columnLabel.TabIndex = 2;
        columnLabel.Text = "Выберите столбец";
        // 
        // valueTextBox
        // 
        valueTextBox.Location = new Point(90, 85);
        valueTextBox.Name = "valueTextBox";
        valueTextBox.Size = new Size(240, 23);
        valueTextBox.TabIndex = 3;
        // 
        // columnComboBox
        // 
        columnComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        columnComboBox.FormattingEnabled = true;
        columnComboBox.Items.AddRange(new object[] { "Имя", "Возраст", "Город" });
        columnComboBox.Location = new Point(350, 85);
        columnComboBox.Name = "columnComboBox";
        columnComboBox.Size = new Size(170, 23);
        columnComboBox.TabIndex = 4;
        // 
        // addButton
        // 
        addButton.Location = new Point(540, 83);
        addButton.Name = "addButton";
        addButton.Size = new Size(100, 27);
        addButton.TabIndex = 5;
        addButton.Text = "Ввести";
        addButton.UseVisualStyleBackColor = true;
        addButton.Click += AddButton_Click;
        // 
        // dataListView
        // 
        dataListView.Columns.AddRange(new ColumnHeader[] { nameColumnHeader, ageColumnHeader, cityColumnHeader });
        dataListView.FullRowSelect = true;
        dataListView.GridLines = true;
        dataListView.Location = new Point(20, 135);
        dataListView.Name = "dataListView";
        dataListView.Size = new Size(660, 290);
        dataListView.TabIndex = 6;
        dataListView.UseCompatibleStateImageBehavior = false;
        dataListView.View = View.Details;
        // 
        // nameColumnHeader
        // 
        nameColumnHeader.Text = "Имя";
        nameColumnHeader.Width = 218;
        // 
        // ageColumnHeader
        // 
        ageColumnHeader.Text = "Возраст";
        ageColumnHeader.Width = 218;
        // 
        // cityColumnHeader
        // 
        cityColumnHeader.Text = "Город";
        cityColumnHeader.Width = 218;
        // 
        // ListViewForm
        // 
        AcceptButton = addButton;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(704, 451);
        Controls.Add(dataListView);
        Controls.Add(addButton);
        Controls.Add(columnComboBox);
        Controls.Add(valueTextBox);
        Controls.Add(columnLabel);
        Controls.Add(valueLabel);
        Controls.Add(titleLabel);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "ListViewForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Lesson 10";
        ResumeLayout(false);
        PerformLayout();
    }
}
