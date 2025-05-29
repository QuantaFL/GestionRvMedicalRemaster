using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetierRvMedical2.Services;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.views.Secret
{
    public partial class frmListerPatient : Form
    {

        private readonly PatientService _patientService = new PatientService();
        public frmListerPatient()
        {
            InitializeComponent();
            LoadAllPatient();
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadAllPatient()
        {
            dgPatients.DataSource = _patientService.GetAllPatients().Select(p => new
            {
                p.NomPrenom,
                p.Addresse,
                p.Email,
                p.Tel,
            }).ToList();
        }

        private void btnRechercherPatient_Click(object sender, EventArgs e)
        {

        }
    }
}
