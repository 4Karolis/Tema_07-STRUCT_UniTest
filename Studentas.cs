using System;
using System.Collections.Generic;
using System.Text;

namespace Tema_07_STRUCT_UniTest
{
    public struct Studentas
    {
        public int ID;
        public bool IskaitosRezultatas;

        public Studentas(int iD, bool iskaitosRezultatas)
        {
            ID = iD;
            IskaitosRezultatas = iskaitosRezultatas;
        }

        //public List<int> IDList = new List<int>();
        //public List<bool> IskaitosRezultatai = new List<bool>();

        //public int GetStudentID()
        //{
        //    return ID;
        //}

        //public bool GetBool()
        //{
        //    return IskaitosRezultatas;
        //}
        public struct ColumnData
        {
            public int ID;
            public bool Blevyzga;

            public ColumnData(int iD, bool blevyzga)
            {
                ID = iD;
                Blevyzga = blevyzga;
            }
        }

    }
}
