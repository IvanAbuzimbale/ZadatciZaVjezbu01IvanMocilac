using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadatciZaVjezbu01IvanMocilac
{
    class KlasaC
    {
        public int Zbroj(int[] niz)
        {
            int suma = 0;
            for (int i = 0; i < niz.Length; i++)
            {
                suma = suma + niz[i];
            }
            return suma;
        }

        public double Prosjek(int[] niz)
        {
            int suma = 0;
            for (int i = 0; i < niz.Length; i++)
            {
                suma = suma + niz[i];
            }
            return (double)suma / niz.Length;
        }
    }
}
