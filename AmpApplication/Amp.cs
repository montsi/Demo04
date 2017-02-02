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
                    Console.WriteLine("Too low volume - Amplifier volume is set to minimum : ");
                    volume = minVolume;
                }
                else if (value < maxVolume)
                {
                    Console.WriteLine("Too much volume - Amplifier volume is set to maximum : ");
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
