using MetierRvMedical2.Models;
using MetierRvMedical2.Services;
using Serilog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.ApiConsumer.Requests;
using WindowsFormsApp1.config;
using WindowsFormsApp1.CustomControls;
using WindowsFormsApp1.views.Secret;

namespace WindowsFormsApp1.views.Admin
{
    public partial class frmAdminAjouterSecretaire : Form
    {

        public frmAdminAjouterSecretaire()
        {
            InitializeComponent();
        }
        string message;
        private void frmAdminAjouterSecretaire_Load(object sender, EventArgs e)
        {
            ResetForm();

        }


        /// <summary>
        /// cette fonction verifie la saisie des entrées utilisateurs.
        /// Retourne true si un seul champ est vide , null ou 
        /// contient des espaces blanc false sinon
        /// </summary>
        /// <returns></returns>
        public bool chechkInput()
        {
            return string.IsNullOrWhiteSpace(txtNomPrenom.Text) ||
                     string.IsNullOrWhiteSpace(txtEmail.Text) ||
                     string.IsNullOrWhiteSpace(txtNumeroTelephone.Text) ||
                     string.IsNullOrEmpty(txtTelephoneFixe.Text)
                     ;

        }
        /// <summary>
        /// cette fonction permet de faire un ping vers google pour verfier si l'appareil est connecté a internet.
        /// Elle retourne true si oui false si non
        /// </summary>
        /// <returns></returns>
        public Boolean ping_google()
        {
            string host = "google.com";
            Boolean is_pinged = false;
            Ping ping = new Ping();
            try
            {
                PingReply reply = ping.Send(host);
                if (reply.Status == IPStatus.Success)
                {
                    is_pinged = true;
                }
            }
            catch (PingException pe)
            {
                Log.Fatal(pe.Message);
            }
            return is_pinged;
        }
        /// <summary>
        /// cette fonction verifie si l'utilisateur saisie a au moins 20 ans.
        /// Elle renvoie 1 si oui sinon 0
        /// </summary>
        /// <returns></returns>
        public int AgeUtilisateur()
        {
            DateTime dateDonne = txtDateNaissance.Value;
            DateTime now = DateTime.Now;
            int age = now.Year - dateDonne.Year;
            return age >= 20 ? 1 : 0;
        }
        /// <summary>
        /// cette fonction envoie un mail a l'addresse donner en paramètre avec le mot de passe et l'identifiant
        /// </summary>
        /// <param name="To">le mail qui recevra le message</param>
        /// <param name="mdp">le mot de passe par defaut</param>
        /// <param name="identifiant">l'identifiant par defaut</param>
        public void sendMail(string To, string mdp, string identifiant)
        {
            // string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); //obtenir le chemin vers le dossier documents 
            //  string fileName = "ticket1.pdf"; // le nom du fichier a envoyer 
            //  string filePath = Path.Combine(documentsPath, fileName); //le chemin complet

            MailMessage mailMessage = new MailMessage();
            // Attachment fichier = new Attachment(filePath);
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
            mailMessage.From = new MailAddress("benirosinard19@gmail.com");
            mailMessage.To.Add(To);
            mailMessage.Subject = "Bienvenue !";
            mailMessage.Body = $"Pour votre primière connexion veuillez saisir comme   mot de passe par defaut {mdp} et  votre identifiant  {identifiant}  vous serez inviter a changer ses informations";
            // mailMessage.Attachments.Add(fichier);

            smtpClient.Port = 587;
            smtpClient.Credentials = new NetworkCredential("benirosinard19@gmail.com", "vust rvfc dbuf vtuq");
            smtpClient.EnableSsl = true;

            try
            {
                smtpClient.Send(mailMessage);
                Log.Information("Mail envoyer");

            }
            catch (WebException ex)
            {
                Log.Error(ex.ToString());
                frmEchecExecution frmEchecExecution = new frmEchecExecution("erreur lors de l'envoie du mail");
                frmEchecExecution.ShowDialog();

            }
        }
        /// <summary>
        /// cette fonction reinitiaalise les champs
        /// </summary>
        public void ResetForm()
        {
            txtNomPrenom.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtNumeroTelephone.Text = string.Empty;
            txtTelephoneFixe.Text = string.Empty;
            textMatricule.Text = generateMatricule();
            txtDateNaissance.Value = DateTime.Now;
            txtAdresse.Text = string.Empty;
            SetDatePickerLimits();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        /// <summary>
        /// cette fonction genere un matricule de manière automatique en le codifiant 
        /// </summary>
        /// <returns></returns>
        private string generateMatricule()
        {
            string matricule;
            var nbrSecretaire = 12457;
            if (nbrSecretaire == 0)
            {
                nbrSecretaire = 1;
            }
            else
            {
                nbrSecretaire++;
            }
            return matricule = "HL-DKR-" + DateTime.Now.Year + "-" + nbrSecretaire;

        }
        private void SetDatePickerLimits()
        {
            try
            {
                var minDate = DateTime.Now.AddYears(-100);
                var maxDate = DateTime.Now;

                txtDateNaissance.MinDate = minDate;
                txtDateNaissance.MaxDate = maxDate;

                Log.Information("Limites de date définies: MinDate={MinDate}, MaxDate={MaxDate}", minDate, maxDate);
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Erreur lors de la configuration des limites de date.");
            }
        }

        private async void btnValiderAjoutUtilisateur_Click(object sender, EventArgs e)
        {
            if (chechkInput())
            {
                Log.Information("veuillez remplir tous les champs");
                message = "veuillez remplir tous les champs";
                frmInformation frmInformationMessage = new frmInformation(message);
                frmInformationMessage.ShowDialog();
                return;
            }
            var listeSecretaires = await ApiConsumer.ApiClientContainer.SecretaireService.ListSecretairesAsync();

            var sec = listeSecretaires.FirstOrDefault(s =>
                s.User.Telephone == txtTelephoneFixe.Text ||
                s.User.Email == txtEmail.Text ||
                s.User.Telephone == txtNumeroTelephone.Text
            );

            if (sec != null)
            {
                frmEchecExecution frmEchecExecution = new frmEchecExecution("le telephone fixe\n le numero \n ou l'email sont déjà utiliser");
                frmEchecExecution.ShowDialog();
                return;
            }
            if (AgeUtilisateur() == 0)
            {
                Log.Information("une secretaire  ne peut avoir moins de 20 ans");
                message = "une secretaire ne peut avoir moins de 20 ans";
                frmInformation frmInformationMessage = new frmInformation(message);
                frmInformationMessage.ShowDialog();
                return;
            }
            if (!ping_google())
            {
                Log.Fatal("pas de connexion ");
                message = "Votre appareil doit etre connecté a internet";
                frmEchecExecution frmEchecExecution = new frmEchecExecution(message);
                frmEchecExecution.ShowDialog();
                return;
            }
            var role = await ApiConsumer.ApiClientContainer.RoleService.GetRoleAsync(3);
           
            MessageBox.Show(role.CodeRole);

            int IdRole = role.Id;
            Guid myuuid = Guid.NewGuid();
            Guid myuuid2 = Guid.NewGuid();
            string mdpTmp = myuuid.ToString().Substring(0, 8);
            string identfiantTmp = myuuid.ToString().Substring(0, 6);
            Secretaire secretaire = new Secretaire();

            try
            {
                secretaire.Addresse = txtAdresse.Text;
                secretaire.NomPrenom = txtNomPrenom.Text;
                secretaire.Email = txtEmail.Text;
                secretaire.Tel = txtNumeroTelephone.Text;
                secretaire.DateNaissance = txtDateNaissance.Value;

                secretaire.Status = true;
                secretaire.IdRole = IdRole;
                secretaire.Identifiant = identfiantTmp;
                var HashedPassword = SaltHash.HashPassword(mdpTmp);
                secretaire.MotDePasse = HashedPassword;
                secretaire.PremiereConnexion = 0;

                secretaire.Matricule = generateMatricule();
                secretaire.TelephoneFixe = txtTelephoneFixe.Text;
                CreateUserRequest userRequest = new CreateUserRequest
                {
                    Email = secretaire.Email,

                    NomPrenom = secretaire.NomPrenom,

                    MedecinDetails = null,
                    Password = secretaire.MotDePasse,
                    RoleId = secretaire.IdRole,
                    SecretaireDetails = new SecretaireDetailsRequest
                    {
                        Matricule = secretaire.Matricule,
                        TelephoneFixe = secretaire.TelephoneFixe,

                    },
                    PremiereConnexion = 0,
                    Identifiant = secretaire.Identifiant,
                    DateNaissance = secretaire.DateNaissance.ToString("yyyy-mm-dd"),
                    Addresse = secretaire.Addresse,
                    Status = secretaire.Status,
                    Tel = secretaire.Tel,
                    PasswordConfirmation = secretaire.MotDePasse
                    
                };

                   var result = await ApiConsumer.ApiClientContainer.UserService.CreateUserAsync(userRequest);
                if (result==null)
                {
                    frmEchecExecution frmee = new frmEchecExecution("echeccccccccc");
                    frmee.ShowDialog();
                }
                


              


                Log.Information("ajout de la secretaire");

                sendMail(txtEmail.Text, mdpTmp, identfiantTmp);
                Log.Information("envoie du mail à la secretaire");
                frmExecutionReussie frmExecutionReussie = new frmExecutionReussie("Secretaire Ajoutée");
                frmExecutionReussie.ShowDialog();
                ResetForm();
            }
            catch (Exception ex)
            {
                Log.Error($" l' erreur {ex} lors de l'ajout de secretaire ");
            }




        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAccueilAdmin frmAccueilAdmin = Application.OpenForms["frmAccueilAdmin"] as frmAccueilAdmin;
            frmAccueilAdmin.loadData();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
