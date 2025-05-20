using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MetierRvMedical.Models
{
    public class Personne
    {
        [Key]
        public int IdP { get; set; }
        [Required, MaxLength(100)]
        public string NomPrenom { get; set; }
        [Required, MaxLength(100)]
        public string Addresse { get; set; }
        [Required, MaxLength(100), DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required, MaxLength(100)]
        public string Tel { get; set; }
        [Required]
        public DateTime DateNaissance { get; set; }

    }
}