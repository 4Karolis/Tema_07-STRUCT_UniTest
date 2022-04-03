using System;
using System.Collections.Generic;
using System.Text;

namespace Tema_07_STRUCT_UniTest
{
    public struct BibliotekosKnyga
    {
        public int ID;       
        public string Pavadinimas;
        public string SkaitytojoVardas;
        public string PaemimoData;
        //public DateTime SiosDienosData;
        //public double KiekDienu;

        public BibliotekosKnyga(int iD, string pavadinimas, string skaitytojoVardas, string paemimoData)
        {
            ID = iD;
            Pavadinimas = pavadinimas;
            SkaitytojoVardas = skaitytojoVardas;
            PaemimoData = paemimoData;
            //KiekDienu = kiekDienu;
            //SiosDienosData = siosDienosData;
        }
        public static double Uzlaike()
        {
            DateTime test = new DateTime(2022, 01, 25);
            double kiekDienu = test.Subtract(DateTime.Today).TotalDays;
            return kiekDienu;
        }

        public void BibliotekosPrograma(double kiekDienu)
        {
            
            Console.WriteLine($"\n ID: {ID} \nPavadinimas: {Pavadinimas}\n");
            Console.WriteLine($"Skaitytojo vardas: {SkaitytojoVardas} \nKnyga paimta: {PaemimoData}\nZulikas knyga uzlaike net: {kiekDienu} dienu!");
        }
    }
}
