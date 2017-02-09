using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Radio radio = new Radio();
            radio.IsOn = true;
            radio.Frequency = 14000.5;
            radio.Volume = 6;
            radio.SettingsAre();

            radio.IsOn = false;
            radio.Frequency = 50000;
            radio.Volume = -2;
            radio.SettingsAre();

            radio.IsOn = true;
            radio.Frequency = 140.5;
            radio.Volume = 10;
            radio.SettingsAre();

            Console.ReadLine();
        }
    }
}
