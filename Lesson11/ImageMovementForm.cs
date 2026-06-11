namespace Lesson11;

public partial class ImageMovementForm : Form
{
    private int movementSpeed;

    public ImageMovementForm()
    {
        InitializeComponent();
        movingPictureBox.Image = LoadImage("OIP.png");
        cipherModeDomainUpDown.SelectedIndex = 0;
        SpeedTrackBar_ValueChanged(null, EventArgs.Empty);
        SynchronizeScrollBar();
        UpdateCipherResult(null, EventArgs.Empty);
        movementTimer.Start();
    }

    private static Image? LoadImage(string name)
    {
        using Stream? stream = typeof(ImageMovementForm).Assembly.GetManifestResourceStream(name);

        if (stream == null)
        {
            return null;
        }

        using Bitmap image = new(stream);
        return new Bitmap(image);
    }

    private void SpeedTrackBar_ValueChanged(object? sender, EventArgs e)
    {
        movementSpeed = speedTrackBar.Value switch
        {
            1 => 0,
            2 => 5,
            3 => 10,
            4 => 15,
            5 => 25,
            _ => 10
        };
    }

    private void MovementTimer_Tick(object? sender, EventArgs e)
    {
        movingPictureBox.Left -= movementSpeed;

        if (movingPictureBox.Right < 0)
        {
            movingPictureBox.Left = movementPanel.ClientSize.Width;
        }

        SynchronizeScrollBarValue();
    }

    private void PositionScrollBar_ValueChanged(object? sender, EventArgs e)
    {
        movingPictureBox.Left = positionScrollBar.Value - movingPictureBox.Width;
    }

    private void MovementPanel_SizeChanged(object? sender, EventArgs e)
    {
        SynchronizeScrollBar();
    }

    private void SynchronizeScrollBar()
    {
        int travelDistance = movementPanel.ClientSize.Width + movingPictureBox.Width;

        positionScrollBar.LargeChange = Math.Max(1, movingPictureBox.Width);
        positionScrollBar.Maximum = travelDistance + positionScrollBar.LargeChange - 1;
        SynchronizeScrollBarValue();
    }

    private void SynchronizeScrollBarValue()
    {
        int value = movingPictureBox.Left + movingPictureBox.Width;
        int maximumValue = positionScrollBar.Maximum - positionScrollBar.LargeChange + 1;
        positionScrollBar.Value = Math.Clamp(value, positionScrollBar.Minimum, maximumValue);
    }

    private void UpdateCipherResult(object? sender, EventArgs e)
    {
        int shift = (int)cipherShiftNumericUpDown.Value;

        if (cipherModeDomainUpDown.SelectedIndex == 1)
        {
            shift = -shift;
        }

        cipherResultTextBox.Text = CaesarCipher(cipherInputTextBox.Text, shift);
    }

    private static string CaesarCipher(string text, int shift)
    {
        char[] result = text.ToCharArray();

        for (int i = 0; i < result.Length; i++)
        {
            result[i] = ShiftLetter(result[i], shift, 'A', 26);
            result[i] = ShiftLetter(result[i], shift, 'a', 26);
            result[i] = ShiftLetter(result[i], shift, '\u0410', 32);
            result[i] = ShiftLetter(result[i], shift, '\u0430', 32);
        }

        return new string(result);
    }

    private static char ShiftLetter(char value, int shift, char alphabetStart, int alphabetLength)
    {
        if (value < alphabetStart || value >= alphabetStart + alphabetLength)
        {
            return value;
        }

        int position = (value - alphabetStart + shift) % alphabetLength;

        if (position < 0)
        {
            position += alphabetLength;
        }

        return (char)(alphabetStart + position);
    }

    private void AddCipherInfoButton_Click(object? sender, EventArgs e)
    {
        string mode = cipherModeDomainUpDown.SelectedItem?.ToString() ?? string.Empty;
        ListViewItem item = new(mode);
        item.SubItems.Add(cipherShiftNumericUpDown.Value.ToString());
        item.SubItems.Add(cipherInputTextBox.Text);
        item.SubItems.Add(cipherResultTextBox.Text);
        cipherInfoListView.Items.Add(item);
    }
}
