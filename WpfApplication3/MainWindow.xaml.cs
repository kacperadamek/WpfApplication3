﻿using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows;

namespace KursPodstawowyRemastered
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        #region Konstruktory Klasy
        // Bazowy konstruktor klasy
        public MainWindow()
        {
            InitializeComponent();
            // Instrukcje();
            Kolekcje();
        }
        #endregion



        #region Enumy

        // Definicja Enum
        enum StanyPostaci
        {
            Biega = 10,
            Skacze = 20,
            Plywa = 30
        }

        void Enumy()
        {
            // Ustawienie "wskaźnika / wartości"
            StanyPostaci stany = StanyPostaci.Biega;

            // Zastosowanie enum w switch
            switch (stany)
            {
                case StanyPostaci.Biega:

                    break;
                case StanyPostaci.Skacze:
                    break;
                case StanyPostaci.Plywa:
                    break;
                default:
                    break;
            }

            // Utworzenie kolekcji (Array) z enum
            var wartosciEnum = Enum.GetValues(typeof(StanyPostaci));

        }


        #endregion

        #region Zmienne i ich typy

        #region Popularne typy zmiennych

        byte malaLiczba;                    // (1 bajt)     | od 0 do 255
        short liczbaCalkowitaKrotka;        // (2 bajty)    | od -32 768 do 32  767
        int liczbaCalkowita;                // (4 bajty)    | od -2 147 483 448 do 2 147 483 448
        long liczbaCalkowitaDluga;          // (8 bajtów)   | od -9 223 372 036 854 777 808 do -9 223 372 036 854 777 807
        float liczbaZmiennoprzecinkowa;     // (4 bajty)
        double liczbaZmiennoprzecinkowa2;   // (8 bajtów)
        bool prawdaFalsz;                   // (1 bajt)
        string tekst;
        object obiekt;                       // Przechowuje każdy obiekt

        #endregion

        #region Bardziej "zaawansowane" typy zmiennych

        char ZnakUnicode = 'Z';             // Reprezentuje jeden znak
        sbyte LiczbaCalkowita;
        Int16 LiczbaCalkowita16Bitowa;      // = short
        Int32 LiczbaCalkowita32Bitowa;      // = int
        Int64 LiczbaCalkowita64Bitowa;      // = long
        ushort liczbaCalkowitaKrotkaDodatnia;
        uint liczbaCalkowitaDodatnia;
        ulong liczbaCalkowitaDlugaDodatnia;

        #endregion

        #endregion

        #region Stale

        const float PI = 3.14f;
        const string naszeA = "aaaaa";

        #endregion

        #region Zasiegi zmiennych

        public int zmiennaPubliczna = 1; // Zmienna publiczna - wszyscy mają do niej dostęp
        internal int zmiennaInternal = 1; // Zmienna wewnętrzna - dostęp tylko z poziomu własnego programu (nie najszczęśliwsza interpretacja)
        private int zmiennaPrywatna = 1; // Zmienna prywatna - zasięg tylko w obrębie klasy


        #endregion

        int liczbaPolubien = 10; // Testowa zmienna
        float r = 10f; // Zmienna pomocnicza

        #region Kolekcje
        // Definicja tablicy z elementami typu int
        int[] naszaTablica = new int[10];
        // Definicja listy z elementami typu int
        List<int> naszaList = new List<int>();

        void Kolekcje()
        {
            // Dodawanie wartości do tablicy
            naszaTablica[0] = 1;
            naszaTablica[1] = 69;
            naszaTablica[2] = 33;

            // Dodawanie elementów do listy
            naszaList.Add(1);
            naszaList.Add(96);
            naszaList.Add(33);

            // Dodawanie źródła danych (kolekcji) do naszego ListView
            listView.ItemsSource = naszaList;
        }


        #endregion

        #region Instrukcje

        private void Instrukcje()
        {
            testowyTextBlock.Text = "Start";
            var warunek = true;

            // stan kobiecej drukarki
            var liczba = 150; // 0 = nie działa; 1 = działa; 2 = może;

            //testowyTextBlock.Text = (warunek) ? "3" : "0";
            #region Instrukcja IF
            if (liczba > 1 && liczba < 100)
            {
                testowyTextBlock.Text = "Prawda 1";
            }
            else if (liczba > 100 && liczba < 200)
            {
                testowyTextBlock.Text = "Prawda 2";
            }
            else
            {
                testowyTextBlock.Text = "Fałsz";
            }
            #endregion

            #region Instrukcja Switch

            switch (liczba)
            {
                case 0:
                    testowyTextBlock.Text = "Nie działa";
                    break;
                case 1:
                    testowyTextBlock.Text = "Działa";
                    break;
                case 2:
                    testowyTextBlock.Text = "MOŻE!!!";
                    break;

                default:
                    testowyTextBlock.Text = "UPS !!!";
                    break;
            }

            #endregion

            #region Instrukcja FOR

            for (int i = 0; i < 10; i++)
            {
                testowyTextBlock.Text = i.ToString();
            }

            #endregion
        }

        #endregion

        #region Metody Pomocnicze

        public void Operatory()
        {
            #region Zmienne pomocnicze

            int zmiennaLiczbowa1 = 10;
            int zmiennaLiczbowa2 = 20;

            bool zmiennaLogiczna1 = true;
            bool zmiennaLogiczna2 = false;

            #endregion

            // Operatory matematyczne
            var wynik1 = zmiennaLiczbowa1 + zmiennaLiczbowa2; // opeartor dodawania
            var wynik2 = zmiennaLiczbowa1 - zmiennaLiczbowa2; // opeartor różnicy (odejmowania)
            var wynik3 = zmiennaLiczbowa1 * zmiennaLiczbowa2; // opeartor mnożenia
            var wynik4 = zmiennaLiczbowa1 / zmiennaLiczbowa2; // opeartor dzielenia
            var wynik5 = zmiennaLiczbowa1 % zmiennaLiczbowa2; // opeartor dzielenia z resztą

            var wynik6 = zmiennaLiczbowa1++; // operator inkrementacji
            var wynik7 = zmiennaLiczbowa1--; // operator dekrementacji

            // Operatory relacji (najpopularniejsze)
            var wynik8 = (zmiennaLiczbowa1 == zmiennaLiczbowa2); // operator porównania
            var wynik9 = (zmiennaLiczbowa1 != zmiennaLiczbowa2); // operator negacji
            var wynik10 = (zmiennaLiczbowa1 > zmiennaLiczbowa2); // operator A większe od B (większości)
            var wynik11 = (zmiennaLiczbowa1 >= zmiennaLiczbowa2); // operator A większe lub równe B
            var wynik12 = (zmiennaLiczbowa1 < zmiennaLiczbowa2); // operator A mniejsze od B (mniejszości)
            var wynik13 = (zmiennaLiczbowa1 <= zmiennaLiczbowa2); // operator A mniejsze lub równe B

            // Operatory logiczne (najpopularniejsze)
            var wynik14 = (zmiennaLogiczna1 && zmiennaLogiczna2); // zwróci [true] gdy A i B mają wartośc true (suma logiczna)
            var wynik15 = (zmiennaLogiczna1 || zmiennaLogiczna2); // zwróci [true] gdy A lub B mają wartośc true (alternatywa logiczna)
            var wynik16 = (!zmiennaLogiczna1); // zwróci [true] A ma wartośc false (negacja logiczna)
            var wynik17 = (!zmiennaLogiczna1); // zwróci [true] A ma wartośc false (negacja logiczna)



            // Operatory matematyczne - sztuczki czyli skracanie zapisu
            zmiennaLiczbowa1 += 3; // skraca zapis => A = A + 3
            zmiennaLiczbowa1 = +3; // skraca zapis => A = 3 + A
            zmiennaLiczbowa1 = -3; // skraca zapis => A = 3 - A
            zmiennaLiczbowa1 *= 3; // skraca zapis => A = 3 * A

        }

        //Metoda
        public void PierwszaMetoda()
        {
            var wynik = PI * r * r;

            DrugaMetoda("aaaa");

            if (wynik > 30)
            {
                int klamrowaPulapka = 1;
            }

            // var wynik2 = PI + klamrowaPulapka; // BAAD!!!


            var naszPierwszyVar = liczbaPolubien; // magiczny var-1
        }

        /// <summary>
        /// To jest testowa metoda która przyjmuje zawsze 'aaaaa'
        /// </summary>
        /// <param name="a">Super Parametr 'aaaa'</param>
        public void DrugaMetoda(string a)
        {
            var naszDrugiVar = liczbaPolubien; // magiczny var-2
        }
        #endregion


    }
}