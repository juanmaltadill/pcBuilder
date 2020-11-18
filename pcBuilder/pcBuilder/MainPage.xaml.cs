using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Xamarin.Forms;

namespace pcBuilder
{
    public partial class MainPage : ContentPage
    {
       public IList<Grafica> Graficas { get; set; }
       public IList<Procesador> Procesadores { get; set; }
       public IList<Ram> Rams { get; set; }
       public IList<Hdd> Hdds { get; set; }


        public MainPage()
        {

            InitializeComponent();
            var boxTapHandlerGraficas = new TapGestureRecognizer();
            boxTapHandlerGraficas.Tapped += onClick;
            frameGraficas.GestureRecognizers.Add(boxTapHandlerGraficas);

            var boxTapHandlerProcesadores = new TapGestureRecognizer();
            boxTapHandlerProcesadores.Tapped += onClick;
            frameProcesadores.GestureRecognizers.Add(boxTapHandlerProcesadores);

            var boxTapHandlerRams = new TapGestureRecognizer();
            boxTapHandlerRams.Tapped += onClick;
            frameRams.GestureRecognizers.Add(boxTapHandlerRams);

            var boxTapHandlerHdds = new TapGestureRecognizer();
            boxTapHandlerHdds.Tapped += onClick;
            frameHdds.GestureRecognizers.Add(boxTapHandlerHdds);

            Graficas = new List<Grafica>();
            Graficas.Add(new Grafica
            {
                Tipo = "Tarjeta Gráfica",
                Marca = "Nvidia",
                Modelo = "GTX 1070",
                Precio = 250,
            });
            Graficas.Add(new Grafica
            {
                Tipo = "Tarjeta Gráfica",
                Marca = "Nvidia",
                Modelo = "GTX 1060",
                Precio = 250,
            });
            Graficas.Add(new Grafica
            {
                Tipo = "Tarjeta Gráfica",
                Marca = "Nvidia",
                Modelo = "GTX 1080",
                Precio = 250,
            });
            listGraficas.BindingContext = this;

            Procesadores = new List<Procesador>();
            Procesadores.Add(new Procesador
            {
                Tipo = "Procesador",
                Marca = "Intel",
                Modelo = "i9",
                Velocidad = "4.5GHz",
                Precio = 250,
            });
            Procesadores.Add(new Procesador
            {
                Tipo = "Procesador",
                Marca = "Intel",
                Modelo = "i7",
                Velocidad = "3.5GHz",
                Precio = 250,
            });
            Procesadores.Add(new Procesador
            {
                Tipo = "Procesador",
                Marca = "Intel",
                Modelo = "i5",
                Velocidad = "2.5GHz",
                Precio = 250,
            });
            listProcesadores.BindingContext = this;

            Rams = new List<Ram>();
            Rams.Add(new Ram
            {
                Tipo = "Memoria RAM",
                Marca = "Corsair",
                Modelo = "158956",
                Velocidad = "2.5GHz",
                Precio = 250,
            });
            Rams.Add(new Ram
            {
                Tipo = "Memoria RAM",
                Marca = "Corsair",
                Modelo = "358721",
                Velocidad = "2.5GHz",
                Precio = 250,
            });
            Rams.Add(new Ram
            {
                Tipo = "Memoria RAM",
                Marca = "Corsair",
                Modelo = "96857412365",
                Velocidad = "2.5GHz",
                Precio = 250,
            });
            listRams.BindingContext = this;

            Hdds = new List<Hdd>();
            Hdds.Add(new Hdd
            {
                Tipo = "Tarjeta Gráfica",
                Marca = "Nvidia",
                Modelo = "GTX 1070",
                Capacidad = "500GB",
                Precio = 250,
            });
            Hdds.Add(new Hdd
            {
                Tipo = "Tarjeta Gráfica",
                Marca = "Nvidia",
                Modelo = "GTX 1060",
                Capacidad = "500GB",
                Precio = 250,
            });
            Hdds.Add(new Hdd
            {
                Tipo = "Tarjeta Gráfica",
                Marca = "Nvidia",
                Modelo = "GTX 1080",
                Capacidad = "500GB",
                Precio = 250,
            }) ;
            Stepper stepperHdds = new Stepper();
            var cantidad = stepperHdds.Value;
            listHdds.BindingContext = this;

            
        }

        private void onClick(object sender, EventArgs e)
        {
            if (sender.Equals(frameGraficas))
            {
                if (listGraficas.IsVisible == false)
                {
                    listGraficas.IsVisible = true;
                }
                else
                {
                    listGraficas.IsVisible = false;
                }
            }
            else if (sender.Equals(frameProcesadores))
            {
                if (listProcesadores.IsVisible == false)
                {
                    listProcesadores.IsVisible = true;
                }
                else
                {
                    listProcesadores.IsVisible = false;
                }
            }
            else if (sender.Equals(frameRams))
            {
                if (listRams.IsVisible == false)
                {
                    listRams.IsVisible = true;
                }
                else
                {
                    listRams.IsVisible = false;
                }
            }
            else if (sender.Equals(frameHdds))
            {
                if (listHdds.IsVisible == false)
                {
                    listHdds.IsVisible = true;
                }
                else
                {
                    listHdds.IsVisible = false;
                }
            }
        }

        async void Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new Recibo()));
        }
    }  
}
