namespace Lesson12;

public partial class ClickerForm : Form
{
    private const int TargetClicks = 50;

    public event EventHandler<int>? GameCompleted;

    private int clicks;
    private bool completionReported;

    public ClickerForm()
    {
        InitializeComponent();
    }

    private void ClickButton_Click(object? sender, EventArgs e)
    {
        clicks++;
        scoreLabel.Text = $"\u041a\u043b\u0438\u043a\u043e\u0432: {clicks}";

        if (clicks >= TargetClicks && !completionReported)
        {
            completionReported = true;
            statusLabel.Text = "\u0418\u0433\u0440\u0430 \u043f\u0440\u043e\u0439\u0434\u0435\u043d\u0430! +50 \u043e\u0447\u043a\u043e\u0432";
            clickButton.Enabled = false;
            GameCompleted?.Invoke(this, 50);
        }
    }

    private void ResetButton_Click(object? sender, EventArgs e)
    {
        clicks = 0;
        completionReported = false;
        scoreLabel.Text = "\u041a\u043b\u0438\u043a\u043e\u0432: 0";
        statusLabel.Text = $"\u0426\u0435\u043b\u044c: {TargetClicks} \u043a\u043b\u0438\u043a\u043e\u0432";
        clickButton.Enabled = true;
    }
}
