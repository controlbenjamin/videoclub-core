using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VideoClubCore.Data;
using VideoClubCore.Data.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VideoClubCore.Controllers.Api
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

        // GET api/<ClientesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ClientesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ClientesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ClientesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
