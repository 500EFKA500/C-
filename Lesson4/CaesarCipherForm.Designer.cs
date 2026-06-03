namespace Lesson4;

partial class CaesarCipherForm
{
    private System.ComponentModel.IContainer components = null;
    private Label titleLabel;
    private Label inputLabel;
    private TextBox inputTextBox;
    private Label shiftLabel;
    private TextBox shiftTextBox;
    private Button encryptButton;
    private Label resultLabel;
    private TextBox resultTextBox;
    private Label areaTitleLabel;
    private Label squareSideLabel;
    private TextBox squareSideTextBox;
    private Button squareAreaButton;
    private Label circleRadiusLabel;
    private TextBox circleRadiusTextBox;
    private Button circleAreaButton;
    private Label triangleBaseLabel;
    private TextBox triangleBaseTextBox;
    private Label triangleHeightLabel;
    private TextBox triangleHeightTextBox;
    private Button triangleAreaButton;
    private Label areaResultLabel;
    private TextBox areaResultTextBox;

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
        shiftLabel = new Label();
        shiftTextBox = new TextBox();
        encryptButton = new Button();
        resultLabel = new Label();
        resultTextBox = new TextBox();
        areaTitleLabel = new Label();
        squareSideLabel = new Label();
        squareSideTextBox = new TextBox();
        squareAreaButton = new Button();
        circleRadiusLabel = new Label();
        circleRadiusTextBox = new TextBox();
        circleAreaButton = new Button();
        triangleBaseLabel = new Label();
        triangleBaseTextBox = new TextBox();
        triangleHeightLabel = new Label();
        triangleHeightTextBox = new TextBox();
        triangleAreaButton = new Button();
        areaResultLabel = new Label();
        areaResultTextBox = new TextBox();
        SuspendLayout();
        // 
        // titleLabel
        // 
        titleLabel.AutoSize = true;
        titleLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
        titleLabel.Location = new Point(24, 20);
        titleLabel.Name = "titleLabel";
        titleLabel.Size = new Size(174, 32);
        titleLabel.TabIndex = 0;
        titleLabel.Text = "Шифр Цезаря";
        // 
        // inputLabel
        // 
        inputLabel.AutoSize = true;
        inputLabel.Location = new Point(28, 72);
        inputLabel.Name = "inputLabel";
        inputLabel.Size = new Size(91, 15);
        inputLabel.TabIndex = 1;
        inputLabel.Text = "Введите слово:";
        // 
        // inputTextBox
        // 
        inputTextBox.Font = new Font("Segoe UI", 12F);
        inputTextBox.Location = new Point(28, 96);
        inputTextBox.Name = "inputTextBox";
        inputTextBox.Size = new Size(552, 29);
        inputTextBox.TabIndex = 2;
        // 
        // shiftLabel
        // 
        shiftLabel.AutoSize = true;
        shiftLabel.Location = new Point(28, 138);
        shiftLabel.Name = "shiftLabel";
        shiftLabel.Size = new Size(98, 15);
        shiftLabel.TabIndex = 3;
        shiftLabel.Text = "Введите сдвиг:";
        // 
        // shiftTextBox
        // 
        shiftTextBox.Font = new Font("Segoe UI", 12F);
        shiftTextBox.Location = new Point(28, 162);
        shiftTextBox.Name = "shiftTextBox";
        shiftTextBox.Size = new Size(160, 29);
        shiftTextBox.TabIndex = 4;
        shiftTextBox.Text = "1";
        // 
        // encryptButton
        // 
        encryptButton.Location = new Point(204, 162);
        encryptButton.Name = "encryptButton";
        encryptButton.Size = new Size(140, 29);
        encryptButton.TabIndex = 5;
        encryptButton.Text = "Зашифровать";
        encryptButton.UseVisualStyleBackColor = true;
        encryptButton.Click += ShiftButton_Click;
        // 
        // resultLabel
        // 
        resultLabel.AutoSize = true;
        resultLabel.Location = new Point(28, 220);
        resultLabel.Name = "resultLabel";
        resultLabel.Size = new Size(62, 15);
        resultLabel.TabIndex = 6;
        resultLabel.Text = "Результат:";
        // 
        // resultTextBox
        // 
        resultTextBox.Font = new Font("Segoe UI", 12F);
        resultTextBox.Location = new Point(28, 244);
        resultTextBox.Name = "resultTextBox";
        resultTextBox.ReadOnly = true;
        resultTextBox.Size = new Size(552, 29);
        resultTextBox.TabIndex = 7;
        // 
        // areaTitleLabel
        // 
        areaTitleLabel.AutoSize = true;
        areaTitleLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        areaTitleLabel.Location = new Point(24, 310);
        areaTitleLabel.Name = "areaTitleLabel";
        areaTitleLabel.Size = new Size(204, 30);
        areaTitleLabel.TabIndex = 8;
        areaTitleLabel.Text = "Площади фигур";
        // 
        // squareSideLabel
        // 
        squareSideLabel.AutoSize = true;
        squareSideLabel.Location = new Point(28, 354);
        squareSideLabel.Name = "squareSideLabel";
        squareSideLabel.Size = new Size(117, 15);
        squareSideLabel.TabIndex = 9;
        squareSideLabel.Text = "Сторона квадрата:";
        // 
        // squareSideTextBox
        // 
        squareSideTextBox.Font = new Font("Segoe UI", 12F);
        squareSideTextBox.Location = new Point(28, 376);
        squareSideTextBox.Name = "squareSideTextBox";
        squareSideTextBox.Size = new Size(160, 29);
        squareSideTextBox.TabIndex = 10;
        // 
        // squareAreaButton
        // 
        squareAreaButton.Location = new Point(204, 376);
        squareAreaButton.Name = "squareAreaButton";
        squareAreaButton.Size = new Size(170, 29);
        squareAreaButton.TabIndex = 11;
        squareAreaButton.Text = "Площадь квадрата";
        squareAreaButton.UseVisualStyleBackColor = true;
        squareAreaButton.Click += SquareAreaButton_Click;
        // 
        // circleRadiusLabel
        // 
        circleRadiusLabel.AutoSize = true;
        circleRadiusLabel.Location = new Point(28, 418);
        circleRadiusLabel.Name = "circleRadiusLabel";
        circleRadiusLabel.Size = new Size(79, 15);
        circleRadiusLabel.TabIndex = 12;
        circleRadiusLabel.Text = "Радиус круга:";
        // 
        // circleRadiusTextBox
        // 
        circleRadiusTextBox.Font = new Font("Segoe UI", 12F);
        circleRadiusTextBox.Location = new Point(28, 440);
        circleRadiusTextBox.Name = "circleRadiusTextBox";
        circleRadiusTextBox.Size = new Size(160, 29);
        circleRadiusTextBox.TabIndex = 13;
        // 
        // circleAreaButton
        // 
        circleAreaButton.Location = new Point(204, 440);
        circleAreaButton.Name = "circleAreaButton";
        circleAreaButton.Size = new Size(170, 29);
        circleAreaButton.TabIndex = 14;
        circleAreaButton.Text = "Площадь круга";
        circleAreaButton.UseVisualStyleBackColor = true;
        circleAreaButton.Click += CircleAreaButton_Click;
        // 
        // triangleBaseLabel
        // 
        triangleBaseLabel.AutoSize = true;
        triangleBaseLabel.Location = new Point(28, 482);
        triangleBaseLabel.Name = "triangleBaseLabel";
        triangleBaseLabel.Size = new Size(72, 15);
        triangleBaseLabel.TabIndex = 15;
        triangleBaseLabel.Text = "Основание:";
        // 
        // triangleBaseTextBox
        // 
        triangleBaseTextBox.Font = new Font("Segoe UI", 12F);
        triangleBaseTextBox.Location = new Point(28, 504);
        triangleBaseTextBox.Name = "triangleBaseTextBox";
        triangleBaseTextBox.Size = new Size(160, 29);
        triangleBaseTextBox.TabIndex = 16;
        // 
        // triangleHeightLabel
        // 
        triangleHeightLabel.AutoSize = true;
        triangleHeightLabel.Location = new Point(204, 482);
        triangleHeightLabel.Name = "triangleHeightLabel";
        triangleHeightLabel.Size = new Size(48, 15);
        triangleHeightLabel.TabIndex = 17;
        triangleHeightLabel.Text = "Высота:";
        // 
        // triangleHeightTextBox
        // 
        triangleHeightTextBox.Font = new Font("Segoe UI", 12F);
        triangleHeightTextBox.Location = new Point(204, 504);
        triangleHeightTextBox.Name = "triangleHeightTextBox";
        triangleHeightTextBox.Size = new Size(160, 29);
        triangleHeightTextBox.TabIndex = 18;
        // 
        // triangleAreaButton
        // 
        triangleAreaButton.Location = new Point(380, 504);
        triangleAreaButton.Name = "triangleAreaButton";
        triangleAreaButton.Size = new Size(180, 29);
        triangleAreaButton.TabIndex = 19;
        triangleAreaButton.Text = "Площадь треугольника";
        triangleAreaButton.UseVisualStyleBackColor = true;
        triangleAreaButton.Click += TriangleAreaButton_Click;
        // 
        // areaResultLabel
        // 
        areaResultLabel.AutoSize = true;
        areaResultLabel.Location = new Point(28, 548);
        areaResultLabel.Name = "areaResultLabel";
        areaResultLabel.Size = new Size(62, 15);
        areaResultLabel.TabIndex = 20;
        areaResultLabel.Text = "Результат:";
        // 
        // areaResultTextBox
        // 
        areaResultTextBox.Font = new Font("Segoe UI", 12F);
        areaResultTextBox.Location = new Point(28, 570);
        areaResultTextBox.Name = "areaResultTextBox";
        areaResultTextBox.ReadOnly = true;
        areaResultTextBox.Size = new Size(552, 29);
        areaResultTextBox.TabIndex = 21;
        // 
        // CaesarCipherForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(620, 630);
        Controls.Add(areaResultTextBox);
        Controls.Add(areaResultLabel);
        Controls.Add(triangleAreaButton);
        Controls.Add(triangleHeightTextBox);
        Controls.Add(triangleHeightLabel);
        Controls.Add(triangleBaseTextBox);
        Controls.Add(triangleBaseLabel);
        Controls.Add(circleAreaButton);
        Controls.Add(circleRadiusTextBox);
        Controls.Add(circleRadiusLabel);
        Controls.Add(squareAreaButton);
        Controls.Add(squareSideTextBox);
        Controls.Add(squareSideLabel);
        Controls.Add(areaTitleLabel);
        Controls.Add(resultTextBox);
        Controls.Add(resultLabel);
        Controls.Add(encryptButton);
        Controls.Add(shiftTextBox);
        Controls.Add(shiftLabel);
        Controls.Add(inputTextBox);
        Controls.Add(inputLabel);
        Controls.Add(titleLabel);
        MinimumSize = new Size(540, 640);
        Name = "CaesarCipherForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Lesson 4 - Caesar Cipher";
        ResumeLayout(false);
        PerformLayout();
    }
}
