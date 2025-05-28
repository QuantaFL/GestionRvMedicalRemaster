using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MetierRvMedical2.Services;
using Serilog;
using WindowsFormsApp1.CustomControls;

namespace WindowsFormsApp1.views.Secret
{
    public partial class frmRdv : Form
    {
        private readonly AgendaService _agendaService = new AgendaService();
        readonly MetierRvMedical2.Models.Patient patient;
        MetierRvMedical2.Models.Agenda agenda;

        public frmRdv(MetierRvMedical2.Models.Patient p)
        {
            InitializeComponent();
            dgAgendaMedecin.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            cbbSpecialite.ValueMember = "Value";
            cbbSpecialite.DisplayMember = "Text";
            cbbSpecialite.DataSource = loadSpecialiteccb();
            patient = p;
            SetDatePickerLimits();

            Log.Information("Formulaire de RDV initialisé avec patient {PatientId}", patient.IdP);
        }
        MetierRvMedical2.Models.bdRdvMedicalContext bd = new MetierRvMedical2.Models.bdRdvMedicalContext();

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Log.Information("Cellule de DataGrid cliquée à la position {Row}, {Column}", e.RowIndex, e.ColumnIndex);
        }

        public void LoadAgenda(DateTime val, String s)
        {
            try
            {
                if (string.IsNullOrEmpty(cbbSpecialite.ValueMember))
                {
                    Log.Warning("Aucune spécialité sélectionnée.");
                    new frmInformation("Selectionner une specialite").ShowDialog();
                    return;
                }

                if (txtDateChercher.Value < DateTime.Now.Date)
                {
                    Log.Warning("Date invalide sélectionnée: {DateSelectionnee}", txtDateChercher.Value);
                    new frmInformation("Selectionner une date valide").ShowDialog();
                    return;
                }

                Log.Information("Chargement des agendas pour la spécialité {Specialite} à partir de {Date}", s, val);

                var medecins = bd.Personnes
                    .OfType<MetierRvMedical2.Models.Medecin>()
                    .Where(m => m.Specialite.NomSpecialte == s)
                    .ToList();

                if (medecins.Count == 0)
                {
                    Log.Warning("Aucun médecin trouvé pour la spécialité {Specialite}", s);
                    new frmInformation("Aucun médecin trouvé pour cette spécialité.").ShowDialog();
                }

                var agendas = new List<MetierRvMedical2.Models.Agenda>();
                foreach (var medecin in medecins)
                {
                    var availableAgendas = medecin.agenda
                        .Where(a => a.DataPlanifier >= val && a.Statut != "non dispo" )
                        .ToList();
                    agendas.AddRange(availableAgendas);
                }

                dgAgendaMedecin.DataSource = agendas;
                Log.Information("Agendas chargés: {NombreAgendas}", agendas.Count);
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Erreur lors du chargement des agendas pour la spécialité {Specialite}", s);
                new frmEchecExecution("Erreur lors du chargement des agendas.").ShowDialog();
            }
        }

        private void btnRechercherDispo_Click(object sender, EventArgs e)
        {
            Log.Information("Recherche de disponibilité lancée pour la date {Date} et spécialité {Specialite}", txtDateChercher.Value, cbbSpecialite.Text);
            LoadAgenda(txtDateChercher.Value, cbbSpecialite.Text);
        }

        private void cbbSpecialite_SelectedIndexChanged(object sender, EventArgs e)
        {
            Log.Information("Changement de sélection dans la spécialité: {Specialite}", cbbSpecialite.Text);
        }

        public List<MetierRvMedical2.Models.SelectListViewModel> loadSpecialiteccb()
        {
            try
            {
                Log.Information("Chargement des spécialités pour le combobox.");
                var s = bd.Specialite.ToList();
                List<MetierRvMedical2.Models.SelectListViewModel> liste = new List<MetierRvMedical2.Models.SelectListViewModel>();
                MetierRvMedical2.Models.SelectListViewModel b = new MetierRvMedical2.Models.SelectListViewModel();
                b.Text = "Selectionner une valeur";
                b.Value = "";
                liste.Add(b);
                foreach (var item in s)
                {
                    MetierRvMedical2.Models.SelectListViewModel a = new MetierRvMedical2.Models.SelectListViewModel();
                    a.Text = item.NomSpecialte;
                    a.Value = item.Id.ToString();
                    liste.Add(a);
                }

                Log.Information("Spécialités chargées: {NombreSpecialites}", s.Count);
                return liste;
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Erreur lors du chargement des spécialités.");
                new frmEchecExecution("Erreur lors du chargement des spécialités.").ShowDialog();
                return new List<MetierRvMedical2.Models.SelectListViewModel>();
            }
        }

        private void SetDatePickerLimits()
        {
            try
            {
                var minDate = DateTime.Now.AddHours(-8);
                var maxDate = DateTime.Now.AddMonths(1);

                txtDateChercher.MinDate = minDate;
                txtDateChercher.MaxDate = maxDate;

                Log.Information("Limites de date définies: MinDate={MinDate}, MaxDate={MaxDate}", minDate, maxDate);
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Erreur lors de la configuration des limites de date.");
                new frmEchecExecution("Erreur lors de la configuration des limites de date.").ShowDialog();
            }
        }

        private void btnAjouterRendezvous_Click(object sender, EventArgs e)
        {
            if (dgAgendaMedecin.SelectedRows.Count > 0)
            {
                var idAgenda = int.Parse(dgAgendaMedecin.CurrentRow.Cells[0].Value.ToString());
                // Use AgendaService to get agenda by id
                agenda = _agendaService.GetAgendaById(idAgenda);
                Log.Information("Agenda selectionne: {AgendaId}, Date: {AgendaDate}", agenda.IdAgenda, agenda.DataPlanifier);

                frmValiderRdv frmValiderRdv = new frmValiderRdv(patient, agenda);
                frmValiderRdv.Show();
                Log.Information("Navigation vers le formulaire de validation de RDV.");
                this.Close();
            }
            else
            {
                Log.Warning("Aucun agenda selectionné pour la prise de rendez-vous.");
                new frmInformation("Veuillez selectionner un agenda.").ShowDialog();
            }
        }

        private void cbbSpecialite_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void txtDateChercher_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pnlControl_MouseMove(object sender, MouseEventArgs e)
        {
           // pnlControl.BackColor = System.Drawing.Color.FromArgb(255, 111, 97);
        }

        private void pnlControl_MouseLeave(object sender, EventArgs e)
        {
           // pnlControl.BackColor = System.Drawing.Color.FromArgb(75, 108, 140);

        }

        private void pnlControl_Paint(object sender, PaintEventArgs e)
        {
            //this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
