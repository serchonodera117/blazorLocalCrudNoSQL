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
    public class mangasController : ControllerBase
    {
        private ProyectoDbContext _contexto;
        public mangasController(ProyectoDbContext contexto)
        {
            _contexto = contexto;
        }


        // GET: api/<mangasController>
        [HttpGet]
        public IEnumerable<Manga> Get()
        {

            return _contexto.Mangas.Include(d => d.Editorial).ToList();
        }

        // GET api/<mangasController>/5
        [HttpGet("{id}")]
        public async Task<Manga> Get(int id)
        {
            return await _contexto.Mangas.Where(r => r.Id == id).FirstOrDefaultAsync();
        }

        // POST api/<mangasController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Manga manga)
        {
            _contexto.Add(manga);
            await _contexto.SaveChangesAsync();
            return NoContent();
        }

        // PUT api/<mangasController>/5
        [HttpPut()]
        public async Task<ActionResult> Put( Manga manga)
        {
            _contexto.Entry(manga).State = EntityState.Modified;
            await _contexto.SaveChangesAsync();
            return NoContent();
        }

        // DELETE api/<mangasController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            Manga manga = new Manga() { Id = id };
            _contexto.Mangas.Remove(manga);
            await _contexto.SaveChangesAsync();
            return NoContent();

        }
    }
}
