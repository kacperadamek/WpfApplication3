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

        if(warunek)
        {
            testowyTextBlock.Text = "prawda";
        }
else
        {
            testowyTextBlock.Text = "Fałsz";
        }
          
    }










    }














}
