using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace ApiRvMedical.Models
{

    public class Utilisateur : Personne
    {

        [MaxLength(100)]
        public string Identifiant { get; set; }

     
        [MaxLength(250)]
        public string MotDePasse { get; set; }

   
        public bool Status { get; set; }

  
        public int IdRole { get; set; }

    
        public virtual Role Role { get; set; }

        public int PremiereConnexion { get; set; }
    }
}