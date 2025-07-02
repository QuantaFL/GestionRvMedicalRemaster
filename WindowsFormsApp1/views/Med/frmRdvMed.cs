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
using Org.BouncyCastle.Security;
using WindowsFormsApp1.ApiConsumer.Models;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.views.Med
{
    public partial class frmRdvMed : Form
    {

        private readonly RendezVousService _rendezVousService = new RendezVousService();
        public frmRdvMed()
        {
            InitializeComponent();
            loadRdv();
        }

        bdRdvMedicalContext bd = new bdRdvMedicalContext();

        private void frmRdvMed_Load(object sender, EventArgs e)
        {

        }

        private async void loadRdv()
        {
            
           MedecinDetails currentMedecin = FrmConnexion.user.User.MedecinDetails;
            var date = DateTime.Now.Date.ToString();
            List<ApiConsumer.Models.RendezVous> rdvs = await ApiConsumer.ApiClientContainer.RendezVousService.ListRendezVousAsync();
            rdvs.Where(r => r.Id == currentMedecin.Id).ToList();

            dgRdvMedecin.DataSource = rdvs.Where(rv=>rv.DateRendezVous.Date.ToString()==date).Select(rdv => new
                {
                   Heure = rdv.HeureRendezVous,
                   DateRv = rdv.DateRendezVous,
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
