using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ApiRvMedical.Models
{
    public class Role
    {
        [Key]
        public int IdRole { get; set; }
        [Required, MaxLength(30)]
        public string CodeRole { get; set; }
        [Required, MaxLength(30)]
        public string LibelleRole { get; set; }
    }
}