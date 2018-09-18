using System;
using System.Collections.Generic;
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

namespace NumericalV.Views
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class GraphicsPage : Page
    {
        public GraphicsPage()
        {
            this.InitializeComponent();
        }

        private void BackBiseccionClick1(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(BiseccionPage));
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (e.Parameter != null)
            {
                var b =  (NumericalV.Models.AlgoritmParams) e.Parameter;
                    greeting.Text += b.Expression;
            }
            else
            {
                greeting.Text = "No se paso correctamente el parametro";
            }
            base.OnNavigatedTo(e);
        }
    }
}
