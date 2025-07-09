using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetierRvMedical2.Models;
using MetierRvMedical2.Services;
using WindowsFormsApp1.CustomControls;
using WindowsFormsApp1.views.Admin;

namespace WindowsFormsApp1.views.Secret
{
    public partial class frmCreerPatient : Form
    {

       // private readonly PatientService _patientService = new PatientService();
        public frmCreerPatient()
        {
            InitializeComponent();
            RessetForm();
        }
      //  bdRdvMedicalContext bd = new bdRdvMedicalContext();
        private async void button1_Click(object sender, EventArgs e)
        {
            if (!ValiderPatient())
            {
                return;
            }
            ApiConsumer.Requests.CreatePatientRequest patient = new ApiConsumer.Requests.CreatePatientRequest() ;
            patient.NomPrenom = txtNomPrenom.Text;
            patient.Telephone = txtNumeroTelephone.Text;
            patient.DateNaissance = DateTime.Parse(txtDateNaissance.Text);
            patient.Email = txtEmail.Text;
            patient.Adresse = txtAdresse.Text;
            patient.taille = float.Parse(txtTaille.Text);
            int idG = int.Parse(cbbGroupeSanguin.SelectedValue.ToString());
          //GroupeSanguin groupe = bd.GroupeSanguins.Find(idG);
            patient.GroupeSanguinId = idG;
            patient.poids = float.Parse(txtPoids.Text);
            // _patientService.AddPatient(patient);
            try
            {
                await ApiConsumer.ApiClientContainer.PatientService.CreatePatientAsync(patient);

                //  bd.SaveChanges();
                //TODO remplacer le message box par le message box cree par Rben//okay cest fait
                new frmInformation("Enregistrement du document patient avec succes").ShowDialog();
                
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var entityError in ex.EntityValidationErrors)
                {
                    Console.WriteLine($"Entity of type {entityError.Entry.Entity.GetType().Name} has the following validation errors:");
                    foreach (var validationError in entityError.ValidationErrors)
                    {
                        Console.WriteLine($" - Property: {validationError.PropertyName}, Error: {validationError.ErrorMessage}");
                    }
                }
            }
        }
        private bool ValiderPatient()
        {
          
            if (string.IsNullOrWhiteSpace(txtNomPrenom.Text))
            {
                new frmInformation("Le nom et prénom sont obligatoires.").ShowDialog();
                return false;
            }

         
            if (string.IsNullOrWhiteSpace(txtNumeroTelephone.Text))
            {
                new frmInformation("Le numéro de téléphone est obligatoire.").ShowDialog();
                return false;
            }

           
            DateTime dateNaissance;
            if (!DateTime.TryParse(txtDateNaissance.Text, out dateNaissance))
            {
                new frmInformation("La date de naissance est invalide.").ShowDialog();
                return false;
            }

         
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                new frmInformation("L'email est obligatoire.").ShowDialog();
                return false;
            }

           
            if (string.IsNullOrWhiteSpace(txtAdresse.Text))
            {
                new frmInformation("L'adresse est obligatoire.").ShowDialog();
                return false;
            }

           
            float taille;
            if (!float.TryParse(txtTaille.Text, out taille))
            {
                new frmInformation("La taille doit être un nombre valide.").ShowDialog();
                return false;
            }

         
            if (cbbGroupeSanguin.SelectedValue == null || string.IsNullOrWhiteSpace(cbbGroupeSanguin.SelectedValue.ToString()))
            {
                new frmInformation("Veuillez sélectionner un groupe sanguin.").ShowDialog();
                return false;
            }

          
            float poids;
            if (!float.TryParse(txtPoids.Text, out poids))
            {
                new frmInformation("Le poids doit être un nombre valide.").ShowDialog();
                return false;
            }

          
            return true;
        }

        public async Task<List<ApiConsumer.Models.SelectListViewModel>> loadGroupeCbb()
        {
            try {
                
                var groupes = await ApiConsumer.ApiClientContainer.GroupeSanguinService.ListGroupeSanguinsAsync();
                List <ApiConsumer.Models.SelectListViewModel> newliste = new List<ApiConsumer.Models.SelectListViewModel>();
                ApiConsumer.Models.SelectListViewModel g = new ApiConsumer.Models.SelectListViewModel();
                g.Text = "Selectionnez un groupe ";
                g.Value = "";
                newliste.Add(g);

                foreach (var groupe in groupes)
                {
                    ApiConsumer.Models.SelectListViewModel s = new ApiConsumer.Models.SelectListViewModel();
                    s.Text = groupe.LibelleGroupeSanguin;
                    s.Value = groupe.Id.ToString();
                    newliste.Add((s));
                }
                return newliste;

            } catch (Exception ex) {
                throw ex;
            
            }

        }
        public async void RessetForm()
        {
            cbbGroupeSanguin.ValueMember = "Value";
            cbbGroupeSanguin.DisplayMember = "Text";
            cbbGroupeSanguin.DataSource = await loadGroupeCbb();

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
