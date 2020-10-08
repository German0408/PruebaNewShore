using PruebaNewShore.Dominio;
using System;
using System.Collections.Generic;

namespace PruebaNewShore.Dominio.Repositorios
{
    public interface IRepositorioDeVuelos
    {
        List<Vuelo> ObtenerVuelos(string ciudadOrigen, string ciudadDestino, DateTime fechaVuelos);
    }
}