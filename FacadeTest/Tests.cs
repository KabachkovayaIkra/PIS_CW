using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using DataAccess.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace DataAccess.Tests
{
    [TestClass]
    public class FacadeDatabaseTests
    {
        private Mock<DataContext> _mockContext;
        private FacadeDatabase _facade;

        private Mock<DbSet<Manager>> _mockManagers;
        private Mock<DbSet<Employee>> _mockEmployees;
        private Mock<DbSet<Employer>> _mockEmployers;
        private Mock<DbSet<Vacancy>> _mockVacancies;
        private Mock<DbSet<Deal>> _mockDeals;
        private Mock<DbSet<TypeOfBusiness>> _mockBusinessTypes;

        [TestInitialize]
        public void TestInitialize()
        {
            _mockContext = new Mock<DataContext>();

            _mockManagers = new Mock<DbSet<Manager>>();
            _mockEmployees = new Mock<DbSet<Employee>>();
            _mockEmployers = new Mock<DbSet<Employer>>();
            _mockVacancies = new Mock<DbSet<Vacancy>>();
            _mockDeals = new Mock<DbSet<Deal>>();
            _mockBusinessTypes = new Mock<DbSet<TypeOfBusiness>>();

            _mockContext.Setup(c => c.Managers).Returns(_mockManagers.Object);
            _mockContext.Setup(c => c.Employees).Returns(_mockEmployees.Object);
            _mockContext.Setup(c => c.Employers).Returns(_mockEmployers.Object);
            _mockContext.Setup(c => c.Vacancies).Returns(_mockVacancies.Object);
            _mockContext.Setup(c => c.Deals).Returns(_mockDeals.Object);
            _mockContext.Setup(c => c.TypesOfBusiness).Returns(_mockBusinessTypes.Object);

            _facade = new FacadeDatabase(_mockContext.Object);
        }

        [TestMethod]
        public void AuthManager_ValidCredentials_ReturnsTrue()
        {
            // Arrange
            var managers = new List<Manager>
            {
                new Manager { Login = "admin", HashPassword = "pass" }
            }.AsQueryable();

            _mockManagers.As<IQueryable<Manager>>().Setup(m => m.Provider).Returns(managers.Provider);
            _mockManagers.As<IQueryable<Manager>>().Setup(m => m.Expression).Returns(managers.Expression);
            _mockManagers.As<IQueryable<Manager>>().Setup(m => m.ElementType).Returns(managers.ElementType);
            _mockManagers.As<IQueryable<Manager>>().Setup(m => m.GetEnumerator()).Returns(managers.GetEnumerator());

            // Act
            var result = _facade.AuthManager("admin", "pass");

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void AuthManager_InvalidCredentials_ReturnsFalse()
        {
            // Arrange
            var managers = new List<Manager>
            {
                new Manager { Login = "admin", HashPassword = "pass" }
            }.AsQueryable();

            _mockManagers.As<IQueryable<Manager>>().Setup(m => m.Provider).Returns(managers.Provider);
            _mockManagers.As<IQueryable<Manager>>().Setup(m => m.Expression).Returns(managers.Expression);
            _mockManagers.As<IQueryable<Manager>>().Setup(m => m.ElementType).Returns(managers.ElementType);
            _mockManagers.As<IQueryable<Manager>>().Setup(m => m.GetEnumerator()).Returns(managers.GetEnumerator());

            // Act
            var result = _facade.AuthManager("admin", "wrongpass");

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void RegisterEmployer_ValidData_ReturnsId()
        {
            // Arrange
            var employers = new List<Employer>().AsQueryable();
            _mockEmployers.As<IQueryable<Employer>>().Setup(m => m.Provider).Returns(employers.Provider);
            _mockEmployers.As<IQueryable<Employer>>().Setup(m => m.Expression).Returns(employers.Expression);
            _mockEmployers.As<IQueryable<Employer>>().Setup(m => m.ElementType).Returns(employers.ElementType);
            _mockEmployers.As<IQueryable<Employer>>().Setup(m => m.GetEnumerator()).Returns(employers.GetEnumerator());

            _mockEmployers.Setup(m => m.Add(It.IsAny<Employer>())).Callback<Employer>(e => e.EmployerId = 1);

            // Act
            var result = _facade.RegisterEmployer("newuser", "pass", "Company");

            // Assert
            Assert.AreEqual(1, result);
            _mockEmployers.Verify(m => m.Add(It.IsAny<Employer>()), Times.Once());
            _mockContext.Verify(m => m.SaveChanges(), Times.Once());
        }

        [TestMethod]
        public void CreateVacancy_ValidData_ReturnsVacancyId()
        {
            // Arrange
            var vacancies = new List<Vacancy>().AsQueryable();
            _mockVacancies.As<IQueryable<Vacancy>>().Setup(m => m.Provider).Returns(vacancies.Provider);
            _mockVacancies.As<IQueryable<Vacancy>>().Setup(m => m.Expression).Returns(vacancies.Expression);
            _mockVacancies.As<IQueryable<Vacancy>>().Setup(m => m.ElementType).Returns(vacancies.ElementType);
            _mockVacancies.As<IQueryable<Vacancy>>().Setup(m => m.GetEnumerator()).Returns(vacancies.GetEnumerator());

            _mockVacancies.Setup(m => m.Add(It.IsAny<Vacancy>())).Callback<Vacancy>(v => v.VacancyId = 1);

            // Act
            var result = _facade.CreateVacancy(1, "Developer", 1, 1000m, "Info");

            // Assert
            Assert.AreEqual(1, result);
            _mockVacancies.Verify(m => m.Add(It.IsAny<Vacancy>()), Times.Once());
            _mockContext.Verify(m => m.SaveChanges(), Times.Once());
        }

        [TestMethod]
        public void ListVacancies_ForEmployer_ReturnsVacancies()
        {
            // Arrange
            var vacancies = new List<Vacancy>
            {
                new Vacancy { VacancyId = 1, EmployerId = 1, Profession = "Dev" },
                new Vacancy { VacancyId = 2, EmployerId = 2, Profession = "Manager" }
            }.AsQueryable();

            _mockVacancies.As<IQueryable<Vacancy>>().Setup(m => m.Provider).Returns(vacancies.Provider);
            _mockVacancies.As<IQueryable<Vacancy>>().Setup(m => m.Expression).Returns(vacancies.Expression);
            _mockVacancies.As<IQueryable<Vacancy>>().Setup(m => m.ElementType).Returns(vacancies.ElementType);
            _mockVacancies.As<IQueryable<Vacancy>>().Setup(m => m.GetEnumerator()).Returns(vacancies.GetEnumerator());

            // Act
            var result = _facade.ListVacancies(1);

            // Assert
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual("Dev", result[0].Profession);
        }

        [TestMethod]
        public void SearchVacancies_WithFilter_ReturnsFilteredResults()
        {
            // Arrange
            var vacancies = new List<Vacancy>
            {
                new Vacancy { VacancyId = 1, Profession = "Developer", VacancyInfo = "C# developer" },
                new Vacancy { VacancyId = 2, Profession = "Manager", VacancyInfo = "Project manager" }
            }.AsQueryable();

            _mockVacancies.As<IQueryable<Vacancy>>().Setup(m => m.Provider).Returns(vacancies.Provider);
            _mockVacancies.As<IQueryable<Vacancy>>().Setup(m => m.Expression).Returns(vacancies.Expression);
            _mockVacancies.As<IQueryable<Vacancy>>().Setup(m => m.ElementType).Returns(vacancies.ElementType);
            _mockVacancies.As<IQueryable<Vacancy>>().Setup(m => m.GetEnumerator()).Returns(vacancies.GetEnumerator());

            // Act
            var result = _facade.SearchVacancies("Developer");

            // Assert
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual("Developer", result[0].Profession);
        }

        [TestMethod]
        public void ApplyForVacancy_NewApplication_ReturnsTrue()
        {
            // Arrange
            var vacancies = new List<Vacancy>
            {
                new Vacancy { VacancyId = 1, EmployerId = 1 }
            }.AsQueryable();

            var employees = new List<Employee>
            {
                new Employee { EmployeeId = 1 }
            }.AsQueryable();

            var deals = new List<Deal>().AsQueryable();

            _mockVacancies.As<IQueryable<Vacancy>>().Setup(m => m.Provider).Returns(vacancies.Provider);
            _mockVacancies.As<IQueryable<Vacancy>>().Setup(m => m.Expression).Returns(vacancies.Expression);
            _mockVacancies.As<IQueryable<Vacancy>>().Setup(m => m.ElementType).Returns(vacancies.ElementType);
            _mockVacancies.As<IQueryable<Vacancy>>().Setup(m => m.GetEnumerator()).Returns(vacancies.GetEnumerator());

            _mockEmployees.As<IQueryable<Employee>>().Setup(m => m.Provider).Returns(employees.Provider);
            _mockEmployees.As<IQueryable<Employee>>().Setup(m => m.Expression).Returns(employees.Expression);
            _mockEmployees.As<IQueryable<Employee>>().Setup(m => m.ElementType).Returns(employees.ElementType);
            _mockEmployees.As<IQueryable<Employee>>().Setup(m => m.GetEnumerator()).Returns(employees.GetEnumerator());

            _mockDeals.As<IQueryable<Deal>>().Setup(m => m.Provider).Returns(deals.Provider);
            _mockDeals.As<IQueryable<Deal>>().Setup(m => m.Expression).Returns(deals.Expression);
            _mockDeals.As<IQueryable<Deal>>().Setup(m => m.ElementType).Returns(deals.ElementType);
            _mockDeals.As<IQueryable<Deal>>().Setup(m => m.GetEnumerator()).Returns(deals.GetEnumerator());

            _mockDeals.Setup(m => m.Add(It.IsAny<Deal>()));

            // Act
            var result = _facade.ApplyForVacancy(1, 1);

            // Assert
            Assert.IsTrue(result);
            _mockDeals.Verify(m => m.Add(It.IsAny<Deal>()), Times.Once());
            _mockContext.Verify(m => m.SaveChanges(), Times.Once());
        }

        [TestMethod]
        public void ApplyForVacancy_DuplicateApplication_ReturnsFalse()
        {
            // Arrange
            var vacancies = new List<Vacancy>
            {
                new Vacancy { VacancyId = 1, EmployerId = 1 }
            }.AsQueryable();

            var employees = new List<Employee>
            {
                new Employee { EmployeeId = 1 }
            }.AsQueryable();

            var deals = new List<Deal>
            {
                new Deal { EmployeeId = 1, VacancyId = 1 }
            }.AsQueryable();

            _mockVacancies.As<IQueryable<Vacancy>>().Setup(m => m.Provider).Returns(vacancies.Provider);
            _mockVacancies.As<IQueryable<Vacancy>>().Setup(m => m.Expression).Returns(vacancies.Expression);
            _mockVacancies.As<IQueryable<Vacancy>>().Setup(m => m.ElementType).Returns(vacancies.ElementType);
            _mockVacancies.As<IQueryable<Vacancy>>().Setup(m => m.GetEnumerator()).Returns(vacancies.GetEnumerator());

            _mockEmployees.As<IQueryable<Employee>>().Setup(m => m.Provider).Returns(employees.Provider);
            _mockEmployees.As<IQueryable<Employee>>().Setup(m => m.Expression).Returns(employees.Expression);
            _mockEmployees.As<IQueryable<Employee>>().Setup(m => m.ElementType).Returns(employees.ElementType);
            _mockEmployees.As<IQueryable<Employee>>().Setup(m => m.GetEnumerator()).Returns(employees.GetEnumerator());

            _mockDeals.As<IQueryable<Deal>>().Setup(m => m.Provider).Returns(deals.Provider);
            _mockDeals.As<IQueryable<Deal>>().Setup(m => m.Expression).Returns(deals.Expression);
            _mockDeals.As<IQueryable<Deal>>().Setup(m => m.ElementType).Returns(deals.ElementType);
            _mockDeals.As<IQueryable<Deal>>().Setup(m => m.GetEnumerator()).Returns(deals.GetEnumerator());

            // Act
            var result = _facade.ApplyForVacancy(1, 1);

            // Assert
            Assert.IsFalse(result);
            _mockDeals.Verify(m => m.Add(It.IsAny<Deal>()), Times.Never());
            _mockContext.Verify(m => m.SaveChanges(), Times.Never());
        }

        [TestMethod]
        public void ListDealsForEmployee_ReturnsEmployeeDeals()
        {
            // Arrange
            var deals = new List<Deal>
            {
                new Deal { DealId = 1, EmployeeId = 1 },
                new Deal { DealId = 2, EmployeeId = 2 }
            }.AsQueryable();

            _mockDeals.As<IQueryable<Deal>>().Setup(m => m.Provider).Returns(deals.Provider);
            _mockDeals.As<IQueryable<Deal>>().Setup(m => m.Expression).Returns(deals.Expression);
            _mockDeals.As<IQueryable<Deal>>().Setup(m => m.ElementType).Returns(deals.ElementType);
            _mockDeals.As<IQueryable<Deal>>().Setup(m => m.GetEnumerator()).Returns(deals.GetEnumerator());

            // Act
            var result = _facade.ListDealsForEmployee(1);

            // Assert
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual(1, result[0].DealId);
        }

        [TestMethod]
        public void SignDeal_ValidDeal_ReturnsTrue()
        {
            // Arrange
            var deals = new List<Deal>
            {
                new Deal { DealId = 1 }
            }.AsQueryable();

            var managers = new List<Manager>
            {
                new Manager { ManagerId = 1 }
            }.AsQueryable();

            _mockDeals.As<IQueryable<Deal>>().Setup(m => m.Provider).Returns(deals.Provider);
            _mockDeals.As<IQueryable<Deal>>().Setup(m => m.Expression).Returns(deals.Expression);
            _mockDeals.As<IQueryable<Deal>>().Setup(m => m.ElementType).Returns(deals.ElementType);
            _mockDeals.As<IQueryable<Deal>>().Setup(m => m.GetEnumerator()).Returns(deals.GetEnumerator());

            _mockManagers.As<IQueryable<Manager>>().Setup(m => m.Provider).Returns(managers.Provider);
            _mockManagers.As<IQueryable<Manager>>().Setup(m => m.Expression).Returns(managers.Expression);
            _mockManagers.As<IQueryable<Manager>>().Setup(m => m.ElementType).Returns(managers.ElementType);
            _mockManagers.As<IQueryable<Manager>>().Setup(m => m.GetEnumerator()).Returns(managers.GetEnumerator());

            // Act
            var result = _facade.SignDeal(1, DateTime.Now);

            // Assert
            Assert.IsTrue(result);
            _mockContext.Verify(m => m.SaveChanges(), Times.Once());
        }

        [TestMethod]
        public void TryLogin_ValidEmployeeCredentials_ReturnsTrueWithRole()
        {
            // Arrange
            var employees = new List<Employee>
            {
                new Employee { Login = "emp1", HashPassword = "pass1" }
            }.AsQueryable();

            _mockEmployees.As<IQueryable<Employee>>().Setup(m => m.Provider).Returns(employees.Provider);
            _mockEmployees.As<IQueryable<Employee>>().Setup(m => m.Expression).Returns(employees.Expression);
            _mockEmployees.As<IQueryable<Employee>>().Setup(m => m.ElementType).Returns(employees.ElementType);
            _mockEmployees.As<IQueryable<Employee>>().Setup(m => m.GetEnumerator()).Returns(employees.GetEnumerator());

            // Act
            var result = _facade.TryLogin("emp1", "pass1", out string role);

            // Assert
            Assert.IsTrue(result);
            Assert.AreEqual("Employee", role);
        }

        [TestMethod]
        public void TryRegister_NewEmployee_ReturnsTrue()
        {
            // Arrange
            var employees = new List<Employee>().AsQueryable();
            _mockEmployees.As<IQueryable<Employee>>().Setup(m => m.Provider).Returns(employees.Provider);
            _mockEmployees.As<IQueryable<Employee>>().Setup(m => m.Expression).Returns(employees.Expression);
            _mockEmployees.As<IQueryable<Employee>>().Setup(m => m.ElementType).Returns(employees.ElementType);
            _mockEmployees.As<IQueryable<Employee>>().Setup(m => m.GetEnumerator()).Returns(employees.GetEnumerator());

            _mockEmployees.Setup(m => m.Add(It.IsAny<Employee>())).Callback<Employee>(e => e.EmployeeId = 1);

            // Act
            var result = _facade.TryRegister("newemp", "pass", "Соискатель");

            // Assert
            Assert.IsTrue(result);
            _mockEmployees.Verify(m => m.Add(It.IsAny<Employee>()), Times.Once());
            _mockContext.Verify(m => m.SaveChanges(), Times.Once());
        }

        [TestMethod]
        public void UpdateVacancy_ValidData_UpdatesVacancy()
        {
            // Arrange
            var vacancy = new Vacancy { VacancyId = 1, VacancyInfo = "Old", VacancyStatus = "Open" };
            var vacancies = new List<Vacancy> { vacancy }.AsQueryable();

            _mockVacancies.As<IQueryable<Vacancy>>().Setup(m => m.Provider).Returns(vacancies.Provider);
            _mockVacancies.As<IQueryable<Vacancy>>().Setup(m => m.Expression).Returns(vacancies.Expression);
            _mockVacancies.As<IQueryable<Vacancy>>().Setup(m => m.ElementType).Returns(vacancies.ElementType);
            _mockVacancies.As<IQueryable<Vacancy>>().Setup(m => m.GetEnumerator()).Returns(vacancies.GetEnumerator());

            // Act
            _facade.UpdateVacancy(1, "New info", "Closed");

            // Assert
            Assert.AreEqual("New info", vacancy.VacancyInfo);
            Assert.AreEqual("Closed", vacancy.VacancyStatus);
            _mockContext.Verify(m => m.SaveChanges(), Times.Once());
        }
    }
}