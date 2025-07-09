using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetierRvMedical2.Models;
using MetierRvMedical2.Services;
using MetierRvMedical2.Utils;
using Serilog;
using WindowsFormsApp1.CustomControls;
using WindowsFormsApp1.utils;

namespace WindowsFormsApp1.views.Secret
{
    public partial class frmValiderRdv : Form
    {
        private readonly ApiConsumer.Models.Patient patient;
        private readonly Agenda agenda;
        private readonly AgendaService _agendaService = new AgendaService();
        private readonly MoyenPaiementService _moyenPaiementService = new MoyenPaiementService();
        private readonly SoinService _soinService = new SoinService();
        private readonly RendezVousService _rendezVousService = new RendezVousService();

        public frmValiderRdv(ApiConsumer.Models.Patient p, Agenda a)
        {
            InitializeComponent();
            patient = p;
            agenda = a;
            InitCombos();
        }

        private async void InitCombos()
        {
            cbbMoyenPaiement.DataSource = await LoadPaiementsAsync();
            cbbSoins.DataSource = await LoadSoinsAsync();
            cbbCreneaux.DataSource = await LoadCreneauxAsync(agenda);
            ResetCombos();
        }

        private void ResetCombos()
        {
            cbbSoins.DisplayMember = "Text";
            cbbSoins.ValueMember = "Value";
            cbbMoyenPaiement.DisplayMember = "Text";
            cbbMoyenPaiement.ValueMember = "Value";
            cbbCreneaux.DisplayMember = "Text";
            cbbCreneaux.ValueMember = "Value";
            cbbSoins.SelectedIndex = 0;
            cbbMoyenPaiement.SelectedIndex = 0;
            cbbCreneaux.SelectedIndex = 0;
        }

        private async void btnValider_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbbCreneaux.SelectedValue == null || cbbSoins.SelectedValue == null)
                {
                    new frmExecutionReussie("Selectionner un créneau et un soin.").ShowDialog();
                    return;
                }

                var creneau = cbbCreneaux.SelectedValue.ToString();
                var soinId = cbbSoins.SelectedValue.ToString();
                var patientId = patient.Id;
                string codeRdv = generateCodeRdv();
                string dateRv = agenda.DataPlanifier.Value.ToString("yyyy-MM-dd") + " " + creneau;
                _rendezVousService.AddRendezVous(dateRv, creneau, int.Parse(soinId), patientId, agenda.IdMedecin, agenda.IdAgenda, codeRdv);

                Log.Information("Rdv confirme pour patient: {PatientId} a {HeureRv}", patientId, creneau);

                cbbCreneaux.DataSource = await LoadCreneauxAsync(agenda);
                ResetForm();

               new frmExecutionReussie("Rdv valide avec succes.").ShowDialog();

