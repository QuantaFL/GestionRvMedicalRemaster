using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ApiRvMedical.Models
{
    public class Patient : Personne
    {
        [MaxLength(3)]
        public string GroupeSanguin { get; set; }

        [Required]
        public float? Taille { get; set; }
        [Required]
        public float? Poids { get; set; }
    }
}