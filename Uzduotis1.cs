using System;
using System.Collections.Generic;
using System.Text;

namespace Tema_07_STRUCT_UniTest
{
    public struct Uzduotis1
    {
        public int Trimestras1;
        public int Trimestras2;
        public int Trimestras3;

        public Uzduotis1(int trimestras1, int trimestras2, int trimestras3)
        {
            Trimestras1 = trimestras1;
            Trimestras2 = trimestras2;
            Trimestras3 = trimestras3;
        }
        
        public int MetinisVidurkis()
        {
            return (Trimestras1 + Trimestras2 + Trimestras3) / 3;
        }               
    }
}
