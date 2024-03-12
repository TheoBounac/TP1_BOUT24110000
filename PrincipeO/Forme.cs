using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipeO
{
    public abstract class Forme
    {
        public abstract int Surface {  get; }   /* Le calcul des surfaces est passe en methode abstraite pour respecter le principe O*/
    }
}
