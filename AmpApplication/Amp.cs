using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmpApplication
{
    class Amp
    {
        private readonly int minVolume = 0;
        private readonly int maxVolume = 100;
        private int volume;
        public int Volume
        {
            get
            {
                return volume;
            }
            set
            {
                if (value >= minVolume && value <= maxVolume) volume = value;
                else if(value < minVolume)
                {
                    Console.WriteLine("Too low volume");
                    volume = minVolume;
                }
                else if (value > maxVolume)
                {
                    Console.WriteLine("Too much volume");
                    volume = maxVolume;
                }
                else
                {
                    Console.WriteLine("");
                }
            }
        }
    }
}
