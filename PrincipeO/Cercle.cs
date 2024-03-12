using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipeO
{
    public class Cercle : Forme
    {
        public int rayon { get; set; }
        private int pi = 3;
        public override int Surface => pi*rayon*rayon; /** On peut ajouter le calcul de la surface d un cercle directement dans la classe cercle que l on ajoute*/
    }
}
