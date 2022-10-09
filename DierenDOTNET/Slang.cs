using DierenDOTNET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Dieren
{
    internal class Slang : Dier
    {
        public SoundPlayer SlangsoundPlayer;
        public Slang(int gewicht) : base(gewicht)
        {
        }

        public string wsss()
        {
            SlangsoundPlayer = new SoundPlayer(@"C:\Users\ajari\source\repos\DierenDOTNET\DierenDOTNET\obj\slanggeluid.wav");
            SlangsoundPlayer.Play();
            return base.Zegt("wssssssss");
        }

        public override string ToString()
        {
            return wsss();
        }
    }
}
