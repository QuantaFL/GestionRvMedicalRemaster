using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MetierRvMedical.Models
{
    public class Specialite
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(10)]
        public string CodeSpecialte { get; set; }
        [Required, MaxLength(100)]
        public string NomSpecialte { get; set; }
    }
}