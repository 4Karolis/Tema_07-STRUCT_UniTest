using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tema_07_STRUCT_UniTest
{
    public struct Studentass
    {
        public List<double> Pazymiai1; // deklaravus INT meta apvalu skaiciu
        public List<double> Pazymiai2;
        public List<double> Pazymiai3;
                
        public Studentass(List<double> pazymiai1, List<double> pazymiai2, List<double> pazymiai3)
        {

            Pazymiai1 = pazymiai1;
            Pazymiai2 = pazymiai2;
            Pazymiai3 = pazymiai3;
        }

        //public void SemestroVidurkis(List<int> pazymiai1)
        //{
        //    int suma = 0;
        //    for (int i = 0; i < pazymiai1.Count; i++)
        //    {
        //        suma += suma;
        //    }
        //    //suma = suma;
        //    double semestroVidurkis = suma / pazymiai1.Count;
        //    //double semestroVidurkis = pazymiai1;
        //    Console.WriteLine($"Pirmo semestro pazymiu vidurkis: {semestroVidurkis}");
        //}
        public double SemestroVidurkis1 (List<double> pavadinimas)
        {
            double suma = 0;            
            for (int i = 0; i < pavadinimas.Count; i++)
            {
                suma = suma + pavadinimas[i];
            }
            double semestroVidurkis1 = suma / pavadinimas.Count;
            Console.WriteLine($"Pirmo semestro pazymiu vidurkis: {semestroVidurkis1}");
            return semestroVidurkis1;
        }
        public double SemestroVidurkis2(List<double> pavadinimas)
        {
            double suma = 0;
            for (int i = 0; i < pavadinimas.Count; i++)
            {
                suma = suma + pavadinimas[i];
            }
            double semestroVidurkis2 = suma / pavadinimas.Count;
            Console.WriteLine($"Antro semestro pazymiu vidurkis: {semestroVidurkis2}");
            return semestroVidurkis2;
        }
        public double SemestroVidurkis3(List<double> pavadinimas)
        {
            double suma = 0;
            for (int i = 0; i < pavadinimas.Count; i++)
            {
                suma = suma + pavadinimas[i];
            }
            double semestroVidurkis3 = suma / pavadinimas.Count;
            Console.WriteLine($"Trecio semestro pazymiu vidurkis: {semestroVidurkis3}");
            return semestroVidurkis3;
        }

        public void MetinisVidurkis(double semestroVidurkis1, double semestroVidurkis2, double semestroVidurkis3)
        {
            double metinisVidurkis = (semestroVidurkis1 + semestroVidurkis2 + semestroVidurkis3) / 3;
            Console.WriteLine($"\nStudento metinis vidurkis: {metinisVidurkis}");
        }       
    }
}
