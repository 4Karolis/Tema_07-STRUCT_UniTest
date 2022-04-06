﻿using System;
using System.Collections.Generic;

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

            //BibliotekosKnyga bibliotekosKnyga = new BibliotekosKnyga(01, "Mobis Dikas", "Karlosas", "2022.01.25", 75);
            //bibliotekosKnyga.BibliotekosPrograma();

            //----------------------------------------------- 3 UZDUOTIS ---------------------------------------

            //Staciakampis staciakampis1 = new Staciakampis(10, 5);
            //staciakampis1.Plotas();

            //Staciakampis staciakampis2 = new Staciakampis(140, 69);
            //staciakampis2.Plotas();

            //Staciakampis staciakampis3 = new Staciakampis(10, 3);
            //staciakampis3.Plotas();

            //----------------------------------------------- 4 UZDUOTIS ---------------------------------------

            //List<Studentas> StudentList = new List<Studentas>();

            //Studentas studentas1 = new Studentas(1, true);
            //Studentas studentas2 = new Studentas(2, false);
            //Studentas studentas3 = new Studentas(3, false);
            //Studentas studentas4 = new Studentas(4, true);
            //Studentas studentas5 = new Studentas(5, false);

            //StudentList.Add(studentas1);
            //StudentList.Add(studentas2);
            //StudentList.Add(studentas3);
            //StudentList.Add(studentas4);
            //StudentList.Add(studentas5);

            //for (int i = 0; i < StudentList.Count; i++)
            //{
            //    Console.WriteLine($"\n{StudentList[i].ID}");
            //    Console.WriteLine(StudentList[i].IskaitosRezultatas);
            //}

            //////SAME tik su FOREACH
            ////foreach (var item in StudentList)
            ////{
            ////    Console.WriteLine($"\n{item.ID}");
            ////    Console.WriteLine(item.IskaitosRezultatas);
            ////}            

            //----------------------------------------------- 5 UZDUOTIS ---------------------------------------

            //List<double> pazymiai1 = new List<double> { 4, 7, 6, 9, 10, 8, 5 };
            //List<double> pazymiai2 = new List<double> { 10, 9, 7, 6, 8, 10, 7 };
            //List<double> pazymiai3 = new List<double> { 3, 5, 7, 4, 6, 8, 5, 6 };

            //Studentass studentass = new Studentass(pazymiai1, pazymiai2, pazymiai3);
            //double semestroVidurkis1 = studentass.SemestroVidurkis1(pazymiai1);
            //double semestroVidurkis2 = studentass.SemestroVidurkis1(pazymiai2);
            //double semestroVidurkis3 = studentass.SemestroVidurkis1(pazymiai3);
            //studentass.MetinisVidurkis(semestroVidurkis1, semestroVidurkis2, semestroVidurkis3);

            //----------------------------------------------- 6 UZDUOTIS ---------------------------------------

            //List<Rinkejai> Rinkejai = new List<Rinkejai>();
            //var random = new Random();
            //for (int i = 0; i < 10; i++)
            //{
            //    Rinkejai.Add(new Rinkejai(random.Next(1, 10), random.Next(2) == 0));
            //}
            //Console.WriteLine("|           Rinkejo ID:        -             Ar prabalsavo?    |");
            //Console.WriteLine("|==============================================================|");
            //foreach (var item in Rinkejai)
            //{
            //    Console.WriteLine($"|               {item.ID}              -                {item.ArPrabalsavo}           |");
            //}
            //Console.WriteLine("|==============================================================|");

            //----------------------------------------------- 7 UZDUOTIS ---------------------------------------

            Gyvunas gyvunas1 = new Gyvunas("Oposumas", "Zinduolis");
            Gyvunas gyvunas2 = new Gyvunas("Keune", "Zinduolis");
            Gyvunas gyvunas3 = new Gyvunas("Pleksne", "Zuvis");
            Gyvunas gyvunas4 = new Gyvunas("Peleda", "Paukstis");
            Gyvunas gyvunas5 = new Gyvunas("Pingvinas", "Paukstis");
            Gyvunas gyvunas6 = new Gyvunas("Zebenkstis", "Zinduolis");
            Gyvunas gyvunas7 = new Gyvunas("Krokodilas", "Reptilija");

            int randomNumber = GenerateRandomNumber();

            //RANDOM FILL
            List<Gyvunas> gyvunuSarasas = new List<Gyvunas> {gyvunas1, gyvunas2, gyvunas3, gyvunas4, gyvunas5, gyvunas6, gyvunas7};

            for (int i = 0; i < 5; i++)// buvo 7
            {
                RandomlyFillList(gyvunuSarasas, randomNumber, gyvunas1);
                RandomlyFillList(gyvunuSarasas, randomNumber, gyvunas2);
                RandomlyFillList(gyvunuSarasas, randomNumber, gyvunas3);
                RandomlyFillList(gyvunuSarasas, randomNumber, gyvunas4);
                RandomlyFillList(gyvunuSarasas, randomNumber, gyvunas5);
                RandomlyFillList(gyvunuSarasas, randomNumber, gyvunas6);
                RandomlyFillList(gyvunuSarasas, randomNumber, gyvunas7);
            }

            PrintOutGyvunaiSarasas(gyvunuSarasas);
            int kiekYraGyvunu = gyvunuSarasas.Count;
            Console.WriteLine(kiekYraGyvunu);

            //AddRandomGyvunas(randomNumber, gyvunuSarasas, gyvunas1);
            //AddRandomGyvunas(randomNumber, gyvunuSarasas, gyvunas2);
            //AddRandomGyvunas(randomNumber, gyvunuSarasas, gyvunas3);
            //AddRandomGyvunas(randomNumber, gyvunuSarasas, gyvunas4);
            //AddRandomGyvunas(randomNumber, gyvunuSarasas, gyvunas5);
            //AddRandomGyvunas(randomNumber, gyvunuSarasas, gyvunas6);
            //AddRandomGyvunas(randomNumber, gyvunuSarasas, gyvunas7);

            //ZoologijosSodas zoologijos = new ZoologijosSodas("Vilnius Zoo", "Ozo g. 25", gyvunuSarasas);

            //zoologijos.SkaiciuotiGyvunus();




            //List<Gyvunas> gyvunas = SkaiciuotiGyvunus(gyvunuSarasas);


            //RandomlyFillList(gyvunuSarasas, randomNumber, gyvunas1);
            //string skaiciuoti = SkaiciuotiGyvunus();
        }
        //=============================================================
        public void SkaiciuotiGyvunus(List<Gyvunas> gyvunuSarasas)
        {
            //List<Gyvunas> GyvunuSarasas = new List <Gyvunas>();
            List<string> rusis = new List<string>();
            List<int> count = new List<int>();

            for (int i = 0; i < gyvunuSarasas.Count; i++)
            {
                if (rusis.Contains(gyvunuSarasas[i].Rusis))
                {
                    count[rusis.IndexOf(gyvunuSarasas[i].Rusis)]++;
                }
                else
                {
                    rusis.Add(gyvunuSarasas[i].Rusis);
                    count.Add(1);
                }
                for (int j = 0; j < rusis.Count; i++)
                {
                    Console.WriteLine($"{rusis[j]} yra {count[j]} vnt.");
                }
            }
        }
        public static void RandomlyFillList(List<Gyvunas> GyvunuSarasas, int randomNumber, Gyvunas gyvunas)
        {
            randomNumber = GenerateRandomNumber();
            AddRandomGyvunas(randomNumber, GyvunuSarasas, gyvunas);
            //GyvunuSarasas.Sort();
        }
        public static /*List<Gyvunas>*/ void PrintOutGyvunaiSarasas(List<Gyvunas> GyvunuSarasas)
        {
            foreach (var item in GyvunuSarasas)
            {
                Console.WriteLine($"{item.Vardas} {item.Rusis}");
            }
            //return GyvunuSarasas;
        }
       
        public static void AddRandomGyvunas(int randomNumber, List<Gyvunas> ListName, Gyvunas gyvunas)
        {
            for (int i = 0; i < 15; i++)
            {
                ListName.Add(gyvunas);
            }
        }
        public static int GenerateRandomNumber()
        {
            Random rnd = new Random();
            int randomSkaicius = rnd.Next(15);
            return randomSkaicius;
        }
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
