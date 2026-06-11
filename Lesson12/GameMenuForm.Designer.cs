namespace Lesson12;

partial class GameMenuForm
{
    private System.ComponentModel.IContainer components = null;
    private Label titleLabel;
    private Label descriptionLabel;
    private Button tamagotchiButton;
    private Button clickerButton;
    private Button battleButton;
    private GroupBox scoreGroupBox;
    private Label tamagotchiScoreLabel;
    private Label clickerScoreLabel;
    private Label battleScoreLabel;
    private Label totalScoreLabel;

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
        descriptionLabel = new Label();
        tamagotchiButton = new Button();
        clickerButton = new Button();
        battleButton = new Button();
        scoreGroupBox = new GroupBox();
        tamagotchiScoreLabel = new Label();
        clickerScoreLabel = new Label();
        battleScoreLabel = new Label();
        totalScoreLabel = new Label();
        scoreGroupBox.SuspendLayout();
        SuspendLayout();
        // 
        // titleLabel
        // 
        titleLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
        titleLabel.Location = new Point(25, 25);
        titleLabel.Name = "titleLabel";
        titleLabel.Size = new Size(450, 45);
        titleLabel.TabIndex = 0;
        titleLabel.Text = "\u041c\u0438\u043d\u0438-\u0438\u0433\u0440\u044b";
        titleLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // descriptionLabel
        // 
        descriptionLabel.Location = new Point(25, 75);
        descriptionLabel.Name = "descriptionLabel";
        descriptionLabel.Size = new Size(450, 35);
        descriptionLabel.TabIndex = 1;
        descriptionLabel.Text = "\u0412\u044b\u0431\u0435\u0440\u0438\u0442\u0435 \u0438\u0433\u0440\u0443. \u0412\u0441\u0435 \u043e\u043a\u043d\u0430 \u043c\u043e\u0433\u0443\u0442 \u0440\u0430\u0431\u043e\u0442\u0430\u0442\u044c \u043e\u0434\u043d\u043e\u0432\u0440\u0435\u043c\u0435\u043d\u043d\u043e.";
        descriptionLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // tamagotchiButton
        // 
        tamagotchiButton.Font = new Font("Segoe UI", 12F);
        tamagotchiButton.Location = new Point(100, 130);
        tamagotchiButton.Name = "tamagotchiButton";
        tamagotchiButton.Size = new Size(300, 50);
        tamagotchiButton.TabIndex = 2;
        tamagotchiButton.Text = "\u0422\u0430\u043c\u0430\u0433\u043e\u0447\u0438";
        tamagotchiButton.UseVisualStyleBackColor = true;
        tamagotchiButton.Click += TamagotchiButton_Click;
        // 
        // clickerButton
        // 
        clickerButton.Font = new Font("Segoe UI", 12F);
        clickerButton.Location = new Point(100, 195);
        clickerButton.Name = "clickerButton";
        clickerButton.Size = new Size(300, 50);
        clickerButton.TabIndex = 3;
        clickerButton.Text = "\u041a\u043b\u0438\u043a\u0435\u0440";
        clickerButton.UseVisualStyleBackColor = true;
        clickerButton.Click += ClickerButton_Click;
        // 
        // battleButton
        // 
        battleButton.Font = new Font("Segoe UI", 12F);
        battleButton.Location = new Point(100, 260);
        battleButton.Name = "battleButton";
        battleButton.Size = new Size(300, 50);
        battleButton.TabIndex = 4;
        battleButton.Text = "\u0424\u0430\u0439\u0442\u0438\u043d\u0433";
        battleButton.UseVisualStyleBackColor = true;
        battleButton.Click += BattleButton_Click;
        // 
        // scoreGroupBox
        // 
        scoreGroupBox.Controls.Add(totalScoreLabel);
        scoreGroupBox.Controls.Add(battleScoreLabel);
        scoreGroupBox.Controls.Add(clickerScoreLabel);
        scoreGroupBox.Controls.Add(tamagotchiScoreLabel);
        scoreGroupBox.Location = new Point(50, 330);
        scoreGroupBox.Name = "scoreGroupBox";
        scoreGroupBox.Size = new Size(400, 145);
        scoreGroupBox.TabIndex = 5;
        scoreGroupBox.TabStop = false;
        scoreGroupBox.Text = "\u041e\u0447\u043a\u0438 \u0437\u0430 \u043f\u0440\u043e\u0445\u043e\u0436\u0434\u0435\u043d\u0438\u0435";
        // 
        // tamagotchiScoreLabel
        // 
        tamagotchiScoreLabel.AutoSize = true;
        tamagotchiScoreLabel.Location = new Point(20, 30);
        tamagotchiScoreLabel.Name = "tamagotchiScoreLabel";
        tamagotchiScoreLabel.Size = new Size(79, 15);
        tamagotchiScoreLabel.Text = "\u0422\u0430\u043c\u0430\u0433\u043e\u0447\u0438: 0";
        // 
        // clickerScoreLabel
        // 
        clickerScoreLabel.AutoSize = true;
        clickerScoreLabel.Location = new Point(20, 55);
        clickerScoreLabel.Name = "clickerScoreLabel";
        clickerScoreLabel.Size = new Size(65, 15);
        clickerScoreLabel.Text = "\u041a\u043b\u0438\u043a\u0435\u0440: 0";
        // 
        // battleScoreLabel
        // 
        battleScoreLabel.AutoSize = true;
        battleScoreLabel.Location = new Point(20, 80);
        battleScoreLabel.Name = "battleScoreLabel";
        battleScoreLabel.Size = new Size(76, 15);
        battleScoreLabel.Text = "\u0424\u0430\u0439\u0442\u0438\u043d\u0433: 0";
        // 
        // totalScoreLabel
        // 
        totalScoreLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        totalScoreLabel.Location = new Point(20, 105);
        totalScoreLabel.Name = "totalScoreLabel";
        totalScoreLabel.Size = new Size(350, 25);
        totalScoreLabel.Text = "\u041e\u0431\u0449\u0430\u044f \u0441\u0443\u043c\u043c\u0430: 0";
        // 
        // GameMenuForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(504, 501);
        Controls.Add(scoreGroupBox);
        Controls.Add(battleButton);
        Controls.Add(clickerButton);
        Controls.Add(tamagotchiButton);
        Controls.Add(descriptionLabel);
        Controls.Add(titleLabel);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "GameMenuForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Lesson 12";
        scoreGroupBox.ResumeLayout(false);
        scoreGroupBox.PerformLayout();
        ResumeLayout(false);
    }
}
