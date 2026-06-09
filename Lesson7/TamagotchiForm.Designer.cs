namespace Lesson7;

partial class TamagotchiForm
{
    private System.ComponentModel.IContainer components = null;
    private Label statusLabel;
    private Label timeLabel;
    private Label scoreLabel;
    private Label foodLabel;
    private Label moodLabel;
    private Label sleepLabel;
    private ProgressBar foodProgressBar;
    private ProgressBar moodProgressBar;
    private ProgressBar sleepProgressBar;
    private Button foodButton;
    private Button moodButton;
    private Button sleepButton;
    private Button restartButton;
    private PictureBox petPictureBox;
    private System.Windows.Forms.Timer timer;

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
        statusLabel = new Label();
        timeLabel = new Label();
        scoreLabel = new Label();
        foodLabel = new Label();
        moodLabel = new Label();
        sleepLabel = new Label();
        foodProgressBar = new ProgressBar();
        moodProgressBar = new ProgressBar();
        sleepProgressBar = new ProgressBar();
        foodButton = new Button();
        moodButton = new Button();
        sleepButton = new Button();
        restartButton = new Button();
        petPictureBox = new PictureBox();
        timer = new System.Windows.Forms.Timer(components);
        ((System.ComponentModel.ISupportInitialize)petPictureBox).BeginInit();
        SuspendLayout();
        // 
        // statusLabel
        // 
        statusLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        statusLabel.Location = new Point(20, 15);
        statusLabel.Name = "statusLabel";
        statusLabel.Size = new Size(660, 25);
        statusLabel.TabIndex = 0;
        statusLabel.Text = "Продержитесь 60 секунд!";
        statusLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // timeLabel
        // 
        timeLabel.AutoSize = true;
        timeLabel.Location = new Point(245, 55);
        timeLabel.Name = "timeLabel";
        timeLabel.Size = new Size(59, 15);
        timeLabel.TabIndex = 1;
        timeLabel.Text = "Время: 60";
        // 
        // scoreLabel
        // 
        scoreLabel.AutoSize = true;
        scoreLabel.Location = new Point(590, 55);
        scoreLabel.Name = "scoreLabel";
        scoreLabel.Size = new Size(47, 15);
        scoreLabel.TabIndex = 2;
        scoreLabel.Text = "Очки: 0";
        // 
        // foodLabel
        // 
        foodLabel.AutoSize = true;
        foodLabel.Location = new Point(245, 95);
        foodLabel.Name = "foodLabel";
        foodLabel.Size = new Size(25, 15);
        foodLabel.TabIndex = 3;
        foodLabel.Text = "Еда";
        // 
        // moodLabel
        // 
        moodLabel.AutoSize = true;
        moodLabel.Location = new Point(245, 145);
        moodLabel.Name = "moodLabel";
        moodLabel.Size = new Size(75, 15);
        moodLabel.TabIndex = 4;
        moodLabel.Text = "Настроение";
        // 
        // sleepLabel
        // 
        sleepLabel.AutoSize = true;
        sleepLabel.Location = new Point(245, 195);
        sleepLabel.Name = "sleepLabel";
        sleepLabel.Size = new Size(29, 15);
        sleepLabel.TabIndex = 5;
        sleepLabel.Text = "Сон";
        // 
        // foodProgressBar
        // 
        foodProgressBar.Location = new Point(330, 90);
        foodProgressBar.Name = "foodProgressBar";
        foodProgressBar.Size = new Size(230, 25);
        foodProgressBar.TabIndex = 6;
        foodProgressBar.Value = 100;
        // 
        // moodProgressBar
        // 
        moodProgressBar.Location = new Point(330, 140);
        moodProgressBar.Name = "moodProgressBar";
        moodProgressBar.Size = new Size(230, 25);
        moodProgressBar.TabIndex = 7;
        moodProgressBar.Value = 100;
        // 
        // sleepProgressBar
        // 
        sleepProgressBar.Location = new Point(330, 190);
        sleepProgressBar.Name = "sleepProgressBar";
        sleepProgressBar.Size = new Size(230, 25);
        sleepProgressBar.TabIndex = 8;
        sleepProgressBar.Value = 100;
        // 
        // foodButton
        // 
        foodButton.Location = new Point(580, 90);
        foodButton.Name = "foodButton";
        foodButton.Size = new Size(100, 25);
        foodButton.TabIndex = 9;
        foodButton.Text = "Покормить";
        foodButton.UseVisualStyleBackColor = true;
        foodButton.Click += FoodButton_Click;
        // 
        // moodButton
        // 
        moodButton.Location = new Point(580, 140);
        moodButton.Name = "moodButton";
        moodButton.Size = new Size(100, 25);
        moodButton.TabIndex = 10;
        moodButton.Text = "Поиграть";
        moodButton.UseVisualStyleBackColor = true;
        moodButton.Click += MoodButton_Click;
        // 
        // sleepButton
        // 
        sleepButton.Location = new Point(580, 190);
        sleepButton.Name = "sleepButton";
        sleepButton.Size = new Size(100, 25);
        sleepButton.TabIndex = 11;
        sleepButton.Text = "Поспать";
        sleepButton.UseVisualStyleBackColor = true;
        sleepButton.Click += SleepButton_Click;
        // 
        // restartButton
        // 
        restartButton.Enabled = false;
        restartButton.Location = new Point(440, 240);
        restartButton.Name = "restartButton";
        restartButton.Size = new Size(140, 30);
        restartButton.TabIndex = 12;
        restartButton.Text = "Начать заново";
        restartButton.UseVisualStyleBackColor = true;
        restartButton.Click += RestartButton_Click;
        // 
        // petPictureBox
        // 
        petPictureBox.Cursor = Cursors.Hand;
        petPictureBox.Location = new Point(20, 55);
        petPictureBox.Name = "petPictureBox";
        petPictureBox.Size = new Size(190, 190);
        petPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
        petPictureBox.TabIndex = 13;
        petPictureBox.TabStop = false;
        petPictureBox.Click += PetPictureBox_Click;
        // 
        // timer
        // 
        timer.Enabled = true;
        timer.Interval = 1000;
        timer.Tick += Timer_Tick;
        // 
        // TamagotchiForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(704, 291);
        Controls.Add(petPictureBox);
        Controls.Add(restartButton);
        Controls.Add(sleepButton);
        Controls.Add(moodButton);
        Controls.Add(foodButton);
        Controls.Add(sleepProgressBar);
        Controls.Add(moodProgressBar);
        Controls.Add(foodProgressBar);
        Controls.Add(sleepLabel);
        Controls.Add(moodLabel);
        Controls.Add(foodLabel);
        Controls.Add(scoreLabel);
        Controls.Add(timeLabel);
        Controls.Add(statusLabel);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "TamagotchiForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Тамагочи";
        ((System.ComponentModel.ISupportInitialize)petPictureBox).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }
}
