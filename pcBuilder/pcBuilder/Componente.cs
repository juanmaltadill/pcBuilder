using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace pcBuilder
{
    public class Grafica : INotifyPropertyChanged
    {
        private string tipo;
        private string marca;
        private string modelo;
        private int precio;
        private int cantidad;
        private string imagen;
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }
        public int Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        public int Cantidad
        {
            get { return cantidad; }
            set 
            { 
                cantidad = value;
                OnPropertyChanged("Cantidad");
            }
        }
        public string Imagen
        {
            get { return imagen; }
            set
            {
                imagen = value;
                OnPropertyChanged("Imagen");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string nombrePropiedad)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(nombrePropiedad));
            }
        }

    }

    public class Procesador : INotifyPropertyChanged
    {
        private string tipo;
        private string marca;
        private string modelo;
        private string velocidad;
        private int precio;
        private string imagen;
        private int cantidad;
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }
        public string Velocidad
        {
            get { return velocidad; }
            set { velocidad = value; }
        }
        public int Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        public int Cantidad
        {
            get { return cantidad; }
            set 
            { 
                cantidad = value;
                OnPropertyChanged("Cantidad");
            }

        }
        public string Imagen
        {
            get { return imagen; }
            set
            {
                imagen = value;
                OnPropertyChanged("Imagen");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string nombrePropiedad)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(nombrePropiedad));
            }
        }
    }

    public class Ram : INotifyPropertyChanged
    {
        private string tipo;
        private string marca;
        private string modelo;
        private string capacidad;
        private string velocidad;
        private int precio;
        private int cantidad;
        private string imagen;
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }
        public string Capacidad
        {
            get { return capacidad; }
            set { capacidad = value; }
        }
        public string Velocidad
        {
            get { return velocidad; }
            set { velocidad = value; }
        }
        public int Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        public int Cantidad
        {
            get { return cantidad; }
            set 
            {
                cantidad = value;
                OnPropertyChanged("Cantidad");
            }
        }
        public string Imagen
        {
            get { return imagen; }
            set
            {
                imagen = value;
                OnPropertyChanged("Imagen");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string nombrePropiedad)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(nombrePropiedad));
            }
        }
    }

    public class Hdd : INotifyPropertyChanged
    {
        private string tipo;
        private string marca;
        private string modelo;
        private string capacidad;
        private int precio;
        private int cantidad;
        private string imagen;
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }
        public string Capacidad
        {
            get { return capacidad; }
            set { capacidad = value; }
        }
        public int Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        public int Cantidad
        {
            get { return cantidad; }
            set 
            { 
                cantidad = value;
                OnPropertyChanged("Cantidad");
            }
        }
        public string Imagen
        {
            get { return imagen; }
            set
            {
                imagen = value;
                OnPropertyChanged("Imagen");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged; 
        
        private void OnPropertyChanged(string nombrePropiedad)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(nombrePropiedad));
            }
        }
    }

}
