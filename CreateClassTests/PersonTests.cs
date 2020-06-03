using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CreateClass.Tests
{
    [TestClass()]
    public class PersonTests
    {
        [TestMethod()]
        public void Add_PersonName_ReturnsCorrectName()
        {
            Person person = new Person() { Name = "William" };

            Assert.AreEqual("William", person.Name);
        }

        [TestMethod()]
        public void Add_PersonBirthDate_ReturnsCorrectDate()
        {
            Person person = new Person() { BirthDate = new DateTime(2010, 11, 12) };

            DateTime birthDate = new DateTime(2010, 11, 12);

            Assert.IsTrue(birthDate.Equals(person.BirthDate));
        }

        [TestMethod()]
        public void Add_PersonGender_ReturnsCorrectGender()
        {
            Person person = new Person() { Genders = Person.Gender.Male };

            Assert.AreEqual(Person.Gender.Male, person.Genders);
        }

        [TestMethod()]
        public void Test_PersonObject_ReturnsCorrectValues()
        {
            Person person = new Person() { Name = "Jake", BirthDate = new DateTime(2010, 10, 10), Genders = Person.Gender.Male };

            Person resultPerson = new Person() { Name = "Jake", BirthDate = new DateTime(2010, 10, 10), Genders = Person.Gender.Male };

            Assert.AreEqual(person.ToString(), resultPerson.ToString());
        }

        [TestMethod()]
        public void Add_PersonSalary_ReturnsFloatValue()
        {
            Person person = new Person() { EmployeeData = new Employee() { Salary = 2311.221f } };

            Assert.AreEqual(2311.221f, person.EmployeeData.Salary);
        }


        [TestMethod()]
        public void Add_PersonProfession_ReturnsProfession()
        {
            Person person = new Person() { EmployeeData = new Employee() { WorkType = Employee.Profession.Broker} };

            Assert.AreEqual(Employee.Profession.Broker, person.EmployeeData.WorkType);
        }

        [TestMethod()]
        public void Add_PersonObjectEmployeeValues_ReturnsCorrectValues()
        {
            Person person = new Person()
            {
                EmployeeData = new Employee()
                {
                    Salary = 212.231f,
                    WorkType = Employee.Profession.Mechanic
                }
            };

            Assert.AreEqual(212.231f, person.EmployeeData.Salary);
            Assert.AreEqual(Employee.Profession.Mechanic, person.EmployeeData.WorkType);

        }
    }
}