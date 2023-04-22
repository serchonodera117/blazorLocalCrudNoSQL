using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Proyecto_programación_web.Server.Data;
using Proyecto_programación_web.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Proyecto_programación_web.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class editorialesController : ControllerBase
    {
        private ProyectoDbContext _contexto;
        public editorialesController(ProyectoDbContext contexto) 
        {
            _contexto = contexto;
        }

        // GET: api/<editorialesController>
        [HttpGet]
        public IEnumerable<Editorial> Get()
        {
            return _contexto.Editoriales.ToList();
        }

        // GET api/<editorialesController>/5
        [HttpGet("{id}")]
        public async Task<Editorial> Get(int id)
        {
            return await _contexto.Editoriales.Where(r=> r.Id == id).FirstOrDefaultAsync();
        }

        // POST api/<editorialesController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Editorial editorial)
        {
            _contexto.Add(editorial);
           await _contexto.SaveChangesAsync();
            return NoContent();
        }

        // PUT api/<editorialesController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] Editorial editorial)
        {
            _contexto.Entry(editorial).State = EntityState.Modified;
            await _contexto.SaveChangesAsync();
            return NoContent();
        }

        // DELETE api/<editorialesController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            Editorial mieditorial = new Editorial() { Id = id};
            _contexto.Editoriales.Remove(mieditorial);
            await _contexto.SaveChangesAsync();
            return NoContent();

        }
    }
}
