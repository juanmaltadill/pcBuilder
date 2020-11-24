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
       public ObservableCollection<Grafica> Graficas { get; set; }
       public ObservableCollection<Procesador> Procesadores { get; set; }
       public ObservableCollection<Ram> Rams { get; set; }
       public ObservableCollection<Hdd> Hdds { get; set; }

        public ObservableCollection<Grafica> pedidoGraficas { get; set; }
        public ObservableCollection<Procesador> pedidoProcesadores { get; set; }
        public ObservableCollection<Ram> pedidoRams { get; set; }
        public ObservableCollection<Hdd> pedidoHdds { get; set; }

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

            Graficas = new ObservableCollection<Grafica>();
            Graficas.Add(new Grafica
            {
                Tipo = "Tarjeta Gráfica",
                Marca = "Nvidia",
                Modelo = "GTX 1060",
                Precio = 150,
                Cantidad = 0,
            });
            Graficas.Add(new Grafica
            {
                Tipo = "Tarjeta Gráfica",
                Marca = "Nvidia",
                Modelo = "GTX 1070",
                Precio = 175,
                Cantidad = 0,
            });
            Graficas.Add(new Grafica
            {
                Tipo = "Tarjeta Gráfica",
                Marca = "Nvidia",
                Modelo = "GTX 1080",
                Precio = 250,
                Cantidad = 0,
            });
            listGraficas.BindingContext = this;

            Procesadores = new ObservableCollection<Procesador>();
            Procesadores.Add(new Procesador
            {
                Tipo = "Procesador",
                Marca = "Intel",
                Modelo = "i9",
                Velocidad = "4.5GHz",
                Precio = 250,
                Cantidad = 0,
            });
            Procesadores.Add(new Procesador
            {
                Tipo = "Procesador",
                Marca = "Intel",
                Modelo = "i7",
                Velocidad = "3.5GHz",
                Precio = 250,
                Cantidad = 0,
            });
            Procesadores.Add(new Procesador
            {
                Tipo = "Procesador",
                Marca = "Intel",
                Modelo = "i5",
                Velocidad = "2.5GHz",
                Precio = 250,
                Cantidad = 0,
            });
            listProcesadores.BindingContext = this;

            Rams = new ObservableCollection<Ram>();
            Rams.Add(new Ram
            {
                Tipo = "Memoria RAM",
                Marca = "Corsair",
                Modelo = "158956",
                Velocidad = "4000Mhz",
                Precio = 250,
                Cantidad = 0,
            });
            Rams.Add(new Ram
            {
                Tipo = "Memoria RAM",
                Marca = "Corsair",
                Modelo = "358721",
                Velocidad = "3500Mhz",
                Precio = 250,
                Cantidad = 0,
            });
            Rams.Add(new Ram
            {
                Tipo = "Memoria RAM",
                Marca = "Corsair",
                Modelo = "968574",
                Velocidad = "3000Mhz",
                Precio = 250,
                Cantidad = 0,
            });
            listRams.BindingContext = this;

            Hdds = new ObservableCollection<Hdd>();
            Hdds.Add(new Hdd
            {
                Tipo = "HDD",
                Marca = "Seagate",
                Modelo = "p450H",
                Capacidad = "500GB",
                Precio = 75,
                Cantidad = 0,
            });
            Hdds.Add(new Hdd
            {
                Tipo = "HDD",
                Marca = "Samsung",
                Modelo = "TSeries 6000",
                Capacidad = "1TB",
                Precio = 125,
                Cantidad = 0,
            });
            Hdds.Add(new Hdd
            {
                Tipo = "SSD",
                Marca = "Samsung",
                Modelo = "xTreme690",
                Capacidad = "2TB",
                Precio = 300,
                Cantidad = 0,
            });
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
        public void Clicked(object Sender, EventArgs e)
        { 
            pedidoGraficas = new ObservableCollection<Grafica>();
            pedidoProcesadores = new ObservableCollection<Procesador>();
            pedidoRams = new ObservableCollection<Ram>();
            pedidoHdds = new ObservableCollection<Hdd>();

            int contadorGraficas = Graficas.Count();
            for(int i=0; i<contadorGraficas; i++)
            {
                if(Graficas[i].Cantidad > 0)
                {
                    pedidoGraficas.Add( new Grafica { 
                        Tipo = Graficas[i].Tipo,
                        Modelo = Graficas[i].Modelo,
                        Marca = Graficas[i].Marca,
                        Precio = Graficas[i].Precio,
                        Cantidad = Graficas[i].Cantidad,
                    });
                }
            }

            int contadorProcesadores = Procesadores.Count();
            for (int i = 0; i < contadorProcesadores; i++)
            {
                if (Procesadores[i].Cantidad > 0)
                {
                    pedidoProcesadores.Add(new Procesador
                    {
                        Tipo = Procesadores[i].Tipo,
                        Modelo = Procesadores[i].Modelo,
                        Marca = Procesadores[i].Marca,
                        Velocidad = Procesadores[i].Velocidad,
                        Precio = Procesadores[i].Precio,
                        Cantidad = Procesadores[i].Cantidad,
                    });
                }
            }

            int contadorRams = Rams.Count();
            for (int i = 0; i < contadorRams; i++)
            {
                if (Rams[i].Cantidad > 0)
                {
                    pedidoRams.Add(new Ram
                    {
                        Tipo = Rams[i].Tipo,
                        Modelo = Rams[i].Modelo,
                        Marca = Rams[i].Marca,
                        Capacidad = Rams[i].Capacidad,
                        Velocidad = Rams[i].Velocidad,
                        Precio = Rams[i].Precio,
                        Cantidad = Rams[i].Cantidad,
                    });
                }
            }

            int contadorHdds = Hdds.Count();
            for (int i = 0; i < contadorHdds; i++)
            {
                if (Hdds[i].Cantidad > 0)
                {
                    pedidoHdds.Add(new Hdd
                    {
                        Tipo = Hdds[i].Tipo,
                        Modelo = Hdds[i].Modelo,
                        Marca = Hdds[i].Marca,
                        Capacidad = Hdds[i].Capacidad,
                        Precio = Hdds[i].Precio,
                        Cantidad = Hdds[i].Cantidad,
                    });
                }
            }

            Navigation.PushAsync(new Recibo(pedidoGraficas, pedidoProcesadores, pedidoRams, pedidoHdds));
        }

        public void onMenosClicked(object Sender, EventArgs e)
        {
            Button button = (Button)Sender;
            Grid listViewItem = (Grid)button.Parent;
            Label label = (Label)listViewItem.Children[6];

            var cantidad = Int32.Parse(label.Text) ;
            cantidad--;
            if (cantidad <= 0)
            {
                label.Text = "0";
            }
            else
            {
                label.Text = cantidad.ToString();
            }
        }

        public void onMasClicked(object Sender, EventArgs e)
        {
            Button button = (Button)Sender;
            Grid listViewItem = (Grid)button.Parent;
            Label label = (Label)listViewItem.Children[6];

            var cantidad = Int32.Parse(label.Text);
            cantidad++;
            label.Text = cantidad.ToString();
        }
    }  
}
