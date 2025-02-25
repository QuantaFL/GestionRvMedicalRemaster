using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Serilog;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.views.Secret
{
    public partial class frmValiderRdv : Form
    {
        private readonly Patient patient;
        private readonly Agenda agenda;
        private readonly bdRdvMedicalContext _bd = new bdRdvMedicalContext();

        public frmValiderRdv(Patient p, Agenda a)
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
            cbbSoins.SelectedIndex = -1;
            cbbMoyenPaiement.SelectedIndex = 0;
            cbbCreneaux.SelectedIndex = 0;
        }

        private async void btnValider_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbbCreneaux.SelectedValue == null || cbbSoins.SelectedValue == null)
                {
                    MessageBox.Show("Selectionner un créneau et un soin.");
                    return;
                }

                var creneau = cbbCreneaux.SelectedValue.ToString();
                var soinId = cbbSoins.SelectedValue.ToString();
                var patientId = patient.IdP;

                string dateRv = agenda.DataPlanifier.Value.ToString("yyyy-MM-dd") + " " + creneau;
                var rdv = new RendezVous
                {
                    DateRv = dateRv,
                    HeureRv = creneau,
                    IdSoin = int.Parse(soinId),
                    IdPatient = patientId,
                    IdMedecin = agenda.IdMedecin,
                    IdAgenda = agenda.IdAgenda
                };

                _bd.RendezVous.Add(rdv);
                await _bd.SaveChangesAsync();

                Log.Information("Rdv confirme pour patient: {PatientId} a {HeureRv}", patientId, creneau);

                cbbCreneaux.DataSource = await LoadCreneauxAsync(agenda);
                ResetForm();

                MessageBox.Show("Rdv valide avec succes.");
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Erreur lors de validation du rdv.");
                MessageBox.Show("Erreur validation: " + ex.Message);
            }
        }

        private void ResetForm()
        {
            ResetCombos();
            txtCout.Clear();
            cbbCreneaux.Focus();
        }

        private async Task<List<SelectListViewModel>> LoadPaiementsAsync()
        {
            try
            {
                Log.Information("Chargement des paiements.");
                var s = await _bd.MoyenDePaiements.ToListAsync();
                var liste = new List<SelectListViewModel>
                {
                    new SelectListViewModel { Text = "Selectionner", Value = "" }
                };
                liste.AddRange(s.Select(item => new SelectListViewModel
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
                MessageBox.Show("Erreur paiement.");
                return new List<SelectListViewModel>();
            }
        }

        private async Task<List<SelectListViewModel>> LoadSoinsAsync()
        {
            try
            {
                Log.Information("Chargement des soins.");
                var s = await _bd.Soins.ToListAsync();
                var liste = new List<SelectListViewModel>
                {
                    new SelectListViewModel { Text = "Selectionner", Value = "" }
                };
                liste.AddRange(s.Select(item => new SelectListViewModel
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
                MessageBox.Show("Erreur soins.");
                return new List<SelectListViewModel>();
            }
        }

        private async Task<List<SelectListViewModel>> LoadCreneauxAsync(Agenda agenda)
        {
            try
            {
                Log.Information("Chargement des créneaux.");

                var creneauxList = new List<SelectListViewModel>();
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
                        creneauxList.Add(new SelectListViewModel
                        {
                            Text = formattedSlot,
                            Value = slotStartTime
                        });
                    }

                    startTime = endSlot;
                }

                Log.Information("Creneaux charges: {NombreCreneaux}", creneauxList.Count);
                return creneauxList;
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Erreur lors du chargement des créneaux.");
                MessageBox.Show("Erreur créneaux: " + ex.Message);
                return new List<SelectListViewModel>();
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
