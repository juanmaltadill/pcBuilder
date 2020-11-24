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
        public int cantidadTotal = 0, cantidadGraficas = 0, cantidadProcesadores = 0, cantidadRams = 0, cantidadHdds = 0;
        public ObservableCollection<Grafica> listaGraficas { get; set; } = new ObservableCollection<Grafica>();
        public ObservableCollection<Procesador> listaProcesadores { get; set; } = new ObservableCollection<Procesador>();
        public ObservableCollection<Ram> listaRams { get; set; } = new ObservableCollection<Ram>();
        public ObservableCollection<Hdd> listaHdds { get; set; } = new ObservableCollection<Hdd>();
        public Recibo(ObservableCollection<Grafica> pedidoGraficas, ObservableCollection<Procesador> pedidoProcesadores, ObservableCollection<Ram> pedidoRams, ObservableCollection<Hdd> pedidoHdds )
        {
            InitializeComponent();
            listaGraficas = pedidoGraficas;
            listPedidoGraficas.BindingContext = this;
            listaProcesadores = pedidoProcesadores;
            listPedidoProcesadores.BindingContext = this;
            listaRams = pedidoRams;
            listPedidoRams.BindingContext = this;
            listaHdds = pedidoHdds;
            listPedidoHdds.BindingContext = this;
            //listPedidoGraficas.ItemsSource = listaGraficas;
            
            for(int i=0; i<listaGraficas.Count(); i++)
            {
                this.cantidadGraficas = this.cantidadGraficas + listaGraficas[i].Cantidad*listaGraficas[i].Precio;
            }
            for (int i = 0; i < listaProcesadores.Count(); i++)
            {
                this.cantidadProcesadores = this.cantidadProcesadores + listaProcesadores[i].Cantidad * listaProcesadores[i].Precio;
            }
            for (int i = 0; i < listaRams.Count(); i++)
            {
                this.cantidadRams = this.cantidadRams + listaRams[i].Cantidad * listaRams[i].Precio;
            }
            for (int i = 0; i < listaHdds.Count(); i++)
            {
                this.cantidadHdds = cantidadHdds + listaHdds[i].Cantidad * listaHdds[i].Precio;
            }
            this.cantidadTotal = this.cantidadGraficas + this.cantidadProcesadores + this.cantidadRams + this.cantidadHdds;
            labelTotal.Text = cantidadTotal.ToString()+" €";

           
        }

        private void onDeleteGrafica(object Sender, EventArgs e)
        {
            Button boton = (Button)Sender;
      
            var grafica = (Grafica)boton?.CommandParameter;
            this.cantidadTotal = this.cantidadTotal - grafica.Precio*grafica.Cantidad;
            labelTotal.Text = this.cantidadTotal.ToString();
            listaGraficas.Remove(grafica);
        }
        private void onDeleteProcesador(object Sender, EventArgs e)
        {
            Button boton = (Button)Sender;

            var procesador = (Procesador)boton?.CommandParameter;
            this.cantidadTotal = this.cantidadTotal - procesador.Precio*procesador.Cantidad;
            labelTotal.Text = this.cantidadTotal.ToString();
            listaProcesadores.Remove(procesador);
        }
        private void onDeleteRam(object Sender, EventArgs e)
        {
            Button boton = (Button)Sender;

            var ram = (Ram)boton?.CommandParameter;
            this.cantidadTotal = this.cantidadTotal - ram.Precio*ram.Cantidad;
            labelTotal.Text = this.cantidadTotal.ToString();
            listaRams.Remove(ram);
        }
        private void onDeleteHdd(object Sender, EventArgs e)
        {
            Button boton = (Button)Sender;

            var hdd = (Hdd)boton?.CommandParameter;
            this.cantidadTotal = cantidadTotal - hdd.Precio*hdd.Cantidad;
            labelTotal.Text = this.cantidadTotal.ToString();
            listaHdds.Remove(hdd);
        }


    }
}