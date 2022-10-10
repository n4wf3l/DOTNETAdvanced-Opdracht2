using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening3
{
    internal class Rupees : USD
    {
        public double r;
        public Rupees(double a) : base(a)
        {
            r = a * 81.50;
        }

        public override string ToString()
        {
            return r.ToString();
        }
    }
}
