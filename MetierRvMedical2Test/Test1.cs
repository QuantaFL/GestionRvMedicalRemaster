using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using MetierRvMedical2.Models;
using MetierRvMedical2.Services;
using MetierRvMedical2.Utils;
using Moq;
using WindowsFormsApp1.views.Secret;

namespace MetierRvMedical2Test
{
    [TestClass]
    public sealed class Test1
    {
        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {
            // This method is called once for the test class, before any tests of the class are run.
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            // This method is called once for the test class, after all tests of the class are run.
        }

        [TestInitialize]
        public void TestInit()
        {
            // This method is called before each test method.
        }

        [TestCleanup]
        public void TestCleanup()
        {
            // This method is called after each test method.
        }


        [TestMethod]
        public void Can_Get_Patients_From_Context()
        {
            // Arrange
            var data = new List<Patient>
            {
                new Patient { Email = "test1@example.com" },
                new Patient { Email = "test2@example.com" }
            }.AsQueryable();

            var mockSet = new Mock<DbSet<Patient>>();
            mockSet.As<IQueryable<Patient>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Patient>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Patient>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Patient>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<bdRdvMedicalContext>();
            mockContext.Setup(c => c.Patients).Returns(mockSet.Object);

            // Act
            var patients = mockContext.Object.Patients.ToList();

            // Assert
            Assert.AreEqual(2, patients.Count);
            Assert.AreEqual("test1@example.com", patients[0].Email);
        }


        [TestMethod]
        public void Can_Get_All_Agendas_From_AgendaService()
        {
            // Arrange
            var medecin = new Medecin { IdP = 1, NomPrenom = "Dr. House" };

            var agendas = new List<Agenda>
    {
        new Agenda { IdAgenda = 1, IdMedecin = 1, Medecin = medecin },
        new Agenda { IdAgenda = 2, IdMedecin = 1, Medecin = medecin }
    }.AsQueryable();

            var mockSet = new Mock<DbSet<Agenda>>();
            mockSet.As<IQueryable<Agenda>>().Setup(m => m.Provider).Returns(agendas.Provider);
            mockSet.As<IQueryable<Agenda>>().Setup(m => m.Expression).Returns(agendas.Expression);
            mockSet.As<IQueryable<Agenda>>().Setup(m => m.ElementType).Returns(agendas.ElementType);
            mockSet.As<IQueryable<Agenda>>().Setup(m => m.GetEnumerator()).Returns(agendas.GetEnumerator());

            var mockContext = new Mock<bdRdvMedicalContext>();
            mockContext.Setup(c => c.Agenda).Returns(mockSet.Object);

            var service = new AgendaService(mockContext.Object);

            // Act
            var result = service.GetAllAgendas().ToList();

            // Assert
            Assert.AreEqual(2, result.Count);
            Assert.AreEqual("Dr. House", result[0].Medecin.NomPrenom);
        }


        [TestMethod]
        public void Can_Create_Agenda()
        {
            // Arrange
            var mockSet = new Mock<DbSet<Agenda>>();
            var mockContext = new Mock<bdRdvMedicalContext>();
            mockContext.Setup(c => c.Agenda).Returns(mockSet.Object);

            var service = new AgendaService(mockContext.Object);

            Agenda captured = null;
            mockSet.Setup(m => m.Add(It.IsAny<Agenda>()))
                   .Callback<Agenda>(r => captured = r);

            // Act
            DateTime datePlanifier = DateTime.Now;
            service.CreateAgenda(datePlanifier,"8:00", "18:30", "dakar", "Seminaire", "dispo", 45, 1);

            // Assert
            mockSet.Verify(m => m.Add(It.IsAny<Agenda>()), Times.Once);
            mockContext.Verify(m => m.SaveChanges(), Times.Once);

            Assert.IsNotNull(captured);
            Assert.AreEqual(datePlanifier, captured.DataPlanifier);
            Assert.AreEqual("8:00", captured.HeureDebut);
            Assert.AreEqual("18:30", captured.HeureFin);
            Assert.AreEqual(1, captured.IdMedecin);
            Assert.AreEqual("dakar", captured.Lieu);
            Assert.AreEqual("Seminaire", captured.Titre);
            Assert.AreEqual("dispo", captured.Statut);
            Assert.AreEqual(45, captured.Creneau);
        }

