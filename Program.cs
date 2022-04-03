using System;

namespace Tema_08___Struckts___UnitTests
{
    class Program
    {
        static void Main(string[] args)
        {
            #region STRUCTS teorija

            // BE KONSTRUKTORIAUS
            Person person;

            person.Name = "Petras";
            person.LastName = "Petrauskas";
            person.Age = 28;
            person.SayMyFullName();

            Person person2;

            person2.Name = "Jonas";
            person2.LastName = "Jonauskas";
            person2.Age = 30;
            person2.SayMyFullName();

            //SU KONSTRUKTORIUM
            //add.missing
            Person person3 = new Person("Petras_CTOR", "Petrauskas_CTOR", 84);
            person3.SayMyFullName();

            #endregion

            #region UZDUOTYS
            //BE konstruktoriaus:
            Uzduotis1 uzduotis1;
            uzduotis1.Trimestras1 = 8;
            uzduotis1.Trimestras2 = 10;
            uzduotis1.Trimestras3 = 6;
            uzduotis1.Vidurkis = (Trimestras1 + Trimestras2 + Trimestras3) / 3) ;
            uzduotis1.IsveskVidurki();
            int vidurkis = MetinisVidurkis();

            #endregion

            #region UnitTest



            #endregion

        }
        public static decimal CalculatorTax(decimal income)
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
