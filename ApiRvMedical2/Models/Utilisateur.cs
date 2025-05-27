using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiRvMedical2.Models
{
    public class Utilisateur : Personne
    {
        [MaxLength(100)]
        public string Identifiant {  get; set; }

        [MaxLength(250)]
        public string MotDePasse { get; set; }
        public bool Status {  get; set; }
        public int IdRole { get; set; }
        [ForeignKey("IdRole")]
        public virtual Role Role { get; set; }
        public int PremiereConnexion { get; set; }
    }
}
