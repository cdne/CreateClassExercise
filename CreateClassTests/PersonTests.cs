using ConsoleApp4;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CreateClass.Tests
{
    [TestClass()]
    public class PersonTests
    {
        [TestMethod]
        public void Add_PersonName_ReturnsCorrectName()
        {
            Person person = new Person() { Name = "William" };

            Assert.AreEqual("William", person.Name);
        }

        [TestMethod]
        public void Add_PersonBirthDate_ReturnsCorrectDate()
        {
            Person person = new Person() { BirthDate = new DateTime(2010, 11, 12) };

            DateTime birthDate = new DateTime(2010, 11, 12);

            Assert.IsTrue(birthDate.Equals(person.BirthDate));
        }

        [TestMethod]
        public void Add_PersonGender_ReturnsCorrectGender()
        {
            Person person = new Person() { Genders = Person.Gender.Male };

            Assert.AreEqual(Person.Gender.Male, person.Genders);
        }

        [TestMethod]
        public void Test_PersonObject_ReturnsCorrectValues()
        {
            Person person = new Person() { Name = "Jake", BirthDate = new DateTime(2010, 10, 10), Genders = Person.Gender.Male };

            Person resultPerson = new Person() { Name = "Jake", BirthDate = new DateTime(2010, 10, 10), Genders = Person.Gender.Male };

            Assert.AreEqual(person.ToString(), resultPerson.ToString());
        }
    }
}