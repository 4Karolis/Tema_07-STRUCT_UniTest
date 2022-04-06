using System;
using System.Collections.Generic;
using System.Text;

namespace Tema_07_STRUCT_UniTest
{
    public struct Mokinys2
    {
        public List<int> Trimestras1;
        public List<int> Trimestras2;
        public List<int> Trimestras3;

        public Mokinys2(List<int> trimestras1, List<int> trimestras2, List<int> trimestras3)
        {
            Trimestras1 = trimestras1;
            Trimestras2 = trimestras2;
            Trimestras3 = trimestras3;
        }

        public int PirmoTrimestroVidurkis(List<int> trimestras1)
        {
            int suma = 0;
            for (int i = 0; i < trimestras1.Count; i++)
            {
                suma = suma + trimestras1[i];
            }
            int pirmoTrimestroVidurkis = suma / trimestras1.Count;
            Console.WriteLine($"Pirmo trimestro vidurkis: {pirmoTrimestroVidurkis}");
            return pirmoTrimestroVidurkis;
        }
        public int AntroTrimestroVidurkis(List<int> trimestras2)
        {
            int suma = 0;
            for (int i = 0; i < trimestras2.Count; i++)
            {
                suma = suma + trimestras2[i];
            }
            int antroTrimestroVidurkis = suma / trimestras2.Count;
            Console.WriteLine($"Antro trimestro vidurkis: {antroTrimestroVidurkis}");
            return antroTrimestroVidurkis;
        }
        public int TrecioTrimestroVidurkis(List<int> trimestras3)
        {
            int suma = 0;
            for (int i = 0; i < trimestras3.Count; i++)
            {
                suma = suma + trimestras3[i];

            }
            int trecioTrimestroVidurkis = suma / trimestras3.Count;
            Console.WriteLine($"Trecio trimestro vidurkis: {trecioTrimestroVidurkis}");
            return trecioTrimestroVidurkis;
        }
        public int MetinisPazymys(int pirmoTrimestroVidurkis, int antroTrimestroVidurkis, int trecioTrimestroVidurkis)
        {
            int metinisPazymys = (pirmoTrimestroVidurkis + antroTrimestroVidurkis + trecioTrimestroVidurkis) / 3;
            Console.WriteLine($"Metinis pazymys: {metinisPazymys}");
            return metinisPazymys;
        }
    }
}
