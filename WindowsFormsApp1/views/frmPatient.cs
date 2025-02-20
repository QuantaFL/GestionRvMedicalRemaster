using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.views
{
    public partial class frmPatient : Form
    {
        // Todo: désactiver le button ajouter lorsqu'on fait un clik sur choisir 
        public frmPatient()
        {
            InitializeComponent();
            
        }
        bdRdvMedicalContext db = new bdRdvMedicalContext();
        Boolean clickSurChoisir;


        private void frmPatient_Load(object sender, EventArgs e)
        {
            ResetForm();
            
        }




        private void txtNomPrenom_TextChanged(object sender, EventArgs e)
        {

        }
        private void ResetForm()
        {
            txtAdresse.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtGroupeSanguin.Text = string.Empty;
            txtPoids.Text = string.Empty;
            txtTaille.Text = string.Empty;
            txtTelephone.Text = string.Empty;
            txtNomPrenom.Text = string.Empty;
            dgPatient.DataSource = db.Patients.ToList();
            txtNomPrenom.Focus();
            if (dgPatient.Rows.Count > 0)
            {
                btnSupprimer.Enabled = true;
                btnModifier.Enabled = true;
                btnChoisir.Enabled = true;

            }
            else { 
                btnSupprimer.Enabled = false;
                btnModifier.Enabled = false;  
                btnChoisir.Enabled = false;
            }
            clickSurChoisir = false;
            btnAjouter.Enabled = true;

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {

            Patient p = new Patient();
            p.NomPrenom = txtNomPrenom.Text;
            p.Email = txtEmail.Text;
            p.Tel = txtTelephone.Text;
            p.Addresse = txtAdresse.Text;
            p.GroupeSanguin = txtGroupeSanguin.Text;
            p.Poids = float.Parse(txtPoids.Text);
            p.Taille = float.Parse(txtTaille.Text);
            db.Patients.Add(p);
            db.SaveChanges();
            ResetForm();
        }

        private void btnChoisir_Click(object sender, EventArgs e)
        {
            clickSurChoisir = true;
            btnAjouter.Enabled = false;
            txtGroupeSanguin.Text = dgPatient.CurrentRow.Cells[0].Value.ToString();
            txtTaille.Text = dgPatient.CurrentRow.Cells[1].Value.ToString();
            txtPoids.Text = dgPatient.CurrentRow.Cells[2].Value.ToString();
            txtNomPrenom.Text = dgPatient.CurrentRow.Cells[4].Value.ToString();
            txtAdresse.Text = dgPatient.CurrentRow.Cells[5].Value.ToString();
            txtEmail.Text = dgPatient.CurrentRow.Cells[6].Value.ToString();
            txtTelephone.Text = dgPatient.CurrentRow.Cells[7].Value.ToString();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (!clickSurChoisir)
            {
                MessageBox.Show("vous devez d'abord slectionner un enregistrement et appuyer sur choisir");

            }
            else {
                int? id = int.Parse(dgPatient.CurrentRow.Cells[3].Value.ToString());
                if (id.HasValue)
                {
                    Patient patient = db.Patients.Find(id);
                    if (patient != null)
                    {
                        DialogResult result = MessageBox.Show("Voulez vous vraiment supprimer ce patient ?", "Veuillez Confirmer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            db.Patients.Remove(patient);
                            db.SaveChanges();
                            ResetForm();
                        }

                    }



                }
            }
              
              
          
            
            //dgPatient.CurrentRow.Index 


        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (!clickSurChoisir)
            {
                MessageBox.Show("Vous devez choisir un patient avant de continuer");
            }
            else
            {

                int? id = int.Parse(dgPatient.CurrentRow.Cells[3].Value.ToString());
                if (id.HasValue)
                {
                    Patient p = db.Patients.Find(id);
                    p.NomPrenom = txtNomPrenom.Text;
                    p.Email = txtEmail.Text;
                    p.Tel = txtTelephone.Text;
                    p.Addresse = txtAdresse.Text;
                    p.GroupeSanguin = txtGroupeSanguin.Text;
                    p.Poids = float.Parse(txtPoids.Text);
                    p.Taille = float.Parse(txtTaille.Text);
                    db.SaveChanges();
                    ResetForm();

                }
            }
           
        }
    }
}
