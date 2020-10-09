using PruebaNewShore.Dominio;
using PruebaNewShore.Dominio.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PruebaNewShore.Infraestructura
{
    public class RepositorioDeVuelosSqlite : IRepositorioDeVuelos
    {
        public List<Vuelo> ObtenerVuelos(string ciudadOrigen, string ciudadDestino, DateTime fechaVuelos)
        {
            using (var context = new PruebaNewShoreBaseDeDatos())
            {
                return context.Vuelos
                    .Where(v => v.EstacionDeSalida == ciudadOrigen
                        && v.EstacionDeSalida == ciudadDestino
                        && v.FechaDeSalida == fechaVuelos)
                    .ToList();
            }
        }
    }
}
