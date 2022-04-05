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
        //Kiek viso gyvunu
        //Kiek kokios rusies gyvunu yra
        
       
    }
}
