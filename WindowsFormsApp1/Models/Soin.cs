using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class Soin
    {
        [Key]
        public int IdSoin {  get; set; }
        [Required, MaxLength(10)]
        public string CodeSoin { get; set; }
        [Required, MaxLength(100)]
        public string NomSoin { get; set; }
        [Required]
        public int CoutSoin { get; set; }
    }
}
