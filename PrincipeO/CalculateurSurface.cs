using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace PrincipeO
{
    public class CalculateurSurface
    {
        public int CalculTouteSurface(IEnumerable<Forme> formes) /** Calcul la somme des aires de toute les formes existantes*/
        {
            int res = 0;
            foreach (var forme in formes)
            {
                res += forme.Surface;
            }
            return res;
        }
        /** A enlever pour respceter le principe O
        private int CalculSurface(Forme forme )
        {
            return forme switch
            {
                Rectangle r => r.Hauteur * r.Largeur,
                Carre c => c.Cote * c.Cote,
                _ => throw new NotImplementedException()
            };

        }*/
    }
}
