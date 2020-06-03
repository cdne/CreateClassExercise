using ConsoleApp4;
using System;

namespace CreateClass
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Employee Claudiu = new Employee()
            {
                Name = "Claudiu",
                Genders = Person.Gender.Male,
                BirthDate = new DateTime(1991, 12, 21),
                Salary = 10231,
                WorkType = Employee.Profession.Broker,
                Room = new Room() { Number = 21 }
            };

            Employee Claudiu2 = (Employee)Claudiu.Clone();
            Claudiu2.Room.Number = 1000;
            Console.WriteLine(Claudiu);
            Console.WriteLine(Claudiu2);
    
        }
    }
}