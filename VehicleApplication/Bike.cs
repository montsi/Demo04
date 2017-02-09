using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleApplication
{
    class Bike: Vehicle
    {
        public bool GearWheels { get; set; }
        public string GearName { get; set; }

        public override string ToString()
        {
            return base.ToString() + " Gearwheels: " + GearWheels + " Gear name: " + GearName + " ";
        }
    }
}
