using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmpApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Amp amp = new Amp();
            int luku = 0;
            do
            {
                Console.WriteLine("Give a new volume value (0-100): ");
                string line = Console.ReadLine();
                luku = int.Parse(line);
                amp.Volume = luku;
                Console.WriteLine("Volume set to: " + amp.Volume);
            }

            while (luku != 0);
        }
    }
}
