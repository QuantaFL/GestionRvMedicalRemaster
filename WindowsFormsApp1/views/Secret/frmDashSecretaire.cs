using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.config;
using WindowsFormsApp1.CustomControls;

namespace WindowsFormsApp1.views.Secret
{
    public partial class frmDashSecretaire : Form
    {
        FrmConnexion frmConnexionInstance;
        public frmDashSecretaire(FrmConnexion f)
        {
            InitializeComponent();
            frmConnexionInstance = f;


        }
        public void fermer()
        {
            Form[] charr = this.MdiChildren;
            foreach (Form f in charr)
            {
                f.Close();
            }
        }
        private void frmDashSecretaire_Load(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is MdiClient)
                {
                    control.BackColor = Color.White;
                }
            }
            Computer myComputer = new Computer();
            this.Width = myComputer.Screen.Bounds.Width;
           this.Height = myComputer.Screen.Bounds.Height;
            this.Location = new Point(0, 0);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }


        private void btnPatient_Click(object sender, EventArgs e)
        {
            CustomNavigatorMdi.push(this, btnListeUtilisateur, new frmListerPatient());
        }

        private void btnListeUtilisateur_Click(object sender, EventArgs e)
        {
            CustomNavigatorMdi.push(this, btnListeUtilisateur, new frmAcceuilSecret());
        }

        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            frmConnexionInstance.Show();
        }

        private void btnCorbeille_Click(object sender, EventArgs e)
        {
            CustomNavigatorMdi.push(this, btnListeUtilisateur, new frmListerAgenda());
        }
    }
}
