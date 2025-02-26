using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1.CustomControls
{
    public class CustomLoading
    {
        private Panel overlayPanel;
        private Timer animationTimer;
        private float angle = 0f;

        public CustomLoading(Form parentForm)
        {
            // Initialize the overlay panel and add it to the parent form
            overlayPanel = new Panel
            {
                BackColor = Color.FromArgb(128, 0, 0, 0), // Semi-transparent black
                Dock = DockStyle.Fill,
                Visible = false // Initially hidden
            };
            parentForm.Controls.Add(overlayPanel);

            // Timer for rotating animation
            animationTimer = new Timer
            {
                Interval = 50 // Animation speed (in milliseconds)
            };
            animationTimer.Tick += (sender, e) =>
            {
                angle += 10f;
                if (angle >= 360f)
                {
                    angle = 0f;
                }
                overlayPanel.Invalidate(); // Redraw the panel
            };

            // Panel's Paint event for custom loading animation
            overlayPanel.Paint += (sender, e) =>
            {
                Graphics g = e.Graphics;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                // Center point and radius for the circle
                int width = overlayPanel.Width;
                int height = overlayPanel.Height;
                int radius = 30;

                Point center = new Point(width / 2, height / 2);
                Pen pen = new Pen(Color.White, 5);

                // Rotate the arc to simulate a loading effect
                g.ResetTransform();
                g.RotateTransform(angle);

                // Draw the rotating arc
                g.DrawArc(pen, center.X - radius, center.Y - radius, radius * 2, radius * 2, 0, 180);
            };
        }

        // Method to show the loading overlay
        public void ShowLoading()
        {
            overlayPanel.Visible = true; // Make the panel visible
            animationTimer.Start(); // Start the animation
        }

        // Method to hide the loading overlay
        public void HideLoading()
        {
            overlayPanel.Visible = false; // Hide the panel
            animationTimer.Stop(); // Stop the animation
        }
    }
}
