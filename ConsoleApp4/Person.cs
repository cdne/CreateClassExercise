using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    public class Person
    {
        public Gender Genders { get; set; }

        public string Name { get; set; }

        public DateTime BirthDate { get; set; }

        public Employee EmployeeData { get; set; }

        public enum Gender
        {
            Male,
            Female
        }

        public override string ToString()
        {   if(EmployeeData is null)
                return $"name: {Name}, birthdate: {BirthDate}, gender: {Genders}";
            return $"name: {Name}, birthdate: {BirthDate}, gender: {Genders}, salary: {EmployeeData.Salary}, profession: {EmployeeData.WorkType}";
        }
    }
}
