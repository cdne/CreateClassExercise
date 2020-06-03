using System;

namespace CreateClass
{
    public class Person
    {
        public Gender Genders { get; set; }

        public string Name { get; set; }

        public DateTime BirthDate { get; set; }

        public enum Gender
        {
            Male,
            Female
        }

        public override string ToString()
        {
            return $"name: {Name}, birthdate: {BirthDate}, gender: {Genders}";
        }
    }
}