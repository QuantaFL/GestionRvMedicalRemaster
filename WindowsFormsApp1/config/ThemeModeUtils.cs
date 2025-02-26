using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.config
{
    class ThemeModeUtils
    {
        public static void ApplyDarkMode(Form form)
        {
            ApplyDarkModeToControl(form);

            foreach (Form child in form.MdiChildren)
            {
                ApplyDarkModeToControl(child);
            }
        }

        private static void ApplyDarkModeToControl(Control control)
        {
            control.BackColor = Color.FromArgb(30, 30, 30);
            control.ForeColor = Color.White;

            foreach (Control child in control.Controls)
            {
                ApplyDarkModeToControl(child);
            }
        }

    }
}
