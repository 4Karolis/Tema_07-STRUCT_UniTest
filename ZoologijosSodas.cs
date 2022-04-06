using System;
using System.Collections.Generic;
using System.Text;

namespace Tema_07_STRUCT_UniTest
{
    public struct ZoologijosSodas
    {
        public string Pavadinimas;
        public string Adresas;
        public List<Gyvunas> GyvunuSarasas;

        public ZoologijosSodas(string pavadinimas, string adresas, List<Gyvunas> gyvunuSarasas)
        {
            Pavadinimas = pavadinimas;
            Adresas = adresas;
            GyvunuSarasas = gyvunuSarasas;
        }
        //Kiek viso gyvunu [+]
        //Kiek kokios rusies gyvunu yra [-]

        public void SkaiciuotiGyvunus()
        {
            List<string> rusis = new List<string>();
            List<int> count = new List<int>();

            for (int i = 0; i < GyvunuSarasas.Count; i++)
            {
                if (rusis.Contains(GyvunuSarasas[i].Rusis))
                {
                    count[rusis.IndexOf(GyvunuSarasas[i].Rusis)]++;
                }
                else
                {
                    rusis.Add(GyvunuSarasas[i].Rusis);
                    count.Add(1);
                }
                for (int j = 0; j < rusis.Count; j++)
                {
                    Console.WriteLine($"{rusis[j]} yra {count[j]} vnt.");
                }
            }

        }

    }
}
