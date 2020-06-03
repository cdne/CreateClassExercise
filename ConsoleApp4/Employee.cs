using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    public class Employee : Person
    {
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
