using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace pcBuilder
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Recibo : ContentPage
    {

        public Recibo(ObservableCollection<Grafica> pedidoGraficas)
        {
            InitializeComponent();
            Console.WriteLine(pedidoGraficas.Count);
        }
    }
}