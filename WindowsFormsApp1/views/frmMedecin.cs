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

namespace WindowsFormsApp1.views
{
    public partial class frmMedecin : Form
    {
        bdRdvMedicalContext db = new bdRdvMedicalContext();
        Boolean clickSurChoisir;
        public frmMedecin()
        {
            InitializeComponent();
        }

        private void frmMedecin_Load(object sender, EventArgs e)
        {
            ResetForm();

        }

        public List<SelectListViewModel> loadSpecialteccb()
        {
            var s = db.Specialite.ToList();
            List<SelectListViewModel> liste = new List<SelectListViewModel>();
            SelectListViewModel b = new SelectListViewModel();
            b.Text = "Selectionner une valeur";
            b.Value = "";
            liste.Add(b);
            foreach (var item in s) {
                SelectListViewModel a = new SelectListViewModel();
                a.Text = item.NomSpecialte;
                a.Value = item.Id.ToString();
                liste.Add(a);

            }
            return liste;
        }

        private void ResetForm()
        {
            //vider les champs
            txtAdresse.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtNumeroOrdreMedecin.Text = string.Empty;
            cbbSpecialite.SelectedValue = string.Empty;
            cbbSpecialite.DataSource = loadSpecialteccb();
            cbbSpecialite.ValueMember = "Value";
            cbbSpecialite.DisplayMember = "Text";
            txtIdentifiant.Text = string.Empty;
            txtTelephone.Text = string.Empty;
            txtNomPrenom.Text = string.Empty;
            // requete LINQ pour selectionner les colonnes à afficher 
            //m.Specialite,
            dgMedecin.DataSource = db.Medecins.Select(m => new { m.IdU, m.NomPrenom, m.Identifiant, m.NumeroOrdre, m.Specialite.NomSpecialte, m.Tel, m.Email ,m.Addresse }).ToList();
            txtNomPrenom.Focus();
            if (dgMedecin.Rows.Count > 0)
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

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Medecin medecin = new Medecin();
            medecin.NomPrenom = txtNomPrenom.Text;
            medecin.Addresse = txtAdresse.Text;
            medecin.Email = txtEmail.Text;
            medecin.Tel = txtTelephone.Text;
            medecin.NumeroOrdre = txtNumeroOrdreMedecin.Text;
            medecin.Identifiant = txtIdentifiant.Text;
            medecin.IdSpecialite = int.Parse(cbbSpecialite.SelectedValue.ToString());
            medecin.Status = false;
            db.Medecins.Add(medecin);
            if (db.SaveChanges() > 0)
            {
                MessageBox.Show("Nouvel enregistrement reussit");
            }
            ResetForm();
        }

        private void btnChoisir_Click(object sender, EventArgs e)
        {
            clickSurChoisir = true;
            btnAjouter.Enabled = false;
            int? id = int.Parse(dgMedecin.CurrentRow.Cells[0].Value.ToString());
            var medecin = db.Medecins.Find(id);
            if (medecin != null) {
                txtNomPrenom.Text = medecin.NomPrenom ;
                txtAdresse.Text = medecin.Addresse ;
                txtEmail.Text = medecin.Email;
                txtTelephone.Text = medecin.Tel;
                txtNumeroOrdreMedecin.Text = medecin.NumeroOrdre;
                txtIdentifiant.Text = medecin.Identifiant;
                cbbSpecialite.SelectedValue = medecin.IdSpecialite;
               // txtSpecialite.Text = medecin.Specialite;

            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (!clickSurChoisir)
            {
                MessageBox.Show("vous devez d'abord slectionner un enregistrement et appuyer sur choisir");
            }
            else
            {
                int? id = int.Parse(dgMedecin.CurrentRow.Cells[0].Value.ToString());
                var medecin = db.Medecins.Find(id);
                if (id.HasValue && medecin != null) {

                    DialogResult result = MessageBox.Show("voulez vraiment supprimer ce medecin ?", "Veuillez confirmer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes) { 

                        db.Medecins.Remove(medecin);
                        db.SaveChanges();
                        ResetForm();
                    }

                
                }
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (!clickSurChoisir)
            {
                MessageBox.Show("veuillez selectionner un enregistrement puis cliquer sur choisir");
            }
            else {
                int id = int.Parse(dgMedecin.CurrentRow.Cells[0].Value.ToString());
                var medecin = db.Medecins.Find(id);
                medecin.NomPrenom = txtNomPrenom.Text;
                medecin.Addresse = txtAdresse.Text;
                medecin.Email = txtEmail.Text;
                medecin.Tel = txtTelephone.Text;
                medecin.NumeroOrdre = txtNumeroOrdreMedecin.Text;
                medecin.Identifiant = txtIdentifiant.Text;
                medecin.IdSpecialite = int.Parse(cbbSpecialite.SelectedValue.ToString());
                db.SaveChanges();
                ResetForm();

            }
        }

        private void btnAgenda_Click(object sender, EventArgs e)
        {
            FrmAgenda agenda = new FrmAgenda();
            agenda.idMedecin = int.Parse(dgMedecin.CurrentRow.Cells[0].Value.ToString());
            agenda.Show();
        }

        private void btnRendezVous_Click(object sender, EventArgs e)
        {
            frmRdv frmRdv = new frmRdv();
            frmRdv.idMedecinRdv = int.Parse(dgMedecin.CurrentRow.Cells[0].Value.ToString());
            frmRdv.Show();
        }
    }
}
