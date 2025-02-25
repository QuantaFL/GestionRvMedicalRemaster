using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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
            string message;
            //frmInformation frmInformation = new frmInformation(message);
            
            if (string.IsNullOrEmpty(txtRechercherMedecin.Text))
            {
                message = "valeur saisie invalide";
                frmInformation frmInformation = new frmInformation(message);
                frmInformation.ShowDialog();
                Log.Information("valeur saisie invalide lors de la recherche du medecin");
                return;

            }
            else
            {
                try
                {
                    var medecin = db.Medecins.Where(m => m.NumeroOrdre == txtRechercherMedecin.Text).FirstOrDefault();
                    if (medecin == null)
                    {
                        Log.Information("aucun medecin n'a ce numero d'ordre");
                        message = "aucun medecin n'a ce numero d'ordre ";
                        frmMessage frmMessage = new frmMessage("Voulez-vous l'ajouter ?", message);
                        frmMessage.ShowDialog();
                        if (frmMessage.CustomDialogResult == DialogResult.Yes) { 
                            frmAdminAjouterUtilisateur frmAdminAjouterUtilisateur = new frmAdminAjouterUtilisateur();
                            frmAdminAjouterUtilisateur.ShowDialog();
                        }
                        return;
                    }
                    else
                    {
                        // TODO : obtenir son statut si il est actif propose de desactiver sinon proposer d' activer 
                        //medecin.Status
                        if (medecin.Status == true)
                        {
                            frmMessage frmMessage = new frmMessage("Voulez-vous bloquer ce medecin ?", "medecin trouver");
                            frmMessage.ShowDialog();
                            if (frmMessage.CustomDialogResult == DialogResult.Yes)
                            {
                                try
                                {

                                    medecin.Status = false;
                                    db.SaveChanges();
                                    frmAccueilAdmin frmAccueilAdmin = Application.OpenForms["frmAccueilAdmin"] as frmAccueilAdmin;
                                    frmAccueilAdmin.loadData();
                                    Log.Information("statut du medecin changer");
                                    frmExecutionReussie frmExecutionReussie = new frmExecutionReussie("execution reussie");
                                    frmExecutionReussie.ShowDialog();
                                    txtRechercherMedecin.Text = string.Empty;
                                }
                                catch (Exception ex)
                                {
                                    Log.Error($"{ex.Message} lors du changement de status");

                                }
                            }
                        }
                        else {

                            frmMessage frmMessage = new frmMessage("Voulez-vous Debloquer ce medecin ?", "medecin trouver");
                            frmMessage.ShowDialog();
                            if (frmMessage.CustomDialogResult == DialogResult.Yes)
                            {
                                try
                                {

                                    medecin.Status = true;
                                    db.SaveChanges();
                                    frmAccueilAdmin frmAccueilAdmin = Application.OpenForms["frmAccueilAdmin"] as frmAccueilAdmin;
                                    frmAccueilAdmin.loadData();
                                    Log.Information("statut du medecin changer");
                                    frmExecutionReussie frmExecutionReussie = new frmExecutionReussie("execution reussie");
                                    frmExecutionReussie.ShowDialog();
                                    txtRechercherMedecin.Text = string.Empty;
                                }
                                catch (Exception ex)
                                {
                                    Log.Error($"{ex.Message} lors du changement de status");

                                }
                            }

                        }
                    }
                }
                catch (Exception ex)
                {
                    Log.Error($" l 'erreur {ex.Message} est survenue lors de la recherche du medecin ");
                }

            }
                

        }

        private void btnRechercherSecretaire_Click(object sender, EventArgs e)
        {
            string message;
            if (string.IsNullOrEmpty(txtRerchercherSecretaire.Text))
            {
                message = "valeur saisie invalide";
                frmInformation frmInformation = new frmInformation(message);
                frmInformation.ShowDialog();
                Log.Information("valeur saisie invalide lors de la recherche de la secretaire");
                return;

            }
            else
            {
                try
                {
                    var secretaire = db.Secretaires.Where(m => m.Matricule == txtRerchercherSecretaire.Text).FirstOrDefault();
                    if (secretaire == null)
                    {
                        Log.Information("aucune secretaire n'a ce matricule");
                        message = "aucune secretaire n'a ce matricule";
                        frmMessage frmMessage = new frmMessage("Voulez-vous l'ajouter ?", message);
                        frmMessage.ShowDialog();
                        if (frmMessage.CustomDialogResult == DialogResult.Yes)
                        {
                            frmAdminAjouterSecretaire frmAdminAjouterSecretaire = new frmAdminAjouterSecretaire();
                            frmAdminAjouterSecretaire.ShowDialog();
                        }
                        return;
                    }
                    else
                    {
                        if (secretaire.Status == true)
                        {
                            frmMessage frmMessage = new frmMessage("Voulez-vous bloquer cette secretaire ?", "secretaire trouvée");
                            frmMessage.ShowDialog();
                            if (frmMessage.CustomDialogResult == DialogResult.Yes)
                            {
                                try
                                {

                                    secretaire.Status = false;
                                    db.SaveChanges();
                                    frmAccueilAdmin frmAccueilAdmin = Application.OpenForms["frmAccueilAdmin"] as frmAccueilAdmin;
                                    frmAccueilAdmin.loadData();
                                    Log.Information("statut de la secretaire changer");
                                    frmExecutionReussie frmExecutionReussie = new frmExecutionReussie("execution reussie");
                                    frmExecutionReussie.ShowDialog();
                                    txtRerchercherSecretaire.Text = string.Empty;
                                }
                                catch (Exception ex)
                                {
                                    Log.Error($"{ex.Message} lors du changement de status");

                                }
                            }
                        }
                        else
                        {

                            frmMessage frmMessage = new frmMessage("Voulez-vous Debloquer cette secretaire ?", "secretaire trouvée");
                            frmMessage.ShowDialog();
                            if (frmMessage.CustomDialogResult == DialogResult.Yes)
                            {
                                try
                                {

                                    secretaire.Status = true;
                                    db.SaveChanges();
                                    frmAccueilAdmin frmAccueilAdmin = Application.OpenForms["frmAccueilAdmin"] as frmAccueilAdmin;
                                    frmAccueilAdmin.loadData();
                                    Log.Information("statut de la secretaire changer");
                                    frmExecutionReussie frmExecutionReussie = new frmExecutionReussie("execution reussie");
                                    frmExecutionReussie.ShowDialog();
                                    txtRechercherMedecin.Text = string.Empty;
                                }
                                catch (Exception ex)
                                {
                                    Log.Error($"{ex.Message} lors du changement de status");

                                }
                            }

                        }
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