                try
                {
                    var lastRdv = _rendezVousService.GetAllRendezVous().Where(r => r.CodeRdv == codeRdv).FirstOrDefault();
                    if (lastRdv != null)
                    {
                        frmRptPrintRecuRdv frmRptPrintRecuRdv = new frmRptPrintRecuRdv(lastRdv.IdRendezVous);
                        frmRptPrintRecuRdv.Show();
                        var frmRdv = Application.OpenForms["frmValiderRdv"] as frmValiderRdv;
                        frmRdv.Close();
                    }
                }
                catch (Exception ex)
                {
                    Log.Error($"{ex.Message} erreur lors de la reucperation du rdv par son code ");
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Erreur lors de validation du rdv.");
                new frmEchecExecution("Erreur validation: " + ex.Message);
            }
        }

        private void ResetForm()
        {
            ResetCombos();
            txtCout.Clear();
            cbbCreneaux.Focus();
        }

        private async Task<List<MetierRvMedical2.Models.SelectListViewModel>> LoadPaiementsAsync()
        {
            try
            {
                Log.Information("Chargement des paiements.");
                var s = await Task.Run(() => _moyenPaiementService.GetAllMoyenDePaiements().ToList());
                var liste = new List<MetierRvMedical2.Models.SelectListViewModel>
                {
                    new MetierRvMedical2.Models.SelectListViewModel { Text = "Selectionner", Value = "" }
                };
                liste.AddRange(s.Select(item => new MetierRvMedical2.Models.SelectListViewModel
                {
                    Text = item.LibelleMoyenPaiement,
                    Value = item.IdMoy.ToString()
                }));

                Log.Information("Paiements charges: {NombrePaiements}", s.Count);
                return liste;
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Erreur lors du chargement des paiements.");
                new frmEchecExecution("Erreur paiement.");
                return new List<MetierRvMedical2.Models.SelectListViewModel>();
            }
        }

        private async Task<List<MetierRvMedical2.Models.SelectListViewModel>> LoadSoinsAsync()
        {
            try
            {
                Log.Information("Chargement des soins.");
                var s = await Task.Run(() => _soinService.GetAllSoins().ToList());
                var liste = new List<MetierRvMedical2.Models.SelectListViewModel>
                {
                    new MetierRvMedical2.Models.SelectListViewModel { Text = "Selectionner", Value = "" }
                };
                liste.AddRange(s.Select(item => new MetierRvMedical2.Models.SelectListViewModel
                {
                    Text = item.NomSoin,
                    Value = item.IdSoin.ToString()
                }));

                Log.Information("Soins charges: {NombreSoins}", s.Count);
                return liste;
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Erreur lors du chargement des soins.");
                new frmEchecExecution("Erreur soins.");
                return new List<MetierRvMedical2.Models.SelectListViewModel>();
            }
        }

        public async Task<List<MetierRvMedical2.Models.SelectListViewModel>> LoadCreneauxAsync(MetierRvMedical2.Models.Agenda agenda)
        {
            try
            {
                Log.Information("Chargement des créneaux.");

                var agendaFromService = await Task.Run(() => _agendaService.GetAgendaById(agenda.IdAgenda));
                if (agendaFromService != null)
                    agenda = agendaFromService;

                var creneauxList = new List<MetierRvMedical2.Models.SelectListViewModel>();
                DateTime startTime = DateTime.Parse(agenda.HeureDebut);
                DateTime endTime = DateTime.Parse(agenda.HeureFin);
                int creneauxDurationInMinutes = agenda.Creneau;

                var allAppointments = _rendezVousService.GetAllRendezVous();

                var appointmentsForSelectedDate = allAppointments
                    .Where(r => DateTime.Parse(r.DateRv).Date == agenda.DataPlanifier.Value.Date)
                    .ToList();

                var bookedSlots = appointmentsForSelectedDate
                    .Select(r => r.HeureRv)
                    .ToList();

                creneauxList = CreneauxGenerator.GenerateCreneaux(
                    agenda.HeureDebut,
                    agenda.HeureFin,
                    agenda.Creneau,
                    bookedSlots);
                if (creneauxList.Count == 0)
                {
                    agenda.Statut = "non dispo";
                    await Task.Run(() => _agendaService.UpdateAgenda(agenda));
                    new frmInformation("L'agenda nest plus disponible: nombre de creneaux remplis").ShowDialog();
                    Log.Information("Aucun créneau disponible, statut de l'agenda mis à jour à false.");
                    this.Close();
                }
                Log.Information("Creneaux charges: {NombreCreneaux}", creneauxList.Count);
                return creneauxList;
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Erreur lors du chargement des créneaux.");
                new frmEchecExecution("Erreur créneaux: " + ex.Message).ShowDialog();
                return new List<MetierRvMedical2.Models.SelectListViewModel>();
            }
        }

        private void cbbSoins_SelectedIndexChanged(object sender, EventArgs e)
        {
            var soinId = cbbSoins.SelectedValue?.ToString();
            if (soinId == null) return;
            var soin = _soinService.GetAllSoins().FirstOrDefault(s => s.IdSoin.ToString() == soinId);
            if (soin != null)
            {
                txtCout.Text = soin.CoutSoin.ToString();
            }
        }

        private string generateCodeRdv()
        {
            string codeRdv ;
            var nbrRdv = _rendezVousService.CountRendezVous();
            if (nbrRdv == 0)
            {
                nbrRdv = 1;
            }
            else
            {
                nbrRdv++;
            }
            return codeRdv = "HL-DKR-" + DateTime.Now.Year + "-" + nbrRdv+"-"+"Rdv";

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
