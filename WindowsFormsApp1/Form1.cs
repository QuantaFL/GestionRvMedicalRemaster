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
using WindowsFormsApp1.ApiConsumer.Models;
using WindowsFormsApp1.ApiConsumer.Requests;
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
        public static LoginResponseData user;
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
               //Utilisateur utilisateur = new Utilisateur();

                MessageBox.Show($"{identifiant}{motdepasse}");
                LoginRequest loginRequest = new LoginRequest
                {
                    Email = identifiant,
                    Password = motdepasse
                };
                Log.Information($"Attempting to log in user: {identifiant}");
                Log.Information($"Attempting to log in user: {identifiant}");
                MessageBox.Show($"Tentative de connexion pour l'utilisateur : {loginRequest.Email}");
                LoginResponseData data = await ApiConsumer.ApiClientContainer.AuthService.LoginAsync(loginRequest);
                
                if (data != null) { 
                    Log.Information($"Login successful for user: {data.User.Email}");
                    MessageBox.Show($"Bienvenue {data.User.Role.CodeRole}");
                    MessageBox.Show($"Bienvenue {data.User.Role.LibelleRole}");
                    user = data;
                    
                    if (user.User.Role.CodeRole.Equals("ADMIN"))
                    {
                        frmDashAdmin frmDashAdmin = new frmDashAdmin();

                        frmDashAdmin.Show();
                    } else if (user.User.Role.CodeRole.Equals("MEDECIN")) {
                        frmDashMed frmDashMed = new frmDashMed(this);
                        frmDashMed.Show();
                    }
                    else
                    {
                        frmDashSecretaire frmDashSecretaire = new frmDashSecretaire(this);
                        frmDashSecretaire.Show();
                    }
                        this.Hide();

                }
                else
                {
                    Log.Warning($"Login failed for user: {identifiant}. Data returned was null.");
                    new frmEchecExecution("Identifiant ou mot de passe incorrect").ShowDialog();
                    return;
                }


            }
            catch(Exception ex) {
                MessageBox.Show("Une erreur est survenue lors de la connexion. "+ex);
                Console.WriteLine("Une erreur est survenue lors de la connexion. "+ex);
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
