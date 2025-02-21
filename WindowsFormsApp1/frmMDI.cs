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
using WindowsFormsApp1.views;

namespace WindowsFormsApp1
{
    public partial class frmMDI : Form
    {
        public frmMDI()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmConnexion frmConnexion = new FrmConnexion();
            frmConnexion.Show();
            this.Close();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void fermer()
        {
            Form[] charr = this.MdiChildren;
            foreach (Form f in charr)
            {
                f.Close();
            }
        }

        private void frmMDI_Load(object sender, EventArgs e)
        {
            Computer myComputer = new Computer();
            this.Width= myComputer.Screen.Bounds.Width;
            this.Height= myComputer.Screen.Bounds.Height;
            this.Location = new Point(0,0);
        }

        private void patientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            frmPatient frmPatient = new frmPatient();
            frmPatient.MdiParent = this;
            frmPatient.Show();
            frmPatient.WindowState = FormWindowState.Maximized;

        }

        private void medecinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            frmMedecin frmMedecin = new frmMedecin();
            frmMedecin.MdiParent = this;
            frmMedecin.Show();
            frmMedecin.WindowState = FormWindowState.Maximized;
        }

        private void rendezvousToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            frmRdv frmRdv = new frmRdv();
            frmRdv.MdiParent = this;
            frmRdv.Show();
            frmRdv.WindowState = FormWindowState.Maximized;

        }
    }
}
