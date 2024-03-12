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
        public int CalculSurface(FormeAvecSurface forme)
        {
            return forme.GetSurface(); /** Renvoit la surface dune forme avec surface mise en parametre*/
        }
    }
}
