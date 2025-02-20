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
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.views
{
    public partial class FrmAgenda : Form
    {
        public int idMedecin;
        bdRdvMedicalContext db = new bdRdvMedicalContext();
        Boolean clickSurChoisir;
        public FrmAgenda()
        {
            InitializeComponent();
        }

        private void FrmAgenda_Load(object sender, EventArgs e)
        {
            var medecin = db.Medecins.Find(idMedecin);
            //Specialite {2}
            //medecin.Specialite
            lblMedecin.Text = string.Format("N ordre {0},Nom Prenom {1}, ",medecin.NumeroOrdre,medecin.NomPrenom);
            lblIdMedecin.Text = medecin.IdU.ToString();
            lblIdMedecin.Visible = false;
            ResetForm();
        }
        private void ResetForm()
        {
            txtTitre.Text = string.Empty;
            txtHeureDebut.Text = string.Empty;
            txtHeureFin.Text = string.Empty;
            txtDatePlanifier.Value = DateTime.Now;
            txtCrenneau.Text = string.Empty;
            txtLieu.Text = string.Empty;
            // requete LINQ pour faire une condition
            dgAgenda.DataSource = db.Agenda.Where(a => a.DataPlanifier>=DateTime.Today && a.IdMedecin == idMedecin).ToList();
            txtTitre.Focus();
            if (dgAgenda.Rows.Count > 0)
            {
                btnSupprimer.Enabled = true;
                btnModifier.Enabled = true;
                btnChoisir.Enabled = true;

            }
            else
            {
                btnSupprimer.Enabled = false;
                btnModifier.Enabled = false;
                btnChoisir.Enabled = false;
            }
            clickSurChoisir = false;
            btnAjouter.Enabled = true;

        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Agenda agenda = new Agenda();
            agenda.DataPlanifier = txtDatePlanifier.Value;
            agenda.Lieu = txtLieu.Text;
            agenda.IdMedecin = idMedecin;
            agenda.HeureDebut = txtHeureDebut.Text;
            agenda.HeureFin = txtHeureFin.Text;
            agenda.Statut = "Brouillon";
            agenda.Creneau = int.Parse(txtCrenneau.Text);
            agenda.Titre = txtTitre.Text;
            db.Agenda.Add(agenda);
            if (db.SaveChanges() > 0) {
                MessageBox.Show("nouvel enregistrement reussit ");
                ResetForm();
            }

        }

        private void btnChoisir_Click(object sender, EventArgs e)
        {
            clickSurChoisir = true;
            btnAjouter.Enabled = false;
        }

        private void btnRendezVous_Click(object sender, EventArgs e)
        {
           
        }

        private void btnRendezVous_Click_1(object sender, EventArgs e)
        {
            frmRdv frmRdv = new frmRdv();
            frmRdv.idMedecinRdv = this.idMedecin;
            frmRdv.crenneau = int.Parse(dgAgenda.CurrentRow.Cells[10].Value.ToString());
            frmRdv.idAgenda = int.Parse(dgAgenda.CurrentRow.Cells[0].Value.ToString());
            this.Hide();
            frmRdv.Show();
        }
    }
}
