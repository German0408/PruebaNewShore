using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaNewShore.Dominio
{
    public class Transporte
    {
        public string NumeroDeVuelo { get; set; }

        public List<Vuelo> Vuelos { get; set; }
    }
}
