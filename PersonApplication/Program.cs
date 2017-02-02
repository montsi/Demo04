using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // create one teacher from Teacher class
            Teacher teacher = new Teacher();
            teacher.FirstName = "Kirsi";
            teacher.LastName = "Kernel";
            teacher.Age = 30;
            teacher.Address = "Piipukatu 2";
            teacher.PhoneNumber = "010-12345678";
            teacher.Room = "D444";
            Console.WriteLine(teacher.ToString());

            // create one student from Student class
            Student student = new Student("Matti", "Mallikas", "H9909");
            student.Address = "Kirkkokatu 10";
            student.Age = 20;
            student.PhoneNumber = "040-23423424";
            Console.WriteLine(student.ToString());

            teacher.TeacherMethod();
            student.StudentMethod();


        }
    }
}
