using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiRvMedical2.Models;
using ApiRvMedical2.services;
using Moq;

namespace ApiRvMedicalTest2
{
    /*
             une source LINQ (comme un IQueryable),
             pour qu’on puisse faire .Where(), .Select(), .ToList() dessus



           var mockSet = new Mock<DbSet<Utilisateur>>();
           mockSet.As<IQueryable<Utilisateur>>().Setup(m => m.Provider).Returns(utilisateurs.Provider); // simule le where 
           mockSet.As<IQueryable<Utilisateur>>().Setup(m => m.Expression).Returns(utilisateurs.Expression); // simule le whre 
           mockSet.As<IQueryable<Utilisateur>>().Setup(m => m.ElementType).Returns(utilisateurs.ElementType); // simule le select 
           mockSet.As<IQueryable<Utilisateur>>().Setup(m => m.GetEnumerator()).Returns(utilisateurs.GetEnumerator());  //simule le toList

           mockSet.Setup(m => m.Include("Role")).Returns(mockSet.Object);
            */
    [TestClass]
    public class AdminServiceTests
    {
        [TestMethod]
        public async Task GetAllUtilisateursAsync_ExcludeAdmins_ReturnsCorrectUsers()
        {
            // Arrange
            var utilisateurs = new List<Utilisateur>
            {
                new Utilisateur
                {
                    NomPrenom = "Adja Sy",
                    DateNaissance = new DateTime(1990, 1, 1),
                    Addresse = "Paris",
                    Email = "adja@example.com",
                    Tel = "0102030405",
                    Status = true,
                    Role = new Role { LibelleRole = "secretaire" }
                },
                new Utilisateur
                {
                    NomPrenom = "Admin Root",
                    DateNaissance = new DateTime(1985, 5, 5),
                    Addresse = "Lyon",
                    Email = "admin@example.com",
                    Tel = "0601020304",
                    Status = true,
                    Role = new Role { LibelleRole = "ADMIN" }
                },
                new Utilisateur
                {
                    NomPrenom = "Fatou Diop",
                    DateNaissance = new DateTime(1992, 2, 2),
                    Addresse = "Dakar",
                    Email = "fatou@example.com",
                    Tel = "0777888999",
                    Status = true,
                    Role = new Role { LibelleRole = "secretaire" }
                }
            }.AsQueryable();

            
            var mockSet = new Mock<DbSet<Utilisateur>>();
            mockSet.As<IDbAsyncEnumerable<Utilisateur>>()
                   .Setup(m => m.GetAsyncEnumerator())
                   .Returns(new TestDbAsyncEnumerator<Utilisateur>(utilisateurs.GetEnumerator()));

            mockSet.As<IQueryable<Utilisateur>>()
                   .Setup(m => m.Provider)
                   .Returns(new TestDbAsyncQueryProvider<Utilisateur>(utilisateurs.Provider));
            mockSet.As<IQueryable<Utilisateur>>().Setup(m => m.Expression).Returns(utilisateurs.Expression);
            mockSet.As<IQueryable<Utilisateur>>().Setup(m => m.ElementType).Returns(utilisateurs.ElementType);
            mockSet.As<IQueryable<Utilisateur>>().Setup(m => m.GetEnumerator()).Returns(utilisateurs.GetEnumerator());

          
            mockSet.Setup(m => m.Include("Role")).Returns(mockSet.Object);

           
            var mockContext = new Mock<bdRdvMedicalContext>();
            mockContext.Setup(c => c.Utilisateurs).Returns(mockSet.Object);

           
            var service = new AdminService(mockContext.Object);

            // Act
            var result = await service.GetAllUtilisateursAsync();

            // Assert
            Assert.AreEqual(2, result.Count);
            Assert.IsTrue(result.All(u => u.LibelleRole != "ADMIN"));
        }

    }

}
