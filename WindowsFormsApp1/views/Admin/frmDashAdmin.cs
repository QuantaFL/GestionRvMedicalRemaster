using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;
using Serilog;

namespace WindowsFormsApp1.views.Admin
{
    public partial class frmDashAdmin : Form
    {
        private CustomControlBox customControlBox;
        public frmDashAdmin()
        {
            InitializeComponent();
            lblNomUtilisateur.Text = FrmConnexion.user.NomPrenom;
            customControlBox = new CustomControlBox();
            customControlBox.Dock = DockStyle.Top;
            customControlBox.MinimizeClick += CustomControlBox_MinimizeClick;
            customControlBox.CloseClick += CustomControlBox_CloseClick;
            Controls.Add(customControlBox);
        }
        private void CustomControlBox_MinimizeClick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CustomControlBox_CloseClick(object sender, EventArgs e)
        {
            this.Close();
        }
        private void fermer()
        {
            Form[] charr = this.MdiChildren;
            foreach (Form f in charr)
            {
                f.Close();
            }
        }


        private void frmDashAdmin_Load(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls) {
                if (control is MdiClient) { 
                    control.BackColor = Color.White;
                }
            }
            Computer myComputer = new Computer();
            this.Width = myComputer.Screen.Bounds.Width;
            this.Height = myComputer.Screen.Bounds.Height;
            this.Location = new Point(0, 0);
        }

        private void btnListeUtilisateur_Click(object sender, EventArgs e)
        {
            fermer();
            frmAccueilAdmin frmAccueilAdmin = new frmAccueilAdmin();
            frmAccueilAdmin.MdiParent = this;
            frmAccueilAdmin.Show();
            frmAccueilAdmin.WindowState = FormWindowState.Maximized;

        }

        private void btnCorbeille_Click(object sender, EventArgs e)
        {
            /*
                    Log.Information("hello");
            frmMessage frmMessage = new frmMessage("Tentative de suppression");
            frmMessage.Show();
            if (frmMessage.CustomDialogResult == 0) {
                Log.Information("NON");

            }
            else
            {
                Log.Information("OUI2");
            }
             
             */
        }

        private void btnTest_Click(object sender, EventArgs e)
        {

        }
    }
}
