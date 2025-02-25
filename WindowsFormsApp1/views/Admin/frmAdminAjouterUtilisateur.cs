using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.Logging;
using Serilog;
using WindowsFormsApp1.Models;
using Log = Serilog.Log;
using Elasticsearch.Net;
using WindowsFormsApp1.config;
using System.Web.Services.Description;
using WindowsFormsApp1.CustomControls;

namespace WindowsFormsApp1.views.Admin
{
    public partial class frmAdminAjouterUtilisateur : Form
    {
        //TODO : Creer un formulaire avec nos propres controles qui afficheront des messages aux utilisateurs
        //TODO : faire un loader pour le formulaire au moment du click
        // TODO : Verifier si le mail se termine par @gmail.com
        // TODO : dans le resetForm ajouter la fonction pour vider des champs


        bdRdvMedicalContext db = new bdRdvMedicalContext();
        // Log.Information("Lancement de lapplication...");
       
      



        public frmAdminAjouterUtilisateur()
        {
            InitializeComponent();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        string message;

      
        /// <summary>
        /// cette fonction verifie la saisie des entrées utilisateurs.
        /// Retourne true si un seul champ est vide , null ou 
        /// contient des espaces blanc false sinon
        /// </summary>
        /// <returns></returns>
        public bool chechkInput()
        {
         return   string.IsNullOrWhiteSpace(txtNomPrenom.Text)||
                  string.IsNullOrWhiteSpace(txtEmail.Text) ||
                  string.IsNullOrWhiteSpace(txtNumeroOrdre.Text)||
                  string.IsNullOrWhiteSpace(txtNumeroTelephone.Text);

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
        public void  ResetForm()
        {
           
            cbbSpecialite.ValueMember = "Value";
            cbbSpecialite.DisplayMember = "Text";
            cbbSpecialite.DataSource = loadSpecialiteccb();
            txtAdresse.Focus();
            txtAdresse.Text = string.Empty;
            txtDateNaissance.Value = DateTime.Now;
            txtEmail.Text = string.Empty;
            txtNumeroOrdre.Text  = string.Empty ;
            txtNumeroTelephone.Text = string.Empty ;
            txtNomPrenom.Text = string.Empty ;
            SetDatePickerLimits();
            
        }
        public List<SelectListViewModel> loadSpecialiteccb()
        {
            var s = db.Specialite.ToList();
            List<SelectListViewModel> liste = new List<SelectListViewModel>();
            SelectListViewModel b = new SelectListViewModel();
            b.Text = "Selectionner une valeur";
            b.Value = "";
            liste.Add(b);
            foreach (var item in s)
            {
                SelectListViewModel a = new SelectListViewModel();
                a.Text = item.NomSpecialte;
                a.Value = item.Id.ToString();
                liste.Add(a);

            }
            return liste;
        }




        private void frmAdminAjouterUtilisateur_Load_1(object sender, EventArgs e)
        {
            ResetForm();
        }
        public void AjouterUtilisateur()
        {
            // essayer de pousser un max l'automatisation de l'ajout
            //  var role = db.Role.Find(IdRole);
            


    
        }
        /// <summary>
        /// cette fonction envoie un mail a l'addresse donner en paramètre avec le mot de passe et l'identifiant
        /// </summary>
        /// <param name="To">le mail qui recevra le message</param>
        /// <param name="mdp">le mot de passe par defaut</param>
        /// <param name="identifiant">l'identifiant par defaut</param>
        public void sendMail(string To,string mdp,string identifiant)
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
                frmEchecExecution frmEchecExecution = new frmEchecExecution("une erreur pendant l'envoie du mail");
                frmEchecExecution.ShowDialog();
            }
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
                Log.Fatal(pe.ToString());
            }
            return is_pinged;
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
        private void btnValiderAjoutUtilisateur_Click_1(object sender, EventArgs e)
        {
            if (chechkInput())
            {
                Log.Information("veuillez remplir tous les champs");
                message = "veuillez remplir tous les champs";
                frmInformation frmInformationMessage = new frmInformation(message);
                frmInformationMessage.ShowDialog();
                return;
            }
            if (AgeUtilisateur() ==0)
            {
                Log.Information("un medecin ne peut avoir moins de 20 ans");
                message = "une medecin ne peut avoir moins de 20 ans";
                frmInformation frmInformationMessage = new frmInformation(message);
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
                var role  = db.Role.Where(r=> r.CodeRole=="MED").FirstOrDefault();
                int IdRole = role.IdRole;
                int IdSpecialite = int.Parse(cbbSpecialite.SelectedValue.ToString());
                Guid myuuid = Guid.NewGuid();
                Guid myuuid2 = Guid.NewGuid();
                string mdpTmp = myuuid.ToString().Substring(0,8);
                string identfiantTmp = myuuid.ToString().Substring(0, 5);
                // Models.Admin admin = new Models.Admin();
                Medecin medecin = new Medecin();
                medecin.NomPrenom = txtNomPrenom.Text;
                medecin.Addresse = txtAdresse.Text;
                medecin.Email = txtEmail.Text;
                medecin.Tel = txtNumeroTelephone.Text;
                medecin.DateNaissance = txtDateNaissance.Value;
                medecin.Identifiant = identfiantTmp;
                var hashedPassword = SaltHash.HashPassword(mdpTmp);
                medecin.MotDePasse = hashedPassword;
                medecin.Status = true;
                medecin.IdRole = IdRole;
                medecin.PremiereConnexion = 0;
                medecin.IdSpecialite = IdSpecialite;
                medecin.NumeroOrdre = txtNumeroOrdre.Text;
                db.Medecins.Add(medecin);
                try {
                    db.SaveChanges();
                    Log.Information("medecin ajouter");
                    sendMail(txtEmail.Text, mdpTmp, identfiantTmp);
                    Log.Information($" mail envoyer à {txtEmail.Text}");
                    ResetForm();

                }
                catch (Exception ex) { 
                Log.Error(ex.Message);
                }
              

            
        }

        private void btnFermer_Click_1(object sender, EventArgs e)
        {
            this.Close();
            frmAccueilAdmin frmAccueilAdmin = Application.OpenForms["frmAccueilAdmin"] as frmAccueilAdmin;
            frmAccueilAdmin.loadData();
        }

        private void cbbRoleUtilisateur_Leave(object sender, EventArgs e)
        {
            /*

              if (cbbRoleUtilisateur.Text!="" && (cbbRoleUtilisateur.Text=="MEDECIN"|| cbbRoleUtilisateur.Text == "SECRETAIRE")) {
                 try {
                     int IdRole = int.Parse(cbbRoleUtilisateur.SelectedValue.ToString());
                     var role = db.Role.Find(IdRole);
                     string codeRole = role.CodeRole;
                     if (IdRole == 3)
                     {
                         //  Log.Information(codeRole);
                         txtNumeroOrdre.Visible=true;
                         txtNumeroOrdre.Enabled = true;
                         cbbSpecialite.Enabled = true;
                         cbbSpecialite.Visible = true;
                         lblNumeroOrdre.Visible = true;
                         lblSpecialite.Visible = true;
                     }
                     else
                     {

                     }
                 }
                 catch {
                     Log.Warning("Heure de saisie");

                 }
             }
             else
             {
                 txtNumeroOrdre.Enabled = false;
                 txtNumeroOrdre.Visible = false;
                 cbbSpecialite.Enabled = false;
                 lblNumeroOrdre.Visible = false;
                 cbbSpecialite.Visible = false;
                 lblSpecialite.Visible = false;
                 cbbRoleUtilisateur.ValueMember = "Value";
                 cbbRoleUtilisateur.DisplayMember = "Text";
             }

             */

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
