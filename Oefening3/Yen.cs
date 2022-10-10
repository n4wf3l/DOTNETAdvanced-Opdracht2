using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening3
{
    internal class Yen : USD
    {
        public double y;
        public Yen(double a) : base(a)
        {
            y = a * 1.02;
        }

        public override string ToString()
        {
            return y.ToString();
        }
    }
}
