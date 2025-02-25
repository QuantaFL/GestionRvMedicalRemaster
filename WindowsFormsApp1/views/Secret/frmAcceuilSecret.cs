using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.Logging;
using Serilog;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.views.Admin;
using Serilog;
using WindowsFormsApp1.CustomControls;

namespace WindowsFormsApp1.views.Secret
{
    public partial class frmAcceuilSecret : Form
    {
        public frmAcceuilSecret()
        {
            InitializeComponent();
            AfficheStats();
            txtEmail.Focus();
        }

        private void AfficheStats()
        {
            var agendaList = bd.Agenda.ToList();
            var rendezvous = bd.RendezVous.ToList();
            lblNbRv.Text = rendezvous.Where(r => r.DateRv.Contains(DateTime.Now.Date.ToString())).ToList().Count().ToString();
            //FrmConnexion.user
            lblNbAgenda.Text = agendaList.Where(a => a.DataPlanifier.Value.Date == DateTime.Now.Date).ToList().Count.ToString();
            //lblNbRv.Text = bd.RendezVous.Where(r => DateTime.Now.ToString().Contains(DateTime.Parse(r.DateRv).ToString())).ToList().Count.ToString();
            lblNbPatient.Text = bd.Patients.ToList().Count.ToString();
        }

        bdRdvMedicalContext bd = new bdRdvMedicalContext();

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
                    frmInformation frmInformation = new frmInformation("Veuillez svp remplir un champ");
                    frmInformation.ShowDialog();
                }
            }
        }

        private static void ShowPatientTrouvePrompt(Patient patient)
        {
          
            frmMessage frmMessage = new frmMessage("Voulez-vous prendre rendez-vous","patient trouvé");
            frmMessage.ShowDialog();
                        
           
            if(frmMessage.CustomDialogResult == DialogResult.Yes)
            {
                //ICIIIII
                Serilog.Log.Information("redirection vers l'ajout d'un patient");
                frmRdv frmRdv = new frmRdv(patient);
                frmRdv.Show();

            }

        }

        private static void ShowNoPatientPrompt()
        {
           
            frmMessage frmMessage = new frmMessage("Voulez vous l'ajouter ?", "Le Patient N'existe pas");
            frmMessage.ShowDialog();

            if (frmMessage.CustomDialogResult == DialogResult.Yes)
            {
                Serilog.Log.Information("Redirection vers le formulaire d'ajout patient");
                frmCreerPatient frmCreerPatient = new frmCreerPatient();
                frmCreerPatient.ShowDialog();
                return;
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

        private void btnAjouterAgenda_Click(object sender, EventArgs e)
        {
            frmCreerPatient frmCreerPatient = new frmCreerPatient();
            frmCreerPatient.Show(); 
        }

        private void btnVoirRdv_Click(object sender, EventArgs e)
        {

        }

        private void btnRechercherPatient_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtTelephone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRechercherPatient.PerformClick();
            }
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRechercherPatient.PerformClick();
            }
        }
    }
}
