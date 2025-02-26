using Org.BouncyCastle.Security;
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

namespace WindowsFormsApp1.views.Med
{
    public partial class frmRdvMed : Form
    {
        public frmRdvMed()
        {
            InitializeComponent();
            loadRdv();
        }

        bdRdvMedicalContext bd = new bdRdvMedicalContext();

        private void frmRdvMed_Load(object sender, EventArgs e)
        {

        }

        private void loadRdv()
        {
            
           Medecin currentMedecin = (Medecin)FrmConnexion.user;
            var date = DateTime.Now.Date.ToString();
            var rdvs = bd.RendezVous.Where(r=> r.IdMedecin == currentMedecin.IdP
           ).ToList();
                dgRdvMedecin.DataSource = rdvs.Where(rv=>DateTime.Parse(rv.DateRv).Date.ToString()==date).Select(rdv => new
                {
                   Heure = rdv.HeureRv,
                   DateRv = rdv.DateRv,
                   Patient=rdv.Patient.NomPrenom,
                   Soin = rdv.Soin.NomSoin,

                }).ToList();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgRdvMedecin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
