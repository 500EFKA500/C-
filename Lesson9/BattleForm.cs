namespace Lesson9;

public partial class BattleForm : Form
{
    private readonly Random random = new();
    private int playerPoints = 10;
    private int enemyNumber = 1;

    public BattleForm()
    {
        InitializeComponent();
        playerPictureBox.Image = LoadImage("OIP.png");
        StartFirstEnemy();
    }

    private static Image? LoadImage(string name)
    {
        using Stream? stream = typeof(BattleForm).Assembly.GetManifestResourceStream(name);

        if (stream == null)
        {
            return null;
        }

        using Bitmap image = new(stream);
        return new Bitmap(image);
    }

    private void ActionButton_Click(object? sender, EventArgs e)
    {
        int cost = ultimateRadioButton.Checked ? 5 : 2;

        if (playerPoints < cost)
        {
            statusLabel.Text = "Недостаточно очков для действия!";
            return;
        }

        playerPoints -= cost;

        if (healRadioButton.Checked)
        {
            int heal = random.Next(15, 26);
            playerHealthBar.Value = Math.Min(100, playerHealthBar.Value + heal);
            statusLabel.Text = $"Вы восстановили {heal} HP.";
        }
        else if (attackRadioButton.Checked)
        {
            int damage = random.Next(12, 21);
            enemyHealthBar.Value = Math.Max(0, enemyHealthBar.Value - damage);
            statusLabel.Text = $"Вы нанесли врагу {damage} урона.";
        }
        else
        {
            int damage = random.Next(30, 46);
            enemyHealthBar.Value = Math.Max(0, enemyHealthBar.Value - damage);
            statusLabel.Text = $"Ульта нанесла врагу {damage} урона!";
        }

        UpdateLabels();

        if (CheckGameOver())
        {
            return;
        }

        actionButton.Enabled = false;
        statusLabel.Text += " Ход врага...";
        enemyTurnTimer.Start();
    }

    private void EnemyTurnTimer_Tick(object? sender, EventArgs e)
    {
        enemyTurnTimer.Stop();

        int healChance = enemyNumber == 1 ? 3 : 2;
        bool enemyHeals = enemyHealthBar.Value <= 70 && random.Next(healChance) == 0;

        if (enemyHeals)
        {
            int heal = enemyNumber == 1 ? random.Next(8, 16) : random.Next(15, 26);
            enemyHealthBar.Value = Math.Min(enemyHealthBar.Maximum, enemyHealthBar.Value + heal);
            statusLabel.Text = $"Враг {enemyNumber} восстановил {heal} HP.";
        }
        else
        {
            int damage = enemyNumber == 1 ? random.Next(7, 15) : random.Next(16, 28);
            playerHealthBar.Value = Math.Max(0, playerHealthBar.Value - damage);
            statusLabel.Text = $"Враг {enemyNumber} нанёс вам {damage} урона.";
        }

        playerPoints = Math.Min(10, playerPoints + 2);
        UpdateLabels();

        if (!CheckGameOver())
        {
            actionButton.Enabled = true;
        }
    }

    private bool CheckGameOver()
    {
        if (playerHealthBar.Value == 0)
        {
            statusLabel.Text = "Поражение! Герой проиграл.";
            EndGame();
            return true;
        }

        if (enemyHealthBar.Value == 0)
        {
            if (enemyNumber == 1)
            {
                StartSecondEnemy();
            }
            else
            {
                statusLabel.Text = "Победа! Вы победили двух врагов.";
                EndGame();
            }

            return true;
        }

        return false;
    }

    private void StartFirstEnemy()
    {
        enemyNumber = 1;
        enemyTitleLabel.Text = "Враг 1 - лёгкий";
        enemyPictureBox.Image = LoadImage("noFun.png");
        enemyHealthBar.Maximum = 100;
        enemyHealthBar.Value = 100;
        statusLabel.Text = "Победите первого врага.";
        UpdateLabels();
    }

    private void StartSecondEnemy()
    {
        enemyNumber = 2;
        enemyTitleLabel.Text = "Враг 2 - сложный";
        enemyPictureBox.Image = LoadImage("fun.png");
        enemyHealthBar.Maximum = 130;
        enemyHealthBar.Value = 130;
        playerHealthBar.Value = Math.Min(100, playerHealthBar.Value + 25);
        playerPoints = 10;
        statusLabel.Text = "Первый враг побеждён! Появился сложный враг.";
        actionButton.Enabled = true;
        UpdateLabels();
    }

    private void EndGame()
    {
        enemyTurnTimer.Stop();
        actionButton.Enabled = false;
        restartButton.Enabled = true;
    }

    private void RestartButton_Click(object? sender, EventArgs e)
    {
        playerHealthBar.Value = 100;
        playerPoints = 10;
        attackRadioButton.Checked = true;
        actionButton.Enabled = true;
        restartButton.Enabled = false;
        StartFirstEnemy();
    }

    private void UpdateLabels()
    {
        enemyHealthLabel.Text = $"HP врага: {enemyHealthBar.Value}/{enemyHealthBar.Maximum}";
        playerHealthLabel.Text = $"HP героя: {playerHealthBar.Value}";
        pointsLabel.Text = $"Очки действий: {playerPoints}/10";
    }
}
