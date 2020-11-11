using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace pcBuilder
{
    public partial class MainPage : ContentPage
    {
       public IList<Componente> Componentes { get; set; }

        public MainPage()
        {

            InitializeComponent();

            Componentes = new List<Componente>();
            Componentes.Add(new Componente
            {
                Tipo = "Tarjeta Gráfica",
                Marca = "Nvidia",
                Modelo = "GTX 1070",
                Precio = 250,
            });
            Componentes.Add(new Componente
            {
                Tipo = "Tarjeta Gráfica",
                Marca = "Nvidia",
                Modelo = "GTX 1060",
                Precio = 250,
            });
            Componentes.Add(new Componente
            {
                Tipo = "Tarjeta Gráfica",
                Marca = "Nvidia",
                Modelo = "GTX 1080",
                Precio = 250,
            });
            BindingContext = this;
            
        }
    }  
}
