namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
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
            context.Secretaires.AddOrUpdate(
                s => s.IdP,
                new Secretaire {DateNaissance = DateTime.Now,Identifiant
                    = "secret",Email = "secretaire@gmail.com",
                    NomPrenom = "Rama Fall",IdRole = 3, MotDePasse = "passer",
                    TelephoneFixe = "7777777", PremiereConnexion = 1,
                    Addresse = "medina",
                    Status = true, Matricule = "rtyrtty", Tel = "7898797" }
                );
            context.Medecins.AddOrUpdate(
                s => s.IdP,
                new Medecin
                {
                    DateNaissance = DateTime.Now,
                    Identifiant
                    = "medecin",
                    Email = "medecin@gmail.com",
                    NomPrenom = "Medecin Fall",
                    IdRole = 2,
                    MotDePasse = "passer",
                    PremiereConnexion = 1,
                    Addresse = "medina",
                    Status = true,
                    Tel = "7898797",
                    IdSpecialite = 1,
                    NumeroOrdre = "432",
                }
                );

            context.SaveChanges();
        }
    }
}
