using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using Serilog;
using WindowsFormsApp1.config;
using WindowsFormsApp1.CustomControls;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.report;

namespace WindowsFormsApp1.utils
{
    public partial class frmRptPrintRecuRdv : Form
    {
        public frmRptPrintRecuRdv()
        {
            InitializeComponent();
        }
        private int idRv;
        rptTicketRv rptTicketRv = new rptTicketRv();
        public frmRptPrintRecuRdv(int idRdv)
        {
            InitializeComponent();
            bdRdvMedicalContext db = new bdRdvMedicalContext();
            idRv = idRdv;
            this.idRv = idRdv;
            
            rptTicketRv.SetDataSource(GetTableTcket(idRv));
            crystalReportViewer1.ReportSource = rptTicketRv;
            

            
            crystalReportViewer1.Refresh();

        }
        bdRdvMedicalContext db = new bdRdvMedicalContext();


        public DataTable GetTableTcket(int? IdRv)
        {
            DataTable dt = new DataTable();

            try {
                dt.Columns.Add("NomPrenom", typeof(string));
                dt.Columns.Add("Medecin", typeof(string));
                dt.Columns.Add("DateRv", typeof(DateTime));
                dt.Columns.Add("heureRv", typeof(string));
                dt.Columns.Add("DataQr", typeof(byte[]));
            }
            catch(Exception ex) { 
                Log.Error($" cette ereur est survenue {ex.Message} lors de creation dataTable sur FrmRptPrintRecuRdv");
            }

            var rdv = db.RendezVous.Where(a => a.IdRendezVous == IdRv).FirstOrDefault();
            var CodeQr = GenerateQR.GenerateQRCode(rdv.CodeRdv);
            /*
                if (ping_google())
            {
               //MessageBox.Show("helloGG");
                //sendMail();

            }
             
             */
            if (rdv != null)
            {
                dt.Rows.Add(rdv.Patient.NomPrenom, rdv.Medecin.NomPrenom, rdv.DateRv, rdv.HeureRv, CodeQr);

                try
                {
                    string documentsFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    string outputPath = Path.Combine(documentsFolder, "Recu_" + rdv.CodeRdv + ".pdf");
                    rptTicketRv.ExportToDisk(ExportFormatType.PortableDocFormat, outputPath);
                    // MessageBox.Show($"Le rapport a été exporté avec succès à l'emplacement : {outputPath}");
                  //  frmInformation frmInformation = new frmInformation("fichier enregisté");
                  //  frmInformation.ShowDialog();

                }
                catch (Exception ex)
                {
                    Log.Error($"{ex.Message} report export erreur");

                }


            }
            else
            {
                dt.Rows.Add("NOMPRENOM", "MED", DateTime.Now, DateTime.Now, new byte[0]);

                frmEchecExecution frmEchecExecution = new frmEchecExecution("rendez-vous invalide");
                frmEchecExecution.ShowDialog();
            }

            return dt;

        }
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

        private void frmRptPrintRecuRdv_Load(object sender, EventArgs e)
        {

        }
    }
}
