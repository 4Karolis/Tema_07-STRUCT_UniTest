using System;
using System.Collections.Generic;
using System.Text;

namespace Tema_07_STRUCT_UniTest
{
    public struct Staciakampis
    {
        public double Ilgis;
        public double Plotis;

        public Staciakampis(double ilgis, double plotis)
        {
            Ilgis = ilgis;
            Plotis = plotis;
        }

        public void Plotas()
        {
            double plotas = Ilgis * Plotis;
            Console.WriteLine($"\nStaciakampio ilgis {Ilgis}, plotis {Plotis} \nPLOTAS: {plotas}");
        }
    }
}
