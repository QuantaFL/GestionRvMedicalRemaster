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
    [KnownType(typeof(Admin))]
    [KnownType(typeof(Medecin))]
    public class Utilisateur : Personne
    {

        [DataMember]
        [MaxLength(100)]
        public string Identifiant { get; set; }

        [DataMember]
        [MaxLength(250)]
        public string MotDePasse { get; set; }

        [DataMember]
        public bool Status { get; set; }

        [DataMember]
        public int IdRole { get; set; }

        [DataMember]
        public virtual Role Role { get; set; }

        [DataMember]
        public int PremiereConnexion { get; set; }
    }
}