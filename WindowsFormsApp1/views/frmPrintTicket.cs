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
using WindowsFormsApp1.report;

namespace WindowsFormsApp1.views
{
    public partial class frmPrintTicket : Form
    {
        public frmPrintTicket()
        {
            InitializeComponent();
        }
        bdRdvMedicalContext db = new bdRdvMedicalContext();

        private void frmPrintTicket_Load(object sender, EventArgs e)
        {
            rptTicketRv  rptTicketRv = new rptTicketRv();
            rptTicketRv.SetDataSource(GetTableTcket(0));
            crystalReportViewer1.ReportSource = rptTicketRv;
            crystalReportViewer1.Refresh();
        }
        public DataTable GetTableTcket(int? IdRv = 0) {
            DataTable dt = new DataTable();
            dt.Columns.Add("NomPrenom", typeof(string));
            dt.Columns.Add("Medecin", typeof(string));
            dt.Columns.Add("DateRv", typeof(DateTime));
            dt.Columns.Add("heureRv", typeof(string));
            dt.Columns.Add("DataQr", typeof(byte[]));
            var rdv = db.RendezVous.Where(a => a.IdRendezVous == IdRv).FirstOrDefault();
            if (rdv != null) {
                dt.Rows.Add(rdv.Patient.NomPrenom, rdv.Medecin.NomPrenom, rdv.DateRv, new byte[0]);

            }
            else
            {
                dt.Rows.Add("NOMPRENOM", "MED", DateTime.Now, DateTime.Now, new byte[0]);
            }

            return dt;

        }
    }
}
