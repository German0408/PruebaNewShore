using System;

namespace PruebaNewShore.Aplicacion.BuscarVuelos
{
    public class PeticionBusquedaDeVuelos
    {
        public string CiudadOrigen { get; set; }
        public string CiudadDestino { get; set; }
        public DateTime FechaDeVuelo { get; set; }
    }
}