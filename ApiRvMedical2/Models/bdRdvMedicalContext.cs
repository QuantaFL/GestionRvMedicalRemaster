using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

using MySql.Data.EntityFramework;
using System.Reflection.Emit;
using System.Data.Entity.Migrations;

namespace ApiRvMedical2.Models
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public  class bdRdvMedicalContext : DbContext
    {
        public bdRdvMedicalContext():base("bdRdvMedicalContext")
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {   
        }


        public virtual DbSet<Personne> Personnes { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<Utilisateur> Utilisateurs { get; set; }
        public virtual DbSet<Secretaire> Secretaires { get; set; }
        public virtual DbSet<Medecin> Medecins { get; set; }
        public virtual DbSet<Agenda> Agenda { get; set; }
        public virtual DbSet<Soin> Soins { get; set; }
        public virtual DbSet<RendezVous> RendezVous { get; set; }
        public virtual DbSet<Specialite> Specialite { get; set; }
        public virtual DbSet<GroupeSanguin> GroupeSanguins { get; set; }
        public virtual DbSet<MoyenDePaiement> MoyenDePaiements { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Admin> Admin { get; set; }
    }
}
