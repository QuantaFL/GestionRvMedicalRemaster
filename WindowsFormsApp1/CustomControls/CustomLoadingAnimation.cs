using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace WindowsFormsApp1 // Change this to match your project namespace
{
    public class CustomLoadingAnimation : UserControl // Changed from Control to UserControl
    {
        // Animation properties
        private int numberOfDots = 8;
        private int dotSize = 8;
        private int radius = 30;
        private Color dotColor = Color.FromArgb(65, 114, 144);
        private Color activeDotColor = Color.FromArgb(25, 74, 104);
        private int rotationSpeed = 100; // Milliseconds per step
        private int activeIndex = 0;
        private Timer animationTimer;
        private bool isAnimating = false;

        // Optional overlay properties
        private bool showOverlay = true;
        private Color overlayColor = Color.FromArgb(200, 240, 240, 240);
        private string loadingText = "Loading...";
        private Font textFont = new Font("Segoe UI", 10F, FontStyle.Regular);
        private Color textColor = Color.FromArgb(65, 114, 144);

        // Public properties with UI category attributes
        [Category("Animation"), Description("Number of dots in the animation")]
        public int NumberOfDots
        {
            get { return numberOfDots; }
            set { numberOfDots = value; Invalidate(); }
        }

        [Category("Animation"), Description("Size of each dot in pixels")]
        public int DotSize
        {
            get { return dotSize; }
            set { dotSize = value; Invalidate(); }
        }

        [Category("Animation"), Description("Radius of the circle on which dots are placed")]
        public int Radius
        {
            get { return radius; }
            set { radius = value; Invalidate(); }
        }

        [Category("Animation"), Description("Color of inactive dots")]
        public Color DotColor
        {
            get { return dotColor; }
            set { dotColor = value; Invalidate(); }
        }

        [Category("Animation"), Description("Color of active dots")]
        public Color ActiveDotColor
        {
            get { return activeDotColor; }
            set { activeDotColor = value; Invalidate(); }
        }

        [Category("Animation"), Description("Speed of animation (milliseconds per step, lower is faster)")]
        public int RotationSpeed
        {
            get { return rotationSpeed; }
            set
            {
                rotationSpeed = value;
                if (animationTimer != null)
                    animationTimer.Interval = value;
            }
        }

        [Category("Overlay"), Description("Whether to show a background overlay")]
        public bool ShowOverlay
        {
            get { return showOverlay; }
            set { showOverlay = value; Invalidate(); }
        }

        [Category("Overlay"), Description("Color of the background overlay")]
        public Color OverlayColor
        {
            get { return overlayColor; }
            set { overlayColor = value; Invalidate(); }
        }

        [Category("Overlay"), Description("Text to display while loading")]
        public string LoadingText
        {
            get { return loadingText; }
            set { loadingText = value; Invalidate(); }
        }

        [Category("Overlay"), Description("Font for loading text")]
        public Font TextFont
        {
            get { return textFont; }
            set { textFont = value; Invalidate(); }
        }

        [Category("Overlay"), Description("Color of loading text")]
        public Color TextColor
        {
            get { return textColor; }
            set { textColor = value; Invalidate(); }
        }

        // Constructor
        public CustomLoadingAnimation()
        {
            // Set control properties
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.UserPaint |
                     ControlStyles.ResizeRedraw, true);

            // Initialize animation timer
            animationTimer = new Timer();
            animationTimer.Interval = rotationSpeed;
            animationTimer.Tick += AnimationTimer_Tick;

            // Set default size
            this.Size = new Size(100, 100);
        }

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            activeIndex = (activeIndex + 1) % numberOfDots;
            this.Invalidate();
        }

        // Start the animation
        public void StartAnimation()
        {
            if (!isAnimating)
            {
                isAnimating = true;
                animationTimer.Start();
                this.Visible = true;
                this.BringToFront();
            }
        }

        // Stop the animation
        public void StopAnimation()
        {
            if (isAnimating)
            {
                animationTimer.Stop();
                isAnimating = false;
                this.Visible = false;
            }
        }

        // Show as overlay to a specific form
        public void ShowAsOverlay(Form form)
        {
            if (form != null)
            {
                this.Parent = form;
                this.Dock = DockStyle.Fill;

                this.BringToFront();

                if (!form.Controls.Contains(this))
                {
                    form.Controls.Add(this);
                }

                StartAnimation();
            }
        }

        // Painting the animation
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;

            // Draw overlay if enabled
            if (showOverlay)
            {
                using (SolidBrush overlayBrush = new SolidBrush(overlayColor))
                {
                    g.FillRectangle(overlayBrush, this.ClientRectangle);
                }
            }

            // Calculate center of control
            int centerX = this.Width / 2;
            int centerY = this.Height / 2;

            // Draw the dots in a circle
            for (int i = 0; i < numberOfDots; i++)
            {
                // Calculate position on the circle
                double angle = 2 * Math.PI * i / numberOfDots;
                int x = centerX + (int)(radius * Math.Cos(angle));
                int y = centerY + (int)(radius * Math.Sin(angle));

                // Determine the color of the dot based on its position
                Color currentDotColor = (i == activeIndex) ? activeDotColor : dotColor;

                // Create a rectangle for the dot
                Rectangle dotRect = new Rectangle(x - dotSize / 2, y - dotSize / 2, dotSize, dotSize);

                // Draw dot with alpha blending based on position relative to active index
                int distance = Math.Abs(i - activeIndex);
                distance = Math.Min(distance, numberOfDots - distance); // Get shortest distance in circular array

                float alpha = 1.0f - (float)distance / (numberOfDots / 2);
                alpha = Math.Max(0.3f, alpha); // Minimum alpha value

                using (SolidBrush brush = new SolidBrush(Color.FromArgb(
                    (int)(alpha * 255),
                    currentDotColor.R,
                    currentDotColor.G,
                    currentDotColor.B)))
                {
                    g.FillEllipse(brush, dotRect);
                }
            }

            // Draw loading text
            if (!string.IsNullOrEmpty(loadingText))
            {
                using (SolidBrush textBrush = new SolidBrush(textColor))
                {
                    SizeF textSize = g.MeasureString(loadingText, textFont);
                    PointF textLocation = new PointF(
                        centerX - textSize.Width / 2,
                        centerY + radius + dotSize + 10
                    );

                    g.DrawString(loadingText, textFont, textBrush, textLocation);
                }
            }
        }

        // Properly override the Dispose method
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (animationTimer != null)
                {
                    animationTimer.Stop();
                    animationTimer.Tick -= AnimationTimer_Tick;
                    animationTimer.Dispose();
                    animationTimer = null;
                }

                if (textFont != null)
                {
                    textFont.Dispose();
                    textFont = null;
                }
            }

            base.Dispose(disposing);
        }

        // Static helper method to show loading on a form
        public static CustomLoadingAnimation ShowLoading(Form parent, string text = "Loading...")
        {
            CustomLoadingAnimation loader = new CustomLoadingAnimation();
            loader.LoadingText = text;
            loader.ShowAsOverlay(parent);
            return loader;
        }
    }
}