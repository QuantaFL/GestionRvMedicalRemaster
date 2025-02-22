using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WindowsFormsApp1.Models
{
    public class Patient:Personne
    {
        [MaxLength(3)]
        public string GroupeSanguin {  get; set; }

        [Required]
        public float? Taille { get; set; }
        [Required]
        public float? Poids { get; set; }
    }
}
