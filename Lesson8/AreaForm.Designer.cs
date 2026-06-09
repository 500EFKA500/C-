namespace Lesson8;

partial class AreaForm
{
    private System.ComponentModel.IContainer components = null;
    private Label titleLabel;
    private Label inputLabel;
    private TextBox inputTextBox;
    private CheckBox digitsCheckBox;
    private CheckBox uppercaseCheckBox;
    private CheckBox symbolsCheckBox;
    private Button createPasswordButton;
    private Label resultLabel;
    private TextBox resultTextBox;

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
        inputLabel = new Label();
        inputTextBox = new TextBox();
        digitsCheckBox = new CheckBox();
        uppercaseCheckBox = new CheckBox();
        symbolsCheckBox = new CheckBox();
        createPasswordButton = new Button();
        resultLabel = new Label();
        resultTextBox = new TextBox();
        SuspendLayout();
        // 
        // titleLabel
        // 
        titleLabel.AutoSize = true;
        titleLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        titleLabel.Location = new Point(90, 20);
        titleLabel.Name = "titleLabel";
        titleLabel.Size = new Size(202, 25);
        titleLabel.TabIndex = 0;
        titleLabel.Text = "Усложнение пароля";
        // 
        // inputLabel
        // 
        inputLabel.AutoSize = true;
        inputLabel.Location = new Point(45, 70);
        inputLabel.Name = "inputLabel";
        inputLabel.Size = new Size(145, 15);
        inputLabel.TabIndex = 1;
        inputLabel.Text = "Введите основу пароля:";
        // 
        // inputTextBox
        // 
        inputTextBox.Location = new Point(45, 90);
        inputTextBox.Name = "inputTextBox";
        inputTextBox.Size = new Size(290, 23);
        inputTextBox.TabIndex = 2;
        // 
        // digitsCheckBox
        // 
        digitsCheckBox.AutoSize = true;
        digitsCheckBox.Location = new Point(45, 135);
        digitsCheckBox.Name = "digitsCheckBox";
        digitsCheckBox.Size = new Size(129, 19);
        digitsCheckBox.TabIndex = 3;
        digitsCheckBox.Text = "Добавить 3 цифры";
        digitsCheckBox.UseVisualStyleBackColor = true;
        // 
        // uppercaseCheckBox
        // 
        uppercaseCheckBox.AutoSize = true;
        uppercaseCheckBox.Location = new Point(45, 165);
        uppercaseCheckBox.Name = "uppercaseCheckBox";
        uppercaseCheckBox.Size = new Size(178, 19);
        uppercaseCheckBox.TabIndex = 4;
        uppercaseCheckBox.Text = "Добавить заглавные буквы";
        uppercaseCheckBox.UseVisualStyleBackColor = true;
        // 
        // symbolsCheckBox
        // 
        symbolsCheckBox.AutoSize = true;
        symbolsCheckBox.Location = new Point(45, 195);
        symbolsCheckBox.Name = "symbolsCheckBox";
        symbolsCheckBox.Size = new Size(176, 19);
        symbolsCheckBox.TabIndex = 5;
        symbolsCheckBox.Text = "Добавить спецсимволы";
        symbolsCheckBox.UseVisualStyleBackColor = true;
        // 
        // createPasswordButton
        // 
        createPasswordButton.Location = new Point(110, 235);
        createPasswordButton.Name = "createPasswordButton";
        createPasswordButton.Size = new Size(160, 30);
        createPasswordButton.TabIndex = 6;
        createPasswordButton.Text = "Создать пароль";
        createPasswordButton.UseVisualStyleBackColor = true;
        createPasswordButton.Click += CreatePasswordButton_Click;
        // 
        // resultLabel
        // 
        resultLabel.AutoSize = true;
        resultLabel.Location = new Point(45, 290);
        resultLabel.Name = "resultLabel";
        resultLabel.Size = new Size(63, 15);
        resultLabel.TabIndex = 7;
        resultLabel.Text = "Результат:";
        // 
        // resultTextBox
        // 
        resultTextBox.Location = new Point(45, 310);
        resultTextBox.Name = "resultTextBox";
        resultTextBox.ReadOnly = true;
        resultTextBox.Size = new Size(290, 23);
        resultTextBox.TabIndex = 8;
        // 
        // AreaForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(384, 361);
        Controls.Add(resultTextBox);
        Controls.Add(resultLabel);
        Controls.Add(createPasswordButton);
        Controls.Add(symbolsCheckBox);
        Controls.Add(uppercaseCheckBox);
        Controls.Add(digitsCheckBox);
        Controls.Add(inputTextBox);
        Controls.Add(inputLabel);
        Controls.Add(titleLabel);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "AreaForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Lesson 8";
        ResumeLayout(false);
        PerformLayout();
    }
}
