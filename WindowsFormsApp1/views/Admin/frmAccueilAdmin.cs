using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetierRvMedical2.Services;
using Serilog;
using WindowsFormsApp1.ApiConsumer.Requests;
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
      

        private void btnAjouterUtilisateur_Click(object sender, EventArgs e)
        {
            frmAdminAjouterUtilisateur ajouterUtilisateur = new frmAdminAjouterUtilisateur();
            ajouterUtilisateur.ShowDialog();
        }

        private void frmAccueilAdmin_Load(object sender, EventArgs e)
        {
            loadData();
        }

        public async Task loadData()
        {
           
            var users = await ApiConsumer.ApiClientContainer.UserService.ListUsersAsync();


            var filteredUsers = users
     .Where(u => !u.Role.CodeRole.Equals("ADMIN"))
     .Select(u => new
     {
         u.Id,
         u.NomPrenom,
         u.DateNaissance,
         u.Email,
         u.Role.CodeRole,
         Statut = (bool)u.Statut ? "Actif" : "Inactif"
     })
     .ToList();


            dgUtilisateur.DataSource = filteredUsers;
        }

        private void btnAjouterSecretaire_Click(object sender, EventArgs e)
        {

        }

        private void btnAjouterSecretaire_Click_1(object sender, EventArgs e)
        {
            frmAdminAjouterSecretaire frmAdminAjouterSecretaire = new frmAdminAjouterSecretaire();
            frmAdminAjouterSecretaire.ShowDialog();
        }
        
        private async void btnRechercherMedecin_Click(object sender, EventArgs e)
        {
            string message;

            if (string.IsNullOrEmpty(txtRechercherMedecin.Text))
            {
                message = "valeur saisie invalide";
                frmInformation frmInformation = new frmInformation(message);
                frmInformation.ShowDialog();
                Log.Information("valeur saisie invalide lors de la recherche du medecin");
                return;
            }

            try
            {
                var medecins = await ApiConsumer.ApiClientContainer.MedecinService.ListMedecinsAsync();
                if(medecins.Count > 0)
                {
                    MessageBox.Show("riennnnnnn");
                  
                }
                if (medecins == null || !medecins.Any())
                {
                    Log.Warning("La liste des médecins est vide ou nulle");
                    MessageBox.Show("Erreur de récupération des médecins depuis le serveur.");
                    return;
                }
                foreach (var m in medecins)
                {
                    Console.WriteLine(m.NumeroOrdre);
                }
                var medecin = medecins.FirstOrDefault(m => m.NumeroOrdre != null &&
                                                           m.NumeroOrdre.Equals(txtRechercherMedecin.Text.ToUpper().Trim()));
                

                if (medecin == null)
                {
                    Log.Information("Aucun médecin trouvé avec ce numéro d'ordre");
                    message = "Aucun médecin n'a ce numéro d'ordre.";
                    frmMessage frmMessage = new frmMessage("Voulez-vous l'ajouter ?", message);
                    frmMessage.ShowDialog();

                    if (frmMessage.CustomDialogResult == DialogResult.Yes)
                    {
                        frmAdminAjouterUtilisateur frmAdminAjouterUtilisateur = new frmAdminAjouterUtilisateur();
                        frmAdminAjouterUtilisateur.ShowDialog();
                    }

                    return;
                }

                Log.Information($"Médecin trouvé : {medecin.User.NomPrenom}, Numéro Ordre : {medecin.NumeroOrdre}");

                if (medecin.User == null)
                {
                    Log.Error("L'objet 'User' du médecin est nul.");
                    MessageBox.Show("Erreur : Données du médecin incomplètes.");
                    return;
                }

                if (medecin.User.Statut == true)
                {
                    frmMessage frmMessage = new frmMessage("Voulez-vous bloquer ce médecin ?", "Médecin trouvé");
                    frmMessage.ShowDialog();

                    if (frmMessage.CustomDialogResult == DialogResult.Yes)
                    {
                        try
                        {
                            UpdateUserRequest updateUserRequest = new UpdateUserRequest
                            {
                                
                               NomPrenom = medecin.User.NomPrenom,
                               Adresse = medecin.User.Adresse,
                               DateNaissance = medecin.User.DateNaissance,
                               Telephone= medecin.User.Telephone,
                               Statut = !medecin.User.Statut,
                               Email = medecin.User.Email,
                               Genre = medecin.User.Genre,
                               MedecinDetails = new MedecinDetailsRequest
                               {
                                   NumeroOrdre = medecin.NumeroOrdre,
                                   SpecialiteId= medecin.SpecialiteId
                               },
                               RoleId = medecin.User.RoleId,
                               Photo = null,
                               SecretaireDetails = null

                               
                              
                            };

                            await ApiConsumer.ApiClientContainer.UserService.UpdateUserAsync(medecin.Id, updateUserRequest);
                           
                            await loadData();
                            Log.Information("Statut du médecin changé à 'bloqué'");
                            frmExecutionReussie frmExecutionReussie = new frmExecutionReussie("Exécution réussie");
                            frmExecutionReussie.ShowDialog();
                            txtRechercherMedecin.Text = string.Empty;
                        }
                        catch (Exception ex)
                        {
                            Log.Error($"Erreur lors du changement de statut : {ex.Message}");
                        }
                    }
                }
                else
                {
                    frmMessage frmMessage = new frmMessage("Voulez-vous débloquer ce médecin ?", "Médecin trouvé");
                    frmMessage.ShowDialog();

                    if (frmMessage.CustomDialogResult == DialogResult.Yes)
                    {
                        try
                        {
                            medecin.User.Statut = true;
                            await loadData();
                            Log.Information("Statut du médecin changé à 'actif'");
                            frmExecutionReussie frmExecutionReussie = new frmExecutionReussie("Exécution réussie");
                            frmExecutionReussie.ShowDialog();
                            txtRechercherMedecin.Text = string.Empty;
                        }
                        catch (Exception ex)
                        {
                            Log.Error($"Erreur lors du changement de statut : {ex.Message}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error($"L'erreur {ex.Message} est survenue lors de la recherche du médecin.");
            }



        }

        private async void  btnRechercherSecretaire_Click(object sender, EventArgs e)
        {
       
            string message;

            if (string.IsNullOrEmpty(txtRerchercherSecretaire.Text))
            {
                message = "Valeur saisie invalide";
                frmInformation frmInformation = new frmInformation(message);
                frmInformation.ShowDialog();
                Log.Information("Valeur saisie invalide lors de la recherche de la secrétaire");
                return;
            }

            try
            {
                var secretaires = await ApiConsumer.ApiClientContainer.SecretaireService.ListSecretairesAsync();
                foreach (var s in secretaires)
                {
                   
                    Console.WriteLine(s.matricule);
                }


                if (secretaires == null || !secretaires.Any())
                {
                    Log.Warning("La liste des secrétaires est vide ou nulle.");
                    MessageBox.Show("Erreur de récupération des secrétaires depuis le serveur.");
                    return;
                }

                string matriculeRecherche = txtRerchercherSecretaire.Text.Trim().ToUpper();

                var secretaire = secretaires.FirstOrDefault(s =>
                    !string.IsNullOrEmpty(s.matricule) &&
                    s.matricule.ToUpper() == matriculeRecherche);

                if (secretaire == null)
                {
                    Log.Information("Aucune secrétaire trouvée avec ce matricule");
                    message = "Aucune secrétaire n'a ce matricule";
                    frmMessage frmMessage = new frmMessage("Voulez-vous l'ajouter ?", message);
                    frmMessage.ShowDialog();

                    if (frmMessage.CustomDialogResult == DialogResult.Yes)
                    {
                        frmAdminAjouterSecretaire frmAdminAjouterSecretaire = new frmAdminAjouterSecretaire();
                        frmAdminAjouterSecretaire.ShowDialog();
                    }

                    return;
                }

                // Contrôle du statut
                if (secretaire.User.Statut == true)
                {
                    frmMessage frmMessage = new frmMessage("Voulez-vous bloquer cette secrétaire ?", "Secrétaire trouvée");
                    frmMessage.ShowDialog();

                    if (frmMessage.CustomDialogResult == DialogResult.Yes)
                    {
                        try
                        {
                            secretaire.User.Statut = false; // ou appeler l'API de désactivation ici
                            loadData();
                            Log.Information("Statut de la secrétaire changé à 'bloqué'");
                            frmExecutionReussie frmExecutionReussie = new frmExecutionReussie("Exécution réussie");
                            frmExecutionReussie.ShowDialog();
                            txtRerchercherSecretaire.Text = string.Empty;
                        }
                        catch (Exception ex)
                        {
                            Log.Error($"{ex.Message} lors du changement de statut");
                        }
                    }
                }
                else
                {
                    frmMessage frmMessage = new frmMessage("Voulez-vous débloquer cette secrétaire ?", "Secrétaire trouvée");
                    frmMessage.ShowDialog();

                    if (frmMessage.CustomDialogResult == DialogResult.Yes)
                    {
                        try
                        {
                            secretaire.User.Statut = true; // ou appeler l'API d'activation ici
                             loadData();
                            Log.Information("Statut de la secrétaire changé à 'actif'");
                            frmExecutionReussie frmExecutionReussie = new frmExecutionReussie("Exécution réussie");
                            frmExecutionReussie.ShowDialog();
                            txtRerchercherSecretaire.Text = string.Empty;
                        }
                        catch (Exception ex)
                        {
                            Log.Error($"{ex.Message} lors du changement de statut");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error($"L'erreur {ex.Message} est survenue lors de la recherche de la secrétaire");
            }
        }


        

        private void ctrlBox1_Load(object sender, EventArgs e)
        {
            frmAccueilAdmin frm = Application.OpenForms["frmAccueilAdmin"] as frmAccueilAdmin;
           // this.ctrlBox1 = new CtrlBox(frm);
           // this.ctrlBox1.closeForm();
        }

        private void btnBloquerUtilisateur_Click(object sender, EventArgs e)
        {

        }
    }
}
