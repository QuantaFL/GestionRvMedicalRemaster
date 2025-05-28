using System.Collections.Generic;
using System.Data.Entity;
using ApiRvMedical2.Models;
using Moq;

namespace ApiRvMedicalTest2
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
        }
   
}
