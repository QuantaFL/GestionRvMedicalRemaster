namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Agenda",
                c => new
                    {
                        IdAgenda = c.Int(nullable: false, identity: true),
                        DataPlanifier = c.DateTime(precision: 0),
                        HeureDebut = c.String(unicode: false),
                        HeureFin = c.String(unicode: false),
                        Lieu = c.String(unicode: false),
                        Titre = c.String(unicode: false),
                        Statut = c.String(unicode: false),
                        IdMedecin = c.Int(nullable: false),
                        Creneau = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdAgenda)
                .ForeignKey("dbo.Personnes", t => t.IdMedecin, cascadeDelete: true)
                .Index(t => t.IdMedecin);
            
            CreateTable(
                "dbo.Personnes",
                c => new
                    {
                        IdU = c.Int(nullable: false, identity: true),
                        NomPrenom = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                        Addresse = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                        Email = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                        Tel = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                        Identifiant = c.String(maxLength: 20, storeType: "nvarchar"),
                        MotDePasse = c.String(maxLength: 250, storeType: "nvarchar"),
                        Status = c.Boolean(),
                        IdSpecialite = c.Int(),
                        NumeroOrdre = c.String(maxLength: 10, storeType: "nvarchar"),
                        GroupeSanguin = c.String(maxLength: 3, storeType: "nvarchar"),
                        Taille = c.Single(),
                        Poids = c.Single(),
                        TelephoneFixe = c.String(maxLength: 15, storeType: "nvarchar"),
                        Discriminator = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.IdU)
                .ForeignKey("dbo.Specialites", t => t.IdSpecialite)
                .Index(t => t.IdSpecialite);
            
            CreateTable(
                "dbo.Specialites",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CodeSpecialte = c.String(nullable: false, maxLength: 10, storeType: "nvarchar"),
                        NomSpecialte = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RendezVous",
                c => new
                    {
                        IdRendezVous = c.Int(nullable: false, identity: true),
                        IdSoin = c.Int(),
                        IdPatient = c.Int(),
                        IdMedecin = c.Int(),
                        Agenda_IdAgenda = c.Int(),
                    })
                .PrimaryKey(t => t.IdRendezVous)
                .ForeignKey("dbo.Personnes", t => t.IdMedecin)
                .ForeignKey("dbo.Personnes", t => t.IdPatient)
                .ForeignKey("dbo.Soins", t => t.IdSoin)
                .ForeignKey("dbo.Agenda", t => t.Agenda_IdAgenda)
                .Index(t => t.IdSoin)
                .Index(t => t.IdPatient)
                .Index(t => t.IdMedecin)
                .Index(t => t.Agenda_IdAgenda);
            
            CreateTable(
                "dbo.Soins",
                c => new
                    {
                        IdSoin = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.IdSoin);
            
            CreateTable(
                "dbo.GroupeSanguins",
                c => new
                    {
                        IdGroupeSanguin = c.Int(nullable: false, identity: true),
                        CodeGroupeSanguin = c.String(nullable: false, maxLength: 3, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.IdGroupeSanguin);
            
            CreateTable(
                "dbo.MoyenDePaiements",
                c => new
                    {
                        IdMoy = c.Int(nullable: false, identity: true),
                        CodeMoyenPaiement = c.String(nullable: false, maxLength: 20, storeType: "nvarchar"),
                        LibelleMoyenPaiement = c.String(nullable: false, maxLength: 20, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.IdMoy);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RendezVous", "Agenda_IdAgenda", "dbo.Agenda");
            DropForeignKey("dbo.RendezVous", "IdSoin", "dbo.Soins");
            DropForeignKey("dbo.RendezVous", "IdPatient", "dbo.Personnes");
            DropForeignKey("dbo.RendezVous", "IdMedecin", "dbo.Personnes");
            DropForeignKey("dbo.Personnes", "IdSpecialite", "dbo.Specialites");
            DropForeignKey("dbo.Agenda", "IdMedecin", "dbo.Personnes");
            DropIndex("dbo.RendezVous", new[] { "Agenda_IdAgenda" });
            DropIndex("dbo.RendezVous", new[] { "IdMedecin" });
            DropIndex("dbo.RendezVous", new[] { "IdPatient" });
            DropIndex("dbo.RendezVous", new[] { "IdSoin" });
            DropIndex("dbo.Personnes", new[] { "IdSpecialite" });
            DropIndex("dbo.Agenda", new[] { "IdMedecin" });
            DropTable("dbo.MoyenDePaiements");
            DropTable("dbo.GroupeSanguins");
            DropTable("dbo.Soins");
            DropTable("dbo.RendezVous");
            DropTable("dbo.Specialites");
            DropTable("dbo.Personnes");
            DropTable("dbo.Agenda");
        }
    }
}
