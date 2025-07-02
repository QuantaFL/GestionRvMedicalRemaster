using Serilog;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp1.CustomControls;
using MetierRvMedical2.Services;

namespace WindowsFormsApp1.views.Med
{
    public partial class frmAccueilMed : Form
    {
        private readonly IAgendaService _agendaService;

        public frmAccueilMed()
        {
            InitializeComponent();
            _agendaService = new AgendaService();
            LoadAgenda();
        }

        private void btnAjouterAgenda_Click(object sender, EventArgs e)
        {
            //TODO : Partir sur Agenda avec l'id du Medecin
            //Pas besoin
            frmMedAgenda frmMedAgenda = new frmMedAgenda();
            frmMedAgenda.ShowDialog();
        }

        public void LoadAgenda()
        {
            var allAgendas = _agendaService.GetAllAgendas();
            var medecinAgendas = allAgendas
                .Where(ag => ag.IdMedecin == FrmConnexion.user.User.Id)
                .Select(ag => new { ag.DataPlanifier.Value.Date, ag.Creneau, ag.HeureDebut, ag.HeureFin })
                .ToList();

            dgAgendaMedecin.DataSource = medecinAgendas;
        }

        private void btnVoirRdv_Click(object sender, EventArgs e)
        {

        }

        private void frmAccueilMed_Load(object sender, EventArgs e)
        {

        }

        private void dgAgendaMedecin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRechercherAgenda_Click(object sender, EventArgs e)
        {
            Log.Information("clique sur le button rechercher agenda medecin");
            LoadAgenda(txtDateChercher.Value);
        }

        public void LoadAgenda(DateTime val)
        {
            try
            {
                var allAgendas = _agendaService.GetAllAgendas();
                var medecinAgendas = allAgendas
                    .Where(a => a.IdMedecin == FrmConnexion.user.User.Id && a.DataPlanifier.Value.Date == val.Date)
                    .ToList();

                dgAgendaMedecin.DataSource = medecinAgendas;
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Erreur lors du chargement des agendas pour le medecin {s}", FrmConnexion.user.User.NomPrenom);
                new frmEchecExecution("Erreur lors du chargement des agendas.").ShowDialog();
            }
        }
    }
}
