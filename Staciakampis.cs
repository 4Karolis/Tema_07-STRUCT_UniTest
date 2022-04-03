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

        public void Plotas(double ilgis, double plotis)
        {
            double plotas = ilgis * plotis;
            Console.WriteLine($"\nStaciakampio ilgis {ilgis}, plotis {plotis} \nPLOTAS: {plotas}");
        }
    }
}
