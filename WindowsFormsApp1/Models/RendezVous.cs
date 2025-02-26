using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class RendezVous
    {
        [Key]
        public int IdRendezVous { get; set; }
        [Required]
        public String DateRv { get; set; }
        [Required, Column]
        public String HeureRv { get; set; }
        public int? IdSoin { get; set; }
        [ForeignKey("IdSoin")]
        public virtual Soin Soin { get; set; }

        public int? IdPatient { get; set; }
        [ForeignKey("IdPatient")]
        public virtual Patient Patient { get; set; }

        public int? IdMedecin { get; set; }
        [ForeignKey("IdMedecin")]
        public virtual Medecin Medecin { get; set; }
        public int? IdAgenda { get; set; }
        [ForeignKey("IdAgenda")]
        public virtual Agenda Agenda { get; set; }
        public string CodeRdv { get; set; }
    }
}
