using System;
using System.Collections.Generic;
using System.Text;

namespace Tema_08___Struckts___UnitTests
{
    public struct Uzduotis1
    {
        public int Trimestras1;
        public int Trimestras2;
        public int Trimestras3;
        //public int Vidurkis;

        public Uzduotis1(int trimestras1, int trimestras2, int trimestras3)
        {
            Trimestras1 = trimestras1;
            Trimestras2 = trimestras2;
            Trimestras3 = trimestras3;
        }
        public int MetinisVidurkis()
        {
            return ((Trimestras1 + Trimestras2 + Trimestras3) / 3);
        }
        public Uzduotis1(int pazimys1, int trimestras1, int trimestras2, int trimestras3)//, int vidurkis)
        {
            Trimestras1 = trimestras1;
            Trimestras2 = trimestras2;
            Trimestras3 = trimestras3;
            //Vidurkis = (trimestras1 + trimestras2 + trimestras3 / 3);
        }

        //public void IsveskVidurki()
        //{
        //    //Console.WriteLine($"Trimestru vidurkis: {(Trimestras1 + Trimestras2 + Trimestras3) / 3) }";
        //    Console.WriteLine($"Trimestru vidurkis: {(trimestras1 + Trimestras2 + Trimestras3) / 3)}");
        //}
    }
}
