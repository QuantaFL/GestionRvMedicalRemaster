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
using WindowsFormsApp1.Models;

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
                        MessageBox.Show("Médecin introuvable.");
                        return;
                    }
                    Log.Information("Creation etat agenda");
                    try
                    {
                        var agenda = new Agenda()
                        {

                            Titre = txtTitreAgenda.Text,
                            Lieu = txtLieu.Text,
                            Creneau = int.Parse(txtCrenneau.Text),
                            HeureDebut = txtHeureDebut.Text,
                            HeureFin = txtHeureFin.Text,
                            DataPlanifier = txtDateAgenda.Value,
                            IdMedecin = medecin.IdP

                        };
                        context.Agenda.Add(agenda);
                        Log.Information("Tentative d'enregistrement de l'agenda au niveau de la base");
                        context.SaveChanges();
                        transaction.Commit();
                    }catch(Exception ex)
                    {
                        Log.Fatal($"Echec de l'action {ex.Message} de {ex.Source}");
                        transaction.Rollback();
                    }
                }
                MessageBox.Show("L'ajout a été effectué avec succès !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur durant 'la creation");
                Log.Fatal($"Echec de l'action {ex.Message} {ex.InnerException}");
            }
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
    }
}
