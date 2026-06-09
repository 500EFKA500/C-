namespace Lesson7;

public partial class TamagotchiForm : Form
{
    private int secondsLeft = 60;
    private int score;
    private int decreaseAmount = 1;
    private Image? normalImage;
    private Image? funImage;
    private Image? noFunImage;

    public TamagotchiForm()
    {
        InitializeComponent();
        LoadPetImages();
        UpdateLabels();
    }

    private void LoadPetImages()
    {
        normalImage = LoadImage("OIP.png");
        funImage = LoadImage("fun.png");
        noFunImage = LoadImage("noFun.png");
    }

    private static Image? LoadImage(string name)
    {
        using Stream? stream = typeof(TamagotchiForm).Assembly.GetManifestResourceStream(name);

        if (stream == null)
        {
            return null;
        }

        using Bitmap image = new(stream);
        return new Bitmap(image);
    }

    private void Timer_Tick(object? sender, EventArgs e)
    {
        secondsLeft--;

        Decrease(foodProgressBar);
        Decrease(moodProgressBar);
        Decrease(sleepProgressBar);

        if (secondsLeft == 40 || secondsLeft == 20)
        {
            decreaseAmount++;
        }

        if (foodProgressBar.Value == 0 ||
            moodProgressBar.Value == 0 ||
            sleepProgressBar.Value == 0)
        {
            FinishGame("Питомец заболел. Вы проиграли!");
        }
        else if (secondsLeft == 0)
        {
            FinishGame("Победа! Питомец счастлив!");
        }

        UpdateLabels();
    }

    private void FoodButton_Click(object? sender, EventArgs e)
    {
        Increase(foodProgressBar, 15);
    }

    private void MoodButton_Click(object? sender, EventArgs e)
    {
        Increase(moodProgressBar, 15);
    }

    private void SleepButton_Click(object? sender, EventArgs e)
    {
        Increase(sleepProgressBar, 15);
    }

    private void PetPictureBox_Click(object? sender, EventArgs e)
    {
        Increase(moodProgressBar, 5);
    }

    private void RestartButton_Click(object? sender, EventArgs e)
    {
        foodProgressBar.Value = 100;
        moodProgressBar.Value = 100;
        sleepProgressBar.Value = 100;
        secondsLeft = 60;
        score = 0;
        decreaseAmount = 1;
        statusLabel.Text = "Продержитесь 60 секунд!";
        restartButton.Enabled = false;
        SetButtonsEnabled(true);
        timer.Start();
        UpdateLabels();
    }

    private void Increase(ProgressBar progressBar, int amount)
    {
        progressBar.Value = Math.Min(100, progressBar.Value + amount);
        score += 10;
        UpdateLabels();
    }

    private void Decrease(ProgressBar progressBar)
    {
        progressBar.Value = Math.Max(0, progressBar.Value - decreaseAmount);
    }

    private void FinishGame(string text)
    {
        timer.Stop();
        statusLabel.Text = text;
        restartButton.Enabled = true;
        SetButtonsEnabled(false);
    }

    private void SetButtonsEnabled(bool enabled)
    {
        foodButton.Enabled = enabled;
        moodButton.Enabled = enabled;
        sleepButton.Enabled = enabled;
        petPictureBox.Enabled = enabled;
    }

    private void UpdateLabels()
    {
        timeLabel.Text = $"Время: {secondsLeft}";
        scoreLabel.Text = $"Очки: {score}";
        UpdatePetImage();
    }

    private void UpdatePetImage()
    {
        int happiness = (foodProgressBar.Value +
                         moodProgressBar.Value +
                         sleepProgressBar.Value) / 3;

        if (happiness > 60)
        {
            petPictureBox.Image = funImage;
        }
        else if (happiness < 30)
        {
            petPictureBox.Image = noFunImage;
        }
        else
        {
            petPictureBox.Image = normalImage;
        }
    }
}
