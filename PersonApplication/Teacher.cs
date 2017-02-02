using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApplication
{
    class Teacher : Person
    {
        // property
        public string Room { get; set; }

        // constructors
        public Teacher()
        {
        }

        public Teacher(string firstname, string lastname, string room)
            : base(firstname, lastname)
        {
            Room = room;
        }

        public void TeacherMethod()
        {
            Console.WriteLine("This method belongs to Teacher");
        }

        public override string ToString()
        {
            // base on tässä tapauksessa Person -luokka
            // "eli" kutsutaan Person -luokan ToString()-metodia
            // return FirstName + " " + ... + Room;
            return base.ToString() + " " + Room;
        }

    }
}
