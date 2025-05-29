using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using Serilog;
using WindowsFormsApp1.CustomControls;
using WindowsFormsApp1.Models;
using MetierRvMedical2.Models;
using MetierRvMedical2.Services;

namespace WindowsFormsApp1.views.Med
{
    public partial class frmMedAgenda : Form
    {
        private readonly AgendaService _agendaService;
        private readonly MedecinService _medecinService;

        public frmMedAgenda()
        {
            InitializeComponent();
            txtHeureDebut.Mask = "00:00";
            txtHeureFin.Mask = "00:00";
            txtHeureDebut.ValidatingType = typeof(DateTime);
            txtHeureFin.ValidatingType = typeof(DateTime);

            _agendaService = new AgendaService();
            _medecinService = new MedecinService();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnValiderAjoutUtilisateur_Click(object sender, EventArgs e)
        {
            try
            {
                Log.Information("Tentative de connexion a la base");

                    Log.Information("Tentative de recuperation des informations medecin");


                    var medecin = _medecinService.GetMedecinById(1);

                    if (medecin == null)
                    {
                        new frmInformation("Medecin introuvable.").ShowDialog();
                        Log.Warning("Medecin introuvable avec l'ID specifie.");
                        return;
                    }

                    Log.Information("Verification des champs obligatoires");

                    if (string.IsNullOrEmpty(txtTitreAgenda.Text) || string.IsNullOrEmpty(txtLieu.Text) ||
                        string.IsNullOrEmpty(txtCrenneau.Text) || string.IsNullOrEmpty(txtHeureDebut.Text) ||
                        string.IsNullOrEmpty(txtHeureFin.Text))
                    {
                        new frmInformation("Tous les champs doivent etre remplis.").ShowDialog();
                        Log.Warning("Des champs obligatoires sont vides.");
                        return;
                    }

                    if (!int.TryParse(txtCrenneau.Text, out int creneau) || creneau <= 0)
                    {
                        new frmInformation("Veuillez entrer un creneau valide.").ShowDialog();
                        Log.Warning("Creneau invalide ou non numérique.");
                        return;
                    }

                    Log.Information("Creation de l'agenda");

                    try
                    {

                        Log.Information("Tentative d'enregistrement de l'agenda");

                        // Replace direct DbContext usage with service
                        _agendaService.CreateAgenda(txtDateAgenda.Value.Date, txtHeureDebut.Text, txtHeureFin.Text, txtLieu.Text, txtTitreAgenda.Text, "dispo", creneau, medecin.IdP);

                        resetForm();

                        new frmInformation("L'ajout a ete effectue avec succes !").ShowDialog();
                        Log.Information("Agenda ajouter avec succes.");
                    }
                    catch (Exception ex)
                    {
                        Log.Fatal($"Echec de l'action lors de l'ajout de l'agenda: {ex.Message} - {ex.Source}");
                    }
                
            }
            catch (Exception ex)
            {
                new frmInformation("Erreur durant la creation").ShowDialog();
                Log.Fatal($"Erreur generale lors de la tentative de creation: {ex.Message} {ex.InnerException}");
            }
        }

        private void resetForm()
        {
            txtTitreAgenda.Text = "";
            txtLieu.Text = "";
            txtHeureDebut.Text = "";
            txtHeureFin.Text = "";
            txtCrenneau.Text = "";
            txtDateAgenda.Value = DateTime.Now;

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void heureDebutChanged(object sender, EventArgs e)
        {
            if (txtHeureDebut.Text.Length > 1)
            {
                txtHeureDebut.Text += ":";
            }else if (txtHeureDebut.Text.Length == 2)
            {

            }
        }

        private void heureFinChanged(object sender, EventArgs e)
        {
            if (txtHeureFin.Text.Length > 1)
            {
                txtHeureFin.Text += ":";
            }
            else if (txtHeureFin.Text.Length == 2)
            {

            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
