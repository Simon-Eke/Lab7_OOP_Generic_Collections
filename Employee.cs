using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_OOP_Generic_Collections
{
    internal class Employee
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public decimal Salary { get; set; }

        public Employee(string id, string name, string gender, decimal salary)
        {
            Id = id;
            Name = name;
            Gender = gender;
            Salary = salary;
        }
    }
}
