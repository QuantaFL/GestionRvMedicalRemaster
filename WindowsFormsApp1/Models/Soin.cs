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
        [Required]
        public string CodeSoin { get; set; }
        public string LibelleSoin { get; set; }
        public bool StatusSoin { get; set; }
        public float CoutSoin { get; set; }
    }
}
