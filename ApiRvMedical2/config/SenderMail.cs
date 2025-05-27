using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Serilog;
using System.IO;
using WindowsFormsApp1.CustomControls;

namespace WindowsFormsApp1.config
{
    public static class SenderMail
    {
        public static Boolean ping_google()
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
        public  static void sendMail(string fileName,string MailPatient)
        {
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); //obtenir le chemin vers le dossier documents 
            //string fileName = "ticket1.pdf"; // le nom du fichier a envoyer 
            string filePath = Path.Combine(documentsPath, fileName); //le chemin complet

            MailMessage mailMessage = new MailMessage();
            Attachment fichier = new Attachment(filePath);
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
            mailMessage.From = new MailAddress("benirosinard19@gmail.com");
            mailMessage.To.Add($"{MailPatient}");
            mailMessage.Subject = "Confirmation de rendez vous, vous trouvez ci joint votre recu de confirmation de rendez-vous ";
            mailMessage.Body = "HEALTH CARE DAKAR";
            mailMessage.Attachments.Add(fichier);

            smtpClient.Port = 587;
            smtpClient.Credentials = new NetworkCredential("benirosinard19@gmail.com", "vust rvfc dbuf vtuq");
            smtpClient.EnableSsl = true;

            try
            {
                smtpClient.Send(mailMessage);

            }
            catch (WebException ex)
            {
                frmEchecExecution frmEchecExecution = new frmEchecExecution("envoie impossible");
                frmEchecExecution.ShowDialog();
                Log.Fatal(ex.ToString());
               // MessageBox.Show(ex.Message);
            }
        }
    }
}
