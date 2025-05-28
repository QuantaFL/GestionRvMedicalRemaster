using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetierRvMedical2.Models;
using MetierRvMedical2.Services;
using Serilog;
using WindowsFormsApp1.CustomControls;
using WindowsFormsApp1.utils;

namespace WindowsFormsApp1.views.Secret
{
    public partial class frmValiderRdv : Form
    {
        private readonly Patient patient;
        private readonly MetierRvMedical2.Models.Agenda agenda;
        private readonly MetierRvMedical2.Models.bdRdvMedicalContext _bd = new MetierRvMedical2.Models.bdRdvMedicalContext();
        private readonly AgendaService _agendaService = new AgendaService();

        public frmValiderRdv(MetierRvMedical2.Models.Patient p, MetierRvMedical2.Models.Agenda a)
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
                var patientId = patient.IdP;
                string codeRdv = generateCodeRdv();
                string dateRv = agenda.DataPlanifier.Value.ToString("yyyy-MM-dd") + " " + creneau;
                var rdv = new MetierRvMedical2.Models.RendezVous
                {
                    DateRv = dateRv,
                    HeureRv = creneau,
                    IdSoin = int.Parse(soinId),
                    IdPatient = patientId,
                    IdMedecin = agenda.IdMedecin,
                    IdAgenda = agenda.IdAgenda,
                    CodeRdv = codeRdv,
                };

                _bd.RendezVous.Add(rdv);
                await _bd.SaveChangesAsync();

                Log.Information("Rdv confirme pour patient: {PatientId} a {HeureRv}", patientId, creneau);

                cbbCreneaux.DataSource = await LoadCreneauxAsync(agenda);
                ResetForm();

               new frmExecutionReussie("Rdv valide avec succes.").ShowDialog();

                try {
                    var lastRdv = _bd.RendezVous.Where(r => r.CodeRdv == codeRdv).FirstOrDefault();
                    if (lastRdv != null) { 
                        frmRptPrintRecuRdv frmRptPrintRecuRdv = new frmRptPrintRecuRdv(lastRdv.IdRendezVous);
                        frmRptPrintRecuRdv.Show();
                        var frmRdv = Application.OpenForms["frmValiderRdv"] as frmValiderRdv;
                        frmRdv.Close();
                    }
                }
                catch (Exception ex) { 
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
                var s = await _bd.MoyenDePaiements.ToListAsync();
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
                var s = await _bd.Soins.ToListAsync();
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

        private async Task<List<MetierRvMedical2.Models.SelectListViewModel>> LoadCreneauxAsync(MetierRvMedical2.Models.Agenda agenda)
        {
            try
            {
                Log.Information("Chargement des créneaux.");

                var agendaFromService = _agendaService.GetAgendaById(agenda.IdAgenda);
                if (agendaFromService != null)
                    agenda = agendaFromService;

                var creneauxList = new List<MetierRvMedical2.Models.SelectListViewModel>();
                DateTime startTime = DateTime.Parse(agenda.HeureDebut);
                DateTime endTime = DateTime.Parse(agenda.HeureFin);
                int creneauxDurationInMinutes = agenda.Creneau;

                var allAppointments = await _bd.RendezVous.ToListAsync();

                var appointmentsForSelectedDate = allAppointments
                    .Where(r => DateTime.Parse(r.DateRv).Date == agenda.DataPlanifier.Value.Date)
                    .ToList();

                var bookedSlots = appointmentsForSelectedDate
                    .Select(r => r.HeureRv)
                    .ToList();

                while (startTime.AddMinutes(creneauxDurationInMinutes) <= endTime)
                {
                    DateTime endSlot = startTime.AddMinutes(creneauxDurationInMinutes);
                    string formattedSlot = $"{startTime:HH:mm} - {endSlot:HH:mm}";
                    string slotStartTime = startTime.ToString("HH:mm");

                    if (!bookedSlots.Contains(slotStartTime))
                    {
                        creneauxList.Add(new MetierRvMedical2.Models.SelectListViewModel
                        {
                            Text = formattedSlot,
                            Value = slotStartTime
                        });
                    }

                    startTime = endSlot;
                }
                if (creneauxList.Count == 0)
                {
                    agenda.Statut = "non dispo";
                    _bd.Entry(agenda).State = EntityState.Modified;
                    await _bd.SaveChangesAsync();
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

            var soin = _bd.Soins.FirstOrDefault(s => s.IdSoin.ToString() == soinId);
            if (soin != null)
            {
                txtCout.Text = soin.CoutSoin.ToString();
            }
        }

        private string generateCodeRdv()
        {
            string codeRdv ;
            var nbrRdv = _bd.RendezVous.Count();
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
