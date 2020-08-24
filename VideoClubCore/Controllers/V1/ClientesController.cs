using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VideoClubCore.Data;
using VideoClubCore.Data.Entities;

namespace VideoClubCore.Controllers.V1
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {

        private readonly ApplicationDbContext _context;

        public ClientesController(ApplicationDbContext context)
        {
            _context = context;
        }


        // GET: api/<ClientesController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cliente>>> Get()
        {

            var clientes = await _context.Clientes.ToListAsync();


            return Ok(clientes);
        }
    }
}
