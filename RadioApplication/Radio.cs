using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioApplication
{
    class Radio
    {
        public bool IsOn;
        private double frequency;
        private readonly double minFreq = 2000.0;
        private readonly double maxFreq = 26000.0;
        public double Frequency
        {
            get
            {
                return frequency;
            }
            set
            {
                if (value >= minFreq && value <= maxFreq) frequency = value;
                else if (value < minFreq)
                {
                    frequency = minFreq;
                }
                else if (value > maxFreq)
                {
                    frequency = maxFreq;
                }
            }
        }
        private readonly int minVolume = 0;
        private readonly int maxVolume = 9;
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
                else if (value < minVolume)
                {
                    volume = minVolume;
                }
                else if (value > maxVolume)
                {
                    volume = maxVolume;
                }
            }
        }

        public Radio()
        {
        }

        public void SettingsAre()
        {
            Console.WriteLine("Radio is on: " + IsOn + "\nFrequency is set to: " + frequency + "\nVolume is set to: " + volume + "\n");
        }
    }
}
