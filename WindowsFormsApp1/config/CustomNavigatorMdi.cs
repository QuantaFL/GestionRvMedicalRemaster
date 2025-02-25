using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.config
{
    class CustomNavigatorMdi
    {
        public static void fermer(Form mdiParent)
        {
            Form[] charr = mdiParent.MdiChildren;
            foreach (Form f in charr)
            {
                f.Close();
            }
        }

        public static void push(Form mdiParent, Button buttonToDisable, Form mdiChild)
        {
            buttonToDisable.Enabled = false;

            fermer(mdiParent);

            mdiChild.MdiParent = mdiParent;
            mdiChild.Show();
            mdiChild.WindowState = FormWindowState.Maximized;

            mdiChild.FormClosed += (s, args) =>
            {
                buttonToDisable.Enabled = true;
            };
        }

    }
}
