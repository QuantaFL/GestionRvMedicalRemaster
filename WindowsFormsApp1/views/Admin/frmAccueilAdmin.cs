using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Serilog;
using WindowsFormsApp1.CustomControls;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.views.Admin;

namespace WindowsFormsApp1.views
{
    public partial class frmAccueilAdmin : Form
    {
        public frmAccueilAdmin()
        {
            InitializeComponent();
        }
        bdRdvMedicalContext db = new bdRdvMedicalContext();

        private void btnAjouterUtilisateur_Click(object sender, EventArgs e)
        {
            frmAdminAjouterUtilisateur ajouterUtilisateur = new frmAdminAjouterUtilisateur();
            ajouterUtilisateur.ShowDialog();
        }

        private void frmAccueilAdmin_Load(object sender, EventArgs e)
        {
            loadData();

        }
        public void loadData()
        {
          dgUtilisateur.DataSource = db.Utilisateurs.ToList();
        }

        private void btnAjouterSecretaire_Click(object sender, EventArgs e)
        {

        }

        private void btnAjouterSecretaire_Click_1(object sender, EventArgs e)
        {
            frmAdminAjouterSecretaire frmAdminAjouterSecretaire = new frmAdminAjouterSecretaire();
            frmAdminAjouterSecretaire.ShowDialog();
        }
        
        private void btnRechercherMedecin_Click(object sender, EventArgs e)
        {
            frmInformation frmInformation = new frmInformation();
            string message;
            if (string.IsNullOrEmpty(txtRechercherMedecin.Text))
            {
                Log.Information("valeur saisie invalide");

            }
            else
            {

                try
                {
                    var medecin = db.Medecins.Where(m => m.NumeroOrdre == txtRechercherMedecin.Text).First();
                    if (medecin == null)
                    {
                        Log.Information("aucun medecin n'a ce numero d'ordre");
                        return;
                    }
                }
                catch (Exception ex)
                {
                    Log.Error($" l 'erreur {ex.Message} est survenue lors de la recherche du medecin ");
                }

            }
                

        }
    }
}
