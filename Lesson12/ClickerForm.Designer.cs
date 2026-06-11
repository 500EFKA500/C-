namespace Lesson12;

partial class ClickerForm
{
    private System.ComponentModel.IContainer components = null;
    private Label titleLabel;
    private Label scoreLabel;
    private Label statusLabel;
    private Button clickButton;
    private Button resetButton;

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
        scoreLabel = new Label();
        statusLabel = new Label();
        clickButton = new Button();
        resetButton = new Button();
        SuspendLayout();
        // 
        // titleLabel
        // 
        titleLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        titleLabel.Location = new Point(25, 25);
        titleLabel.Name = "titleLabel";
        titleLabel.Size = new Size(350, 40);
        titleLabel.TabIndex = 0;
        titleLabel.Text = "\u041a\u043b\u0438\u043a\u0435\u0440";
        titleLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // scoreLabel
        // 
        scoreLabel.Font = new Font("Segoe UI", 14F);
        scoreLabel.Location = new Point(25, 80);
        scoreLabel.Name = "scoreLabel";
        scoreLabel.Size = new Size(350, 35);
        scoreLabel.TabIndex = 1;
        scoreLabel.Text = "\u041a\u043b\u0438\u043a\u043e\u0432: 0";
        scoreLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // statusLabel
        // 
        statusLabel.Location = new Point(25, 112);
        statusLabel.Name = "statusLabel";
        statusLabel.Size = new Size(350, 20);
        statusLabel.TabIndex = 2;
        statusLabel.Text = "\u0426\u0435\u043b\u044c: 50 \u043a\u043b\u0438\u043a\u043e\u0432";
        statusLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // clickButton
        // 
        clickButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        clickButton.Location = new Point(75, 135);
        clickButton.Name = "clickButton";
        clickButton.Size = new Size(250, 80);
        clickButton.TabIndex = 3;
        clickButton.Text = "\u041a\u043b\u0438\u043a!";
        clickButton.UseVisualStyleBackColor = true;
        clickButton.Click += ClickButton_Click;
        // 
        // resetButton
        // 
        resetButton.Location = new Point(125, 235);
        resetButton.Name = "resetButton";
        resetButton.Size = new Size(150, 35);
        resetButton.TabIndex = 4;
        resetButton.Text = "\u0421\u0431\u0440\u043e\u0441\u0438\u0442\u044c";
        resetButton.UseVisualStyleBackColor = true;
        resetButton.Click += ResetButton_Click;
        // 
        // ClickerForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(404, 301);
        Controls.Add(resetButton);
        Controls.Add(clickButton);
        Controls.Add(statusLabel);
        Controls.Add(scoreLabel);
        Controls.Add(titleLabel);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "ClickerForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "\u041a\u043b\u0438\u043a\u0435\u0440";
        ResumeLayout(false);
    }
}
