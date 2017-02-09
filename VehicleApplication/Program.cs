using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Bike bike = new Bike();
            bike.Name = "Jopo";
            bike.Model = "Street";
            bike.Year = 1990;
            bike.Color = "Red";
            bike.GearWheels = false;
            Console.WriteLine("Bike info:\n" + bike.ToString() + "\n");

            Bike bike2 = new Bike();
            bike.Name = "Tunturi";
            bike.Model = "StreetPower";
            bike.Year = 2010;
            bike.Color = "Black";
            bike.GearWheels = true;
            bike.GearName = "Shimano";
            Console.WriteLine("Bike2 info:\n" + bike.ToString() + "\n");

            Boat boat = new Boat();
            boat.Name = "Suvi";
            boat.Model = "S900";
            boat.Year = 1989;
            boat.Color = "White";
            boat.SeatCount = 3;
            boat.BoatType = "Rowboat";
            Console.WriteLine("Boat info:\n" + boat.ToString() + "\n");

            Boat boat2 = new Boat();
            boat.Name = "Yamaha";
            boat.Model = "1050";
            boat.Year = 2015;
            boat.Color = "Yellow";
            boat.SeatCount = 5;
            boat.BoatType = "Motorboat";
            Console.WriteLine("Boat2 info:\n" + boat.ToString() + "\n");


            Console.ReadLine();
        }
    }
}
