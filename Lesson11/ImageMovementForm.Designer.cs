namespace Lesson11;

partial class ImageMovementForm
{
    private System.ComponentModel.IContainer components = null;
    private Panel movementPanel;
    private PictureBox movingPictureBox;
    private HScrollBar positionScrollBar;
    private TrackBar speedTrackBar;
    private GroupBox cipherGroupBox;
    private Label cipherModeLabel;
    private DomainUpDown cipherModeDomainUpDown;
    private Label cipherShiftLabel;
    private NumericUpDown cipherShiftNumericUpDown;
    private Label cipherInputLabel;
    private TextBox cipherInputTextBox;
    private Label cipherResultLabel;
    private TextBox cipherResultTextBox;
    private Button addCipherInfoButton;
    private ListView cipherInfoListView;
    private ColumnHeader modeColumnHeader;
    private ColumnHeader shiftColumnHeader;
    private ColumnHeader inputColumnHeader;
    private ColumnHeader resultColumnHeader;
    private System.Windows.Forms.Timer movementTimer;

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
        movementPanel = new Panel();
        movingPictureBox = new PictureBox();
        positionScrollBar = new HScrollBar();
        speedTrackBar = new TrackBar();
        cipherGroupBox = new GroupBox();
        cipherModeLabel = new Label();
        cipherModeDomainUpDown = new DomainUpDown();
        cipherShiftLabel = new Label();
        cipherShiftNumericUpDown = new NumericUpDown();
        cipherInputLabel = new Label();
        cipherInputTextBox = new TextBox();
        cipherResultLabel = new Label();
        cipherResultTextBox = new TextBox();
        addCipherInfoButton = new Button();
        cipherInfoListView = new ListView();
        modeColumnHeader = new ColumnHeader();
        shiftColumnHeader = new ColumnHeader();
        inputColumnHeader = new ColumnHeader();
        resultColumnHeader = new ColumnHeader();
        movementTimer = new System.Windows.Forms.Timer(components);
        movementPanel.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)movingPictureBox).BeginInit();
        ((System.ComponentModel.ISupportInitialize)speedTrackBar).BeginInit();
        cipherGroupBox.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)cipherShiftNumericUpDown).BeginInit();
        SuspendLayout();
        // 
        // movementPanel
        // 
        movementPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        movementPanel.BackColor = Color.White;
        movementPanel.BorderStyle = BorderStyle.FixedSingle;
        movementPanel.Controls.Add(movingPictureBox);
        movementPanel.Location = new Point(40, 30);
        movementPanel.Name = "movementPanel";
        movementPanel.Size = new Size(720, 190);
        movementPanel.TabIndex = 1;
        movementPanel.SizeChanged += MovementPanel_SizeChanged;
        // 
        // movingPictureBox
        // 
        movingPictureBox.Location = new Point(558, 19);
        movingPictureBox.Name = "movingPictureBox";
        movingPictureBox.Size = new Size(160, 150);
        movingPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
        movingPictureBox.TabIndex = 0;
        movingPictureBox.TabStop = false;
        // 
        // positionScrollBar
        // 
        positionScrollBar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        positionScrollBar.Location = new Point(40, 228);
        positionScrollBar.Name = "positionScrollBar";
        positionScrollBar.Size = new Size(720, 17);
        positionScrollBar.TabIndex = 7;
        positionScrollBar.ValueChanged += PositionScrollBar_ValueChanged;
        // 
        // speedTrackBar
        // 
        speedTrackBar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        speedTrackBar.LargeChange = 1;
        speedTrackBar.Location = new Point(40, 255);
        speedTrackBar.Maximum = 5;
        speedTrackBar.Minimum = 1;
        speedTrackBar.Name = "speedTrackBar";
        speedTrackBar.Size = new Size(720, 45);
        speedTrackBar.TabIndex = 8;
        speedTrackBar.TickFrequency = 1;
        speedTrackBar.Value = 3;
        speedTrackBar.ValueChanged += SpeedTrackBar_ValueChanged;
        // 
        // cipherGroupBox
        // 
        cipherGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        cipherGroupBox.Controls.Add(cipherModeLabel);
        cipherGroupBox.Controls.Add(cipherModeDomainUpDown);
        cipherGroupBox.Controls.Add(cipherShiftLabel);
        cipherGroupBox.Controls.Add(cipherShiftNumericUpDown);
        cipherGroupBox.Controls.Add(cipherInputLabel);
        cipherGroupBox.Controls.Add(cipherInputTextBox);
        cipherGroupBox.Controls.Add(cipherResultLabel);
        cipherGroupBox.Controls.Add(cipherResultTextBox);
        cipherGroupBox.Controls.Add(addCipherInfoButton);
        cipherGroupBox.Location = new Point(40, 310);
        cipherGroupBox.Name = "cipherGroupBox";
        cipherGroupBox.Size = new Size(720, 250);
        cipherGroupBox.TabIndex = 9;
        cipherGroupBox.TabStop = false;
        cipherGroupBox.Text = "Шифр Цезаря";
        // 
        // cipherModeLabel
        // 
        cipherModeLabel.AutoSize = true;
        cipherModeLabel.Location = new Point(15, 29);
        cipherModeLabel.Name = "cipherModeLabel";
        cipherModeLabel.Size = new Size(48, 15);
        cipherModeLabel.Text = "Режим:";
        // 
        // cipherModeDomainUpDown
        // 
        cipherModeDomainUpDown.Items.Add("Шифрование");
        cipherModeDomainUpDown.Items.Add("Расшифрование");
        cipherModeDomainUpDown.Location = new Point(69, 25);
        cipherModeDomainUpDown.Name = "cipherModeDomainUpDown";
        cipherModeDomainUpDown.ReadOnly = true;
        cipherModeDomainUpDown.Size = new Size(155, 23);
        cipherModeDomainUpDown.TabIndex = 0;
        cipherModeDomainUpDown.Wrap = true;
        cipherModeDomainUpDown.SelectedItemChanged += UpdateCipherResult;
        // 
        // cipherShiftLabel
        // 
        cipherShiftLabel.AutoSize = true;
        cipherShiftLabel.Location = new Point(247, 29);
        cipherShiftLabel.Name = "cipherShiftLabel";
        cipherShiftLabel.Size = new Size(43, 15);
        cipherShiftLabel.Text = "Сдвиг:";
        // 
        // cipherShiftNumericUpDown
        // 
        cipherShiftNumericUpDown.Location = new Point(296, 25);
        cipherShiftNumericUpDown.Maximum = new decimal(new int[] { 33, 0, 0, 0 });
        cipherShiftNumericUpDown.Name = "cipherShiftNumericUpDown";
        cipherShiftNumericUpDown.Size = new Size(65, 23);
        cipherShiftNumericUpDown.TabIndex = 1;
        cipherShiftNumericUpDown.Value = new decimal(new int[] { 3, 0, 0, 0 });
        cipherShiftNumericUpDown.ValueChanged += UpdateCipherResult;
        // 
        // cipherInputLabel
        // 
        cipherInputLabel.AutoSize = true;
        cipherInputLabel.Location = new Point(15, 65);
        cipherInputLabel.Name = "cipherInputLabel";
        cipherInputLabel.Size = new Size(97, 15);
        cipherInputLabel.Text = "Исходный текст:";
        // 
        // cipherInputTextBox
        // 
        cipherInputTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        cipherInputTextBox.Location = new Point(15, 83);
        cipherInputTextBox.Multiline = true;
        cipherInputTextBox.Name = "cipherInputTextBox";
        cipherInputTextBox.ScrollBars = ScrollBars.Vertical;
        cipherInputTextBox.Size = new Size(690, 60);
        cipherInputTextBox.TabIndex = 2;
        cipherInputTextBox.TextChanged += UpdateCipherResult;
        // 
        // cipherResultLabel
        // 
        cipherResultLabel.AutoSize = true;
        cipherResultLabel.Location = new Point(15, 153);
        cipherResultLabel.Name = "cipherResultLabel";
        cipherResultLabel.Size = new Size(65, 15);
        cipherResultLabel.Text = "Результат:";
        // 
        // cipherResultTextBox
        // 
        cipherResultTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        cipherResultTextBox.Location = new Point(15, 171);
        cipherResultTextBox.Multiline = true;
        cipherResultTextBox.Name = "cipherResultTextBox";
        cipherResultTextBox.ReadOnly = true;
        cipherResultTextBox.ScrollBars = ScrollBars.Vertical;
        cipherResultTextBox.Size = new Size(690, 64);
        cipherResultTextBox.TabIndex = 3;
        // 
        // addCipherInfoButton
        // 
        addCipherInfoButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        addCipherInfoButton.Location = new Point(555, 24);
        addCipherInfoButton.Name = "addCipherInfoButton";
        addCipherInfoButton.Size = new Size(150, 25);
        addCipherInfoButton.TabIndex = 4;
        addCipherInfoButton.Text = "\u0414\u043e\u0431\u0430\u0432\u0438\u0442\u044c \u0432 \u0442\u0430\u0431\u043b\u0438\u0446\u0443";
        addCipherInfoButton.UseVisualStyleBackColor = true;
        addCipherInfoButton.Click += AddCipherInfoButton_Click;
        // 
        // cipherInfoListView
        // 
        cipherInfoListView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        cipherInfoListView.Columns.AddRange(new ColumnHeader[] { modeColumnHeader, shiftColumnHeader, inputColumnHeader, resultColumnHeader });
        cipherInfoListView.FullRowSelect = true;
        cipherInfoListView.GridLines = true;
        cipherInfoListView.Location = new Point(40, 570);
        cipherInfoListView.Name = "cipherInfoListView";
        cipherInfoListView.Size = new Size(720, 180);
        cipherInfoListView.TabIndex = 10;
        cipherInfoListView.UseCompatibleStateImageBehavior = false;
        cipherInfoListView.View = View.Details;
        // 
        // modeColumnHeader
        // 
        modeColumnHeader.Text = "\u0420\u0435\u0436\u0438\u043c";
        modeColumnHeader.Width = 150;
        // 
        // shiftColumnHeader
        // 
        shiftColumnHeader.Text = "\u0421\u0434\u0432\u0438\u0433";
        shiftColumnHeader.Width = 70;
        // 
        // inputColumnHeader
        // 
        inputColumnHeader.Text = "\u0418\u0441\u0445\u043e\u0434\u043d\u044b\u0439 \u0442\u0435\u043a\u0441\u0442";
        inputColumnHeader.Width = 240;
        // 
        // resultColumnHeader
        // 
        resultColumnHeader.Text = "\u0420\u0435\u0437\u0443\u043b\u044c\u0442\u0430\u0442";
        resultColumnHeader.Width = 240;
        // 
        // movementTimer
        // 
        movementTimer.Interval = 20;
        movementTimer.Tick += MovementTimer_Tick;
        // 
        // ImageMovementForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(804, 770);
        Controls.Add(cipherInfoListView);
        Controls.Add(cipherGroupBox);
        Controls.Add(speedTrackBar);
        Controls.Add(positionScrollBar);
        Controls.Add(movementPanel);
        MinimumSize = new Size(600, 650);
        Name = "ImageMovementForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Lesson 11";
        movementPanel.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)movingPictureBox).EndInit();
        ((System.ComponentModel.ISupportInitialize)speedTrackBar).EndInit();
        cipherGroupBox.ResumeLayout(false);
        cipherGroupBox.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)cipherShiftNumericUpDown).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }
}
