


using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using Bogus;
using ApiRvMedical.Models;


namespace ApiRvMedical.utils
{
    public static class FactorySeed
    {
        private static Faker _faker = new Faker();

        public static Role[] GetRoles()
        {
            return new[]
            {
            new Role { CodeRole = "ADM", LibelleRole = "ADMIN" },
            new Role { CodeRole = "SEC", LibelleRole = "SECRETAIRE" },
            new Role { CodeRole = "MED", LibelleRole = "MEDECIN" }
        };
        }
        public static GroupeSanguin[] GetGroupeSanguins()
        {
            return new[]
            {
            new GroupeSanguin { CodeGroupeSanguin = "A+" },
            new GroupeSanguin { CodeGroupeSanguin = "A-" },
            new GroupeSanguin { CodeGroupeSanguin = "B+" },
            new GroupeSanguin { CodeGroupeSanguin = "B-" },
            new GroupeSanguin { CodeGroupeSanguin = "AB+" },
            new GroupeSanguin { CodeGroupeSanguin = "AB-" },
            new GroupeSanguin { CodeGroupeSanguin = "O+" },
            new GroupeSanguin { CodeGroupeSanguin = "O-" }
        };
        }

        public static Specialite[] GetSpecialites()
        {
            return new[]
            {
            new Specialite { CodeSpecialte = "CAR", NomSpecialte = "CARDIOLOGIE" },
            new Specialite { CodeSpecialte = "CHIR", NomSpecialte = "CHIRURGIE" }
        };
        }

        public static MoyenDePaiement[] GetMoyenDePaiements()
        {
            return new[]
            {
            new MoyenDePaiement { CodeMoyenPaiement = "WAV", LibelleMoyenPaiement = "WAVE" },
            new MoyenDePaiement { CodeMoyenPaiement = "ESP", LibelleMoyenPaiement = "ESPECE" },
            new MoyenDePaiement { CodeMoyenPaiement = "ORA", LibelleMoyenPaiement = "ORANGE MONEY" }
        };
        }

        public static Soin[] GetSoins()
        {
            return new[]
            {
            new Soin { IdSoin = 1, CodeSoin = "CONS", NomSoin = "CONSULTATION", CoutSoin = 5000 },
            new Soin { IdSoin = 2, CodeSoin = "URGE", NomSoin = "URGENCE", CoutSoin = 50000 },
            new Soin { IdSoin = 3, CodeSoin = "HOSP", NomSoin = "HOSPITALISATION", CoutSoin = 235000 },
            new Soin { IdSoin = 4, CodeSoin = "SUIV", NomSoin = "SUIVI MEDICAL", CoutSoin = 20000 },
            new Soin { IdSoin = 5, CodeSoin = "VACC", NomSoin = "VACCINATION", CoutSoin = 5000 },
            new Soin { IdSoin = 6, CodeSoin = "BILA", NomSoin = "BILAN", CoutSoin = 75000 }
        };
        }

        public static Admin GetAdmin()
        {
            return new Faker<Admin>()
                .RuleFor(a => a.DateNaissance, f => f.Date.Past(30))
                .RuleFor(a => a.Identifiant, f => f.Internet.UserName())
                .RuleFor(a => a.Email, f => f.Internet.Email())
                .RuleFor(a => a.NomPrenom, f => f.Name.FullName())
                .RuleFor(a => a.IdRole, 1)
                .RuleFor(a => a.MotDePasse, f => SaltHash.HashPassword("passer"))
                .RuleFor(a => a.PremiereConnexion, 1)
                .RuleFor(a => a.Addresse, f => f.Address.FullAddress())
                .RuleFor(a => a.Status, true)
                .RuleFor(a => a.Tel, f => f.Phone.PhoneNumber());
        }

