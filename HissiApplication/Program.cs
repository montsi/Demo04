using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HissiApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Hissi hissi = new Hissi();
            int luku = 0;
            do
            {
                Console.WriteLine("Anna haluamasi kerros: "+"\n(Lopeta valitsemalla 0)");
                string line = Console.ReadLine();
                luku = int.Parse(line);
                hissi.Kerros = luku;
                Console.WriteLine("...Hissin kerros on: " + hissi.Kerros);
            }
            while (luku != 0);
        }
    }
}
