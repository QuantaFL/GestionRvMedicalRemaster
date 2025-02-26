using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.views.Secret
{
    public partial class frmListerPatient : Form
    {
        public frmListerPatient()
        {
            InitializeComponent();
            LoadAllPatient();
        }

        bdRdvMedicalContext bd = new bdRdvMedicalContext();

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadAllPatient()
        {
            dgPatients.DataSource = bd.Patients.Select(p => new
            {
                p.NomPrenom,
                p.Addresse,
                p.Email,
                p.Tel,
            }).ToList();
        }
    }
}
