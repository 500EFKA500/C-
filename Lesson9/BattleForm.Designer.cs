namespace Lesson9;

partial class BattleForm
{
    private System.ComponentModel.IContainer components = null;
    private Label enemyTitleLabel;
    private Label playerTitleLabel;
    private PictureBox enemyPictureBox;
    private PictureBox playerPictureBox;
    private ProgressBar enemyHealthBar;
    private ProgressBar playerHealthBar;
    private Label enemyHealthLabel;
    private Label playerHealthLabel;
    private Label pointsLabel;
    private GroupBox actionGroupBox;
    private RadioButton healRadioButton;
    private RadioButton attackRadioButton;
    private RadioButton ultimateRadioButton;
    private Button actionButton;
    private Button restartButton;
    private Label statusLabel;
    private System.Windows.Forms.Timer enemyTurnTimer;

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
        components = new System.ComponentModel.Container();
        enemyTitleLabel = new Label();
        playerTitleLabel = new Label();
        enemyPictureBox = new PictureBox();
        playerPictureBox = new PictureBox();
        enemyHealthBar = new ProgressBar();
        playerHealthBar = new ProgressBar();
        enemyHealthLabel = new Label();
        playerHealthLabel = new Label();
        pointsLabel = new Label();
        actionGroupBox = new GroupBox();
        healRadioButton = new RadioButton();
        attackRadioButton = new RadioButton();
        ultimateRadioButton = new RadioButton();
        actionButton = new Button();
        restartButton = new Button();
        statusLabel = new Label();
        enemyTurnTimer = new System.Windows.Forms.Timer(components);
        ((System.ComponentModel.ISupportInitialize)enemyPictureBox).BeginInit();
        ((System.ComponentModel.ISupportInitialize)playerPictureBox).BeginInit();
        actionGroupBox.SuspendLayout();
        SuspendLayout();
        // 
        // enemyTitleLabel
        // 
        enemyTitleLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        enemyTitleLabel.Location = new Point(545, 15);
        enemyTitleLabel.Name = "enemyTitleLabel";
        enemyTitleLabel.Size = new Size(220, 25);
        enemyTitleLabel.TabIndex = 0;
        enemyTitleLabel.Text = "Враг 1 - лёгкий";
        enemyTitleLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // playerTitleLabel
        // 
        playerTitleLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        playerTitleLabel.Location = new Point(35, 15);
        playerTitleLabel.Name = "playerTitleLabel";
        playerTitleLabel.Size = new Size(220, 25);
        playerTitleLabel.TabIndex = 1;
        playerTitleLabel.Text = "Герой";
        playerTitleLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // enemyPictureBox
        // 
        enemyPictureBox.Location = new Point(545, 45);
        enemyPictureBox.Name = "enemyPictureBox";
        enemyPictureBox.Size = new Size(220, 220);
        enemyPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
        enemyPictureBox.TabIndex = 2;
        enemyPictureBox.TabStop = false;
        // 
        // playerPictureBox
        // 
        playerPictureBox.Location = new Point(35, 45);
        playerPictureBox.Name = "playerPictureBox";
        playerPictureBox.Size = new Size(220, 220);
        playerPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
        playerPictureBox.TabIndex = 3;
        playerPictureBox.TabStop = false;
        // 
        // enemyHealthBar
        // 
        enemyHealthBar.Location = new Point(545, 290);
        enemyHealthBar.Name = "enemyHealthBar";
        enemyHealthBar.Size = new Size(220, 25);
        enemyHealthBar.TabIndex = 4;
        enemyHealthBar.Value = 100;
        // 
        // playerHealthBar
        // 
        playerHealthBar.Location = new Point(35, 290);
        playerHealthBar.Name = "playerHealthBar";
        playerHealthBar.Size = new Size(220, 25);
        playerHealthBar.TabIndex = 5;
        playerHealthBar.Value = 100;
        // 
        // enemyHealthLabel
        // 
        enemyHealthLabel.Location = new Point(545, 320);
        enemyHealthLabel.Name = "enemyHealthLabel";
        enemyHealthLabel.Size = new Size(220, 20);
        enemyHealthLabel.TabIndex = 6;
        enemyHealthLabel.Text = "HP врага: 100/100";
        enemyHealthLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // playerHealthLabel
        // 
        playerHealthLabel.Location = new Point(35, 320);
        playerHealthLabel.Name = "playerHealthLabel";
        playerHealthLabel.Size = new Size(220, 20);
        playerHealthLabel.TabIndex = 7;
        playerHealthLabel.Text = "HP героя: 100";
        playerHealthLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // pointsLabel
        // 
        pointsLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        pointsLabel.Location = new Point(285, 35);
        pointsLabel.Name = "pointsLabel";
        pointsLabel.Size = new Size(230, 25);
        pointsLabel.TabIndex = 8;
        pointsLabel.Text = "Очки действий: 10/10";
        pointsLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // actionGroupBox
        // 
        actionGroupBox.Controls.Add(ultimateRadioButton);
        actionGroupBox.Controls.Add(attackRadioButton);
        actionGroupBox.Controls.Add(healRadioButton);
        actionGroupBox.Location = new Point(290, 75);
        actionGroupBox.Name = "actionGroupBox";
        actionGroupBox.Size = new Size(220, 145);
        actionGroupBox.TabIndex = 9;
        actionGroupBox.TabStop = false;
        actionGroupBox.Text = "Действие";
        // 
        // healRadioButton
        // 
        healRadioButton.AutoSize = true;
        healRadioButton.Location = new Point(25, 30);
        healRadioButton.Name = "healRadioButton";
        healRadioButton.Size = new Size(156, 19);
        healRadioButton.TabIndex = 0;
        healRadioButton.Text = "Похилиться (2 очка)";
        healRadioButton.UseVisualStyleBackColor = true;
        // 
        // attackRadioButton
        // 
        attackRadioButton.AutoSize = true;
        attackRadioButton.Checked = true;
        attackRadioButton.Location = new Point(25, 70);
        attackRadioButton.Name = "attackRadioButton";
        attackRadioButton.Size = new Size(132, 19);
        attackRadioButton.TabIndex = 1;
        attackRadioButton.TabStop = true;
        attackRadioButton.Text = "Удар (2 очка)";
        attackRadioButton.UseVisualStyleBackColor = true;
        // 
        // ultimateRadioButton
        // 
        ultimateRadioButton.AutoSize = true;
        ultimateRadioButton.Location = new Point(25, 110);
        ultimateRadioButton.Name = "ultimateRadioButton";
        ultimateRadioButton.Size = new Size(131, 19);
        ultimateRadioButton.TabIndex = 2;
        ultimateRadioButton.Text = "Ульта (5 очков)";
        ultimateRadioButton.UseVisualStyleBackColor = true;
        // 
        // actionButton
        // 
        actionButton.Location = new Point(315, 235);
        actionButton.Name = "actionButton";
        actionButton.Size = new Size(170, 32);
        actionButton.TabIndex = 10;
        actionButton.Text = "Выполнить действие";
        actionButton.UseVisualStyleBackColor = true;
        actionButton.Click += ActionButton_Click;
        // 
        // restartButton
        // 
        restartButton.Enabled = false;
        restartButton.Location = new Point(335, 285);
        restartButton.Name = "restartButton";
        restartButton.Size = new Size(130, 30);
        restartButton.TabIndex = 11;
        restartButton.Text = "Начать заново";
        restartButton.UseVisualStyleBackColor = true;
        restartButton.Click += RestartButton_Click;
        // 
        // statusLabel
        // 
        statusLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        statusLabel.Location = new Point(35, 360);
        statusLabel.Name = "statusLabel";
        statusLabel.Size = new Size(730, 35);
        statusLabel.TabIndex = 12;
        statusLabel.Text = "Победите первого врага.";
        statusLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // enemyTurnTimer
        // 
        enemyTurnTimer.Interval = 1000;
        enemyTurnTimer.Tick += EnemyTurnTimer_Tick;
        // 
        // BattleForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 415);
        Controls.Add(statusLabel);
        Controls.Add(restartButton);
        Controls.Add(actionButton);
        Controls.Add(actionGroupBox);
        Controls.Add(pointsLabel);
        Controls.Add(playerHealthLabel);
        Controls.Add(enemyHealthLabel);
        Controls.Add(playerHealthBar);
        Controls.Add(enemyHealthBar);
        Controls.Add(playerPictureBox);
        Controls.Add(enemyPictureBox);
        Controls.Add(playerTitleLabel);
        Controls.Add(enemyTitleLabel);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "BattleForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Lesson 9 - Бой";
        ((System.ComponentModel.ISupportInitialize)enemyPictureBox).EndInit();
        ((System.ComponentModel.ISupportInitialize)playerPictureBox).EndInit();
        actionGroupBox.ResumeLayout(false);
        actionGroupBox.PerformLayout();
        ResumeLayout(false);
    }
}
