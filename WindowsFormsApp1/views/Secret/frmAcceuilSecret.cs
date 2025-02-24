using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.views.Admin;

namespace WindowsFormsApp1.views.Secret
{
    public partial class frmAcceuilSecret : Form
    {
        public frmAcceuilSecret()
        {
            InitializeComponent();
        }

        private void btnRechercherPatient_Click(object sender, EventArgs e)
        {
            using (var context = new bdRdvMedicalContext())
            {
                if (!string.IsNullOrEmpty(txtEmail.Text))
                {
                    var patient = context.Patients
                        .Where(p => p.Email == txtEmail.Text)
                        .FirstOrDefault();

                    if (patient != null)
                    {
                        ShowPatientTrouvePrompt(patient);
                    }
                    else
                    {
                        ShowNoPatientPrompt();
                    }
                }
                else if (!string.IsNullOrEmpty(txtTelephone.Text))
                {
                    var patient = context.Patients
                        .Where(p => p.Tel == txtTelephone.Text)
                        .FirstOrDefault();

                    if (patient != null)
                    {
                        ShowPatientTrouvePrompt(patient);
                    }
                    else
                    {
                        ShowNoPatientPrompt();
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez svp remplir un champ");
                }
            }
        }

        private static void ShowPatientTrouvePrompt(Patient patient)
        {
            frmMessage frmMessage = new frmMessage();
            var result = MessageBox.Show(
                "Patient : " + patient.NomPrenom,
                "Voulez vous prend un rv pour cette personne ?",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information
            );

            if (result == DialogResult.OK)
            {
                frmRdv frmRdv = new frmRdv(patient);
                frmDashSecretaire parentForm = Application.OpenForms["frmDashSecretaire"] as frmDashSecretaire;
                parentForm.fermer();
                frmRdv.MdiParent = parentForm;
                frmRdv.WindowState = FormWindowState.Maximized;
                frmRdv.Show();
                //fermer();
                //frmAcceuilSecret frmAcceuilSecret = new frmAcceuilSecret();
                //frmAcceuilSecret.MdiParent = this;
                //frmAcceuilSecret.Show();
                //frmAcceuilSecret.WindowState = FormWindowState.Maximized;
            }
            else if (result == DialogResult.Cancel)
            {
                //TODO
            }
        }

        private static void ShowNoPatientPrompt()
        {
            var result = MessageBox.Show(
                "Le Patient N'existe pas dans la base ",
                "Voulez vous l'ajouter ?",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information
            );

            if (result == DialogResult.OK)
            {

            }
            else if (result == DialogResult.Cancel)
            {
                //TODO
            }
        }



        private void txtTelephone_Enter(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEmail.Text))
            {
                txtEmail.Text = "";
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTelephone.Text))
            {
                txtTelephone.Text = "";
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
