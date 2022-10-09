using DierenDOTNET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace DierenDOTNET
{
    internal class Koe : Dier
    {
        public SoundPlayer KoesoundPlayer;

        public Koe(int gewicht) : base(gewicht)
        {
        }

        public string meu()
        {
            KoesoundPlayer = new SoundPlayer(@"C:\Users\ajari\source\repos\DierenDOTNET\DierenDOTNET\obj\koegeluid.wav");
            KoesoundPlayer.Play();
            return base.Zegt("meuu");
        }

        public override string ToString()
        {
            return meu();
        }


    }
}
