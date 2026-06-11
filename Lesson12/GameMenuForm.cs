using Lesson7;
using Lesson9;

namespace Lesson12;

public partial class GameMenuForm : Form
{
    private TamagotchiForm? tamagotchiForm;
    private ClickerForm? clickerForm;
    private BattleForm? battleForm;
    private int tamagotchiScore;
    private int clickerScore;
    private int battleScore;

    public GameMenuForm()
    {
        InitializeComponent();
    }

    private void TamagotchiButton_Click(object? sender, EventArgs e)
    {
        if (tamagotchiForm is { IsDisposed: false })
        {
            tamagotchiForm.Activate();
            return;
        }

        tamagotchiForm = new TamagotchiForm();
        tamagotchiForm.GameCompleted += TamagotchiForm_GameCompleted;
        tamagotchiForm.FormClosed += TamagotchiForm_FormClosed;
        Hide();
        tamagotchiForm.Show();
    }

    private void ClickerButton_Click(object? sender, EventArgs e)
    {
        if (clickerForm is { IsDisposed: false })
        {
            clickerForm.Activate();
            return;
        }

        clickerForm = new ClickerForm();
        clickerForm.GameCompleted += ClickerForm_GameCompleted;
        clickerForm.FormClosed += ClickerForm_FormClosed;
        Hide();
        clickerForm.Show();
    }

    private void BattleButton_Click(object? sender, EventArgs e)
    {
        if (battleForm is { IsDisposed: false })
        {
            battleForm.Activate();
            return;
        }

        battleForm = new BattleForm();
        battleForm.GameCompleted += BattleForm_GameCompleted;
        battleForm.FormClosed += BattleForm_FormClosed;
        Hide();
        battleForm.Show();
    }

    private void TamagotchiForm_GameCompleted(object? sender, int points)
    {
        tamagotchiScore += points;
        UpdateScoreLabels();
    }

    private void ClickerForm_GameCompleted(object? sender, int points)
    {
        clickerScore += points;
        UpdateScoreLabels();
    }

    private void BattleForm_GameCompleted(object? sender, int points)
    {
        battleScore += points;
        UpdateScoreLabels();
    }

    private void TamagotchiForm_FormClosed(object? sender, FormClosedEventArgs e)
    {
        if (tamagotchiForm != null)
        {
            tamagotchiForm.GameCompleted -= TamagotchiForm_GameCompleted;
            tamagotchiForm.FormClosed -= TamagotchiForm_FormClosed;
            tamagotchiForm = null;
        }

        RestoreMenu();
    }

    private void ClickerForm_FormClosed(object? sender, FormClosedEventArgs e)
    {
        if (clickerForm != null)
        {
            clickerForm.GameCompleted -= ClickerForm_GameCompleted;
            clickerForm.FormClosed -= ClickerForm_FormClosed;
            clickerForm = null;
        }

        RestoreMenu();
    }

    private void BattleForm_FormClosed(object? sender, FormClosedEventArgs e)
    {
        if (battleForm != null)
        {
            battleForm.GameCompleted -= BattleForm_GameCompleted;
            battleForm.FormClosed -= BattleForm_FormClosed;
            battleForm = null;
        }

        RestoreMenu();
    }

    private void RestoreMenu()
    {
        Show();
        Activate();
    }

    private void UpdateScoreLabels()
    {
        tamagotchiScoreLabel.Text = $"\u0422\u0430\u043c\u0430\u0433\u043e\u0447\u0438: {tamagotchiScore}";
        clickerScoreLabel.Text = $"\u041a\u043b\u0438\u043a\u0435\u0440: {clickerScore}";
        battleScoreLabel.Text = $"\u0424\u0430\u0439\u0442\u0438\u043d\u0433: {battleScore}";
        totalScoreLabel.Text = $"\u041e\u0431\u0449\u0430\u044f \u0441\u0443\u043c\u043c\u0430: {tamagotchiScore + clickerScore + battleScore}";
    }
}
