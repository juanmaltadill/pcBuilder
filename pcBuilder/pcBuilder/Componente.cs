using System;
using System.Collections.Generic;
using System.Text;

namespace pcBuilder
{
    public class Grafica
    {
        public string Tipo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Precio { get; set; }
    }

    public class Procesador
    {
        public string Tipo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Velocidad { get; set; }
        public int Precio { get; set; }
    }

    public class Ram
    {
        public string Tipo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Capacidad { get; set; }
        public string Velocidad { get; set; }
        public int Precio { get; set; }
    }

    public class Hdd
    {
        public string Tipo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Capacidad { get; set; }
        public int Precio { get; set; }
        public int Cantidad { get; set; }

    }

}
