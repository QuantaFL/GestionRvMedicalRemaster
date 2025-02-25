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
       
        public frmDashMed()
        {
            InitializeComponent();
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
            CustomNavigatorMdi.push(this, btnListerAgenda, new frmAccueilMed());
        }
    }
}
