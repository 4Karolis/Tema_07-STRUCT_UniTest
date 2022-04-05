using System;
using System.Collections.Generic;
using System.Text;

namespace Tema_07_STRUCT_UniTest
{
    public struct Rinkejai
    {
        //public List<Rinkejai> RinkejuSarasas;
        public int ID;
        public bool ArPrabalsavo;

        public Rinkejai(int iD, bool arPrabalsavo)
        {
            //RinkejuSarasas = rinkejuSarasas;
            ID = iD;
            ArPrabalsavo = arPrabalsavo;
        }

        public void BalsavimoStatistika(int ID, bool ArPrabalsavo)
        {
            Console.WriteLine($"Rinkejas (ID: {ID} prabalsavo {ArPrabalsavo}");
        }
    }
}
