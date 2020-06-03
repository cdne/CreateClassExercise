using System;
namespace CreateClass
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var person1 = new Person() { Name = "Andrew", BirthDate = new DateTime(1978, 10, 10), Genders = Person.Gender.Male };
            Console.WriteLine(person1);
        }
    }
}