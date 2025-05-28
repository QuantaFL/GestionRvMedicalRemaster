using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiRvMedical2.dto
{
    public class UserDto
    {
        public string NomPrenom { get; set; }
        public DateTime DateNaissance { get; set; }
        public string Addresse { get; set; }
        public string Email { get; set; }
        public string LibelleRole { get; set; }
        public bool Status { get; set; }
        public string Tel { get; set; }
    }
}