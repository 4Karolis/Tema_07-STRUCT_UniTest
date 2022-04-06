using System;
using System.Collections.Generic;
using System.Text;

namespace Tema_07_STRUCT_UniTest
{
    public struct Saskaita
    {
        public int SaskNr;
        public int Viso;

        public Saskaita(int saskNr, int viso)
        {
            SaskNr = saskNr;
            Viso = viso;
        }
    }
}
