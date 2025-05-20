using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MetierRvMedical.Models
{
    public class Secretaire : Utilisateur
    {
        [MaxLength(15)]
        public string TelephoneFixe { get; set; }
        [MaxLength(30)]
        public string Matricule { get; set; }
    }
}