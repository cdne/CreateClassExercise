using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp4;

namespace CreateClass.Tests
{
    [TestClass()]
    public class EmployeeTests
    {
        [TestMethod]
        public void Add_EmployeeSalary_ReturnsFloatValue()
        {
            Employee employee = new Employee() { Salary = 239.021f };

            Assert.AreEqual(239.021f, employee.Salary);
        }

        [TestMethod]
        public void Add_EmployeeRoom_ReturnsInteger()
        {
            Employee employee = new Employee() { Room = new Room() { Number = 18291 } };

            Assert.AreEqual(18291, employee.Room.Number);
        }

        [TestMethod]
        public void Add_EmployeeProfession_ReturnsProfession()
        {
            Employee employee = new Employee() { WorkType = Employee.Profession.Carpenter };

            Assert.AreEqual(Employee.Profession.Carpenter, employee.WorkType);
        }
    }
}