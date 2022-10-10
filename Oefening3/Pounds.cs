using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening3
{
    internal class Pounds : USD
    {
        public double p;
        public Pounds(double a) : base(a)
        {
            p = a * 0.88;
        }

        public override string ToString()
        {
            return p.ToString();
        }
    }
}
