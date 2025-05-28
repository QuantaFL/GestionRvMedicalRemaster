using System.Data.Entity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MetierRvMedical2.Models;
using System.Collections.Generic;
using System.Linq;

namespace MetierRvMedical2.Tests.Models
{
    [TestClass]
    public class bdRdvMedicalContextTests
    {
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
    }
    [TestClass]
    public class DummyTest
    {
        [TestMethod]
        public void Dummy_Should_Run()
        {
            Assert.IsTrue(true);
        }
    }
}