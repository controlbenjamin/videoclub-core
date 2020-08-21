using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using VideoClubCore.Data;
using VideoClubCore.Models;


namespace VideoClubCore.Controllers
{
    [AllowAnonymous]
    public class ClientesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ClientesController(ApplicationDbContext context)
        {
            _context = context;
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public IActionResult Index()
        {

            var viewModel = new ClientesViewModel
            {
                Clientes = _context.Clientes.ToList()
            };

            return View(viewModel);
        }
    }
}
