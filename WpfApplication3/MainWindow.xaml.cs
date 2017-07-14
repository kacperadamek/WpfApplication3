using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }

    #region Zasieng zmiennych

    public int zmiennaPubliczna = 1;
    internal int zmiennaInternal = 1;
    private int zmiennaPrywatna = 1;

    public void PierwszaMetoda()
    {






        #region
        
       private void Instrukcje()
    {
        testowyTextBlock.Text = "Start";
        var warunek = true;
        var liczba = 1;

//        testowyTextBlock.Text = (warunek) ? "3" : "0";

        if(liczba >1)
        {
            testowyTextBlock.Text = "Prawda";
        }
            else
        {
            testowyTextBlock.Text = "Fałsz";
        }

        #region Instrukcja Switch
        
        switch (liczba)
        {
            case 0:
                testowyTextBlock.Text = "Nie Działa";
                break;
            case 2:
                testowyTextBlock.Text = "Działa";
                break;
            case 2:
                testowyTextBlock.Text = "Może!!!";
                break;

            default:
                break:
        }
        #endregion

        #region Istrukcja For

        for (int i = 0 ; i < lenght; i++)
        {
            testowyTextBlock.Text = i.ToString();
        }


        #region Kolekcje
        int[] naszaTablica = new int[10];

        List<int> naszList = new List<int>();

        void Kolekcje()
            {
            naszaTablica[0] = 45;
            naszaTablica[1] = 4546;
            naszaTablica[2] = 54;
            naszaTablica[3] = 14;
            naszaTablica[4] = 16;
            naszaTablica[5] = 17;
            naszaTablica[6] = 18;
            naszaTablica[7] = 19;
            naszaTablica[8] = 11;
            naszaTablica[9] = 12;

            naszList.Add(1);
            naszList.Add(55);
            naszList.Add(45);


            ListView.ItemsSourceProperty = naszList;
            
               
            
                    
                    
                    
                    
                      
        }



    }










}














}
