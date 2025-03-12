using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Devices;
using WindowsFormsApp1.config;
using WindowsFormsApp1.views.Secret;

namespace WindowsFormsApp1.views.Med
{
    public partial class frmDashMed : Form
    {
        FrmConnexion frmConnexionInstance;
        private CustomControlBox customControlBox;

        public frmDashMed(FrmConnexion f)
        {
            customControlBox = new CustomControlBox();
            customControlBox.Dock = DockStyle.Top;
            customControlBox.MinimizeClick += CustomControlBox_MinimizeClick;
            customControlBox.CloseClick += CustomControlBox_CloseClick;
            Controls.Add(customControlBox);
            InitializeComponent();
            frmConnexionInstance = f;
        }
        private void CustomControlBox_MinimizeClick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CustomControlBox_CloseClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDashMed_Load(object sender, EventArgs e)
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

        private void btnListerAgenda_Click(object sender, EventArgs e)
        {
            //CustomNavigatorMdi.push(this, btnListerAgenda, new frmAccueilMed());
            frmAccueilMed frmAccueilMed = new frmAccueilMed();
            frmAccueilMed.Show();
        }

        private void btnRdvMedecin_Click(object sender, EventArgs e)
        {
           // CustomNavigatorMdi.push(this, btnListerAgenda, new frmRdvMed()); 
            frmRdvMed frmRdvMed = new frmRdvMed();  
            frmRdvMed.Show();
            
        }

        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            this.Close();
            frmConnexionInstance.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMedAgenda frmMedAgenda = new frmMedAgenda();
            frmMedAgenda.Show();
        }
    }
}
