using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PruebaNewShore.Aplicacion.BuscarVuelos;
using PruebaNewShore.MVC.Models;

namespace PruebaNewShore.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly BuscadorDeVuelos buscadorDeVuelos;

        public HomeController(ILogger<HomeController> logger, BuscadorDeVuelos buscadorDeVuelos)
        {
            _logger = logger;
            this.buscadorDeVuelos = buscadorDeVuelos;
        }

        public IActionResult Index()
        {
            var VuelosDisponibles = buscadorDeVuelos.Buscar(new PeticionBusquedaDeVuelos { CiudadOrigen = "Manizales", CiudadDestino= "Bogota", FechaDeVuelo = DateTime.Now });
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
