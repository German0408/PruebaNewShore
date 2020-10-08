using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaNewShore.Dominio
{
    public class Vuelo
    {
        public string EstacionDeSalida { get; set; }
        public string EstacionDeLlegada { get; set; }
        public DateTime FechaDeSalida { get; set; }
        public Transporte Transporte { get; set; }
        public decimal Precio { get; set; }
        public string Moneda { get; set; }
    }
}
