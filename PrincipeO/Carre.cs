using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipeO
{
    public class Carre : Forme
    {
        public int Cote { get; set; }

        public override int Surface => Cote*Cote; /** La classe Rectangle renvoit elle même le calcul de sa surface pour le respect du principe O*/
    }
}
