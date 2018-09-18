using NumericalV.Models;
using NumericalV.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace NumericalV
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class BiseccionPage : Page
    {
        public AlgoritmParams Esend { get; set; }

        public BiseccionPage()
        {
            this.InitializeComponent();
        }

        private void BackMainClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void GraphClick(object sender, RoutedEventArgs e)
        {
            if (Esend!=null)
            {
                this.Frame.Navigate(typeof(GraphicsPage), Esend);
            }
        }

        private void CalcButtonClick(object sender, RoutedEventArgs e)
        {
            RootsClassLibrary.Biseccion b = new RootsClassLibrary.Biseccion();
            b.Expresion = this.ExpresionVar.Text;
            b.ValStarta1 = this.ValaVar.Text;
            b.ValStartb1 = this.ValbVar.Text;
            b.Iteration = Convert.ToInt32(this.Iterations.Text);
            b.Tolerance = Convert.ToDouble(this.ToleranceVar.Text);

            var items = b.Solucion();

            ObservableCollection<Biseccion> bt = new ObservableCollection<Biseccion>();

            foreach (var item in items)
            {
                bt.Add(new Biseccion(item[0],item[1], item[2], item[3], item[4], item[5], item[6], item[7]));
            }

            BiseccionTable.ItemsSource = bt;
            Esend = new AlgoritmParams(b.Expresion, Convert.ToDouble(b.ValStarta1), Convert.ToDouble(b.ValStartb1));

            this.RootVar.Text = b.Root.ToString();
        }


        private void CleanButtonClick(object sender, RoutedEventArgs e)
        {
            BiseccionTable.ItemsSource=null;
        }
    }

}
