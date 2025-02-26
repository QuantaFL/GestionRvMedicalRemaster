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
    public partial class frmListerRdv : Form
    {
        bdRdvMedicalContext bd = new bdRdvMedicalContext();
        public frmListerRdv()
        {
            InitializeComponent();
            LoadRdv();
        }


        private void frmListerRdv_Load(object sender, EventArgs e)
        {

        }

        private void LoadRdv()
        {
            dgRdv.DataSource = bd.RendezVous.Select(rdv => new
            {
                PatientNomPrenom = rdv.Patient.NomPrenom,
                MedecinNomPrenom = rdv.Medecin.NomPrenom,
                rdv.Soin.NomSoin,
                rdv.DateRv,
                rdv.Patient,

            }).ToList();
        }
    }
}
