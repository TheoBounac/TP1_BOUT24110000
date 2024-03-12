using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipeO
{
    public class Rectangle : FormeAvecSurface /** Rectangle possede une surface donc herite de FormeAvecSurface*/
    {
        public int Hauteur { get; set; }
        public int Largeur { get; set; }

        public override int GetSurface()
        {
            return Hauteur*Largeur; /** La classe Rectangle renvoit elle même le calcul de sa surface pour le respect du principe O*/
        }
    }
}
