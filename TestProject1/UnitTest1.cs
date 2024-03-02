using BankEmployeeModule.Controllers;
using BankEmployeeModule.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace TestProject1
{
    public class Tests
    {
        private EmployeeController _employeeController;
        [SetUp]
        public void Setup()
        {
            _employeeController = new EmployeeController();
        }

        [Test]
        public void TestMethodForGetEmployee()
        {
            IEnumerable<Employee> result = _employeeController.GetEmployees();
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Count(), Is.EqualTo(0));
        }
        [Test]
        public void TestMethodForPostEmployee()
        {
            var newItem = new Employee
            {
                Id = 1,
                Fname = "test",
                Lname = "test",
                JobRole = "test",
                LoginId=1,
                Password="test",
            };
            var actionResult = _employeeController.PostEmployee(newItem);
            Assert.That(actionResult, Is.Not.Null);
        }
        [Test]
        public void TestMethodForPostEmployeeNull()
        {
            var newItem = new Employee
            {
                Id = 1,
                Fname = null,
                Lname = null,
                JobRole = null,
                LoginId=1,
                Password=null,
            };
            var actionResult = _employeeController.PostEmployee(newItem);
            Assert.IsNotInstanceOf<BadRequest>(actionResult);
        }
    }
}