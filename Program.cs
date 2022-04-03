using System;

namespace Tema_07_STRUCT_UniTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region STRUCTS teorija

            //// BE KONSTRUKTORIAUS
            //Person person;

            //person.Name = "Petras";
            //person.LastName = "Petrauskas";
            //person.Age = 28;
            //person.SayMyFullName();

            //Person person2;

            //person2.Name = "Jonas";
            //person2.LastName = "Jonauskas";
            //person2.Age = 30;
            //person2.SayMyFullName();

            ////SU KONSTRUKTORIUM
            ////add.missing
            //Person person3 = new Person("Petras_CTOR", "Petrauskas_CTOR", 84);
            //person3.SayMyFullName();

            //#endregion

            //#region UZDUOTYS
            ////BE konstruktoriaus:
            //Uzduotis1 uzduotis1;
            //uzduotis1.Trimestras1 = 8;
            //uzduotis1.Trimestras2 = 10;
            //uzduotis1.Trimestras3 = 6;
            //int vidurkis = uzduotis1.MetinisVidurkis();

            ////SU konstruktorium
            //Uzduotis1 uzduotis1Ctor = new Uzduotis1(8, 10, 6);
            //uzduotis1Ctor.MetinisVidurkis();

            #endregion

            #region UnitTest

            #endregion

            //----------------------------------------------- 1 UZDUOTIS ---------------------------------------

            //Mokinys1 mokinys1Ctor = new Mokinys1("Karolis", "Tarasevicius", "2022.02.28", "2022.10.21");
            //mokinys1Ctor.SayMyInfo();

            //----------------------------------------------- 2 UZDUOTIS ---------------------------------------

            //BibliotekosKnyga bibliotekosKnyga = new BibliotekosKnyga(01, "Mobis Dikas", "Karlosas", "2022.01.25");
            //bibliotekosKnyga.BibliotekosPrograma(kiekDienu);

            //----------------------------------------------- 3 UZDUOTIS ---------------------------------------

            Staciakampis staciakampis1 = new Staciakampis();
            staciakampis1.Plotas(11, 25);

            Staciakampis staciakampis2 = new Staciakampis();
            staciakampis1.Plotas(140, 69);

            Staciakampis staciakampis3 = new Staciakampis();
            staciakampis1.Plotas(10, 3);

            //----------------------------------------------- 4 UZDUOTIS ---------------------------------------



            //----------------------------------------------- 5 UZDUOTIS ---------------------------------------



            //----------------------------------------------- 6 UZDUOTIS ---------------------------------------



            //----------------------------------------------- 7 UZDUOTIS ---------------------------------------


        }
        //=============================================================
        public static decimal CalculateTax(decimal income)
        {
            decimal result = 0;
            if (income <= 40000)
            {
                result = income * 0.05m;
            }
            else if (income > 40000 && income <= 100000)
            {
                result = income * 0.15m;
            }
            else
            {
                result = income * 0.25m;
            }
            return result;
        }
    }
}
