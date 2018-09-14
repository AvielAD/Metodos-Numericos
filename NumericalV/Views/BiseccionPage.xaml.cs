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
        public BiseccionPage()
        {
            this.InitializeComponent();
            ObservableCollection<Biseccion> _pets = new ObservableCollection<Biseccion>();
            _pets.Add(new Biseccion("Gato", "Animal", "Desc", "Desc", "Desc", "Desc", "Desc", "Desc"));
            _pets.Add(new Biseccion("Perro", "Animal", "Desc", "Desc", "Desc", "Desc", "Desc", "Desc"));
            _pets.Add(new Biseccion("Pavo", "Animal", "Desc", "Desc", "Desc", "Desc", "Desc", "Desc"));
            _pets.Add(new Biseccion("Pitbull", "Animal", "Desc", "Desc", "Desc", "Desc", "Desc", "Desc"));

            this.TableTest.ItemsSource = _pets;
        }

        private void BackMainClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void GraphClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(GraphicsPage));
        }
    }

}
