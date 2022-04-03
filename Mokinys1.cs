using System;
using System.Collections.Generic;
using System.Text;

namespace Tema_07_STRUCT_UniTest
{
    public struct Mokinys1
    {
        public string Vardas;
        public string Pavarde;
        public string KursoPradzia;
        public string KursoPabaiga;

        public Mokinys1(string vardas, string pavarde, string kursoPradzia, string kursoPabaiga)
        {
            Vardas = vardas;
            Pavarde = pavarde;
            KursoPradzia = kursoPradzia;
            KursoPabaiga = kursoPabaiga;
        }
        public void SayMyInfo()
        {
            Console.WriteLine($"Mokinio vardas: {Vardas} \nPavarde: {Pavarde} \nKursa pradejo: {KursoPradzia} \nKursa baigs: {KursoPabaiga}");
        }
    }
}
