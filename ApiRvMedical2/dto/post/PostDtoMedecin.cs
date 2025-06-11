using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiRvMedical2.dto.post
{
    public class PostDtoMedecin
    {
        public string NumeroOrdre { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public string Addresse { get; set; }
     //   public  int  IdRole {  get; set; }
        public string NomPrenom { get; set; }
        public string DateNaissance { get; set; }
        public int IdSpecialite { get; set; }
    }
}