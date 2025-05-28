using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Serilog;
using WindowsFormsApp1.config;
using WindowsFormsApp1.CustomControls;

using WindowsFormsApp1.Models;
using WindowsFormsApp1.views.Admin;
using WindowsFormsApp1.views.Med;
using WindowsFormsApp1.views.Secret;
using Utilisateur = WindowsFormsApp1.Models.Utilisateur;


namespace WindowsFormsApp1
{
    public partial class FrmConnexion : Form
    {
        public static Utilisateur user;
        private CustomControlBox customControlBox;
        public FrmConnexion()
        {
            //customControlBox = new CustomControlBox();
            //customControlBox.Dock = DockStyle.Top;
            //customControlBox.MinimizeClick += CustomControlBox_MinimizeClick;
            //customControlBox.CloseClick += CustomControlBox_CloseClick;
            //Controls.Add(customControlBox);

            FormBorderStyle = FormBorderStyle.None;
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void CustomControlBox_MinimizeClick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CustomControlBox_CloseClick(object sender, EventArgs e)
        {
            this.Close();
        }
         bdRdvMedicalContext db = new bdRdvMedicalContext();
       //  MetierRvMedical.AuthentificationClient  client = new MetierRvMedical.AuthentificationClient();
      //  MetierAuthService.AuthentificationClient authentificationClient = new MetierAuthService.AuthentificationClient();

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

        public void resetText()
        {
            txtMotDePasse.Text = String.Empty;
        }

        private async void btnConnexion_Click(object sender, EventArgs e)
        {
            try {
                var identifiant = txtIdentifiant.Text;
                var motdepasse = txtMotDePasse.Text;
                if (identifiant == "" || motdepasse == "")
                {
                    new frmInformation("veuillez svp renseigner les deux champs").ShowDialog();
                    return;
                }
               // MetierRvMedical.Utilisateur utilisateur = client.GetUserByIdentifiant(identifiant);
               Utilisateur utilisateur = new Utilisateur();

                MessageBox.Show($"{utilisateur.Identifiant}");
                if (utilisateur != null)
                {
                    if (SaltHash.VerifyPassword(motdepasse, utilisateur.MotDePasse))
                    {
                        if (utilisateur.Status == false)
                        {
                            new frmEchecExecution("Votre compte est bloquer veuillez svp contacter votre administrateur").ShowDialog();
                            resetText();
                            return;
                        }
                     //   MetierRvMedical.Utilisateur user = utilisateur;
                    //    MetierRvMedical.Role role = await client.GetRoleUserAsync(user);
                        //    var role = db.Role.Where(r => r.IdRole.Equals(utilisateur.IdRole)).FirstOrDefault();


                        if (utilisateur.PremiereConnexion == 0)
                        {
                            MessageBox.Show("Bienvenue, veuillez changer vos informations de connexion.");
                            this.Hide();
                            frmChangerIdentifiants frmChanger = new frmChangerIdentifiants();
                            frmChanger.ShowDialog();
                            string nouvelIdentifiant = frmChanger.NouvelIdentifiant;
                            string nouveauMotDePasse = frmChanger.NouveauMotDePasse;
                            if (!string.IsNullOrEmpty(nouvelIdentifiant) && !string.IsNullOrEmpty(nouveauMotDePasse))
                            {
                                utilisateur.Identifiant = nouvelIdentifiant;
                                utilisateur.MotDePasse = SaltHash.HashPassword(nouveauMotDePasse);
                                utilisateur.PremiereConnexion = 1;
                                //db.Utilisateurs.AddOrUpdate(utilisateur);
                                // db.SaveChanges();
                            //    await client.UpdateUserAsync(utilisateur);
                            }
                        }
                        resetText();

                        /*
                            if (role.LibelleRole.Equals("ADMIN"))
                           {
                               this.Hide();
                               frmDashAdmin frm = new frmDashAdmin();
                               frm.Show();
                               return;
                           }
                           if (role.LibelleRole.Equals("SECRETAIRE"))
                           {
                               this.Hide();
                               frmDashSecretaire frm = new frmDashSecretaire(this);
                               frm.Show();
                               return;
                           }
                           if (role.LibelleRole.Equals("MEDECIN"))
                           {
                               this.Hide();
                               frmDashMed frm = new frmDashMed(this);
                               frm.Show();
                               return;
                           }

                         */
                    }


                    else
                    {
                        new frmEchecExecution("Utilisateur ou mot de passe incorrect").ShowDialog();
                    }
                }
                else
                {
                    new frmEchecExecution("Cet identifiant n'existe pas").ShowDialog();
                }


            }
            catch(Exception ex) {
                Log.Error($"Une erreur est survenue lors de la connexion de l'utilisateur avec l'identifiant '{txtIdentifiant.Text}'.\n Erreur : {ex.Message} .\n type : ${ex.GetType().FullName} .\n Source : ${ex.Source}`\n methode : ${ex.TargetSite} ");

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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
