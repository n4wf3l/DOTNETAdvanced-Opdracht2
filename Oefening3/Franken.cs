﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening3
{
    internal class Franken : USD
    {
        public double f;
        public Franken(double a) : base(a)
        {
            f = a * 0.99;
        }

        public override string ToString()
        {
            return f.ToString();
        }
    }
}
