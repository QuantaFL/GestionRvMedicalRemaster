using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ApiRvMedical2.dto.get
{
    public class GetSecretaireDto
    {
        public string NomPrenom { get; set; }
        public DateTime DateNaissance { get; set; }
        public string Addresse { get; set; }
        public string Email { get; set; }
        public string Tel { get; set; }
        public bool Status { get; set; }
        public string TelephoneFixe { get; set; }
        public string Matricule { get; set; }
        public int? Id { get; set; }
    }
}