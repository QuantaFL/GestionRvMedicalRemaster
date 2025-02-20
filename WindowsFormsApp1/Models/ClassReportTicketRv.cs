using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class ClassReportTicketRv
    {
        public string NomPrenom {  get; set; }
        public string heureRv { get; set; }
        public string Medecin {  get; set; }
        public DateTime DateRv { get; set; }
        public byte[] DataQr { get; set; }

    }
}
