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
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsApp1.views.Med
{
    public partial class frmMedAgenda : Form
    {
        public frmMedAgenda()
        {
            InitializeComponent();
            txtHeureDebut.Mask = "00:00";
            txtHeureFin.Mask = "00:00";
            txtHeureDebut.ValidatingType = typeof(DateTime);
            txtHeureFin.ValidatingType = typeof(DateTime);
            
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
                using (var context = new bdRdvMedicalContext())
                {
                    var transaction = context.Database.BeginTransaction();
                    Log.Information("Tentative de recuperation des informations medecin");

                    var medecin = context.Personnes
                        .Where(p => p.IdP == 1)
                        .OfType<Medecin>()
                        .FirstOrDefault();

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
                        var agenda = new Agenda()
                        {
                            Titre = txtTitreAgenda.Text,
                            Lieu = txtLieu.Text,
                            Creneau = creneau,
                            HeureDebut = txtHeureDebut.Text,
                            HeureFin = txtHeureFin.Text,
                            DataPlanifier = txtDateAgenda.Value.Date,
                            IdMedecin = medecin.IdP
                        };

                        Log.Information("Tentative d'enregistrement de l'agenda");

                        context.Agenda.Add(agenda);
                        context.SaveChanges();
                        transaction.Commit();

                        resetForm();

                        new frmInformation("L'ajout a ete effectue avec succes !");
                        Log.Information("Agenda ajouter avec succes.");
                    }
                    catch (Exception ex)
                    {
                        Log.Fatal($"Echec de l'action lors de l'ajout de l'agenda: {ex.Message} - {ex.Source}");
                        transaction.Rollback();
                    }
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
