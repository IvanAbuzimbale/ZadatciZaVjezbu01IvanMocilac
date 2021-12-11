using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadatciZaVjezbu01IvanMocilac
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] niz = new int[5];

            Console.WriteLine("Upišite 5 cijelih brojeva");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Upišite " + (i+1) + ". broj: ");
                string s = Console.ReadLine();
                niz[i] = Convert.ToInt32(s);
            }

            KlasaC c = new KlasaC();
            int zbroj = c.Zbroj(niz);
            Console.WriteLine("Zbroj zadanih brojeva je: " + zbroj);
            double prosjek = c.Prosjek(niz);
            Console.WriteLine("Prosjek zadanih projeva je: " + prosjek);
            Console.ReadKey();
        }
    }
}
