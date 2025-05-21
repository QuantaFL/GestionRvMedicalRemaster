using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace MetierRvMedical.Models
{
    [DataContract]
    [KnownType(typeof(Admin))]
    [KnownType(typeof(Utilisateur))]
    [KnownType(typeof(Medecin))]
    public class Personne
    {
        [Key]
        [DataMember]
        public int IdP { get; set; }
        [Required, MaxLength(100)]
        [DataMember]
        public string NomPrenom { get; set; }
        [Required, MaxLength(100)]
        [DataMember]
        public string Addresse { get; set; }
        [Required, MaxLength(100), DataType(DataType.EmailAddress)]
        [DataMember]
        public string Email { get; set; }
        [Required, MaxLength(100)]
        [DataMember]
        public string Tel { get; set; }
        [Required]
        [DataMember]
        public DateTime DateNaissance { get; set; }
    }
}