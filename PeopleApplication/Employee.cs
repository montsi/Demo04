using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleApplication
{
    class Employee: Person
    {
        // constructor
        public Employee()
        {
        }
        public Employee(string name, string profession)
            : base(name, profession)
        {
            
        }

        // methods
        public void EmployeeMethod()
        {
            Console.WriteLine("This method belongs to Employee!");
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
