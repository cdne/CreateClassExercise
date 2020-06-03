using ConsoleApp4;

namespace CreateClass
{
    public class Employee : Person, ICloneable
    {
        public Room Room { get; set; }

        public float Salary { get; set; }

        public Profession WorkType { get; set; }

        public enum Profession
        {
            Carpenter,
            Mechanic,
            Lawyer,
            Broker
        }

        public object Clone()
        {
            return MemberwiseClone();
        }

        public object Clone2()
        {
            Employee newEmployee = (Employee)this.MemberwiseClone();
            newEmployee.Room. = new Room() { Number };
            return newEmployee;
        }


        public override string ToString()
        {
            return $"name: {Name}, birthdate: {BirthDate}, gender: {Genders}, salary: {Salary}, profession: {WorkType}, roomNumber: {Room.Number}";
        }
    }

    interface ICloneable
    {
        object Clone();
    }
}