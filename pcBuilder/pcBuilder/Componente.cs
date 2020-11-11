using System;
using System.Collections.Generic;
using System.Text;

namespace pcBuilder
{
    public class Componente
    {
        public string Tipo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Precio { get; set; }

        public override string ToString()
        {
            return Tipo;
        }
    }
}
