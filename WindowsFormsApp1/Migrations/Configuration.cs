namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WindowsFormsApp1.config;
    using WindowsFormsApp1.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WindowsFormsApp1.Models.bdRdvMedicalContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }
        protected override void Seed(WindowsFormsApp1.Models.bdRdvMedicalContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            
            context.Role.AddOrUpdate(
                r => r.CodeRole,
                new Role { CodeRole = "ADM", LibelleRole = "ADMIN" },
                new Role { CodeRole = "SEC", LibelleRole = "SECRETAIRE" },
                new Role { CodeRole = "MED", LibelleRole = "MEDECIN" }
            );
            context.SaveChanges();
            context.Admin.AddOrUpdate(
                a => a.IdP,
                new Admin{
                    DateNaissance = DateTime.Now,
                    Identifiant = "admin",
                    Email = "admin@gmail.com",
                    NomPrenom = "Rama Fall",
                    IdRole = 1,
                    MotDePasse = SaltHash.HashPassword("passer"),
                    PremiereConnexion = 1,
                    Addresse = "medina",
                    Status = true,
                    Tel = "7898797"
                }
                );
            context.GroupeSanguins.AddOrUpdate(
                g => g.CodeGroupeSanguin,
                new GroupeSanguin { CodeGroupeSanguin = "A+" },
                new GroupeSanguin { CodeGroupeSanguin = "A-" },
                new GroupeSanguin { CodeGroupeSanguin = "B+" },
                new GroupeSanguin { CodeGroupeSanguin = "B-" },
                new GroupeSanguin { CodeGroupeSanguin = "AB+" },
                new GroupeSanguin { CodeGroupeSanguin = "AB-" },
                new GroupeSanguin { CodeGroupeSanguin = "O+" },
                new GroupeSanguin { CodeGroupeSanguin = "O-" }
                );
            context.SaveChanges();
            context.Secretaires.AddOrUpdate(
                s => s.IdP,
                new Secretaire
                {
                    DateNaissance = DateTime.Now,
                    Identifiant = "secret",
                    Email = "secretaire@gmail.com",
                    NomPrenom = "Rama Fall",
                    IdRole = 2,
                    MotDePasse = SaltHash.HashPassword("passer"),
                    TelephoneFixe = "7777777",
                    PremiereConnexion = 1,
                    Addresse = "medina",
                    Status = true,
                    Matricule = "rtyrtty",
                    Tel = "7898797"
                }
                );
            context.SaveChanges();

            context.Specialite.AddOrUpdate(
              sp => sp.Id,
              new Specialite
              {
                  CodeSpecialte="CAR",
                  NomSpecialte="CARDIOLOGIE"
              },
               new Specialite
               {
                   CodeSpecialte = "CHIR",
                   NomSpecialte = "CHIRURGIE"
               }
            );
            context.MoyenDePaiements.AddOrUpdate(
                mp => mp.IdMoy,
                new MoyenDePaiement { CodeMoyenPaiement = "WAV", LibelleMoyenPaiement = "WAVE" },
                new MoyenDePaiement { CodeMoyenPaiement = "ESP", LibelleMoyenPaiement = "ESPECE" },
                new MoyenDePaiement {CodeMoyenPaiement = "ORA", LibelleMoyenPaiement = "ORANGE MONEY" }
                );
            context.Patients.AddOrUpdate(
                pt => pt.IdP,
                new Patient
                {
                    DateNaissance = DateTime.Now,
                    Email = "p@gmail.com",
                    NomPrenom = "Patient Fall",
                    Addresse = "medina",
                    Tel = "7898797",
                    Poids = 70,
                    Taille = 180,
                    GroupeSanguin = "A+"
                }
                );
            context.Soins.AddOrUpdate(
                so => so.IdSoin,
                new Soin { IdSoin = 1, CodeSoin = "CONS", NomSoin = "CONSULTATION" ,CoutSoin = 5000},
                new Soin { IdSoin = 2, CodeSoin = "URGE", NomSoin = "URGENCE", CoutSoin = 50000},
                new Soin { IdSoin = 3, CodeSoin = "HOSP", NomSoin = "HOSPITALISATION", CoutSoin = 235000 },
                new Soin { IdSoin = 4, CodeSoin = "SUIV", NomSoin = "SUIVI MEDICAL", CoutSoin = 20000 },
                new Soin { IdSoin = 5, CodeSoin = "VACC", NomSoin = "VACCINATION",CoutSoin = 5000 },
                new Soin { IdSoin = 6, CodeSoin = "BILA", NomSoin = "BILAN" , CoutSoin =75000 }
                );
            context.SaveChanges();
            context.Medecins.AddOrUpdate(
                s => s.IdP,
                new Medecin
                {
                    DateNaissance = DateTime.Now,
                    Identifiant
                    = "medecin",
                    Email = "me@gmail.com",
                    NomPrenom = "Medecin Fall",
                    IdRole = 2,
                    MotDePasse = SaltHash.HashPassword("passer"),
                    PremiereConnexion = 1,
                    Addresse = "medina",
                    Status = true,
                    Tel = "7898797",
                    IdSpecialite = 1,
                    NumeroOrdre = "432",
                }
                );

            context.SaveChanges();
            context.Agenda.AddOrUpdate(
              ag => ag.IdAgenda,
              new Agenda
              {
                  IdMedecin = 4,
                  Lieu = "Health Care",
                  HeureDebut = "08:00",
                  HeureFin = "16:00",
                  Creneau = 45,
                  Titre = "Test",
                  DataPlanifier = DateTime.Now,
                  Statut = "ACTIVE"
              },
              new Agenda
              {
                  IdMedecin = 4,
                  Lieu = "Health Care",
                  HeureDebut = "08:00",
                  HeureFin = "16:00",
                  Creneau = 35,
                  Titre = "Test1",
                  DataPlanifier = DateTime.Now.AddDays(1),
                  Statut = "ACTIVE"
              }

          );
            context.SaveChanges();
        }
    }
}
