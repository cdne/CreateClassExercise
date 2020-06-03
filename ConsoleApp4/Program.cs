using System;
namespace CreateClass
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var person1 = new Person() { Name = "Andrew", BirthDate = new DateTime(1978, 10, 10), Genders = Person.Gender.Male };
            Console.WriteLine(person1);
            var person2 = new Person()
            {
                Name = "Julia",
                BirthDate = DateTime.Now,
                Genders = Person.Gender.Female,
                EmployeeData = new Employee()
                {
                    Salary = 21231,
                    WorkType = Employee.Profession.Lawyer
                }
            };
            Console.WriteLine(person2);

        }
    }
}