        [TestMethod]
        public void Can_Create_RendezVous()
        {
            // Arrange
            var mockSet = new Mock<DbSet<RendezVous>>();
            var mockContext = new Mock<bdRdvMedicalContext>();
            mockContext.Setup(c => c.RendezVous).Returns(mockSet.Object);

            var service = new RendezVousService(mockContext.Object);

            RendezVous captured = null;
            mockSet.Setup(m => m.Add(It.IsAny<RendezVous>()))
                   .Callback<RendezVous>(r => captured = r);

            // Act
            service.AddRendezVous( "21/10/2025", "8h30", 1, 1, 1, 1, "123");

            // Assert
            mockSet.Verify(m => m.Add(It.IsAny<RendezVous>()), Times.Once);
            mockContext.Verify(m => m.SaveChanges(), Times.Once);

            Assert.IsNotNull(captured);
            Assert.AreEqual("8h30", captured.HeureRv);
            Assert.AreEqual("21/10/2025", captured.DateRv);
            Assert.AreEqual(1, captured.IdMedecin);
            Assert.AreEqual(1, captured.IdPatient);
            Assert.AreEqual(1, captured.IdSoin);
            Assert.AreEqual("123", captured.CodeRdv);
        }



        [TestMethod]
        public void Can_Delete_Agenda()
        {
            // Arrange
            var agenda = new Agenda { IdAgenda = 1, Titre = "To Delete" };
            var mockSet = new Mock<DbSet<Agenda>>();
            mockSet.Setup(m => m.Find(It.IsAny<int>())).Returns(agenda);

            var mockContext = new Mock<bdRdvMedicalContext>();
            mockContext.Setup(c => c.Agenda).Returns(mockSet.Object);

            var service = new AgendaService(mockContext.Object);

            // Act
            service.DeleteAgenda(1);

            // Assert
            mockSet.Verify(m => m.Remove(It.Is<Agenda>(a => a == agenda)), Times.Once);
            mockContext.Verify(m => m.SaveChanges(), Times.Once);
        }

        [TestMethod]
        public void Can_Get_All_RendezVous_From_RendezVousService()
        {
            // Arrange
            var rendezVousList = new List<RendezVous>
            {
                new RendezVous { IdRendezVous = 1 },
                new RendezVous { IdRendezVous = 2 }
            }.AsQueryable();

            var mockSet = new Mock<DbSet<RendezVous>>();
            mockSet.As<IQueryable<RendezVous>>().Setup(m => m.Provider).Returns(rendezVousList.Provider);
            mockSet.As<IQueryable<RendezVous>>().Setup(m => m.Expression).Returns(rendezVousList.Expression);
            mockSet.As<IQueryable<RendezVous>>().Setup(m => m.ElementType).Returns(rendezVousList.ElementType);
            mockSet.As<IQueryable<RendezVous>>().Setup(m => m.GetEnumerator()).Returns(rendezVousList.GetEnumerator());

            var mockContext = new Mock<bdRdvMedicalContext>();
            mockContext.Setup(c => c.RendezVous).Returns(mockSet.Object);

            var service = new RendezVousService(mockContext.Object);

            // Act
            var result = service.GetAllRendezVous().ToList();

            // Assert
            Assert.AreEqual(2, result.Count);
        }



        [TestClass]
        public class MedecinServiceTests
        {
            private Mock<DbSet<Medecin>> mockSet;
            private Mock<bdRdvMedicalContext> mockContext;
            private MedecinService service;

            [TestInitialize]
            public void Setup()
            {
                var medecins = new List<Medecin>
            {
                new Medecin { IdP = 1, NumeroOrdre = "12345", Status = false },
                new Medecin { IdP = 2, NumeroOrdre = "67890", Status = false }
            }.AsQueryable();

                mockSet = new Mock<DbSet<Medecin>>();
                mockSet.As<IQueryable<Medecin>>().Setup(m => m.Provider).Returns(medecins.Provider);
                mockSet.As<IQueryable<Medecin>>().Setup(m => m.Expression).Returns(medecins.Expression);
                mockSet.As<IQueryable<Medecin>>().Setup(m => m.ElementType).Returns(medecins.ElementType);
                mockSet.As<IQueryable<Medecin>>().Setup(m => m.GetEnumerator()).Returns(medecins.GetEnumerator());

                mockContext = new Mock<bdRdvMedicalContext>();
                mockContext.Setup(c => c.Medecins).Returns(mockSet.Object);

                service = new MedecinService(mockContext.Object);
            }

