using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // create one employee from Employee class
            Employee employee = new Employee();
            employee.Name = "Kirsi Kernel";
            employee.Profession = "Teacher";
            employee.Salary = 1200;
            Console.WriteLine("Employee:\n" + employee.ToString() + "\n");

            // create one boss from Boss class
            Boss boss = new Boss();
            boss.Name = "Jussi Jurkka";
            boss.Profession = "Head of Institute";
            boss.Salary = 9000;
            boss.Car = "Audi";
            boss.Bonus = 500;
            Console.WriteLine("Boss:\n" + boss.ToString() + "\n");

            employee.Profession = "Principal";
            employee.Salary = 2200;
            Console.WriteLine("Employee:\n" + employee.ToString() + "\n");

            Console.ReadLine();
        }
    }
}
