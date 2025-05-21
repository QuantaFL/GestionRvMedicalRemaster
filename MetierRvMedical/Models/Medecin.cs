using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace MetierRvMedical.Models
{
    [DataContract]
    public class Medecin : Utilisateur
    {
        [DataMember]
        public int? IdSpecialite { get; set; }
        [ForeignKey("IdSpecialite")]
        [DataMember]
        public virtual Specialite Specialite { get; set; }

        [MaxLength(10)]
        [DataMember]
        public string NumeroOrdre { get; set; }
        [DataMember]
        public virtual ICollection<Agenda> agenda { get; set; }
    }
}