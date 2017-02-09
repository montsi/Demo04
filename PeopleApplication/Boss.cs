using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleApplication
{
    class Boss: Person
    {
        // property
        public string Car { get; set; }
        public int Bonus { get; set; }

        // constructors
        public Boss()
        {
        }

        public Boss(string name, string profession, string car, int bonus)
            : base(name, profession)
        {
            Car = car;
            Bonus = bonus;
        }

        public void BossMethod()
        {
            Console.WriteLine("This method belongs to Boss");
        }

        public override string ToString()
        {
            // base on tässä tapauksessa Person -luokka
            // "eli" kutsutaan Person -luokan ToString()-metodia
            // return Name + " " + ... + Car;
            return base.ToString() + " Car: " + Car + " Bonus: " + Bonus;
        }

    }
}
