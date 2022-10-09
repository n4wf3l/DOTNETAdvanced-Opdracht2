using DierenDOTNET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Dieren
{
    internal class Varken : Dier
    {
        public SoundPlayer VarkensoundPlayer;
        public Varken(int gewicht) : base(gewicht)
        {
        }
        public string Roor()
        {
            VarkensoundPlayer = new SoundPlayer(@"C:\Users\ajari\source\repos\DierenDOTNET\DierenDOTNET\obj\koegeluid.wav");
            VarkensoundPlayer.Play();
            return base.Zegt("rooor");
        }

        public override string ToString()
        {
            return Roor();
        }
    }
}
