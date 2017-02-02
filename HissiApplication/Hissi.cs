﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HissiApplication
{
    class Hissi
    {
        private readonly int minKerros = 1;
        private readonly int maxKerros = 5;
        private int kerros;
        public int Kerros
        {
            get
            {
                return kerros;
            }
            set
            {
                if (value <= maxKerros && value >= minKerros) kerros = value;
                else
                {
                    Console.WriteLine("Antamaasi kerrosta ei ole!");
                }
            }
        }
    }
}
