using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

public class CustomControlBox : UserControl
{
    private Button btnMinimize;
    private Button btnClose;
    private Color backgroundColor = Color.FromArgb(65, 114, 144);
    private Color buttonHoverColor = Color.FromArgb(85, 134, 164);
    private Color closeButtonHoverColor = Color.FromArgb(232, 17, 35);

    public event EventHandler MinimizeClick;
    public event EventHandler CloseClick;

    public Color BackgroundColor
    {
        get { return backgroundColor; }
        set
        {
            backgroundColor = value;
            this.BackColor = value;
            Invalidate();
        }
    }

    public CustomControlBox()
    {
        this.Height = 144;
        this.Dock = DockStyle.Top;
        this.BackColor = backgroundColor;

        btnMinimize = new Button();
        btnClose = new Button();

        InitializeButton(btnMinimize, "-");
        InitializeButton(btnClose, "x");

        UpdateButtonPositions();

        btnMinimize.Click += (sender, e) => MinimizeClick?.Invoke(sender, e);
        btnClose.Click += (sender, e) => CloseClick?.Invoke(sender, e);

        btnMinimize.MouseEnter += (sender, e) => { btnMinimize.BackColor = buttonHoverColor; btnMinimize.ForeColor = Color.White; };
        btnMinimize.MouseLeave += (sender, e) => { btnMinimize.BackColor = backgroundColor; btnMinimize.ForeColor = Color.White; };

        btnClose.MouseEnter += (sender, e) => {
            btnClose.BackColor = closeButtonHoverColor;
            btnClose.ForeColor = Color.White;
        };
        btnClose.MouseLeave += (sender, e) => {
            btnClose.BackColor = backgroundColor;
            btnClose.ForeColor = Color.White;
        };
        btnMinimize.Height = 40;
        btnClose.Height = 40;

        Controls.Add(btnMinimize);
        Controls.Add(btnClose);
    }

    private void InitializeButton(Button button, string text)
    {
        if (button == null) return;

        button.Text = text;
        button.Size = new Size(24, 24);
        button.FlatStyle = FlatStyle.Flat;
        button.FlatAppearance.BorderSize = 0;
        button.BackColor = backgroundColor;
        button.ForeColor = Color.White;
        button.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        button.Cursor = Cursors.Hand;
        button.TabStop = false;
        button.FlatAppearance.MouseOverBackColor = button == btnClose ? closeButtonHoverColor : buttonHoverColor;
    }

    private void UpdateButtonPositions()
    {
        if (btnMinimize != null)
            btnMinimize.Location = new Point(Width - 48, 0);

        if (btnClose != null)
            btnClose.Location = new Point(Width - 24, 0);
    }

    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);
        UpdateButtonPositions();
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        using (LinearGradientBrush brush = new LinearGradientBrush(
            this.ClientRectangle,
            Color.FromArgb(backgroundColor.R + 10, backgroundColor.G + 10, backgroundColor.B + 10),
            backgroundColor,
            LinearGradientMode.Vertical))
        {
            e.Graphics.FillRectangle(brush, this.ClientRectangle);
        }

        if (btnMinimize != null) btnMinimize.BringToFront();
        if (btnClose != null) btnClose.BringToFront();
    }

    public void AdaptToParentBackground(Color color)
    {
        backgroundColor = color;
        BackColor = color;

        if (btnMinimize != null) btnMinimize.BackColor = color;
        if (btnClose != null) btnClose.BackColor = color;

        Invalidate();
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            if (btnMinimize != null)
            {
                btnMinimize.Dispose();
                btnMinimize = null;
            }

            if (btnClose != null)
            {
                btnClose.Dispose();
                btnClose = null;
            }
        }

        base.Dispose(disposing);
    }
}