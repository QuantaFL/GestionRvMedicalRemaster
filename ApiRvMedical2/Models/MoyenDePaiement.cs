using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiRvMedical2.Models
{
    public class MoyenDePaiement
    {
        [Key]
        public int IdMoy { get; set; }
        [Required,MaxLength(20)]
        public string CodeMoyenPaiement { get; set; }
        [Required, MaxLength(20)]
        public string LibelleMoyenPaiement { get; set; }
    }
}
