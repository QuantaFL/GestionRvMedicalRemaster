using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.config;
using WindowsFormsApp1.CustomControls;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.views.Admin;
using WindowsFormsApp1.views.Med;
using WindowsFormsApp1.views.Secret;

namespace WindowsFormsApp1
{
    public partial class FrmConnexion : Form
    {
        public static Utilisateur user;
        public FrmConnexion()
        {
            InitializeComponent();
        }
        bdRdvMedicalContext db = new bdRdvMedicalContext();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSeConnecter_Click(object sender, EventArgs e)
        {

           
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            var identifiant = txtIdentifiant.Text;
            var motdepasse =  txtMotDePasse.Text;
            var utilisateur = db.Utilisateurs.Where(a => a.Identifiant.Equals(identifiant)).FirstOrDefault();
            if (utilisateur != null)
            {
                if (SaltHash.VerifyPassword(motdepasse, utilisateur.MotDePasse))
                {
                    user = utilisateur;
                    var Role = db.Role.Where(r => r.IdRole.Equals(utilisateur.IdRole)).FirstOrDefault();

                    if (Role.LibelleRole.Equals("ADMIN"))
                    {
                        this.Hide();
                        frmDashAdmin frm = new frmDashAdmin();
                        frm.Show();
                        return;
                    }
                    //if (utilisateur.PremiereConnexion == 0)
                    //{
                    //    return;
                    //}
                    else
                    {
                        if (Role.LibelleRole.Equals("SECRETAIRE"))
                        {
                            this.Hide();
                            frmDashSecretaire frm = new frmDashSecretaire();
                            frm.Show();
                        }
                        else
                        {
                            this.Hide();
                            frmDashMed frm = new frmDashMed();
                            frm.Show();
                        }
                    }
                }
            }
            else { 
                frmEchecExecution frmEchecExecution = new frmEchecExecution("cet identifiant n'exite pas");
                frmEchecExecution.ShowDialog();
            
            }
        }

        private void FrmConnexion_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void btnConnexion_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtMotDePasse_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnConnexion.PerformClick();
            }
        }
    }
}
