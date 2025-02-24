using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Serilog;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.views.Secret
{

    public partial class frmValiderRdv : Form
    {
        Patient patient;
        Agenda agenda;
        public frmValiderRdv(Patient p, Agenda a)
        {
            InitializeComponent();
            cbbMoyenPaiement.DataSource = loadModePaiementccb();
            cbbSoins.DataSource = loadSoinsccb();
            cbbSoins.DisplayMember = "Text";
            cbbSoins.ValueMember = "Value";
            cbbMoyenPaiement.DisplayMember = "Text";
            cbbMoyenPaiement.ValueMember = "Value";
            cbbCreneaux.DataSource = loadCreneaux(a);
            cbbCreneaux.DisplayMember = "Text";  // Show the formatted time slot in the ComboBox
            cbbCreneaux.ValueMember = "Value";
            patient = p;
            agenda = a;

        }

        bdRdvMedicalContext bd = new bdRdvMedicalContext();
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            try
    {
        var selectedCreneau = cbbCreneaux.SelectedValue.ToString();
        var selectedSoinId = cbbSoins.SelectedValue.ToString();
        var selectedPatientId = patient.IdP;

        DateTime dateRv = DateTime.Parse(agenda.DataPlanifier.Value.ToString("yyyy-MM-dd") + " " + selectedCreneau);
                RendezVous newRdv = new RendezVous
        {
            DateRv = dateRv,
            HeureRv = selectedCreneau,
            IdSoin = int.Parse(selectedSoinId),
            IdPatient = selectedPatientId,
            IdMedecin = agenda.IdMedecin,
            IdAgenda = agenda.IdAgenda
        };

        bd.RendezVous.Add(newRdv);
        bd.SaveChanges();

        Log.Information("Rendez-vous confirmé pour le patient: {PatientId} à {HeureRv}", selectedPatientId, selectedCreneau);

        cbbCreneaux.DataSource = loadCreneaux(agenda);

        MessageBox.Show("Rendez-vous validé avec succès.");
    }
    catch (Exception ex)
    {
        Log.Error(ex, "Erreur lors de la validation du rendez-vous.");
        MessageBox.Show("Erreur lors de la validation du rendez-vous: " + ex.Message);
    }
        }

        public List<SelectListViewModel> loadModePaiementccb()
        {
            try
            {
                Log.Information("Chargement des paiements pour le combobox.");
                var s = bd.MoyenDePaiements.ToList();
                List<SelectListViewModel> liste = new List<SelectListViewModel>();
                SelectListViewModel b = new SelectListViewModel();
                b.Text = "Selectionner une valeur";
                b.Value = "";
                liste.Add(b);
                foreach (var item in s)
                {
                    SelectListViewModel a = new SelectListViewModel();
                    a.Text = item.LibelleMoyenPaiement;
                    a.Value = item.IdMoy.ToString();
                    liste.Add(a);
                }

                Log.Information("Paiement chargées: {NombrePaiement}", s.Count);
                return liste;
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Erreur lors du chargement des Paiement.");
                MessageBox.Show("Erreur lors du chargement des paiement.");
                return new List<SelectListViewModel>();
            }
        }
        public List<SelectListViewModel> loadSoinsccb()
        {
            try
            {
                Log.Information("Chargement des soins pour le combobox.");
                var s = bd.Soins.ToList();
                List<SelectListViewModel> liste = new List<SelectListViewModel>();
                SelectListViewModel b = new SelectListViewModel();
                b.Text = "Selectionner une valeur";
                b.Value = "";
                liste.Add(b);
                foreach (var item in s)
                {
                    SelectListViewModel a = new SelectListViewModel();
                    a.Text = item.NomSoin;
                    a.Value = item.IdSoin.ToString();
                    liste.Add(a);
                }

                Log.Information("Soins chargées: {NombrePaiement}", s.Count);
                return liste;
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Erreur lors du chargement des soins.");
                MessageBox.Show("Erreur lors du chargement des soins.");
                return new List<SelectListViewModel>();
            }
        }
      public List<SelectListViewModel> loadCreneaux(Agenda agenda)
{
    try
    {
        Log.Information("Chargement des créneaux pour l'agenda.");

        List<SelectListViewModel> creneauxList = new List<SelectListViewModel>();

        DateTime startTime = DateTime.Parse(agenda.HeureDebut);
        DateTime endTime = DateTime.Parse(agenda.HeureFin);
        int creneauxDurationInMinutes = agenda.Creneau;

        // Fetch all RendezVous entries into memory (no filtering by DateRv here)
        var allAppointments = bd.RendezVous.ToList();  // Fetch all records into memory

        // Perform the slot checking logic in memory
        while (startTime.AddMinutes(creneauxDurationInMinutes) <= endTime)
        {
            DateTime endSlot = startTime.AddMinutes(creneauxDurationInMinutes);
            string formattedSlot = $"{startTime.ToString("HH:mm")} - {endSlot.ToString("HH:mm")}";
            string slotStartTime = startTime.ToString("HH:mm");

            // Check if this slot is already booked by any existing appointment
            bool isSlotBooked = allAppointments
                .Any(r => r.DateRv.Date == agenda.DataPlanifier.Value.Date && r.HeureRv == slotStartTime);

            if (!isSlotBooked)
            {
                creneauxList.Add(new SelectListViewModel
                {
                    Text = formattedSlot,
                    Value = slotStartTime
                });
            }

            startTime = endSlot;
        }

        Log.Information("Créneaux chargés: {NombreCreneaux}", creneauxList.Count);
        return creneauxList;
    }
    catch (Exception ex)
    {
        Log.Error(ex, "Erreur lors du chargement des créneaux.");
        MessageBox.Show("Erreur lors du chargement des créneaux: " + ex.Message);
        return new List<SelectListViewModel>();
    }
}
    private void cbbCreneaux_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbbSoins_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedSoinId = cbbSoins.SelectedValue.ToString();

            var selectedSoin = bd.Soins.FirstOrDefault(s => s.IdSoin.ToString() == selectedSoinId);

            if (selectedSoin != null)
            {
                txtCout.Text = selectedSoin.CoutSoin.ToString();
            }
        }

    }
}