        public static List<Secretaire> GetSecretaires(int n)
        {
            var secretaires = new Faker<Secretaire>()
                .RuleFor(s => s.DateNaissance, f => f.Date.Past(30))
                .RuleFor(s => s.Identifiant, f => f.Internet.UserName())
                .RuleFor(s => s.Email, f => f.Internet.Email())
                .RuleFor(s => s.NomPrenom, f => f.Name.FullName())
                .RuleFor(s => s.IdRole, 2)
                .RuleFor(s => s.MotDePasse, f => SaltHash.HashPassword("passer"))
                .RuleFor(s => s.TelephoneFixe, f => f.Random.String2(15))
                .RuleFor(s => s.PremiereConnexion, 1)
                .RuleFor(s => s.Addresse, f => f.Address.FullAddress())
                .RuleFor(s => s.Status, true)
                .RuleFor(s => s.Matricule, f => f.Random.AlphaNumeric(10))
                .RuleFor(s => s.Tel, f => f.Phone.PhoneNumber());

            return secretaires.Generate(n);
        }

        public static List<Patient> GetPatients(int n)
        {
            var patients = new Faker<Patient>()
                .RuleFor(pt => pt.DateNaissance, f => f.Date.Past(30))
                .RuleFor(pt => pt.Email, f => f.Internet.Email())
                .RuleFor(pt => pt.NomPrenom, f => f.Name.FullName())
                .RuleFor(pt => pt.Addresse, f => f.Address.FullAddress())
                .RuleFor(pt => pt.Tel, f => f.Phone.PhoneNumber().Normalize())
                .RuleFor(pt => pt.Poids, f => f.Random.Number(50, 100))
                .RuleFor(pt => pt.Taille, f => f.Random.Number(150, 190))
                .RuleFor(pt => pt.GroupeSanguin, f => f.PickRandom("A+", "A-", "B+", "B-", "O+", "O-"));

            return patients.Generate(n);
        }

        public static List<Medecin> GetMedecins(int n)
        {
            var medecins = new Faker<Medecin>()
                .RuleFor(m => m.DateNaissance, f => f.Date.Past(30))
                .RuleFor(m => m.Identifiant, f => f.Internet.UserName())
                .RuleFor(m => m.Email, f => f.Internet.Email())
                .RuleFor(m => m.NomPrenom, f => f.Name.FullName())
                .RuleFor(m => m.IdRole, 3)
                .RuleFor(m => m.MotDePasse, f => SaltHash.HashPassword("passer"))
                .RuleFor(m => m.PremiereConnexion, 1)
                .RuleFor(m => m.Addresse, f => f.Address.FullAddress())
                .RuleFor(m => m.Status, true)
                .RuleFor(m => m.Tel, f => f.Phone.PhoneNumber())
                .RuleFor(m => m.IdSpecialite, 1)
                .RuleFor(m => m.NumeroOrdre, f => f.Random.Number(1000, 9999).ToString());

            return medecins.Generate(n);
        }

