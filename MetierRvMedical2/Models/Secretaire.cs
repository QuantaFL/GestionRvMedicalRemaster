using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MetierRvMedical2.Models
{
    [DataContract]
    public class Secretaire : Utilisateur
    {
        [MaxLength(15)]
        [DataMember]
        public string TelephoneFixe { get; set; }
        [MaxLength(30)]
        [DataMember]
        public string Matricule { get; set; }
    }
}
