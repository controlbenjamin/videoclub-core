using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using VideoClubCore.Data;
using VideoClubCore.Models;

namespace VideoClubCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _dbContext;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext   dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {

            var valor = _dbContext.Clientes.Where(c => c.Id == 5)
                .Select(c =>c.Nombres)
                .FirstOrDefault();

    

            ViewBag.nombre = valor.ToString();

            var model = new ClientesViewModel() {
                Clientes = _dbContext.Clientes.ToList()
            };

            ViewBag.lista = model.Clientes;
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
