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
        public double KiekDienu;

        public BibliotekosKnyga(int iD, string pavadinimas, string skaitytojoVardas, string paemimoData, double kiekDienu)
        {
            ID = iD;
            Pavadinimas = pavadinimas;
            SkaitytojoVardas = skaitytojoVardas;
            PaemimoData = paemimoData;
            KiekDienu = kiekDienu; // kike dieno program cs parasyt programa, kad skaiciuotu
            //SiosDienosData = siosDienosData;
        }
        public static double Uzlaike(DateTime pavadinims, DateTime neu, double pavadinimas)
        {
            DateTime test = new DateTime(2022, 01, 25);
            //DateTime.Today;
            double kiekDienu = test.Subtract(DateTime.Today).TotalDays;
            return kiekDienu;
        }

        //public static void Uzlaikymas()
        //{

        //}

        public void BibliotekosPrograma(/*DateTime pavadinimas, DateTime neu, double pavadinimas*/)
        {
            //double kiekDienu = Uzlaike(DateTime.Today(-69), DateTime.Now, KiekDienu);
            Console.WriteLine($"\nID: {ID} \nPavadinimas: {Pavadinimas}\n");
            Console.WriteLine($"Skaitytojo vardas: {SkaitytojoVardas} \nKnyga paimta: {PaemimoData}\nZulikas knyga uzlaike net: {KiekDienu} dienu!");
        }
    }
}
