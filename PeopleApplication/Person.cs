using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleApplication
{
    class Person
    {
        // properties
        public string Name { get; set; }
        public string Profession { get; set; }
        public int Salary { get; set; }

        // constructors
        public Person()
        {
        }

        public Person(string name, string profession)
        {
            Name = name;
            Profession = profession;
        }

        // methods
        public void PersonMethod()
        {
            Console.WriteLine("This method belongs to Person!");
        }
        public override string ToString()
        {
            return "Name: " + Name + " Profession: " + Profession + " Salary: " + Salary;
        }
    }
}