            [TestMethod]
            public void GetMedecinByNumeroOrdre_ReturnsCorrectMedecin()
            {
                var medecin = service.GetMedecinByNumeroOrdre("12345");
                Assert.IsNotNull(medecin);
                Assert.AreEqual("12345", medecin.NumeroOrdre);
            }

            [TestMethod]
            public void ActiverMedecin_SetsStatusTrue()
            {
                service.ActiverMedecin("12345");

                mockContext.Verify(m => m.SaveChanges(), Times.Once);

                var medecin = service.GetMedecinByNumeroOrdre("12345");
                Assert.IsTrue(medecin.Status);
            }

            [TestMethod]
            public void DesactiverMedecin_SetsStatusFalse()
            {
                service.DesactiverMedecin("12345");

                mockContext.Verify(m => m.SaveChanges(), Times.Once);

                var medecin = service.GetMedecinByNumeroOrdre("12345");
                Assert.IsFalse(medecin.Status);
            }
        }

        [TestMethod]
        public void GenerateCreneaux_ReturnsExpectedCreneaux()
        {
            // Arrange
            string heureDebut = "08:00";
            string heureFin = "10:00";
            int creneauMinutes = 30;
            var bookedHeures = new List<string> { "08:30" };

            // Act
            var result = CreneauxGenerator.GenerateCreneaux(heureDebut, heureFin, creneauMinutes, bookedHeures);

            // Assert
            Assert.AreEqual(3, result.Count);
            Assert.AreEqual("08:00 - 08:30", result[0].Text);
            Assert.AreEqual("08:00", result[0].Value);
            Assert.AreEqual("09:00 - 09:30", result[1].Text);
            Assert.AreEqual("09:00", result[1].Value);
            Assert.AreEqual("09:30 - 10:00", result[2].Text);
            Assert.AreEqual("09:30", result[2].Value);
        }

        [TestClass]
        public class SecretaireServiceTests
        {
            private Mock<DbSet<Secretaire>> mockSet;
            private Mock<bdRdvMedicalContext> mockContext;
            private SecretaireService service;

            [TestInitialize]
            public void Setup()
            {
                var secretaires = new List<Secretaire>
            {
                new Secretaire { IdP = 1, Matricule = "A001", Status = false },
                new Secretaire { IdP = 2, Matricule = "B002", Status = false }
            }.AsQueryable();

                mockSet = new Mock<DbSet<Secretaire>>();
                mockSet.As<IQueryable<Secretaire>>().Setup(m => m.Provider).Returns(secretaires.Provider);
                mockSet.As<IQueryable<Secretaire>>().Setup(m => m.Expression).Returns(secretaires.Expression);
                mockSet.As<IQueryable<Secretaire>>().Setup(m => m.ElementType).Returns(secretaires.ElementType);
                mockSet.As<IQueryable<Secretaire>>().Setup(m => m.GetEnumerator()).Returns(secretaires.GetEnumerator());

                mockContext = new Mock<bdRdvMedicalContext>();
                mockContext.Setup(c => c.Secretaires).Returns(mockSet.Object);

                service = new SecretaireService(mockContext.Object);
            }

            [TestMethod]
            public void GetSecretaireByMatricule_ReturnsCorrectSecretaire()
            {
                var secretaire = service.GetSecretaireByMatricule("A001");
                Assert.IsNotNull(secretaire);
                Assert.AreEqual("A001", secretaire.Matricule);
            }

            [TestMethod]
            public void ActiverSecretaire_SetsStatusTrue()
            {
                service.ActiverSecretaire("A001");

                mockContext.Verify(m => m.SaveChanges(), Times.Once);

                var secretaire = service.GetSecretaireByMatricule("A001");
                Assert.IsTrue(secretaire.Status);
            }

            [TestMethod]
            public void DesactiverSecretaire_SetsStatusFalse()
            {
                service.DesactiverSecretaire("A001");

                mockContext.Verify(m => m.SaveChanges(), Times.Once);

                var secretaire = service.GetSecretaireByMatricule("A001");
                Assert.IsFalse(secretaire.Status);
            }
        }

    }

}

