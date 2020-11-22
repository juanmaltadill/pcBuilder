using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace pcBuilder
{
    public class Pedido
    {
        public Grafica pedidoGraficas { get; set; }
        public Procesador pedidoProcesadores { get; set; }
        public Ram pedidoRams { get; set; }
        public Hdd pedidoHdds { get; set; }

    }
}
