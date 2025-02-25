using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp1.Models;
using Serilog;
using System.Drawing;
using WindowsFormsApp1.CustomControls;

namespace WindowsFormsApp1.views.Secret
{
    public partial class frmRdv : Form
    {
        readonly Patient patient;
        Agenda agenda;

        public frmRdv(Patient p)
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
        bdRdvMedicalContext bd = new bdRdvMedicalContext();

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
                    new frmInformation("Selectionner une specialite");
                    return;
                }

                if (txtDateChercher.Value < DateTime.Now.Date)
                {
                    Log.Warning("Date invalide sélectionnée: {DateSelectionnee}", txtDateChercher.Value);
                    new frmInformation("Selectionner une date valide");
                    return;
                }

                Log.Information("Chargement des agendas pour la spécialité {Specialite} à partir de {Date}", s, val);

                var medecins = bd.Personnes
                    .OfType<Medecin>()
                    .Where(m => m.Specialite.NomSpecialte == s)
                    .ToList();

                if (medecins.Count == 0)
                {
                    Log.Warning("Aucun médecin trouvé pour la spécialité {Specialite}", s);
                    new frmInformation("Aucun médecin trouvé pour cette spécialité.");
                }

                var agendas = new List<Agenda>();
                foreach (var medecin in medecins)
                {
                    var availableAgendas = medecin.agenda
                        .Where(a => a.DataPlanifier >= val)
                        .ToList();
                    agendas.AddRange(availableAgendas);
                }

                dgAgendaMedecin.DataSource = agendas;
                Log.Information("Agendas chargés: {NombreAgendas}", agendas.Count);
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Erreur lors du chargement des agendas pour la spécialité {Specialite}", s);
                new frmEchecExecution("Erreur lors du chargement des agendas.");
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

        public List<SelectListViewModel> loadSpecialiteccb()
        {
            try
            {
                Log.Information("Chargement des spécialités pour le combobox.");
                var s = bd.Specialite.ToList();
                List<SelectListViewModel> liste = new List<SelectListViewModel>();
                SelectListViewModel b = new SelectListViewModel();
                b.Text = "Selectionner une valeur";
                b.Value = "";
                liste.Add(b);
                foreach (var item in s)
                {
                    SelectListViewModel a = new SelectListViewModel();
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
                new frmEchecExecution("Erreur lors du chargement des spécialités.");
                return new List<SelectListViewModel>();
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
                new frmEchecExecution("Erreur lors de la configuration des limites de date.");
            }
        }

        private void btnAjouterRendezvous_Click(object sender, EventArgs e)
        {
            if (dgAgendaMedecin.SelectedRows.Count > 0)
            {
                //agenda = (Agenda)dgAgendaMedecin.CurrentRow.Cells[0].Value;
                var idAgenda = int.Parse(dgAgendaMedecin.CurrentRow.Cells[0].Value.ToString());
             //MessageBox.Show(idAgenda.ToString());
                agenda = bd.Agenda
                    .Where(a => a.IdAgenda == idAgenda)
                    .FirstOrDefault();
                Log.Information("Agenda selectionne: {AgendaId}, Date: {AgendaDate}", agenda.IdAgenda, agenda.DataPlanifier);

                frmValiderRdv frmValiderRdv = new frmValiderRdv(patient, agenda);

               // frmDashSecretaire parentForm = Application.OpenForms["frmDashSecretaire"] as frmDashSecretaire;
               // parentForm.fermer();

               // frmValiderRdv.MdiParent = parentForm;
               // frmValiderRdv.WindowState = FormWindowState.Maximized;
                frmValiderRdv.Show();

                Log.Information("Navigation vers le formulaire de validation de RDV.");
                this.Close();
            }
            else
            {
                Log.Warning("Aucun agenda selectionné pour la prise de rendez-vous.");
                new frmInformation("Veuillez selectionner un agenda.");
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
