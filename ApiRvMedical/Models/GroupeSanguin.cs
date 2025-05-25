using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ApiRvMedical.Models
{
    public class GroupeSanguin
    {
        [Key]
        public int IdGroupeSanguin { get; set; }
        [Required, MaxLength(3)]
        public string CodeGroupeSanguin { get; set; }
    }
}