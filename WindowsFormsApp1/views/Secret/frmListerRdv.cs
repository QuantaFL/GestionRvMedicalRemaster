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
    public partial class frmListerRdv : Form
    {
        bdRdvMedicalContext bd = new bdRdvMedicalContext();
        private readonly RendezVousService _rendezVousService = new RendezVousService();
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
            dgRdv.DataSource = _rendezVousService.GetAllRendezVous().Select(rdv => new
            {
                PatientNomPrenom = rdv.Patient.NomPrenom,
                MedecinNomPrenom = rdv.Medecin.NomPrenom,
                rdv.Soin.NomSoin,
                rdv.DateRv,


            }).ToList();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
