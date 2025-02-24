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
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.views.Secret
{
    public partial class frmCreerPatient : Form
    {
        public frmCreerPatient()
        {
            InitializeComponent();
            RessetForm();
        }
        bdRdvMedicalContext bd = new bdRdvMedicalContext();
        private void button1_Click(object sender, EventArgs e)
        {
            if (!ValiderPatient())
            {
                return;
            }
            Patient patient = new Patient();
            patient.NomPrenom = txtNomPrenom.Text;
            patient.Tel = txtNumeroTelephone.Text;
            patient.DateNaissance = DateTime.Parse(txtDateNaissance.Text);
            patient.Email = txtEmail.Text;
            patient.Addresse = txtAdresse.Text;
            patient.Taille = float.Parse(txtTaille.Text);
            int idG = int.Parse(cbbGroupeSanguin.SelectedValue.ToString());
            GroupeSanguin groupe = bd.GroupeSanguins.Find(idG);
            patient.GroupeSanguin = groupe.CodeGroupeSanguin;
            patient.Poids = float.Parse(txtPoids.Text);
            bd.Patients.Add(patient);
            try
            {
                bd.SaveChanges();
                //TODO remplacer le message box par le message box cree par Rben
                MessageBox.Show("success");
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
                MessageBox.Show("Le nom et prénom sont obligatoires.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

         
            if (string.IsNullOrWhiteSpace(txtNumeroTelephone.Text))
            {
                MessageBox.Show("Le numéro de téléphone est obligatoire.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

           
            DateTime dateNaissance;
            if (!DateTime.TryParse(txtDateNaissance.Text, out dateNaissance))
            {
                MessageBox.Show("La date de naissance est invalide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

         
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("L'email est obligatoire.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

           
            if (string.IsNullOrWhiteSpace(txtAdresse.Text))
            {
                MessageBox.Show("L'adresse est obligatoire.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

           
            float taille;
            if (!float.TryParse(txtTaille.Text, out taille))
            {
                MessageBox.Show("La taille doit être un nombre valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

         
            if (cbbGroupeSanguin.SelectedValue == null || string.IsNullOrWhiteSpace(cbbGroupeSanguin.SelectedValue.ToString()))
            {
                MessageBox.Show("Veuillez sélectionner un groupe sanguin.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

          
            float poids;
            if (!float.TryParse(txtPoids.Text, out poids))
            {
                MessageBox.Show("Le poids doit être un nombre valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

          
            return true;
        }

        public List<SelectListViewModel> loadGroupeCbb()
        {
            var groupes = bd.GroupeSanguins.ToList();
            List<SelectListViewModel> newliste = new List<SelectListViewModel>();
            SelectListViewModel g = new SelectListViewModel();
            g.Text = "Selectionnez un groupe ";
            g.Value = "";
            newliste.Add(g);

            foreach (var groupe in groupes)
            {
                SelectListViewModel s = new SelectListViewModel();
                s.Text = groupe.CodeGroupeSanguin;
                s.Value = groupe.IdGroupeSanguin.ToString();
                newliste.Add((s));
            }
            return newliste;

        }
        public void RessetForm()
        {
            cbbGroupeSanguin.ValueMember = "Value";
            cbbGroupeSanguin.DisplayMember = "Text";
            cbbGroupeSanguin.DataSource = loadGroupeCbb();

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
