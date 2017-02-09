using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleApplication
{
    class Vehicle
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public Vehicle()
        {
        }

        public override string ToString()
        {
            return "Name: " + Name + " Model: " + Model + " Year: " + Year + " Color: " + Color;
        }
    }
}
