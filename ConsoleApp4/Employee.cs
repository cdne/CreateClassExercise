using ConsoleApp4;

namespace CreateClass
{
    public class Employee : Person
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
    }
}