        public static void SeedMedecinsAndAgendas(int n, bdRdvMedicalContext context)
        {
            // Generate Medecins first
            var medecins = GetMedecins(n);

            // Save Medecins to the database
            context.Medecins.AddRange(medecins);
            context.SaveChanges();  // Ensure Medecins are saved to the database

            // Generate and save Agendas for each Medecin
            var agendas = new List<Agenda>();

            foreach (var medecin in medecins)
            {
                var agendaCount = new Faker().Random.Number(1, 3);

                for (int i = 0; i < agendaCount; i++)
                {
                    var agenda = new Faker<Agenda>()
                        .RuleFor(a => a.IdMedecin, medecin.IdP)  // Link to the existing Medecin's ID
                        .RuleFor(a => a.Lieu, f => f.Company.CompanyName())
                        .RuleFor(a => a.HeureDebut, f => f.Date.Future(1).ToString("HH:mm"))
                        .RuleFor(a => a.HeureFin, f => f.Date.Future(1).ToString("HH:mm"))
                        .RuleFor(a => a.Creneau, f => f.Random.Number(30, 60))
                        .RuleFor(a => a.Titre, f => f.Random.Word())
                        .RuleFor(a => a.DataPlanifier, f => f.Date.Future(1))
                        .RuleFor(a => a.Statut, "ACTIVE")
                        .Generate();

                    agendas.Add(agenda);
                }
            }

            context.Agenda.AddRange(agendas);
            context.SaveChanges();

        }
        public static void MedecinSeeder(bdRdvMedicalContext context)
        {
            Random rand = new Random();
            var africanNames = new[]
            {
            new { FirstName = "Mamadou", LastName = "Diop" },
            new { FirstName = "Fatoumata", LastName = "Diarra" },
            new { FirstName = "Amadou", LastName = "Sow" },
            new { FirstName = "Aissatou", LastName = "Ba" },
            new { FirstName = "Mouhamed", LastName = "Ndour" },
            new { FirstName = "Mariama", LastName = "Toure" },
            new { FirstName = "Ibrahime", LastName = "Fall" },
            new { FirstName = "Sokhna", LastName = "Sy" },
            new { FirstName = "Cheikh", LastName = "Ndiaye" },
            new { FirstName = "Ndeye", LastName = "Gueye" },
            new { FirstName = "Omar", LastName = "Fall" },
            new { FirstName = "Maimouna", LastName = "Thiam" },
            new { FirstName = "Tijani", LastName = "Kane" },
            new { FirstName = "Kadidia", LastName = "Faye" },
            new { FirstName = "Boubacar", LastName = "Diagne" },
            new { FirstName = "Khadija", LastName = "Mbaye" },
            new { FirstName = "Seydou", LastName = "Seck" },
            new { FirstName = "Khady", LastName = "Sarr" },
            new { FirstName = "Alioune", LastName = "Mbacke" }
        };

            for (int i = 5; i <= 24; i++)
            {
                var name = africanNames[rand.Next(0, africanNames.Length)];
                var phone = $"78{rand.Next(1000000, 9999999)}";
                var email = $"{name.FirstName.ToLower()}.{name.LastName.ToLower()}@gmail.com";

                context.Medecins.AddOrUpdate(
                    m => m.IdP,
                    new Medecin
                    {
                        DateNaissance = DateTime.Now.AddYears(-rand.Next(30, 60)),
                        Identifiant = $"medecin{i}",
                        Email = email,
                        NomPrenom = $"{name.FirstName} {name.LastName}",
                        IdRole = 3,
                        MotDePasse = SaltHash.HashPassword("passer"),
                        PremiereConnexion = 1,
                        Addresse = $"Address {i}",
                        Status = true,
                        Tel = phone,
                        IdSpecialite = rand.Next(1, 11),
                        NumeroOrdre = $"{rand.Next(100, 999)}",
                    }
                );
            }

            context.SaveChanges();

            for (int medecinId = 4; medecinId <= 24; medecinId++)
            {
                for (int agendaCount = 0; agendaCount < 15; agendaCount++)
                {
                    var startHour = rand.Next(7, 12);
                    var startMinute = rand.Next(0, 60);
                    var endHour = startHour + rand.Next(5, 14);

                    context.Agenda.AddOrUpdate(
                        ag => ag.IdAgenda,
                        new Agenda
                        {
                            IdMedecin = medecinId,
                            Lieu = $"Health Care {medecinId}",
                            HeureDebut = $"{startHour:D2}:{startMinute:D2}",
                            HeureFin = $"{endHour:D2}:{rand.Next(0, 60):D2}",
                            Creneau = rand.Next(20, 60),
                            Titre = $"Agenda {agendaCount + 1} for Medecin {medecinId}",
                            DataPlanifier = DateTime.Now.AddDays(rand.Next(1, 30)),
                            Statut = "dispo"
                        }
                    );
                }
            }

            context.SaveChanges();
        }


    }

}