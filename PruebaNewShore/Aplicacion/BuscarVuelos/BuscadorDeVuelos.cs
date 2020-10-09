using PruebaNewShore.Dominio.Repositorios;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaNewShore.Aplicacion.BuscarVuelos
{
    public class BuscadorDeVuelos
    {
        private readonly IRepositorioDeVuelos repositorio;

        public BuscadorDeVuelos(IRepositorioDeVuelos repositorio)
        {
            this.repositorio = repositorio;
        }

        public RespuestaBusquedaDeVuelos Buscar(PeticionBusquedaDeVuelos peticion) {

            var vuelosDisponibles = repositorio.ObtenerVuelos(peticion.CiudadOrigen, peticion.CiudadDestino, peticion.FechaDeVuelo);

            return new RespuestaBusquedaDeVuelos
            {
                VuelosDisponibles = vuelosDisponibles
            };
        }
    }
}
